namespace PrTask.Git.Generated;

internal static partial class Ident
{
    internal const int IDENT_NAME_GIVEN = 01;
    internal const int IDENT_MAIL_GIVEN = 02;
    internal static void CopyGecos(nint W, nint Name)
    {
    }

    internal static int AddMailnameHost(nint Buf)
        => default;

    internal static int CanonicalName(string Host, nint Out)
        => default;

    internal static void AddDomainname(nint Out, nint IsBogus)
    {
    }

    internal static void ResetIdentDate()
    {
    }

    internal static int Crud(Unchar C)
        => default;

    internal static int HasNonCrud(string Str)
        => default;

    internal static void StrbufAddstrWithoutCrud(nint Sb, string Src)
    {
    }

    internal static int SplitIdentLine(nint Split, string Line, nuint Len)
        => default;

    internal static void IdentEnvHint(WantIdent WhoseIdent)
    {
    }

    internal static int IdentIsSufficient(int UserIdentExplicitlyGiven)
        => default;

    internal static int CommitterIdentSufficientlyGiven()
        => default;

    internal static int AuthorIdentSufficientlyGiven()
        => default;

    internal static int SetIdent(string Var, string Value)
        => default;

    internal static void SetEnvIf(string Key, string Value, nint Given, int Bit)
    {
    }

    internal static void PrepareFallbackIdent(string Name, string Email)
    {
    }

}
