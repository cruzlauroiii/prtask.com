using System.Globalization;
using PrTask.Domain.Constants;

namespace PrTask.Git;

#pragma warning disable SA1600
public class GitSyncService : PrTask.Application.Services.IGitSyncService
{
    private string LocalDir = GitSyncConstants.DefaultLocalDir;
    private GitRepository? Repo;

    public GitSyncService()
    {
    }

    public GitSyncService(string LocalDir)
    {
        this.LocalDir = LocalDir;
    }

    public void SetLocalDirectory(string Path)
    {
        LocalDir = Path;
        Repo = null;
    }

    public Task InitAsync()
    {
        EnsureRepo();
        return Task.CompletedTask;
    }

    public async Task CloneAsync(string Branch)
    {
        var Url = string.Format(CultureInfo.InvariantCulture, GitSyncConstants.CloneUrlFormat, GitSyncConstants.CorsProxyBase, GitSyncConstants.RepoOwner, GitSyncConstants.PublicRepo);

        Repo = GitRepository.Init(LocalDir);
        var Remote = new GitRemote(Repo);
        Remote.AddRemote(GitSyncConstants.DefaultRemoteName, Url);
        await Remote.FetchAsync(GitSyncConstants.DefaultRemoteName).ConfigureAwait(false);

        // Resolve remote branch and set local HEAD
        var RemoteRef = string.Format(CultureInfo.InvariantCulture, "refs/remotes/{0}/{1}", GitSyncConstants.DefaultRemoteName, Branch);
        var Hash = Repo.ResolveRef(RemoteRef);
        if (Hash is not null)
        {
            Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", Branch), Hash);
            Repo.SetHead(Branch);

            var BranchOps = new GitBranch(Repo);
            BranchOps.Checkout(Branch);
        }
    }

    public async Task PullAsync()
    {
        EnsureRepo();
        var Remote = new GitRemote(Repo!);
        await Remote.FetchAsync(GitSyncConstants.DefaultRemoteName).ConfigureAwait(false);

        // Reset to remote HEAD
        var RefParts = GitSyncConstants.DefaultRemoteRef.Split('/');
        var RemoteRef = string.Format(CultureInfo.InvariantCulture, "refs/remotes/{0}", string.Join("/", RefParts));
        var Hash = Repo!.ResolveRef(RemoteRef);
        if (Hash is not null)
        {
            var CurrentBranch = Repo.GetCurrentBranch();
            if (CurrentBranch is not null)
            {
                Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", CurrentBranch), Hash);
            }

            var BranchOps = new GitBranch(Repo);
            if (CurrentBranch is not null)
            {
                BranchOps.Checkout(CurrentBranch);
            }
        }
    }

    public Task<string?> GetCurrentBranchAsync()
    {
        EnsureRepo();
        return Task.FromResult(Repo!.GetCurrentBranch());
    }

    public Task SwitchBranchAsync(string Branch)
    {
        EnsureRepo();
        var BranchOps = new GitBranch(Repo!);
        BranchOps.Checkout(Branch);
        return Task.CompletedTask;
    }

    public Task<string?> GetLastCommitHashAsync()
    {
        EnsureRepo();
        return Task.FromResult(Repo!.GetHead());
    }

    public Task ResetHardAsync(string Ref)
    {
        EnsureRepo();
        var Hash = Repo!.ResolveRef(Ref) ?? Ref;
        var CurrentBranch = Repo.GetCurrentBranch();
        if (CurrentBranch is not null)
        {
            Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", CurrentBranch), Hash);
        }

        var BranchOps = new GitBranch(Repo);
        if (CurrentBranch is not null)
        {
            BranchOps.Checkout(CurrentBranch);
        }

        return Task.CompletedTask;
    }

    public Task CommitAsync(string Message)
    {
        EnsureRepo();
        var Index = new GitIndex(Repo!);
        Index.StageAll();
        var Committer = new GitCommit(Repo!);
        Committer.CreateCommit(Message, "PrTask", "deploy@prtask.com");
        return Task.CompletedTask;
    }

    public async Task PushAsync(string Remote, string Branch)
    {
        EnsureRepo();
        var RemoteOps = new GitRemote(Repo!);
        await RemoteOps.PushAsync(Remote, Branch).ConfigureAwait(false);
    }

    private void EnsureRepo()
    {
        if (Repo is not null)
        {
            return;
        }

        var GitDir = Path.Combine(LocalDir, ".git");
        Repo = Directory.Exists(GitDir)
            ? GitRepository.Open(LocalDir)
            : GitRepository.Init(LocalDir);
    }
}
#pragma warning restore SA1600
