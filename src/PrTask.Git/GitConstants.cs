namespace PrTask.Git;

#pragma warning disable SA1600
internal static class GitConstants
{
    internal const string Refs = "refs";
    internal const string Heads = "heads";
    internal const string Tags = "tags";
    internal const string Remotes = "remotes";
    internal const string Objects = "objects";
    internal const string Pack = "pack";
    internal const string HeadFile = "HEAD";
    internal const string IndexFile = "index";
    internal const string ConfigFile = "config";
    internal const string DescriptionFile = "description";
    internal const string GitDirName = ".git";
    internal const string GitIgnoreFileName = ".gitignore";

    internal const string RefsHeadsPrefix = "refs/heads/";
    internal const string RefPrefix = "ref: ";
    internal const string RefHeadPrefix = "ref: refs/heads/";

    internal const string TreePrefix = "tree ";
    internal const string ParentPrefix = "parent ";
    internal const string AuthorPrefix = "author ";
    internal const string CommitterPrefix = "committer ";

    internal const string BlobTypeString = "blob";
    internal const string TreeTypeString = "tree";
    internal const string CommitTypeString = "commit";
    internal const string TagTypeString = "tag";

    internal const string ObjectHeaderFormat = "{0} {1}\0";
    internal const string TreeEntryFormat = "{0} {1}\0";
    internal const string PathSeparator = "/";
    internal const string PathCombineFormat = "{0}/{1}";
    internal const string RefHashFormat = "{0}\n";
    internal const string HeadRefFormat = "ref: refs/heads/{0}\n";
    internal const string RefsHeadsFormat = "refs/heads/{0}";
    internal const string RefsRemotesFormat = "refs/remotes/{0}/{1}";
    internal const string ConfigSectionFormat = "[{0}]";
    internal const string ConfigEntryFormat = "\t{0} = {1}";

    internal const string CommitTreeLineFormat = "tree {0}\n";
    internal const string CommitParentLineFormat = "parent {0}\n";
    internal const string CommitAuthorLineFormat = "author {0} <{1}> {2}\n";
    internal const string CommitCommitterLineFormat = "committer {0} <{1}> {2}\n";
    internal const string TimestampFormat = "{0} {1}{2:D2}{3:D2}";
    internal const string TimestampSignPlus = "+";
    internal const string TimestampSignMinus = "-";

    internal const string DiffGitHeaderFormat = "diff --git a/{0} b/{0}";
    internal const string DiffGitHeaderTwoPathFormat = "diff --git a/{0} b/{1}";
    internal const string DiffNewFileMode = "new file mode 100644";
    internal const string DiffDeletedFileMode = "deleted file mode 100644";
    internal const string DiffDevNull = "/dev/null";
    internal const string DiffOldPathFormat = "--- a/{0}";
    internal const string DiffNewPathFormat = "+++ b/{0}";
    internal const string DiffOldDevNull = "--- /dev/null";
    internal const string DiffNewDevNull = "+++ /dev/null";
    internal const string DiffLineAddPrefix = "+";
    internal const string DiffLineDeletionPrefix = "-";
    internal const string DiffLineContextPrefix = " ";
    internal const string DiffLineFormat = "{0}{1}";
    internal const string HunkHeaderFormat = "@@ -{0},{1} +{2},{3} @@";

    internal const string ErrorCannotResolveRef = "Cannot resolve ref: {0}";
    internal const string ErrorNoHeadCommit = "No HEAD commit to branch from";
    internal const string ErrorBranchNotFound = "Branch not found: {0}";
    internal const string ErrorCannotDeleteCurrentBranch = "Cannot delete current branch: {0}";
    internal const string ErrorCannotResolveBranch = "Cannot resolve branch: {0}";
    internal const string ErrorCannotReadCommit = "Cannot read commit: {0}";
    internal const string ErrorNothingToCommit = "Nothing to commit \u2014 index is empty";
    internal const string ErrorNotAGitRepository = "Not a git repository: {0}";
    internal const string ErrorRemoteNotFound = "Remote not found: {0}";

    internal const string RemoteSectionPrefix = "[remote \"";
    internal const string RemoteSectionSuffix = "\"]";
    internal const string RemoteConfigSectionFormat = "[remote \"{0}\"]";
    internal const string RemoteConfigUrlFormat = "\turl = {0}";
    internal const string RemoteConfigFetchFormat = "\tfetch = +refs/heads/*:refs/remotes/{0}/*";
    internal const string ConfigKeyUrl = "url";
    internal const string ConfigKeyPushUrl = "pushurl";

