namespace PrTask.Git.Generated;

internal static partial class Setup
{
    internal enum AllowedBareRepo
    {
        ALLOWED_BARE_REPO_EXPLICIT = 0,
        ALLOWED_BARE_REPO_ALL,
    }
    internal static int AbspathPartInsideRepo(string Path)
        => default;

    internal static int PathInsideRepo(string Prefix, string Path)
        => default;

    internal static int CheckFilename(string Prefix, string Arg)
        => default;

    internal static int LooksLikePathspec(string Arg)
        => default;

    internal static void VerifyNonFilename(string Prefix, string Arg)
    {
    }

    internal static int GetCommonDir(nint Sb, string Gitdir)
        => default;

    internal static int GetCommonDirNoenv(nint Sb, string Gitdir)
        => default;

    internal static int ValidateHeadref(string Path)
        => default;

    internal static int IsGitDirectory(string Suspect)
        => default;

    internal static int IsNonbareRepositoryDir(nint Path)
        => default;

    internal static int IsInsideGitDir()
        => default;

    internal static int IsInsideWorkTree()
        => default;

    internal static void SetupWorkTree()
    {
    }

    internal static void SetupOriginalCwd()
    {
    }

    internal enum ExtensionResult
    {
        EXTENSION_ERROR = -1,
        EXTENSION_UNKNOWN = 0,
        EXTENSION_OK = 1,
    }
    internal static int CheckRepositoryFormatGently(string Gitdir, nint Candidate, nint NongitOk)
        => default;

    internal static int UpgradeRepositoryFormat(int TargetVersion)
        => default;

    internal static void InitRepositoryFormat(nint Format)
    {
    }

    internal static int ReadRepositoryFormat(nint Format, string Path)
        => default;

    internal static void ClearRepositoryFormat(nint Format)
    {
    }

    internal static void ReadGitfileErrorDie(int ErrorCode, string Path, string Dir)
    {
    }

    internal static void SetupGitEnv(string GitDir)
    {
    }

    internal static void SetGitDir1(string Path, bool SkipInitializingOdb)
    {
    }

    internal static void SetGitDir(string Path, int MakeRealpath)
    {
    }

    internal static DevT GetDeviceOrDie(string Path, string Prefix, int PrefixLen)
        => default;

    internal static AllowedBareRepo GetAllowedBareRepo()
        => default;

    internal static int IsImplicitBareRepo(string Path)
        => default;

    internal static void SetGitWorkTree(string NewWorkTree)
    {
    }

    internal static int GitConfigPerm(string Var, string Value)
        => default;

    internal static void CheckRepositoryFormat(nint Fmt)
    {
    }

    internal static void SanitizeStdfds()
    {
    }

    internal static int Daemonize()
        => default;

    internal const int TEST_FILEMODE = 0;
    internal const int TEST_FILEMODE = 1;
    internal const string GIT_DEFAULT_HASH_ENVIRONMENT = "GIT_DEFAULT_HASH";
    internal static void CopyTemplates(string OptionTemplate)
    {
    }

    internal static int NeedsWorkTreeConfig(string GitDir, string WorkTree)
        => default;

    internal static int IsReinit()
        => default;

    internal static void CreateReferenceDatabase(string InitialBranch, int Quiet)
    {
    }

    internal static void CreateObjectDirectory()
    {
    }

    internal static void SeparateGitDir(string GitDir, string GitLink)
    {
    }

}
