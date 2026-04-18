namespace WillowMaze.Wasm.Decompiled;

public class P592a534d
{
    public static p592a534d F0f38911d;
    private static CopyOnWriteArraySet F3a3bfd70;
    private static int F4723e7f7;
    public static p592a534d F55f7e1da;
    private static CopyOnWriteArraySet F5fe34891;
    private static int F672d9981;
    public static p592a534d F76425f17;
    private static int F77b86e9d;
    private static Dictionary<string, object> F85f5a3cc;
    private static int Fa74dae40;
    private static CopyOnWriteArraySet Fb151082b;
    private static int Fc776c129;
    private static CopyOnWriteArraySet Fd3a8884a;
    public static p592a534d Feecaa54d;
    private static Dictionary<string, object> Ffd72ef09;

    private void EnableLogging(string P0, string P1)
    {
        // call: Logger.addHandler
        // call: Logger.setUseParentHandlers
        // call: Logger.getLogger
        // call: Console.isLoggable
        // call: Logger.setLevel
        // call: CopyOnWriteArraySet.add
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.fb151082b
        // field: java.util.logging.Level.WARNING
        // field: java.util.logging.Level.INFO
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p5623e81d.f76425f17
        // field: java.util.logging.Level.FINE
    }

    private string LoggerTag(string P0)
    {
        // call: StringsKt.take
        // call: Dictionary<string, object>.get
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.ffd72ef09
        return string.Empty;
    }

    public void AndroidLog$okhttp(string P0, int P1, string P2, Exception P3)
    {
        // str: "message"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // str: "loggerName"
        // call: Console.getStackTraceString
        // call: string.substring
        // call: Console.isLoggable
        // call: Console.println
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: Math.min
        // call: p592a534d.loggerTag
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: string.length
        // call: StringsKt.indexOf$default
        // type: StringBuilder
    }

    public void Enable()
    {
        // call: HashSet<object>.iterator
        // call: p592a534d.enableLogging
        // call: Dictionary<string, object>.entrySet
        // call: Map$Entry.getKey
        // call: Map$Entry.getValue
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.ffd72ef09
    }

}
