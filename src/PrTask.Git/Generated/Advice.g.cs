namespace PrTask.Git.Generated;

internal static partial class Advice
{
    internal enum ColorAdvice
    {
        ADVICE_COLOR_RESET = 0,
        ADVICE_COLOR_HINT = 1,
    }
    internal static int ParseAdviseColorSlot(string Slot)
        => default;

    internal enum AdviceLevel
    {
        ADVICE_LEVEL_NONE = 0,
        ADVICE_LEVEL_DISABLED,
        ADVICE_LEVEL_ENABLED,
    }
    internal static void Advise(string Advice, params object[] VarArgs)
    {
    }

    internal static int AdviceEnabled(AdviceType Type)
        => default;

    internal static void AdviseIfEnabled(AdviceType Type, string Advice, params object[] VarArgs)
    {
    }

    internal static int GitDefaultAdviceConfig(string Var, string Value)
        => default;

    internal static void ListConfigAdvices(nint List, string Prefix)
    {
    }

    internal static int ErrorResolveConflict(string Me)
        => default;

    internal static Void NORETURN DieResolveConflict(string Me)
        => default;

    internal static Void NORETURN DieConcludeMerge()
        => default;

    internal static Void NORETURN DieFfImpossible()
        => default;

    internal static void AdviseOnUpdatingSparsePaths(nint PathspecList)
    {
    }

    internal static void DetachAdvice(string NewName)
    {
    }

    internal static void AdviseOnMovingDirtyPath(nint PathspecList)
    {
    }

}
