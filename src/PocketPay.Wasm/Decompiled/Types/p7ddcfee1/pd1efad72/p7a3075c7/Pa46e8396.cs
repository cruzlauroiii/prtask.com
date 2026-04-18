namespace WillowMaze.Wasm.Decompiled;

public class Pa46e8396
{
    public static void Access$log(peaeb30f9 P0, p6d96efb7 P1, string P2)
    {
        // call: pa46e8396.log
    }

    public static string FormatDuration(long P0)
    {
        // str: " ms"
        // str: "format(format, *args)"
        // str: "%6s"
        // str: " s "
        // str: " µs"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: string.format
        // call: Arrays.copyOf
        // call: Intrinsics.checkNotNullExpressionValue
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // type: StringBuilder
        return string.Empty;
    }

    private static void Log(peaeb30f9 P0, p6d96efb7 P1, string P2)
    {
        // str: "%-22s"
        // str: "format(format, *args)"
        // str: ": "
        // call: p6d96efb7.getName$okhttp
        // call: peaeb30f9.getName
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Arrays.copyOf
        // call: StringBuilder.<init>
        // call: string.format
        // call: StringBuilder.append
        // call: Logger.fine
        // call: pf9f34f60$p910eef8c.getLogger
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // type: StringBuilder
    }

    public static object LogElapsed(peaeb30f9 P0, p6d96efb7 P1, Func<object> P2)
    {
        // str: "block"
        // str: "starting"
        // str: "task"
        // str: "finished run in "
        // str: "queue"
        // str: "failed a run in "
        // call: pf9f34f60$p2e427c26.nanoTime
        // call: pf9f34f60.getBackend
        // call: pa46e8396.formatDuration
        // call: pa46e8396.access$log
        // call: Intrinsics.checkNotNullParameter
        // call: Logger.isLoggable
        // call: Intrinsics.stringPlus
        // call: Func<object>.invoke
        // call: p6d96efb7.getTaskRunner$okhttp
        // call: pf9f34f60$p910eef8c.getLogger
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
        return default!;
    }

    public static void TaskLog(peaeb30f9 P0, p6d96efb7 P1, Func<object> P2)
    {
        // str: "task"
        // str: "messageBlock"
        // str: "queue"
        // call: pf9f34f60$p910eef8c.getLogger
        // call: Logger.isLoggable
        // call: Func<object>.invoke
        // call: Intrinsics.checkNotNullParameter
        // call: pa46e8396.access$log
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
    }

}
