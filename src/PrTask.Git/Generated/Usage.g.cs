namespace PrTask.Git.Generated;

internal static partial class Usage
{
    internal static void Vfreportf(nint F, string Prefix, string Err, VaList Params)
    {
    }

    internal static void Vreportf(string Prefix, string Err, VaList Params)
    {
    }

    internal static NORETURN void UsageBuiltin(string Err, VaList Params)
        => default;

    internal static void DieMessageBuiltin(string Err, VaList Params)
    {
    }

    internal static NORETURN void DieBuiltin(string Err, VaList Params)
        => default;

    internal static void ErrorBuiltin(string Err, VaList Params)
    {
    }

    internal static void WarnBuiltin(string Warn, VaList Params)
    {
    }

    internal static int DieIsRecursingBuiltin()
        => default;

    internal static void SetDieRoutine(NORETURNPTR reportFn Routine)
    {
    }

    internal static ReportFn GetDieMessageRoutine()
        => default;

    internal static void SetErrorRoutine(ReportFn Routine)
    {
    }

    internal static ReportFn GetErrorRoutine()
        => default;

    internal static void SetWarnRoutine(ReportFn Routine)
    {
    }

    internal static ReportFn GetWarnRoutine()
        => default;

    internal static Void NORETURN Usagef(string Err, params object[] VarArgs)
        => default;

    internal static Void NORETURN Usage(string Err)
        => default;

    internal static void ShowUsageIfAskedHelper(string Err, params object[] VarArgs)
    {
    }

    internal static void ShowUsageIfAsked(int Ac, string Av, string Err)
    {
    }

    internal static Void NORETURN Die(string Err, params object[] VarArgs)
        => default;

    internal static Void NORETURN DieErrno(string Fmt, params object[] VarArgs)
        => default;

    internal static int DieMessage(string Err, params object[] VarArgs)
        => default;

    internal static int DieMessageErrno(string Fmt, params object[] VarArgs)
        => default;

    internal static int ErrorErrno(string Fmt, params object[] VarArgs)
        => default;

    internal static int Error(string Err, params object[] VarArgs)
        => default;

    internal static void WarningErrno(string Warn, params object[] VarArgs)
    {
    }

    internal static void Warning(string Warn, params object[] VarArgs)
    {
    }

    internal static NORETURN void BUGVfl(string File, int Line, string Fmt, VaList Params)
        => default;

    internal static NORETURN void BUGFl(string File, int Line, string Fmt, params object[] VarArgs)
        => default;

    internal static void BugFl(string File, int Line, string Fmt, params object[] VarArgs)
    {
    }

    internal static NORETURN void YouStillUseThat(string CommandName, string Hint)
        => default;

}
