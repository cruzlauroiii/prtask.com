namespace PrTask.Git.Generated;

internal static partial class Help
{
    internal const string DEFAULT_HELP_FORMAT = "man";
    internal enum HelpFormat
    {
        HELP_FORMAT_NONE,
        HELP_FORMAT_MAN,
        HELP_FORMAT_INFO,
        HELP_FORMAT_WEB,
    }
    internal enum ShowConfigType
    {
        SHOW_CONFIG_HUMAN,
        SHOW_CONFIG_VARS,
        SHOW_CONFIG_SECTIONS,
    }
    internal static void ListConfigHelp(ShowConfigType Type)
    {
    }

    internal static HelpFormat ParseHelpFormat(string Format)
        => default;

    internal static int CheckEmacsclientVersion()
        => default;

    internal static void ExecWomanEmacs(string Path, string Page)
    {
    }

    internal static void ExecManKonqueror(string Path, string Page)
    {
    }

    internal static void ExecManMan(string Path, string Page)
    {
    }

    internal static void ExecManCmd(string Cmd, string Page)
    {
    }

    internal static void AddManViewer(string Name)
    {
    }

    internal static int SupportedManViewer(string Name, nuint Len)
        => default;

    internal static int AddManViewerInfo(string Var, string Value)
        => default;

    internal static int IsGitCommand(string S)
        => default;

    internal static void SetupManPath()
    {
    }

    internal static void ExecViewer(string Name, string Page)
    {
    }

    internal static void ShowManPage(string Page)
    {
    }

    internal static void ShowInfoPage(string Page)
    {
    }

    internal static void GetHtmlPagePath(nint PagePath, string Page)
    {
    }

    internal static void OpenHtml(string Path)
    {
    }

    internal static void ShowHtmlPage(string Page)
    {
    }

    internal static void NoHelpFormat(string OptMode, HelpFormat Fmt)
    {
    }

}
