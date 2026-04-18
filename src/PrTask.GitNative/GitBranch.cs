using System.Globalization;
using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public sealed class GitBranch
{
    private readonly GitRepository Repo;

    public GitBranch(GitRepository Repo)
    {
        this.Repo = Repo;
    }

    public List<GitBranchInfo> ListBranches()
    {
        var Result = new List<GitBranchInfo>();
        var CurrentBranch = Repo.GetCurrentBranch();

        var HeadsDir = Path.Combine(Repo.GitDir, "refs", "heads");
        if (Directory.Exists(HeadsDir))
        {
            CollectBranches(HeadsDir, string.Empty, false, CurrentBranch, Result);
        }

        return Result;
    }

    public List<GitBranchInfo> ListRemoteBranches()
    {
        var Result = new List<GitBranchInfo>();
        var RemotesDir = Path.Combine(Repo.GitDir, "refs", "remotes");
        if (Directory.Exists(RemotesDir))
        {
            CollectBranches(RemotesDir, string.Empty, true, null, Result);
        }

        return Result;
    }

    public List<GitBranchInfo> ListAllBranches()
    {
        var Result = ListBranches();
        Result.AddRange(ListRemoteBranches());
        return Result;
    }

    public void CreateBranch(string Name, string? StartPoint = null)
    {
        var RefPath = string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", Name);
        var ExistingHash = Repo.ResolveRef(RefPath);
        if (ExistingHash is not null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch '{0}' already exists", Name));
        }

        string Hash;
        if (StartPoint is not null)
        {
            var Resolved = Repo.ResolveRef(StartPoint) ?? Repo.ResolveRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", StartPoint));
            Hash = Resolved ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot resolve start point: {0}", StartPoint));
        }
        else
        {
            Hash = Repo.GetHead() ?? throw new InvalidOperationException("HEAD does not point to a valid commit");
        }

        Repo.UpdateRef(RefPath, Hash);
    }

    public void DeleteBranch(string Name)
    {
        var CurrentBranch = Repo.GetCurrentBranch();
        if (string.Equals(Name, CurrentBranch, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot delete checked out branch '{0}'", Name));
        }

        var RefPath = Path.Combine(Repo.GitDir, "refs", "heads", Name.Replace('/', Path.DirectorySeparatorChar));
        if (!File.Exists(RefPath))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch '{0}' not found", Name));
        }

        File.Delete(RefPath);

        // Clean up empty parent directories
        var Parent = Path.GetDirectoryName(RefPath);
        while (Parent is not null && Parent != Path.Combine(Repo.GitDir, "refs", "heads"))
        {
            if (Directory.Exists(Parent) && Directory.GetFileSystemEntries(Parent).Length == 0)
            {
                Directory.Delete(Parent);
                Parent = Path.GetDirectoryName(Parent);
            }
            else
            {
                break;
            }
        }
    }

    public void RenameBranch(string OldName, string NewName)
    {
        var OldRefPath = Path.Combine(Repo.GitDir, "refs", "heads", OldName.Replace('/', Path.DirectorySeparatorChar));
        if (!File.Exists(OldRefPath))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch '{0}' not found", OldName));
        }

        var NewRefPath = string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", NewName);
        if (Repo.ResolveRef(NewRefPath) is not null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch '{0}' already exists", NewName));
        }

        var Hash = File.ReadAllText(OldRefPath).Trim();
        Repo.UpdateRef(NewRefPath, Hash);
        File.Delete(OldRefPath);

        // Update HEAD if needed
        var CurrentBranch = Repo.GetCurrentBranch();
        if (string.Equals(CurrentBranch, OldName, StringComparison.Ordinal))
        {
            Repo.SetHead(NewName);
        }
    }

    public void Checkout(string Name)
    {
        var Hash = Repo.ResolveRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", Name));
        if (Hash is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch '{0}' not found", Name));
        }

        Repo.SetHead(Name);
    }

    public string? GetUpstream(string BranchName)
    {
        var MergeRef = Repo.GetConfig(string.Format(CultureInfo.InvariantCulture, "branch \"{0}\"", BranchName), "merge");
        var Remote = Repo.GetConfig(string.Format(CultureInfo.InvariantCulture, "branch \"{0}\"", BranchName), "remote");

        if (MergeRef is null || Remote is null)
        {
            return null;
        }

        // Convert refs/heads/main to origin/main
        var RemoteBranch = MergeRef.StartsWith("refs/heads/", StringComparison.Ordinal)
            ? MergeRef["refs/heads/".Length..]
            : MergeRef;

        return string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Remote, RemoteBranch);
    }

    public void SetUpstream(string BranchName, string RemoteName, string RemoteBranch)
    {
        var Section = string.Format(CultureInfo.InvariantCulture, "branch \"{0}\"", BranchName);
        Repo.SetConfig(Section, "remote", RemoteName);
        Repo.SetConfig(Section, "merge", string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", RemoteBranch));
    }

    public List<GitRemoteInfo> ListRemotes()
    {
        var Result = new List<GitRemoteInfo>();
        var ConfigPath = Path.Combine(Repo.GitDir, "config");
        if (!File.Exists(ConfigPath))
        {
            return Result;
        }

        var Lines = File.ReadAllLines(ConfigPath);
        string? CurrentRemote = null;
        string? FetchUrl = null;
        string? PushUrl = null;

        foreach (var Line in Lines)
        {
            var Trimmed = Line.Trim();
            if (Trimmed.StartsWith("[remote \"", StringComparison.Ordinal) && Trimmed.EndsWith("\"]", StringComparison.Ordinal))
            {
                if (CurrentRemote is not null)
                {
                    Result.Add(new GitRemoteInfo
                    {
                        Name = CurrentRemote,
                        FetchUrl = FetchUrl ?? string.Empty,
                        PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
                    });
                }

                CurrentRemote = Trimmed["[remote \"".Length..^"\"]".Length];
                FetchUrl = null;
                PushUrl = null;
            }
            else if (Trimmed.StartsWith('['))
            {
                if (CurrentRemote is not null)
                {
                    Result.Add(new GitRemoteInfo
                    {
                        Name = CurrentRemote,
                        FetchUrl = FetchUrl ?? string.Empty,
                        PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
                    });

                    CurrentRemote = null;
                    FetchUrl = null;
                    PushUrl = null;
                }
            }
            else if (CurrentRemote is not null)
            {
                var EqPos = Trimmed.IndexOf('=', StringComparison.Ordinal);
                if (EqPos < 0)
                {
                    continue;
                }

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

        if (CurrentRemote is not null)
        {
            Result.Add(new GitRemoteInfo
            {
                Name = CurrentRemote,
                FetchUrl = FetchUrl ?? string.Empty,
                PushUrl = PushUrl ?? FetchUrl ?? string.Empty,
            });
        }

        return Result;
    }

    private static void CollectBranches(string Dir, string Prefix, bool IsRemote, string? CurrentBranch, List<GitBranchInfo> Result)
    {
        foreach (var Entry in Directory.GetFileSystemEntries(Dir))
        {
            var Name = Path.GetFileName(Entry);
            var FullName = string.IsNullOrEmpty(Prefix) ? Name : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, Name);

            if (Directory.Exists(Entry))
            {
                CollectBranches(Entry, FullName, IsRemote, CurrentBranch, Result);
            }
            else
            {
                var Hash = File.ReadAllText(Entry).Trim();
                Result.Add(new GitBranchInfo
                {
                    Name = FullName,
                    Hash = Hash,
                    IsHead = !IsRemote && string.Equals(FullName, CurrentBranch, StringComparison.Ordinal),
                    IsRemote = IsRemote,
                });
            }
        }
    }
}
#pragma warning restore SA1600
