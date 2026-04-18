using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed partial class GitRemote
{
    public async Task<IDictionary<string, string>> LsRemoteAsync(string Url, CancellationToken Cancel = default)
    {
        var Refs = new Dictionary<string, string>(StringComparer.Ordinal);
        var InfoUrl = string.Format(CultureInfo.InvariantCulture, GitConstants.InfoRefsUrlFormat, Url.TrimEnd('/'));

        var Request = new HttpRequestMessage(HttpMethod.Get, InfoUrl);
        Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(GitConstants.ContentTypeUploadPackAd));

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var Content = await Response.Content.ReadAsStringAsync(Cancel).ConfigureAwait(false);
        var Lines = Content.Split('\n');

        foreach (var Line in Lines)
        {
            if (Line.Length < GitConstants.PktLineMinLength)
            {
                continue;
            }

            var PktLine = Line.Length >= GitConstants.PktLineHeaderSize ? Line[GitConstants.PktLineHeaderSize..] : Line;
            var SpaceIdx = PktLine.IndexOf(' ', StringComparison.Ordinal);
            var TabIdx = PktLine.IndexOf('\t', StringComparison.Ordinal);
            var SepIdx = SpaceIdx >= 0 ? SpaceIdx : TabIdx;
            if (SepIdx is < 0 or < GitConstants.HashHexLength)
            {
                continue;
            }

            var Hash = PktLine[..SepIdx].Trim();
            var RefName = PktLine[(SepIdx + 1)..].TrimEnd('\0', '\n', '\r');

            var NulIdx = RefName.IndexOf('\0', StringComparison.Ordinal);
            if (NulIdx >= 0)
            {
                RefName = RefName[..NulIdx];
            }

            if (Hash.Length == GitConstants.HashHexLength && IsHex(Hash))
            {
                Refs[RefName] = Hash;
            }
        }

        return Refs;
    }

    public async Task FetchAsync(string RemoteName, CancellationToken Cancel = default)
    {
        var Remotes = ListRemotes();
        var Remote = Remotes.FirstOrDefault(R => string.Equals(R.Name, RemoteName, StringComparison.Ordinal))
            ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, GitConstants.ErrorRemoteNotFound, RemoteName));

        var Refs = await LsRemoteAsync(Remote.FetchUrl, Cancel).ConfigureAwait(false);

        var WantHashes = new List<string>();
        foreach (var Kvp in Refs)
        {
            if (Kvp.Key.StartsWith(GitConstants.RefsHeadsPrefix, StringComparison.Ordinal))
            {
                var Obj = Repo.ReadObject(Kvp.Value);
                if (Obj is null)
                {
                    WantHashes.Add(Kvp.Value);
                }
            }
        }

        if (WantHashes.Count > 0)
        {
            await DownloadPackAsync(Remote.FetchUrl, WantHashes, Cancel).ConfigureAwait(false);
        }

        foreach (var Kvp in Refs)
        {
            if (Kvp.Key.StartsWith(GitConstants.RefsHeadsPrefix, StringComparison.Ordinal))
            {
                var BranchName = Kvp.Key[GitConstants.RefsHeadsPrefix.Length..];
                var RemoteRef = string.Format(CultureInfo.InvariantCulture, GitConstants.RefsRemotesFormat, RemoteName, BranchName);
                Repo.UpdateRef(RemoteRef, Kvp.Value);
            }
        }
    }

    public async Task PushAsync(string RemoteName, string BranchName, CancellationToken Cancel = default)
    {
        var Remotes = ListRemotes();
        var Remote = Remotes.FirstOrDefault(R => string.Equals(R.Name, RemoteName, StringComparison.Ordinal))
            ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, GitConstants.ErrorRemoteNotFound, RemoteName));

        var LocalHash = Repo.ResolveRef(BranchName)
            ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, GitConstants.ErrorCannotResolveBranch, BranchName));

        var RefName = string.Format(CultureInfo.InvariantCulture, GitConstants.RefsHeadsFormat, BranchName);

        var RemoteRefs = await LsRemoteAsync(Remote.PushUrl, Cancel).ConfigureAwait(false);
        var OldHash = RemoteRefs.TryGetValue(RefName, out var Existing) ? Existing : GitConstants.ZeroHash;

        var PackData = GitPack.CreatePack(Repo, LocalHash, OldHash == GitConstants.ZeroHash ? null : OldHash);

        var UploadUrl = string.Format(CultureInfo.InvariantCulture, GitConstants.ReceivePackUrlFormat, Remote.PushUrl.TrimEnd('/'));
        using var RequestContent = new MemoryStream();

        var PktData = string.Format(CultureInfo.InvariantCulture, GitConstants.ReceivePackPktDataFormat, OldHash, LocalHash, RefName);
        var PktLength = PktData.Length + GitConstants.PktLineHeaderSize;
        var PktHeader = string.Format(CultureInfo.InvariantCulture, GitConstants.PktLineFormat, PktLength, PktData);
        var PktLine = Encoding.ASCII.GetBytes(PktHeader);
        RequestContent.Write(PktLine, 0, PktLine.Length);
        RequestContent.Write("0000"u8);
        RequestContent.Write(PackData, 0, PackData.Length);
        RequestContent.Position = 0;

        var Request = new HttpRequestMessage(HttpMethod.Post, UploadUrl)
        {
            Content = new StreamContent(RequestContent),
        };
        Request.Content.Headers.ContentType = new MediaTypeHeaderValue(GitConstants.ContentTypeReceivePackRequest);

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();
    }

    private async Task DownloadPackAsync(string Url, List<string> WantHashes, CancellationToken Cancel)
    {
        var UploadPackUrl = string.Format(CultureInfo.InvariantCulture, GitConstants.UploadPackUrlFormat, Url.TrimEnd('/'));

        using var RequestContent = new MemoryStream();
        foreach (var Hash in WantHashes)
        {
            var WantLine = string.Format(CultureInfo.InvariantCulture, GitConstants.WantLineFormat, Hash);
            var WantPkt = string.Format(CultureInfo.InvariantCulture, GitConstants.PktLineFormat, WantLine.Length + GitConstants.PktLineHeaderSize, WantLine);
            var WantBytes = Encoding.ASCII.GetBytes(WantPkt);
            RequestContent.Write(WantBytes, 0, WantBytes.Length);
        }

        RequestContent.Write("00000009done\n"u8);
        RequestContent.Position = 0;

        var Request = new HttpRequestMessage(HttpMethod.Post, UploadPackUrl)
        {
            Content = new StreamContent(RequestContent),
        };
        Request.Content.Headers.ContentType = new MediaTypeHeaderValue(GitConstants.ContentTypeUploadPackRequest);

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var ResponseData = await Response.Content.ReadAsByteArrayAsync(Cancel).ConfigureAwait(false);

        var PackStart = FindPackStart(ResponseData);
        if (PackStart >= 0)
        {
            var PackBytes = new byte[ResponseData.Length - PackStart];
            Buffer.BlockCopy(ResponseData, PackStart, PackBytes, 0, PackBytes.Length);
            GitPack.UnpackObjects(Repo, PackBytes);
        }
    }

    private static int FindPackStart(byte[] Data)
    {
        for (var I = 0; I < Data.Length - GitConstants.PktLineHeaderSize; I++)
        {
            if (Data[I] == GitConstants.PackSigP && Data[I + 1] == GitConstants.PackSigA && Data[I + 2] == GitConstants.PackSigC && Data[I + GitConstants.Byte3Offset] == GitConstants.PackSigK)
            {
                return I;
            }
        }

        return GitConstants.NotFound;
    }
}
#pragma warning restore SA1600
