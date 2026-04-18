namespace PrTask.Git.Generated;

internal static partial class Log
{
    internal const int MAIL_DEFAULT_WRAP = 72;
    internal const int COVER_FROM_AUTO_MAX_SUBJECT_LEN = 100;
    internal const int FORMAT_PATCH_NAME_MAX_DEFAULT = 64;
    internal static int SessionIsInteractive()
        => default;

    internal static int AutoDecorationStyle()
        => default;

    internal static int ParseDecorationStyle(string Value)
        => default;

    internal static void LogConfigInit(nint Cfg)
    {
    }

    internal static void LogConfigRelease(nint Cfg)
    {
    }

    internal static int LogLineRangeCallback(nint Option, string Arg, int Unset)
        => default;

    internal static void SetDefaultDecorationFilter(nint DecorationFilter)
    {
    }

    internal static int CmdLogWalkNoFree(nint Rev)
        => default;

    internal static int CmdLogWalk(nint Rev)
        => default;

    internal static void ShowTagger(string Buf, nint Rev)
    {
    }

    internal static int ShowBlobObject(nint Oid, nint Rev, string ObjName)
        => default;

    internal static int ShowTagObject(nint Oid, nint Rev)
        => default;

    internal static void ShowSetupRevisionsTweak(nint Rev)
    {
    }

    internal static void LogSetupRevisionsTweak(nint Rev)
    {
    }

    internal enum CoverSetting
    {
        COVER_UNSET,
        COVER_OFF,
        COVER_ON,
        COVER_AUTO,
    }
    internal enum ThreadLevel
    {
        THREAD_UNSET,
        THREAD_SHALLOW,
        THREAD_DEEP,
    }
    internal enum CoverFromDescription
    {
        COVER_FROM_NONE,
        COVER_FROM_MESSAGE,
        COVER_FROM_SUBJECT,
        COVER_FROM_AUTO,
    }
    internal enum AutoBaseSetting
    {
        AUTO_BASE_NEVER,
        AUTO_BASE_ALWAYS,
        AUTO_BASE_WHEN_ABLE,
    }
    internal static void FormatConfigInit(nint Cfg)
    {
    }

    internal static void FormatConfigRelease(nint Cfg)
    {
    }

    internal static CoverFromDescription ParseCoverFromDescription(string Arg)
        => default;

    internal static void AddHeader(nint Cfg, string Value)
    {
    }

    internal static void GetPatchIds(nint Rev, nint Ids)
    {
    }

    internal static void GenMessageId(nint Info, string Base)
    {
    }

    internal static void PrintSignature(string Signature, nint File)
    {
    }

    internal static void ReadDescFile(nint Buf, string DescFile)
    {
    }

    internal static int GetNotesRefs(nint Item, nint Arg)
        => default;

    internal static void GetNotesArgs(nint Arg, nint Rev)
    {
    }

    internal static int KeepCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static int ThreadCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static int AttachCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static int InlineCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static int FromCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static int BaseCallback(nint Opt, string Arg, int Unset)
        => default;

    internal static void PrintBases(nint Bases, nint File)
    {
    }

    internal static int AddPendingCommit(string Arg, nint Revs, int Flags)
        => default;

}
