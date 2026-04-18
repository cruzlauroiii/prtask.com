namespace PrTask.Git.Generated;

internal static partial class Help
{
    internal static void ExtractCmds(nint PCmds, uint Mask)
    {
    }

    internal static int CmdNameCmp(nint Elem1, nint Elem2)
        => default;

    internal static void AddCmdname(nint Cmds, string Name, int Len)
    {
    }

    internal static void CmdnamesRelease(nint Cmds)
    {
    }

    internal static int CmdnameCompare(nint A, nint B)
        => default;

    internal static void Uniq(nint Cmds)
    {
    }

    internal static void ExcludeCmds(nint Cmds, nint Excludes)
    {
    }

    internal static void PrettyPrintCmdnames(nint Cmds, Unint Colopts)
    {
    }

    internal static void ListCommands(nint MainCmds, nint OtherCmds)
    {
    }

    internal static void ListCommonCmdsHelp()
    {
    }

    internal static void ListAllMainCmds(nint List)
    {
    }

    internal static void ListAllOtherCmds(nint List)
    {
    }

    internal static void ListCmdsByConfig(nint List)
    {
    }

    internal static void ListGuidesHelp()
    {
    }

    internal static void ListUserInterfacesHelp()
    {
    }

    internal static void ListDeveloperInterfacesHelp()
    {
    }

    internal static void ListAllCmdsHelpExternalCommands()
    {
    }

    internal static void ListAllCmdsHelpAliases(int Longest)
    {
    }

    internal static void ListAllCmdsHelp(int ShowExternalCommands, int ShowAliases)
    {
    }

    internal static int IsInCmdlist(nint C, string S)
        => default;

    internal static int ParseAutocorrect(string Value)
        => default;

    internal static int LevenshteinCompare(nint P1, nint P2)
        => default;

    internal static void AddCmdList(nint Cmds, nint Old)
    {
    }

    internal const int SIMILARITY_FLOOR = 7;
    internal static void GetVersionInfo(nint Buf, int ShowBuildOptions)
    {
    }

    internal static int CmdVersion(int Argc, string Argv, string Prefix, nint UNUSED)
        => default;

    internal static int AppendSimilarRef(nint Ref, nint CbData)
        => default;

    internal static StringList GuessRefs(string Ref)
        => default;

}
