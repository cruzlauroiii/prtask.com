namespace PrTask.Git.Generated;

internal static partial class RefFilter
{
    internal static void SetupRefFilterPorcelainMsg()
    {
    }

    internal enum AtomType
    {
        ATOM_REFNAME,
        ATOM_OBJECTTYPE,
        ATOM_OBJECTSIZE,
        ATOM_OBJECTNAME,
        ATOM_DELTABASE,
        ATOM_TREE,
        ATOM_PARENT,
        ATOM_NUMPARENT,
        ATOM_OBJECT,
        ATOM_TYPE,
        ATOM_TAG,
        ATOM_AUTHOR,
        ATOM_AUTHORNAME,
        ATOM_AUTHOREMAIL,
        ATOM_AUTHORDATE,
        ATOM_COMMITTER,
        ATOM_COMMITTERNAME,
        ATOM_COMMITTEREMAIL,
        ATOM_COMMITTERDATE,
        ATOM_TAGGER,
        ATOM_TAGGERNAME,
        ATOM_TAGGEREMAIL,
        ATOM_TAGGERDATE,
        ATOM_CREATOR,
        ATOM_CREATORDATE,
        ATOM_DESCRIBE,
        ATOM_SUBJECT,
        ATOM_BODY,
        ATOM_TRAILERS,
        ATOM_CONTENTS,
        ATOM_SIGNATURE,
        ATOM_RAW,
        ATOM_UPSTREAM,
        ATOM_PUSH,
        ATOM_SYMREF,
        ATOM_FLAG,
        ATOM_HEAD,
        ATOM_COLOR,
        ATOM_WORKTREEPATH,
        ATOM_ALIGN,
        ATOM_END,
        ATOM_IF,
        ATOM_THEN,
        ATOM_ELSE,
        ATOM_REST,
        ATOM_AHEADBEHIND,
        ATOM_ISBASE,
    }
    internal static int StrbufAddfRet(nint Sb, int Ret, string Fmt, params object[] VarArgs)
        => default;

    internal static int ErrNoArg(nint Sb, string Name)
        => default;

    internal static int ErrBadArg(nint Sb, string Name, string Arg)
        => default;

    internal static int ParseSignatureOption(string Arg)
        => default;

    internal static int EmailAtomOptionParser(string Arg)
        => default;

    internal static AlignType ParseAlignPosition(string S)
        => default;

    internal static void QuoteFormatting(nint S, string Str, nint Len, int QuoteStyle)
    {
    }

    internal static void PushStackElement(nint Stack)
    {
    }

    internal static void PopStackElement(nint Stack)
    {
    }

    internal static void EndAlignHandler(nint Stack)
    {
    }

    internal static void IfThenElseHandler(nint Stack)
    {
    }

    internal static int IsEmpty(nint Buf)
        => default;

    internal static int RejectAtom(AtomType AtomType)
        => default;

    internal static int VerifyRefFormat(nint Format)
        => default;

    internal static void GrabCommonValues(nint Val, int Deref, nint Oi)
    {
    }

    internal static void GrabDate(string Buf, nint V, string Atomname)
    {
    }

    internal static void GrabPerson(string Who, nint Val, int Deref, nint Buf)
    {
    }

    internal static void AppendLines(nint Out, string Buf, Unlong Size, int Lines)
    {
    }

    internal static void GrabSubBodyContents(nint Val, int Deref, nint Data)
    {
    }

    internal static void FillMissingValues(nint Val)
    {
    }

    internal static int NormalizeComponentCount(string Refname, int Len)
        => default;

    internal static void PopulateWorktreeMap(nint Map, nint Worktrees)
    {
    }

    internal static void LazyInitWorktreeMap()
    {
    }

    internal static int PopulateValue(nint Ref, nint Err)
        => default;

    internal static int FilterPatternMatch(nint Filter, string Refname)
        => default;

    internal static int FilterExcludeMatch(nint Filter, string Refname)
        => default;

    internal static int StartRefIteratorAfter(nint Iter, string Marker)
        => default;

    internal static void RefArrayAppend(nint Array, nint Ref)
    {
    }

    internal static int RefKindFromRefname(string Refname)
        => default;

    internal static int FilterRefKind(nint Filter, string Refname)
        => default;

    internal static int FilterOne(nint Ref, nint CbData)
        => default;

    internal static void FreeArrayItem(nint Item)
    {
    }

    internal static int FilterAndFormatOne(nint Ref, nint CbData)
        => default;

    internal static void RefArrayClear(nint Array)
    {
    }

    internal const int EXCLUDE_REACHED = 0;
    internal const int INCLUDE_REACHED = 1;
    internal static int DoFilterRefs(nint Filter, Unint Type, RefsForEachCb Fn, nint CbData)
        => default;

    internal static int FilterRefs(nint Array, nint Filter, Unint Type)
        => default;

    internal static int CompareDetachedHead(nint A, nint B)
        => default;

    internal static int Memcasecmp(nint Vs1, nint Vs2, nuint N)
        => default;

    internal static int CmpRefSorting(nint S, nint A, nint B)
        => default;

    internal static int CompareRefs(nint A, nint B, nint RefSorting)
        => default;

    internal static void RefArraySort(nint Sorting, nint Array)
    {
    }

    internal static void AppendLiteral(string Cp, string Ep, nint State)
    {
    }

    internal static void PrintFormattedRefArray(nint Array, nint Format)
    {
    }

    internal static int ParseSortingAtom(string Atom)
        => default;

    internal static void ParseRefSorting(nint SortingTail, string Arg)
    {
    }

    internal static void RefSortingRelease(nint Sorting)
    {
    }

    internal static int ParseOptMergeFilter(nint Opt, string Arg, int Unset)
        => default;

    internal static void RefFilterInit(nint Filter)
    {
    }

    internal static void RefFilterClear(nint Filter)
    {
    }

}
