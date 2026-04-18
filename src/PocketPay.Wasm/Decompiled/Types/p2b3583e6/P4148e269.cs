namespace WillowMaze.Wasm.Decompiled;

public class P4148e269
{
    private static int F14fcc162;
    private static int F2b73000f;
    private static int F40d44548;
    private static int Fa15cdda1;
    private static int Fb7bcfe63;
    private static string Fba2b45bd;
    private static string Fc8a552b0;
    private static int Fd3328aee;
    private static string Fdef31e7c;

    private static string M088ee16c(pd7778d0c P0)
    {
        // str: "4990a2c51b787e1c715edfa4b9626fb8612c49ab396e2501003ac946d78911383d8807"
        // call: pd7778d0c.getDateStart
        // call: p4148e269.m535adb49
        // call: pd7778d0c.getDateEnd
        // call: Intrinsics.areEqual
        // call: DecryptString.decryptString
        // call: string.<init>
        // call: CultureInfo.getDefault
        // call: p4148e269.mde8ba61b
        // type: string
        return string.Empty;
    }

    private static CharSequence M14ed46fd(string P0)
    {
        // str: "it"
        // str: "getDefault(...)"
        // str: "toLowerCase(...)"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: CultureInfo.getDefault
        // call: string.toLowerCase
        // call: StringsKt.capitalize
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public static CharSequence M30fe91d6(string P0)
    {
        // call: p4148e269.m14ed46fd
        return default!;
    }

    public static string M4a2b4239(pd7778d0c P0)
    {
        // str: "1aa3d6cedf8a84e84f3efffad2baf11c0067c50f8d61149f032fc8287d304a174f13fb16b6ab"
        // str: "<this>"
        // call: CultureInfo.getDefault
        // call: DecryptString.decryptString
        // call: p4148e269.m684778fd
        // call: p4148e269.m088ee16c
        // call: string.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: string
        return string.Empty;
    }

    private static p8cf10d23 M535adb49(p8cf10d23 P0)
    {
        // call: p8cf10d23.plusDays
        // call: p8cf10d23.minusMinutes
        // call: p4148e269.mde8ba61b
        return default!;
    }

    private static string M684778fd(pd7778d0c P0, string P1, string P2)
    {
        // str: " - "
        // str: ", "
        // str: ""
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p8cf10d23.toDate
        // call: pd7778d0c.getDateStart
        // call: pd7778d0c.getDateEnd
        // call: string.format
        // call: pa859c1d6.ordinal
        // call: pd7778d0c.getType
        // call: Intrinsics.areEqual
        // call: StringBuilder.<init>
        // field: p2b3583e6.p4148e269$p12c674ac.$EnumSwitchMapping$0
        // type: StringBuilder
        return string.Empty;
    }

    private static string M843a7b4f(string P0)
    {
        // str: "58270614102c6a09d8142e2d4f19ee60c3512e98acf6775cf335c08f13"
        // str: "116a8b976cdfca383775a002ce073e989534df46370e24be5eccb6c9cc"
        // str: ""
        // call: StringsKt.replace$default
        // call: p4148e269$pd41d8cd9$p95263d50.<init>
        // call: CollectionsKt.joinToString$default
        // call: DecryptString.decryptString
        // call: StringsKt.split$default
        // type: p4148e269$pd41d8cd9$p95263d50
        return string.Empty;
    }

    public static string M9af25912(pd7778d0c P0)
    {
        // str: "<this>"
        // call: p4148e269.m843a7b4f
        // call: p4148e269.m088ee16c
        // call: Intrinsics.checkNotNullParameter
        // call: p4148e269.md557d9db
        // call: p4148e269.m684778fd
        return string.Empty;
    }

    private static string Md557d9db(pd7778d0c P0)
    {
        // str: "EE dd MMM yyyy"
        // str: "EE dd MMM"
        // call: p8cf10d23.getYear
        // call: p8cf10d23.m97bc592b
        // call: string.<init>
        // call: CultureInfo.getDefault
        // call: pd7778d0c.getDateStart
        // call: pd7778d0c.getDateEnd
        // type: string
        return string.Empty;
    }

    private static p8cf10d23 Mde8ba61b(p8cf10d23 P0)
    {
        // call: p8cf10d23.withTimeAtStartOfDay
        return default!;
    }

}
