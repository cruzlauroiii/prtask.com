using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public sealed class GitRemote
{
    private const string GitUploadPackService = "git-upload-pack";
    private const string GitReceivePackService = "git-receive-pack";
    private const string FlushPkt = "0000";
    private const string DonePkt = "0009done\n";

    private readonly GitRepository Repo;
    private readonly HttpClient Http = new();

    public GitRemote(GitRepository Repo)
    {
        this.Repo = Repo;
    }

    public async Task<List<RemoteRef>> ListRefsAsync(string RemoteUrl, CancellationToken Cancel = default)
    {
        var InfoRefsUrl = string.Format(CultureInfo.InvariantCulture, "{0}/info/refs?service={1}", RemoteUrl.TrimEnd('/'), GitUploadPackService);

        using var Request = new HttpRequestMessage(HttpMethod.Get, InfoRefsUrl);
        Request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PrTask-GitNative", "1.0"));

        using var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var Body = await Response.Content.ReadAsStringAsync(Cancel).ConfigureAwait(false);
        return ParseSmartRefs(Body);
    }

    public async Task FetchAsync(string RemoteUrl, string RemoteName = "origin", CancellationToken Cancel = default)
    {
        // Step 1: Get remote refs
        var RemoteRefs = await ListRefsAsync(RemoteUrl, Cancel).ConfigureAwait(false);

        // Step 2: Determine which objects we need
        var WantHashes = new List<string>();
        var HaveHashes = new List<string>();

        foreach (var Ref in RemoteRefs)
        {
            if (string.IsNullOrEmpty(Ref.Hash))
            {
                continue;
            }

            var LocalObj = Repo.ReadObject(Ref.Hash);
            if (LocalObj is null)
            {
                WantHashes.Add(Ref.Hash);
            }
        }

        if (WantHashes.Count == 0)
        {
            // Already up to date — just update refs
            UpdateRemoteRefs(RemoteName, RemoteRefs);
            return;
        }

        // Get local HEAD as "have"
        var HeadHash = Repo.GetHead();
        if (HeadHash is not null)
        {
            HaveHashes.Add(HeadHash);
        }

        // Step 3: Send upload-pack request
        var PackData = await RequestPackAsync(RemoteUrl, WantHashes, HaveHashes, Cancel).ConfigureAwait(false);

        // Step 4: Unpack objects
        if (PackData is not null && PackData.Length > 0)
        {
            UnpackInMemory(PackData);
        }

        // Step 5: Update remote refs
        UpdateRemoteRefs(RemoteName, RemoteRefs);
    }

    public async Task PushAsync(string RemoteUrl, string BranchName, string RemoteName = "origin", bool Force = false, CancellationToken Cancel = default)
    {
        // Step 1: Get remote refs
        var RemoteRefs = await ListPushRefsAsync(RemoteUrl, Cancel).ConfigureAwait(false);

        // Step 2: Determine what to send
        var LocalHash = Repo.ResolveRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", BranchName));
        if (LocalHash is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch not found: {0}", BranchName));
        }

        var RemoteRef = RemoteRefs.Find(R => R.Name == string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", BranchName));
        var OldHash = RemoteRef?.Hash ?? "0000000000000000000000000000000000000000";

        if (string.Equals(OldHash, LocalHash, StringComparison.OrdinalIgnoreCase))
        {
            return; // Already up to date
        }

        // Step 3: Collect objects to send
        var ObjectsToSend = CollectObjectsForPush(LocalHash, OldHash == "0000000000000000000000000000000000000000" ? null : OldHash);

        // Step 4: Create pack data in memory
        var PackData = CreatePackInMemory(ObjectsToSend);

        // Step 5: Send receive-pack request
        var RefUpdate = string.Format(CultureInfo.InvariantCulture, "{0} {1} refs/heads/{2}",
            OldHash, LocalHash, BranchName);

        await SendPackAsync(RemoteUrl, RefUpdate, PackData, Cancel).ConfigureAwait(false);
    }

    public void AddRemote(string Name, string Url)
    {
        Repo.SetConfig(string.Format(CultureInfo.InvariantCulture, "remote \"{0}\"", Name), "url", Url);
        Repo.SetConfig(string.Format(CultureInfo.InvariantCulture, "remote \"{0}\"", Name), "fetch",
            string.Format(CultureInfo.InvariantCulture, "+refs/heads/*:refs/remotes/{0}/*", Name));
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
        var LinesToRemove = new List<int>();

        for (var I = 0; I < Lines.Count; I++)
        {
            var Trimmed = Lines[I].Trim();
            if (Trimmed.Equals(SectionHeader, StringComparison.OrdinalIgnoreCase))
            {
                InSection = true;
                LinesToRemove.Add(I);
            }
            else if (Trimmed.StartsWith('['))
            {
                InSection = false;
            }
            else if (InSection)
            {
                LinesToRemove.Add(I);
            }
        }

        for (var I = LinesToRemove.Count - 1; I >= 0; I--)
        {
            Lines.RemoveAt(LinesToRemove[I]);
        }

        File.WriteAllLines(ConfigPath, Lines);

        // Remove remote refs
        var RemoteRefsDir = Path.Combine(Repo.GitDir, "refs", "remotes", Name);
        if (Directory.Exists(RemoteRefsDir))
        {
            Directory.Delete(RemoteRefsDir, true);
        }
    }

    public string? GetRemoteUrl(string Name)
    {
        return Repo.GetConfig(string.Format(CultureInfo.InvariantCulture, "remote \"{0}\"", Name), "url");
    }

    private async Task<List<RemoteRef>> ListPushRefsAsync(string RemoteUrl, CancellationToken Cancel)
    {
        var InfoRefsUrl = string.Format(CultureInfo.InvariantCulture, "{0}/info/refs?service={1}", RemoteUrl.TrimEnd('/'), GitReceivePackService);

        using var Request = new HttpRequestMessage(HttpMethod.Get, InfoRefsUrl);
        Request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PrTask-GitNative", "1.0"));

        using var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var Body = await Response.Content.ReadAsStringAsync(Cancel).ConfigureAwait(false);
        return ParseSmartRefs(Body);
    }

    private async Task<byte[]?> RequestPackAsync(string RemoteUrl, List<string> WantHashes, List<string> HaveHashes, CancellationToken Cancel)
    {
        var UploadPackUrl = string.Format(CultureInfo.InvariantCulture, "{0}/{1}", RemoteUrl.TrimEnd('/'), GitUploadPackService);

        var Sb = new StringBuilder();
        foreach (var Want in WantHashes)
        {
            var Line = string.Format(CultureInfo.InvariantCulture, "want {0}\n", Want);
            Sb.Append(FormatPktLine(Line));
        }

        Sb.Append(FlushPkt);

        foreach (var Have in HaveHashes)
        {
            var Line = string.Format(CultureInfo.InvariantCulture, "have {0}\n", Have);
            Sb.Append(FormatPktLine(Line));
        }

        Sb.Append(DonePkt);

        using var Request = new HttpRequestMessage(HttpMethod.Post, UploadPackUrl);
        Request.Content = new StringContent(Sb.ToString(), Encoding.UTF8, "application/x-git-upload-pack-request");
        Request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PrTask-GitNative", "1.0"));

        using var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();

        var ResponseBytes = await Response.Content.ReadAsByteArrayAsync(Cancel).ConfigureAwait(false);
        return ExtractPackData(ResponseBytes);
    }

    private async Task SendPackAsync(string RemoteUrl, string RefUpdate, byte[] PackData, CancellationToken Cancel)
    {
        var ReceivePackUrl = string.Format(CultureInfo.InvariantCulture, "{0}/{1}", RemoteUrl.TrimEnd('/'), GitReceivePackService);

        using var Stream = new MemoryStream();

        // Send ref update line
        var RefLine = Encoding.UTF8.GetBytes(FormatPktLine(RefUpdate + "\0 report-status\n"));
        Stream.Write(RefLine, 0, RefLine.Length);

        // Flush
        var FlushBytes = Encoding.UTF8.GetBytes(FlushPkt);
        Stream.Write(FlushBytes, 0, FlushBytes.Length);

        // Pack data
        Stream.Write(PackData, 0, PackData.Length);

        using var Request = new HttpRequestMessage(HttpMethod.Post, ReceivePackUrl);
        Request.Content = new ByteArrayContent(Stream.ToArray());
        Request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-git-receive-pack-request");
        Request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PrTask-GitNative", "1.0"));

        using var Response = await Http.SendAsync(Request, Cancel).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();
    }

    private void UpdateRemoteRefs(string RemoteName, List<RemoteRef> Refs)
    {
        foreach (var Ref in Refs)
        {
            if (string.IsNullOrEmpty(Ref.Hash) || string.IsNullOrEmpty(Ref.Name))
            {
                continue;
            }

            if (Ref.Name.StartsWith("refs/heads/", StringComparison.Ordinal))
            {
                var LocalRefName = Ref.Name.Replace("refs/heads/", string.Format(CultureInfo.InvariantCulture, "refs/remotes/{0}/", RemoteName));
                Repo.UpdateRef(LocalRefName, Ref.Hash);
            }
        }
    }

    private List<string> CollectObjectsForPush(string LocalHash, string? RemoteHash)
    {
        var Objects = new List<string>();
        var Visited = new HashSet<string>(StringComparer.Ordinal);
        var StopAt = new HashSet<string>(StringComparer.Ordinal);

        if (RemoteHash is not null)
        {
            StopAt.Add(RemoteHash);
        }

        CollectReachableObjects(LocalHash, Visited, StopAt, Objects);
        return Objects;
    }

    private void CollectReachableObjects(string Hash, HashSet<string> Visited, HashSet<string> StopAt, List<string> Result)
    {
        if (!Visited.Add(Hash) || StopAt.Contains(Hash))
        {
            return;
        }

        var Obj = Repo.ReadObject(Hash);
        if (Obj is null)
        {
            return;
        }

        Result.Add(Hash);

        if (Obj.Type == GitObjectType.Commit)
        {
            var Info = GitObjects.ParseCommit(Obj.Data);
            if (Info is not null)
            {
                CollectReachableObjects(Info.TreeHash, Visited, StopAt, Result);
                foreach (var Parent in Info.ParentHashes)
                {
                    CollectReachableObjects(Parent, Visited, StopAt, Result);
                }
            }
        }
        else if (Obj.Type == GitObjectType.Tree)
        {
            var Entries = GitObjects.ParseTree(Obj.Data);
            foreach (var Entry in Entries)
            {
                CollectReachableObjects(Entry.Hash, Visited, StopAt, Result);
            }
        }
    }

    private byte[] CreatePackInMemory(List<string> ObjectHashes)
    {
        using var Stream = new MemoryStream();

        // Pack header
        WriteInt32BigEndian(Stream, 0x5041434B); // "PACK"
        WriteInt32BigEndian(Stream, 2); // Version
        WriteInt32BigEndian(Stream, ObjectHashes.Count);

        foreach (var Hash in ObjectHashes)
        {
            var Obj = Repo.ReadObject(Hash);
            if (Obj is null)
            {
                continue;
            }

            WritePackObject(Stream, Obj);
        }

        // Pack checksum
        var Content = Stream.ToArray();
        var Checksum = SHA1.HashData(Content);
        Stream.Write(Checksum, 0, Checksum.Length);

        return Stream.ToArray();
    }

    private static void WritePackObject(MemoryStream Stream, GitRawObject Obj)
    {
        var TypeCode = Obj.Type switch
        {
            GitObjectType.Commit => 1,
            GitObjectType.Tree => 2,
            GitObjectType.Blob => 3,
            GitObjectType.Tag => 4,
            _ => 3,
        };

        var Size = Obj.Data.Length;
        var FirstByte = (byte)(((TypeCode & 0x07) << 4) | (Size & 0x0F));
        Size >>= 4;
        if (Size > 0)
        {
            FirstByte |= 0x80;
        }

        Stream.WriteByte(FirstByte);

        while (Size > 0)
        {
            var NextByte = (byte)(Size & 0x7F);
            Size >>= 7;
            if (Size > 0)
            {
                NextByte |= 0x80;
            }

            Stream.WriteByte(NextByte);
        }

        using var CompressedStream = new MemoryStream();
        using (var DeflateStream = new ZLibStream(CompressedStream, CompressionLevel.Optimal, true))
        {
            DeflateStream.Write(Obj.Data, 0, Obj.Data.Length);
        }

        var Compressed = CompressedStream.ToArray();
        Stream.Write(Compressed, 0, Compressed.Length);
    }

    private void UnpackInMemory(byte[] PackData)
    {
        if (PackData.Length < 12)
        {
            return;
        }

        var Signature = ReadInt32BigEndian(PackData, 0);
        if (Signature != 0x5041434B)
        {
            return;
        }

        var ObjectCount = ReadInt32BigEndian(PackData, 8);
        var Offset = 12;

        for (var I = 0; I < ObjectCount && Offset < PackData.Length - 20; I++)
        {
            var Obj = ReadPackObject(PackData, ref Offset);
            if (Obj is not null)
            {
                GitObjects.WriteObject(Repo.GitDir, Obj.Type, Obj.Data);
            }
        }
    }

    private static GitRawObject? ReadPackObject(byte[] Data, ref int Offset)
    {
        if (Offset >= Data.Length)
        {
            return null;
        }

        var Byte = Data[Offset];
        var ObjectType = (Byte >> 4) & 0x07;
        var Size = (long)(Byte & 0x0F);
        var Shift = 4;
        Offset++;

        while ((Byte & 0x80) != 0)
        {
            if (Offset >= Data.Length)
            {
                return null;
            }

            Byte = Data[Offset];
            Size |= (long)(Byte & 0x7F) << Shift;
            Shift += 7;
            Offset++;
        }

        var Type = ObjectType switch
        {
            1 => GitObjectType.Commit,
            2 => GitObjectType.Tree,
            3 => GitObjectType.Blob,
            4 => GitObjectType.Tag,
            _ => GitObjectType.Blob,
        };

        if (ObjectType == 6)
        {
            var DeltaByte = Data[Offset];
            Offset++;
            while ((DeltaByte & 0x80) != 0)
            {
                if (Offset >= Data.Length)
                {
                    return null;
                }

                DeltaByte = Data[Offset];
                Offset++;
            }
        }
        else if (ObjectType == 7)
        {
            Offset += 20;
        }

        try
        {
            using var CompressedStream = new MemoryStream(Data, Offset, Data.Length - Offset - 20);
            using var DeflateStream = new ZLibStream(CompressedStream, CompressionMode.Decompress);
            using var OutputStream = new MemoryStream();
            DeflateStream.CopyTo(OutputStream);
            var Decompressed = OutputStream.ToArray();
            Offset += (int)CompressedStream.Position;

            var Hash = GitObjects.ComputeHash(Type, Decompressed);
            return new GitRawObject
            {
                Hash = Hash,
                Type = Type,
                Data = Decompressed,
                Size = Decompressed.Length,
            };
        }
        catch
        {
            return null;
        }
    }

    private static List<RemoteRef> ParseSmartRefs(string Body)
    {
        var Refs = new List<RemoteRef>();
        var Lines = Body.Split('\n', StringSplitOptions.RemoveEmptyEntries);

        foreach (var RawLine in Lines)
        {
            var Line = RawLine.Trim();

            // Skip service announcement lines (e.g., "# service=...")
            if (Line.StartsWith('#') || Line == FlushPkt)
            {
                continue;
            }

            // Strip pkt-line length prefix (4 hex chars)
            var Content = Line.Length >= 4 ? Line[4..] : Line;

            // Strip capabilities
            var NullIdx = Content.IndexOf('\0', StringComparison.Ordinal);
            if (NullIdx >= 0)
            {
                Content = Content[..NullIdx];
            }

            // Skip service lines
            if (Content.StartsWith("# service=", StringComparison.Ordinal))
            {
                continue;
            }

            var SpaceIdx = Content.IndexOf(' ', StringComparison.Ordinal);
            if (SpaceIdx < 0)
            {
                // Try tab separator
                SpaceIdx = Content.IndexOf('\t', StringComparison.Ordinal);
            }

            if (SpaceIdx < 0)
            {
                continue;
            }

            var Hash = Content[..SpaceIdx].Trim();
            var Name = Content[(SpaceIdx + 1)..].Trim();

            // Validate hash looks like a SHA-1
            if (Hash.Length != 40)
            {
                continue;
            }

            Refs.Add(new RemoteRef
            {
                Hash = Hash,
                Name = Name,
            });
        }

        return Refs;
    }

    private static string FormatPktLine(string Content)
    {
        var Length = Content.Length + 4;
        return string.Format(CultureInfo.InvariantCulture, "{0:x4}{1}", Length, Content);
    }

    private static byte[]? ExtractPackData(byte[] Response)
    {
        // Find PACK signature in response
        for (var I = 0; I < Response.Length - 4; I++)
        {
            if (Response[I] == 'P' && Response[I + 1] == 'A' && Response[I + 2] == 'C' && Response[I + 3] == 'K')
            {
                var PackData = new byte[Response.Length - I];
                Buffer.BlockCopy(Response, I, PackData, 0, PackData.Length);
                return PackData;
            }
        }

        return null;
    }

    private static int ReadInt32BigEndian(byte[] Data, int Offset) =>
        (Data[Offset] << 24) | (Data[Offset + 1] << 16) | (Data[Offset + 2] << 8) | Data[Offset + 3];

    private static void WriteInt32BigEndian(MemoryStream Stream, int Value)
    {
        Stream.WriteByte((byte)((Value >> 24) & 0xFF));
        Stream.WriteByte((byte)((Value >> 16) & 0xFF));
        Stream.WriteByte((byte)((Value >> 8) & 0xFF));
        Stream.WriteByte((byte)(Value & 0xFF));
    }
}

public sealed class RemoteRef
{
    public string Hash { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
#pragma warning restore SA1600
