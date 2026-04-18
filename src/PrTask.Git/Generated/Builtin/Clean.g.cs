namespace PrTask.Git.Generated;

internal static partial class Clean
{
    internal enum ColorClean
    {
        CLEAN_COLOR_RESET = 0,
        CLEAN_COLOR_PLAIN = 1,
        CLEAN_COLOR_PROMPT = 2,
        CLEAN_COLOR_HEADER = 3,
        CLEAN_COLOR_HELP = 4,
        CLEAN_COLOR_ERROR = 5,
    }
    internal const int MENU_OPTS_SINGLETON = 01;
    internal const int MENU_OPTS_IMMEDIATE = 02;
    internal const int MENU_OPTS_LIST_ONLY = 04;
    internal const int MENU_RETURN_NO_LOOP = 10;
    internal enum MenuStuffType
    {
        MENU_STUFF_TYPE_STRING_LIST = 1,
        MENU_STUFF_TYPE_MENU_ITEM,
    }
    internal static void CleanPrintColor(ColorClean Ix)
    {
    }

    internal static int ExcludeCb(nint Opt, string Arg, int Unset)
        => default;

    internal static void PrettyPrintDels()
    {
    }

    internal static void PrettyPrintMenus(nint MenuList)
    {
    }

    internal static void PromptHelpCmd(int Singleton)
    {
    }

    internal static void PrintHighlightMenuStuff(nint Stuff, nint Chosen)
    {
    }

    internal static int FindUnique(string Choice, nint MenuStuff)
        => default;

    internal static int CleanCmd()
        => default;

    internal static int FilterByPatternsCmd()
        => default;

    internal static int SelectByNumbersCmd()
        => default;

    internal static int AskEachCmd()
        => default;

    internal static int QuitCmd()
        => default;

    internal static int HelpCmd()
        => default;

    internal static void InteractiveMainLoop()
    {
    }

    internal static void CorrectUntrackedEntries(nint Dir)
    {
    }

}
