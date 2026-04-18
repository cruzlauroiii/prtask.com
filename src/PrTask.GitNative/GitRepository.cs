using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public sealed class GitRepository
{
    private const string HeadFile = "HEAD";
    private const string RefsHeadsDir = "refs/heads";
    private const string RefsTagsDir = "refs/tags";
    private const string RefsRemotesDir = "refs/remotes";
    private const string ConfigFile = "config";
    private const string ObjectsDir = "objects";
    private const string PackedRefsFile = "packed-refs";

    public string WorkDir { get; }
    public string GitDir { get; }

    private GitRepository(string WorkDir, string GitDir)
    {
        this.WorkDir = WorkDir;
        this.GitDir = GitDir;
    }

    public static GitRepository Open(string Path)
    {
        var GitDir = System.IO.Path.Combine(Path, ".git");
        if (Directory.Exists(GitDir))
        {
            return new GitRepository(Path, GitDir);
        }

        // Bare repository
        if (File.Exists(System.IO.Path.Combine(Path, HeadFile)) &&
            Directory.Exists(System.IO.Path.Combine(Path, ObjectsDir)))
        {
            return new GitRepository(Path, Path);
        }

        // Check parent directories
        var Dir = new DirectoryInfo(Path);
        while (Dir.Parent is not null)
        {
            Dir = Dir.Parent;
            var CandidateGit = System.IO.Path.Combine(Dir.FullName, ".git");
            if (Directory.Exists(CandidateGit))
            {
                return new GitRepository(Dir.FullName, CandidateGit);
            }
        }

        throw new InvalidOperationException($"Not a git repository: {Path}");
    }

    public static GitRepository Init(string Path, bool Bare = false)
    {
        Directory.CreateDirectory(Path);

        var GitDir = Bare ? Path : System.IO.Path.Combine(Path, ".git");
        Directory.CreateDirectory(GitDir);
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, ObjectsDir));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "objects/info"));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "objects/pack"));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, RefsHeadsDir));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, RefsTagsDir));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "info"));

        File.WriteAllText(System.IO.Path.Combine(GitDir, HeadFile), "ref: refs/heads/main\n");
        File.WriteAllText(System.IO.Path.Combine(GitDir, "description"), "Unnamed repository\n");
        File.WriteAllText(System.IO.Path.Combine(GitDir, ConfigFile),
            "[core]\n\trepositoryformatversion = 0\n\tfilemode = false\n\tbare = " + (Bare ? "true" : "false") + "\n");

        return new GitRepository(Bare ? Path : Path, GitDir);
    }

    public string ReadHead()
    {
        var HeadPath = System.IO.Path.Combine(GitDir, HeadFile);
        if (!File.Exists(HeadPath))
        {
            return string.Empty;
        }

        var Content = File.ReadAllText(HeadPath).Trim();

        // Symbolic reference: "ref: refs/heads/main"
        if (Content.StartsWith("ref: ", StringComparison.Ordinal))
        {
            var RefPath = Content[5..];
            return ResolveRef(RefPath);
        }

        // Detached HEAD: raw SHA-1
        return Content;
    }

    public string ReadHeadRef()
    {
        var HeadPath = System.IO.Path.Combine(GitDir, HeadFile);
        if (!File.Exists(HeadPath))
        {
            return string.Empty;
        }

        var Content = File.ReadAllText(HeadPath).Trim();
        if (Content.StartsWith("ref: ", StringComparison.Ordinal))
        {
            return Content[5..];
        }

        return string.Empty;
    }

    public string ReadHeadBranchName()
    {
        var Ref = ReadHeadRef();
        if (Ref.StartsWith("refs/heads/", StringComparison.Ordinal))
        {
            return Ref[11..];
        }

        return string.Empty;
    }

    public bool IsDetachedHead()
    {
        var HeadPath = System.IO.Path.Combine(GitDir, HeadFile);
        if (!File.Exists(HeadPath))
        {
            return false;
        }

        var Content = File.ReadAllText(HeadPath).Trim();
        return !Content.StartsWith("ref: ", StringComparison.Ordinal);
    }

    public string ResolveRef(string RefPath)
    {
        var FullPath = System.IO.Path.Combine(GitDir, RefPath.Replace('/', System.IO.Path.DirectorySeparatorChar));
        if (File.Exists(FullPath))
        {
            var Content = File.ReadAllText(FullPath).Trim();
            // Follow symbolic refs
            if (Content.StartsWith("ref: ", StringComparison.Ordinal))
            {
                return ResolveRef(Content[5..]);
            }

            return Content;
        }

        // Check packed-refs
        return ResolvePackedRef(RefPath);
    }

    public Dictionary<string, string> ReadAllRefs()
    {
        var Refs = new Dictionary<string, string>(StringComparer.Ordinal);

        // Read loose refs
        ReadLooseRefs(System.IO.Path.Combine(GitDir, "refs"), "refs", Refs);

        // Read packed-refs (loose refs override packed)
        ReadPackedRefs(Refs);

        return Refs;
    }

    public GitRawObject? ReadObject(string Hash) => GitObjects.ReadObject(GitDir, Hash);

    public string WriteObject(GitObjectType Type, byte[] Data) => GitObjects.WriteObject(GitDir, Type, Data);

    public GitBlob? ReadBlob(string Hash)
    {
        var Raw = ReadObject(Hash);
        if (Raw is null || Raw.Type != GitObjectType.Blob)
        {
            return null;
        }

        return GitBlob.FromRaw(Raw);
    }

    public GitTree? ReadTree(string Hash)
    {
        var Raw = ReadObject(Hash);
        if (Raw is null || Raw.Type != GitObjectType.Tree)
        {
            return null;
        }

        return GitTree.FromRaw(Raw);
    }

    public GitCommitObject? ReadCommit(string Hash)
    {
        var Raw = ReadObject(Hash);
        if (Raw is null || Raw.Type != GitObjectType.Commit)
        {
            return null;
        }

        return GitCommitObject.FromRaw(Raw);
    }

    public bool ObjectExists(string Hash) =>
        File.Exists(System.IO.Path.Combine(GitDir, "objects", Hash[..2], Hash[2..]));

    private string ResolvePackedRef(string RefPath)
    {
        var PackedPath = System.IO.Path.Combine(GitDir, PackedRefsFile);
        if (!File.Exists(PackedPath))
        {
            return string.Empty;
        }

        foreach (var Line in File.ReadLines(PackedPath))
        {
            if (Line.StartsWith('#'))
            {
                continue;
            }

            if (Line.StartsWith('^'))
            {
                continue;
            }

            var Parts = Line.Split(' ', 2);
            if (Parts.Length == 2 && Parts[1] == RefPath)
            {
                return Parts[0];
            }
        }

        return string.Empty;
    }

    private void ReadLooseRefs(string Dir, string Prefix, Dictionary<string, string> Refs)
    {
        if (!Directory.Exists(Dir))
        {
            return;
        }

        foreach (var FilePath in Directory.GetFiles(Dir))
        {
            var Name = System.IO.Path.GetFileName(FilePath);
            var RefName = Prefix + "/" + Name;
            var Content = File.ReadAllText(FilePath).Trim();
            Refs[RefName] = Content;
        }

        foreach (var SubDir in Directory.GetDirectories(Dir))
        {
            var DirName = System.IO.Path.GetFileName(SubDir);
            ReadLooseRefs(SubDir, Prefix + "/" + DirName, Refs);
        }
    }

    private void ReadPackedRefs(Dictionary<string, string> Refs)
    {
        var PackedPath = System.IO.Path.Combine(GitDir, PackedRefsFile);
        if (!File.Exists(PackedPath))
        {
            return;
        }

        foreach (var Line in File.ReadLines(PackedPath))
        {
            if (Line.StartsWith('#') || Line.StartsWith('^'))
            {
                continue;
            }

            var Parts = Line.Split(' ', 2);
            if (Parts.Length == 2 && !Refs.ContainsKey(Parts[1]))
            {
                Refs[Parts[1]] = Parts[0];
            }
        }
    }
}
#pragma warning restore SA1600
