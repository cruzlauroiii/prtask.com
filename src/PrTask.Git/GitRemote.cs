using System.Globalization;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed class GitRemote
{
    private readonly GitRepository Repo;
    private static readonly HttpClient Http = new();

    public GitRemote(GitRepository Repo)
    {
        this.Repo = Repo;
    }

    public List<GitRemoteInfo> ListRemotes()
    {
        var Remotes = new List<GitRemoteInfo>();
        var ConfigPath = Path.Combine(Repo.GitDir, "config");
        if (!File.Exists(ConfigPath))
        {
            return Remotes;
        }

        var Lines = File.ReadAllLines(ConfigPath);
        string? CurrentRemoteName = null;
        string? FetchUrl = null;
        string? PushUrl = null;

        foreach (var Line in Lines)
        {
            var Trimmed = Line.Trim();
            if (Trimmed.StartsWith("[remote \"", StringComparison.Ordinal) && Trimmed.EndsWith("\"]", StringComparison.Ordinal))
            {
                if (CurrentRemoteName is not null)
                {
                    Remotes.Add(new GitRemoteInfo
                    {
                        Name = CurrentRemoteName,
                        FetchUrl = FetchUrl ?? string.Empty,
                        PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
                    });
                }

                CurrentRemoteName = Trimmed["[remote \"".Length..^"\"]".Length];
                FetchUrl = null;
                PushUrl = null;
            }
            else if (Trimmed.StartsWith('['))
            {
                if (CurrentRemoteName is not null)
                {
                    Remotes.Add(new GitRemoteInfo
                    {
                        Name = CurrentRemoteName,
                        FetchUrl = FetchUrl ?? string.Empty,
                        PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
                    });
                    CurrentRemoteName = null;
                    FetchUrl = null;
                    PushUrl = null;
                }
            }
            else if (CurrentRemoteName is not null)
            {
                var EqPos = Trimmed.IndexOf('=', StringComparison.Ordinal);
                if (EqPos >= 0)
                {
                    var Key = Trimmed[..EqPos].Trim();
                    var Value = Trimmed[(EqPos + 1)..].Trim();
                    if (Key.Equals("url", StringComparison.OrdinalIgnoreCase))
                    {
                        FetchUrl = Value;
                    }
                    else if (Key.Equals("pushurl", StringComparison.OrdinalIgnoreCase))
                    {
                        PushUrl = Value;
                    }
                }
            }
        }

        if (CurrentRemoteName is not null)
        {
            Remotes.Add(new GitRemoteInfo
            {
                Name = CurrentRemoteName,
                FetchUrl = FetchUrl ?? string.Empty,
                PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
            });
        }

        return Remotes;
    }

    public void AddRemote(string Name, string Url)
    {
        var ConfigPath = Path.Combine(Repo.GitDir, "config");
        var Lines = File.Exists(ConfigPath) ? File.ReadAllLines(ConfigPath).ToList() : new List<string>();

        Lines.Add(string.Format(CultureInfo.InvariantCulture, "[remote \"{0}\"]", Name));
        Lines.Add(string.Format(CultureInfo.InvariantCulture, "\turl = {0}", Url));
        Lines.Add(string.Format(CultureInfo.InvariantCulture, "\tfetch = +refs/heads/*:refs/remotes/{0}/*", Name));

        File.WriteAllLines(ConfigPath, Lines);
    }

    public void RemoveRemote(string Name)
    {
        var ConfigPath = Path.Combine(Repo.GitDir, "config");
        if (!File.Exists(ConfigPath))
        {
            return;
        }

        var Lines = File.ReadAllLines(ConfigPath).ToList();
        var SectionHeader = string.Format(CultureInfo.InvariantCulture, "[remote \"{0}\"]", Name);
        var InSection = false;
        var NewLines = new List<string>();

        foreach (var Line in Lines)
        {
            var Trimmed = Line.Trim();
            if (Trimmed.Equals(SectionHeader, StringComparison.OrdinalIgnoreCase))
            {
                InSection = true;
                continue;
            }

            if (InSection && Trimmed.StartsWith('['))
            {
                InSection = false;
            }

            if (!InSection)
            {
                NewLines.Add(Line);
            }
        }

        File.WriteAllLines(ConfigPath, NewLines);

        // Clean up remote refs
        var RemoteRefsDir = Path.Combine(Repo.GitDir, "refs", "remotes", Name);
        if (Directory.Exists(RemoteRefsDir))
        {
            Directory.Delete(RemoteRefsDir, true);
        }
    }

    public async Task<Dictionary<string, string>> LsRemoteAsync(string Url, CancellationToken Cancel = default)
    {
        var Refs = new Dictionary<string, string>(StringComparer.Ordinal);
        var InfoUrl = string.Format(CultureInfo.InvariantCulture, "{0}/info/refs?service=git-upload-pack", Url.TrimEnd('/'));

        var Request = new HttpRequestMessage(HttpMethod.Get, InfoUrl);
        Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-git-upload-pack-advertisement"));

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var Content = await Response.Content.ReadAsStringAsync(Cancel).ConfigureAwait(false);
        var Lines = Content.Split('\n');

        foreach (var Line in Lines)
        {
            if (Line.Length < 44)
            {
                continue;
            }

            // Smart HTTP protocol: 4-char hex length + hash + SP + refname
            var PktLine = Line.Length >= 4 ? Line[4..] : Line;
            var SpaceIdx = PktLine.IndexOf(' ', StringComparison.Ordinal);
            var TabIdx = PktLine.IndexOf('\t', StringComparison.Ordinal);
            var SepIdx = SpaceIdx >= 0 ? SpaceIdx : TabIdx;
            if (SepIdx < 0 || SepIdx < 40)
            {
                continue;
            }

            var Hash = PktLine[..SepIdx].Trim();
            var RefName = PktLine[(SepIdx + 1)..].TrimEnd('\0', '\n', '\r');

            // Remove capability list from first line
            var NulIdx = RefName.IndexOf('\0', StringComparison.Ordinal);
            if (NulIdx >= 0)
            {
                RefName = RefName[..NulIdx];
            }

            if (Hash.Length == 40 && IsHex(Hash))
            {
                Refs[RefName] = Hash;
            }
        }

        return Refs;
    }

    public async Task FetchAsync(string RemoteName, CancellationToken Cancel = default)
    {
        var Remotes = ListRemotes();
        var Remote = Remotes.Find(R => string.Equals(R.Name, RemoteName, StringComparison.Ordinal));
        if (Remote is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Remote not found: {0}", RemoteName));
        }

        var Refs = await LsRemoteAsync(Remote.FetchUrl, Cancel).ConfigureAwait(false);

        // Download pack for refs we don't have
        var WantHashes = new List<string>();
        foreach (var Kvp in Refs)
        {
            if (Kvp.Key.StartsWith("refs/heads/", StringComparison.Ordinal))
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

        // Update remote refs
        foreach (var Kvp in Refs)
        {
            if (Kvp.Key.StartsWith("refs/heads/", StringComparison.Ordinal))
            {
                var BranchName = Kvp.Key["refs/heads/".Length..];
                var RemoteRef = string.Format(CultureInfo.InvariantCulture, "refs/remotes/{0}/{1}", RemoteName, BranchName);
                Repo.UpdateRef(RemoteRef, Kvp.Value);
            }
        }
    }

    public async Task PushAsync(string RemoteName, string BranchName, CancellationToken Cancel = default)
    {
        var Remotes = ListRemotes();
        var Remote = Remotes.Find(R => string.Equals(R.Name, RemoteName, StringComparison.Ordinal));
        if (Remote is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Remote not found: {0}", RemoteName));
        }

        var LocalHash = Repo.ResolveRef(BranchName)
            ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot resolve branch: {0}", BranchName));

        var RefName = string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", BranchName);

        // Get current remote ref
        var RemoteRefs = await LsRemoteAsync(Remote.PushUrl, Cancel).ConfigureAwait(false);
        var OldHash = RemoteRefs.TryGetValue(RefName, out var Existing) ? Existing : new string('0', 40);

        // Build pack data
        var PackData = GitPack.CreatePack(Repo, LocalHash, OldHash == new string('0', 40) ? null : OldHash);

        // Send receive-pack request
        var UploadUrl = string.Format(CultureInfo.InvariantCulture, "{0}/git-receive-pack", Remote.PushUrl.TrimEnd('/'));
        using var RequestContent = new MemoryStream();

        // Pkt-line: old-hash new-hash refname\0capabilities
        var PktData = string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}\0report-status", OldHash, LocalHash, RefName);
        var PktLength = PktData.Length + 4;
        var PktHeader = string.Format(CultureInfo.InvariantCulture, "{0:x4}", PktLength);
        var PktLine = Encoding.ASCII.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0}{1}", PktHeader, PktData));
        RequestContent.Write(PktLine, 0, PktLine.Length);
        RequestContent.Write("0000"u8);
        RequestContent.Write(PackData, 0, PackData.Length);
        RequestContent.Position = 0;

        var Request = new HttpRequestMessage(HttpMethod.Post, UploadUrl)
        {
            Content = new StreamContent(RequestContent),
        };
        Request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-git-receive-pack-request");

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();
    }

    private async Task DownloadPackAsync(string Url, List<string> WantHashes, CancellationToken Cancel)
    {
        var UploadPackUrl = string.Format(CultureInfo.InvariantCulture, "{0}/git-upload-pack", Url.TrimEnd('/'));

        using var RequestContent = new MemoryStream();
        foreach (var Hash in WantHashes)
        {
            var WantLine = string.Format(CultureInfo.InvariantCulture, "want {0}\n", Hash);
            var WantPkt = string.Format(CultureInfo.InvariantCulture, "{0:x4}{1}", WantLine.Length + 4, WantLine);
            var WantBytes = Encoding.ASCII.GetBytes(WantPkt);
            RequestContent.Write(WantBytes, 0, WantBytes.Length);
        }

        RequestContent.Write("00000009done\n"u8);
        RequestContent.Position = 0;

        var Request = new HttpRequestMessage(HttpMethod.Post, UploadPackUrl)
        {
            Content = new StreamContent(RequestContent),
        };
        Request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-git-upload-pack-request");

        var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var ResponseData = await Response.Content.ReadAsByteArrayAsync(Cancel).ConfigureAwait(false);

        // Find pack data start (after pkt-line responses)
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
        // Look for "PACK" signature
        for (var I = 0; I < Data.Length - 4; I++)
        {
            if (Data[I] == 'P' && Data[I + 1] == 'A' && Data[I + 2] == 'C' && Data[I + 3] == 'K')
            {
                return I;
            }
        }

        return GitConstants.NotFound;
    }

    private static bool IsHex(string Value)
    {
        foreach (var Ch in Value)
        {
            if (!char.IsAsciiHexDigit(Ch))
            {
                return false;
            }
        }

        return true;
    }
}
#pragma warning restore SA1600
