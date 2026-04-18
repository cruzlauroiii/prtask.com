namespace PrTask.Git.Generated;

internal static partial class Date
{
    internal static long TmToTimeT(nint Tm)
        => default;

    internal static long GmTimeT(TimestampT Time, int Tz)
        => default;

    internal static int LocalTimeTzoffset(long T, nint Tm)
        => default;

    internal static int LocalTzoffset(TimestampT Time)
        => default;

    internal static void GetTime(nint Now)
    {
    }

    internal static void ShowDateRelative(TimestampT Time, nint Timebuf)
    {
    }

    internal static DateMode DateModeFromType(DateModeType Type)
        => default;

    internal static void ShowDateNormal(nint Buf, TimestampT Time, nint Tm, int Tz, nint HumanTm, int HumanTz, int Local)
    {
    }

    internal static int MatchString(string Date, string Str)
        => default;

    internal static int SkipAlpha(string Date)
        => default;

    internal static int MatchAlpha(string Date, nint Tm, nint Offset)
        => default;

    internal static int SetDate(int Year, int Month, int Day, nint NowTm, long Now, nint Tm)
        => default;

    internal static int SetTime(long Hour, long Minute, long Second, nint Tm)
        => default;

    internal static int IsDateKnown(nint Tm)
        => default;

    internal static int Nodate(nint Tm)
        => default;

    internal static int Maybeiso8601(nint Tm)
        => default;

    internal static int MatchDigit(string Date, nint Tm, nint Offset, nint TmGmt)
        => default;

    internal static int MatchTz(string Date, nint Offp)
        => default;

    internal static void DateString(TimestampT Date, int Offset, nint Buf)
    {
    }

    internal static int MatchObjectHeaderDate(string Date, nint Timestamp, nint Offset)
        => default;

    internal static int ParseDateBasic(string Date, nint Timestamp, nint Offset)
        => default;

    internal static int ParseExpiryDate(string Date, nint Timestamp)
        => default;

    internal static int ParseDate(string Date, nint Result)
        => default;

    internal static DateModeType ParseDateType(string Format, string End)
        => default;

    internal static void ParseDateFormat(string Format, nint Mode)
    {
    }

    internal static void DateModeRelease(nint Mode)
    {
    }

    internal static void Datestamp(nint Out)
    {
    }

    internal static long UpdateTm(nint Tm, nint Now, long Sec)
        => default;

    internal static void PendingNumber(nint Tm, nint Num)
    {
    }

    internal static void DateNow(nint Tm, nint Now, nint Num)
    {
    }

    internal static void DateYesterday(nint Tm, nint Now, nint Num)
    {
    }

    internal static void DateTime(nint Tm, nint Now, int Hour)
    {
    }

    internal static void DateMidnight(nint Tm, nint Now, nint Num)
    {
    }

    internal static void DateNoon(nint Tm, nint Now, nint Num)
    {
    }

    internal static void DateTea(nint Tm, nint Now, nint Num)
    {
    }

    internal static void DatePm(nint Tm, nint UNUSED, nint Num)
    {
    }

    internal static void DateAm(nint Tm, nint UNUSED, nint Num)
    {
    }

    internal static void DateNever(nint Tm, nint UNUSED, nint Num)
    {
    }

    internal static TimestampT ApproxidateCareful(string Date, nint ErrorRet)
        => default;

    internal static int DateOverflows(TimestampT T)
        => default;

}