    internal const string ContentTypeUploadPackAd = "application/x-git-upload-pack-advertisement";
    internal const string ContentTypeUploadPackRequest = "application/x-git-upload-pack-request";
    internal const string ContentTypeReceivePackRequest = "application/x-git-receive-pack-request";
    internal const string InfoRefsUrlFormat = "{0}/info/refs?service=git-upload-pack";
    internal const string UploadPackUrlFormat = "{0}/git-upload-pack";
    internal const string ReceivePackUrlFormat = "{0}/git-receive-pack";
    internal const string WantLineFormat = "want {0}\n";
    internal const string PktLineFormat = "{0:x4}{1}";
    internal const string PktLineCombineFormat = "{0}{1}";
    internal const string ReceivePackPktDataFormat = "{0} {1} {2}\0report-status";

    internal const string InitialHeadRef = "ref: refs/heads/main\n";
    internal const string InitialConfig = "[core]\n\trepositoryformatversion = 0\n\tfilemode = false\n\tbare = false\n";
    internal const string InitialDescription = "Unnamed repository\n";

    internal const string ModeRegularFile = "100644";
    internal const string ModeExecutableFile = "100755";
    internal const string ModeDirectory = "40000";
    internal const string ModeSymlink = "120000";
    internal const string ModeSubmodule = "160000";

    internal const int RegularFileMode = 0x81A4;
    internal const int ExecutableMask = 0x1FF;
    internal const int ExecutableBitMask = 0x49;

    internal const int Sha1ByteSize = 20;
    internal const int IndexHeaderSize = 12;
    internal const int IndexEntryFixedSize = 62;
    internal const int IndexEntryAlignment = 8;
    internal const int IndexVersion = 2;
    internal const int IndexNameLengthMask = 0xFFF;
    internal const int IndexStageBitShift = 12;
    internal const int IndexStageFieldMask = 3;
    internal const int ByteMask = 0xFF;
    internal const int BitShift24 = 24;
    internal const int BitShift16 = 16;
    internal const int BitShift8 = 8;
    internal const int Byte3Offset = 3;
    internal const int CtimeSecOffset = 0;
    internal const int CtimeNsecOffset = 4;
    internal const int MtimeSecOffset = 8;
    internal const int MtimeNsecOffset = 12;
    internal const int DevOffset = 16;
    internal const int InoOffset = 20;
    internal const int ModeOffset = 24;
    internal const int UidOffset = 28;
    internal const int GidOffset = 32;
    internal const int FileSizeOffset = 36;
    internal const int HashOffset = 40;
    internal const int FlagsOffset = 60;
    internal const int NameStartOffset = 62;

    internal const byte IndexSigD = (byte)'D';
    internal const byte IndexSigI = (byte)'I';
    internal const byte IndexSigR = (byte)'R';
    internal const byte IndexSigC = (byte)'C';

    internal const int PackObjectTypeCommit = 1;
    internal const int PackObjectTypeTree = 2;
    internal const int PackObjectTypeBlob = 3;
    internal const int PackObjectTypeTag = 4;
    internal const int PackObjectTypeOfsDelta = 6;
    internal const int PackObjectTypeRefDelta = 7;
    internal const int PackTypeBitShift = 4;
    internal const int PackTypeBitMask = 0x7;
    internal const int PackSizeLowMask = 0x0F;
    internal const int PackContinuationBit = 0x80;
    internal const int PackDataMask = 0x7F;
    internal const int PackInitialShift = 4;
    internal const int PackSubsequentShift = 7;
    internal const int PackHeaderSize = 12;
    internal const int DeltaPaddingEstimate = 16;

    internal const uint PackSignature = 0x5041434B;
    internal const int PackVersion = 2;
    internal const int IdxSignature = unchecked((int)0xFF744F63);
    internal const int IdxVersion = 2;
    internal const int FanoutSize = 256;
    internal const int FanoutEntrySize = 4;
    internal const int CrcEntrySize = 4;
    internal const int Offset32EntrySize = 4;
    internal const int Offset64EntrySize = 8;
    internal const uint PackOffset64Bit = 0x80000000;
    internal const uint PackOffset64Mask = 0x7FFFFFFF;

    internal const byte PackSigP = (byte)'P';
    internal const byte PackSigA = (byte)'A';
    internal const byte PackSigC = (byte)'C';
    internal const byte PackSigK = (byte)'K';

    internal const int PktLineMinLength = 44;
    internal const int PktLineHeaderSize = 4;
    internal const int HashHexLength = 40;
    internal const int MinTimezoneLength = 4;
    internal const int TimezoneHoursEnd = 2;

    internal const int LookaheadDistance = 5;
    internal const int DiffContextSize = 3;

    internal const string ZeroHash = "0000000000000000000000000000000000000000";

    internal const string IdxFilePattern = "*.idx";
    internal const string PackFileExtension = ".pack";

    internal const int NotFound = -1;
    internal const int NegativeSign = -1;
}
#pragma warning restore SA1600
