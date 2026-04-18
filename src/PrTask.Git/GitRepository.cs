using System.Globalization;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed class GitRepository
{
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
        if (!Directory.Exists(GitDir))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Not a git repository: {0}", Path));
        }

        return new GitRepository(Path, GitDir);
    }

    public static GitRepository Init(string Path)
    {
        var GitDir = System.IO.Path.Combine(Path, ".git");
        Directory.CreateDirectory(GitDir);
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "objects"));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "refs", "heads"));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "refs", "tags"));
        Directory.CreateDirectory(System.IO.Path.Combine(GitDir, "refs", "remotes"));

        File.WriteAllText(System.IO.Path.Combine(GitDir, "HEAD"), "ref: refs/heads/main\n");
        File.WriteAllText(System.IO.Path.Combine(GitDir, "config"), "[core]\n\trepositoryformatversion = 0\n\tfilemode = false\n\tbare = false\n");
        File.WriteAllText(System.IO.Path.Combine(GitDir, "description"), "Unnamed repository\n");

        return new GitRepository(Path, GitDir);
    }

    public string? GetHead()
    {
        var HeadPath = System.IO.Path.Combine(GitDir, "HEAD");
        if (!File.Exists(HeadPath))
        {
            return null;
        }

        var Content = File.ReadAllText(HeadPath).Trim();
        if (Content.StartsWith("ref: ", StringComparison.Ordinal))
        {
            var RefPath = System.IO.Path.Combine(GitDir, Content[5..].Replace('/', System.IO.Path.DirectorySeparatorChar));
            return File.Exists(RefPath) ? File.ReadAllText(RefPath).Trim() : null;
        }

        return Content;
    }

    public string? GetCurrentBranch()
    {
        var HeadPath = System.IO.Path.Combine(GitDir, "HEAD");
        if (!File.Exists(HeadPath))
        {
            return null;
        }

        var Content = File.ReadAllText(HeadPath).Trim();
        if (Content.StartsWith("ref: refs/heads/", StringComparison.Ordinal))
        {
            return Content["ref: refs/heads/".Length..];
        }

        return null; // Detached HEAD
    }

    public void SetHead(string Ref)
    {
        var HeadPath = System.IO.Path.Combine(GitDir, "HEAD");
        File.WriteAllText(HeadPath, string.Format(CultureInfo.InvariantCulture, "ref: refs/heads/{0}\n", Ref));
    }

    public string? ResolveRef(string RefName)
    {
        // Try full ref path
        var FullPath = System.IO.Path.Combine(GitDir, RefName.Replace('/', System.IO.Path.DirectorySeparatorChar));
        if (File.Exists(FullPath))
        {
            return File.ReadAllText(FullPath).Trim();
        }

        // Try refs/heads/
        var HeadRef = System.IO.Path.Combine(GitDir, "refs", "heads", RefName);
        if (File.Exists(HeadRef))
        {
            return File.ReadAllText(HeadRef).Trim();
        }

        // Try refs/tags/
        var TagRef = System.IO.Path.Combine(GitDir, "refs", "tags", RefName);
        if (File.Exists(TagRef))
        {
            return File.ReadAllText(TagRef).Trim();
        }

        // Try refs/remotes/
        var RemoteRef = System.IO.Path.Combine(GitDir, "refs", "remotes", RefName.Replace('/', System.IO.Path.DirectorySeparatorChar));
        if (File.Exists(RemoteRef))
        {
            return File.ReadAllText(RemoteRef).Trim();
        }

        return null;
    }

    public void UpdateRef(string RefName, string Hash)
    {
        var RefPath = System.IO.Path.Combine(GitDir, RefName.Replace('/', System.IO.Path.DirectorySeparatorChar));
        var RefDir = System.IO.Path.GetDirectoryName(RefPath)!;
        Directory.CreateDirectory(RefDir);
        File.WriteAllText(RefPath, string.Format(CultureInfo.InvariantCulture, "{0}\n", Hash));
    }

    public GitRawObject? ReadObject(string Hash) =>
        GitObjects.ReadObject(GitDir, Hash);

    public GitCommitInfo? GetCommit(string Hash)
    {
        var Obj = ReadObject(Hash);
        if (Obj is null || Obj.Type != GitObjectType.Commit)
        {
            return null;
        }

        var Info = GitObjects.ParseCommit(Obj.Data);
        if (Info is null)
        {
            return null;
        }

        Info.Hash = Hash;
        return Info;
    }

    public List<GitTreeEntry> GetTree(string Hash)
    {
        var Obj = ReadObject(Hash);
        if (Obj is null || Obj.Type != GitObjectType.Tree)
        {
            return new List<GitTreeEntry>();
        }

        return GitObjects.ParseTree(Obj.Data);
    }

    public byte[]? GetBlobContent(string Hash)
    {
        var Obj = ReadObject(Hash);
        return Obj?.Type == GitObjectType.Blob ? Obj.Data : null;
    }

    public string? GetConfig(string Section, string Key)
    {
        var ConfigPath = System.IO.Path.Combine(GitDir, "config");
        if (!File.Exists(ConfigPath))
        {
            return null;
        }

        var Lines = File.ReadAllLines(ConfigPath);
        var InSection = false;
        var SectionHeader = string.Format(CultureInfo.InvariantCulture, "[{0}]", Section);

        foreach (var Line in Lines)
        {
            var Trimmed = Line.Trim();
            if (Trimmed.StartsWith('['))
            {
                InSection = Trimmed.Equals(SectionHeader, StringComparison.OrdinalIgnoreCase);
                continue;
            }

            if (!InSection)
            {
                continue;
            }

            var EqPos = Trimmed.IndexOf('=', StringComparison.Ordinal);
            if (EqPos < 0)
            {
                continue;
            }

            var K = Trimmed[..EqPos].Trim();
            if (K.Equals(Key, StringComparison.OrdinalIgnoreCase))
            {
                return Trimmed[(EqPos + 1)..].Trim();
            }
        }

        return null;
    }

    public void SetConfig(string Section, string Key, string Value)
    {
        var ConfigPath = System.IO.Path.Combine(GitDir, "config");
        var Lines = File.Exists(ConfigPath) ? File.ReadAllLines(ConfigPath).ToList() : new List<string>();
        var SectionHeader = string.Format(CultureInfo.InvariantCulture, "[{0}]", Section);
        var Found = false;
        var InSection = false;
        var SectionEnd = GitConstants.NotFound;

        for (var I = 0; I < Lines.Count; I++)
        {
            var Trimmed = Lines[I].Trim();
            if (Trimmed.StartsWith('['))
            {
                if (InSection)
                {
                    SectionEnd = I;
                }

                InSection = Trimmed.Equals(SectionHeader, StringComparison.OrdinalIgnoreCase);
                continue;
            }

            if (!InSection)
            {
                continue;
            }

            var EqPos = Trimmed.IndexOf('=', StringComparison.Ordinal);
            if (EqPos < 0)
            {
                continue;
            }

            var K = Trimmed[..EqPos].Trim();
            if (K.Equals(Key, StringComparison.OrdinalIgnoreCase))
            {
                Lines[I] = string.Format(CultureInfo.InvariantCulture, "\t{0} = {1}", Key, Value);
                Found = true;
                break;
            }
        }

        if (!Found)
        {
            var Entry = string.Format(CultureInfo.InvariantCulture, "\t{0} = {1}", Key, Value);
            if (SectionEnd >= 0)
            {
                Lines.Insert(SectionEnd, Entry);
            }
            else if (InSection)
            {
                Lines.Add(Entry);
            }
            else
            {
                Lines.Add(SectionHeader);
                Lines.Add(Entry);
            }
        }

        File.WriteAllLines(ConfigPath, Lines);
    }
}
#pragma warning restore SA1600
