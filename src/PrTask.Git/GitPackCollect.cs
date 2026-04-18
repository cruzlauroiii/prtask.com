using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public static partial class GitPack
{
    private static void CollectObjectsForPack(
        GitRepository Repo, string Hash,
        List<GitRawObject> Objects, HashSet<string> Visited, HashSet<string> Exclude)
    {
        if (!Visited.Add(Hash) || Exclude.Contains(Hash))
        {
            return;
        }

        var Obj = Repo.ReadObject(Hash);
        if (Obj is null)
        {
            return;
        }

        Objects.Add(Obj);

        if (Obj.Type == GitObjectType.Commit)
        {
            var Info = GitObjects.ParseCommit(Obj.Data);
            if (Info is not null)
            {
                CollectObjectsForPack(Repo, Info.TreeHash, Objects, Visited, Exclude);
                foreach (var Parent in Info.ParentHashes)
                {
                    CollectObjectsForPack(Repo, Parent, Objects, Visited, Exclude);
                }
            }
        }
        else if (Obj.Type == GitObjectType.Tree)
        {
            var Entries = GitObjects.ParseTree(Obj.Data);
            foreach (var Entry in Entries)
            {
                CollectObjectsForPack(Repo, Entry.Hash, Objects, Visited, Exclude);
            }
        }
    }

    private static void CollectReachableObjects(GitRepository Repo, string Hash, HashSet<string> Visited)
    {
        if (!Visited.Add(Hash))
        {
            return;
        }

        var Obj = Repo.ReadObject(Hash);
        if (Obj is null)
        {
            return;
        }

        if (Obj.Type == GitObjectType.Commit)
        {
            var Info = GitObjects.ParseCommit(Obj.Data);
            if (Info is not null)
            {
                CollectReachableObjects(Repo, Info.TreeHash, Visited);
                foreach (var Parent in Info.ParentHashes)
                {
                    CollectReachableObjects(Repo, Parent, Visited);
                }
            }
        }
        else if (Obj.Type == GitObjectType.Tree)
        {
            var Entries = GitObjects.ParseTree(Obj.Data);
            foreach (var Entry in Entries)
            {
                CollectReachableObjects(Repo, Entry.Hash, Visited);
            }
        }
    }
}
#pragma warning restore SA1600
