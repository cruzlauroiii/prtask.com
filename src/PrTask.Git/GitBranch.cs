using System.Globalization;
using PrTask.Git.Models;

namespace PrTask.Git;

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
        var Branches = new List<GitBranchInfo>();
        var HeadBranch = Repo.GetCurrentBranch();
        var HeadsDir = Path.Combine(Repo.GitDir, "refs", "heads");

        if (Directory.Exists(HeadsDir))
        {
            CollectBranches(HeadsDir, string.Empty, Branches, HeadBranch, false);
        }

        return Branches;
    }

    public List<GitBranchInfo> ListRemoteBranches()
    {
        var Branches = new List<GitBranchInfo>();
        var RemotesDir = Path.Combine(Repo.GitDir, "refs", "remotes");

        if (Directory.Exists(RemotesDir))
        {
            CollectBranches(RemotesDir, string.Empty, Branches, null, true);
        }

        return Branches;
    }

    public void CreateBranch(string Name, string? StartPoint = null)
    {
        var Hash = StartPoint is not null
            ? Repo.ResolveRef(StartPoint) ?? throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot resolve ref: {0}", StartPoint))
            : Repo.GetHead() ?? throw new InvalidOperationException("No HEAD commit to branch from");

        Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", Name), Hash);
    }

    public void DeleteBranch(string Name)
    {
        var RefPath = Path.Combine(Repo.GitDir, "refs", "heads", Name);
        if (!File.Exists(RefPath))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch not found: {0}", Name));
        }

        var CurrentBranch = Repo.GetCurrentBranch();
        if (string.Equals(Name, CurrentBranch, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot delete current branch: {0}", Name));
        }

        File.Delete(RefPath);
    }

    public void Checkout(string Name)
    {
        var Hash = Repo.ResolveRef(Name);
        if (Hash is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot resolve branch: {0}", Name));
        }

        // Update working tree from the commit tree
        var Commit = Repo.GetCommit(Hash);
        if (Commit is null)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot read commit: {0}", Hash));
        }

        CheckoutTree(Commit.TreeHash, Repo.WorkDir, string.Empty);

        // Update HEAD
        Repo.SetHead(Name);

        // Update index
        var Index = new GitIndex(Repo);
        Index.StageAll();
    }

    public void RenameBranch(string OldName, string NewName)
    {
        var OldRef = Path.Combine(Repo.GitDir, "refs", "heads", OldName);
        if (!File.Exists(OldRef))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Branch not found: {0}", OldName));
        }

        var Hash = File.ReadAllText(OldRef).Trim();
        Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", NewName), Hash);
        File.Delete(OldRef);

        var CurrentBranch = Repo.GetCurrentBranch();
        if (string.Equals(OldName, CurrentBranch, StringComparison.Ordinal))
        {
            Repo.SetHead(NewName);
        }
    }

    private void CheckoutTree(string TreeHash, string BaseDir, string Prefix)
    {
        var Entries = Repo.GetTree(TreeHash);
        foreach (var Entry in Entries)
        {
            var FullPath = Path.Combine(BaseDir, Entry.Name);
            if (Entry.IsDirectory)
            {
                Directory.CreateDirectory(FullPath);
                var SubPrefix = string.IsNullOrEmpty(Prefix)
                    ? Entry.Name
                    : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, Entry.Name);
                CheckoutTree(Entry.Hash, FullPath, SubPrefix);
            }
            else
            {
                var Content = Repo.GetBlobContent(Entry.Hash);
                if (Content is not null)
                {
                    File.WriteAllBytes(FullPath, Content);
                }
            }
        }
    }

    private static void CollectBranches(string Dir, string Prefix, List<GitBranchInfo> Branches, string? HeadBranch, bool IsRemote)
    {
        foreach (var FilePath in Directory.GetFiles(Dir))
        {
            var Name = Path.GetFileName(FilePath);
            var FullName = string.IsNullOrEmpty(Prefix)
                ? Name
                : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, Name);
            var Hash = File.ReadAllText(FilePath).Trim();

            Branches.Add(new GitBranchInfo
            {
                Name = FullName,
                Hash = Hash,
                IsHead = !IsRemote && string.Equals(FullName, HeadBranch, StringComparison.Ordinal),
                IsRemote = IsRemote,
            });
        }

        foreach (var SubDir in Directory.GetDirectories(Dir))
        {
            var SubName = Path.GetFileName(SubDir);
            var SubPrefix = string.IsNullOrEmpty(Prefix)
                ? SubName
                : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, SubName);
            CollectBranches(SubDir, SubPrefix, Branches, HeadBranch, IsRemote);
        }
    }
}
#pragma warning restore SA1600
