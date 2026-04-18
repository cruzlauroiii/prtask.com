namespace WillowMaze.Wasm.Decompiled;

public class P6d96efb7
{
    private readonly string F0311b666;
    private bool F17e1704b;
    private readonly string F2a0155cc;
    private readonly pf9f34f60 F2c738810;
    private readonly List<object> F2ff19eb6;
    private bool F5305e537;
    private bool F5924f03a;
    private readonly pf9f34f60 F5c0e4218;
    private bool F73f98dbf;
    private peaeb30f9 F895bdba7;
    private readonly List<object> Faa3bba7b;
    private bool Fad990062;
    private readonly string Fb068931c;
    private peaeb30f9 Fb2984645;
    private readonly string Fc8e26cb4;
    private bool Fdafe8693;
    private readonly List<object> Fe30e8cdf;
    private bool Fe358cc52;
    private readonly List<object> Ff2183691;

    public static void Execute$default(p6d96efb7 P0, string P1, long P2, bool P3, Func<object> P4, int P5, object P6)
    {
        // str: "name"
        // str: "block"
        // call: Intrinsics.checkNotNullParameter
        // call: p6d96efb7$pec0cd3cb$1.<init>
        // call: p6d96efb7.schedule
        // type: p6d96efb7$pec0cd3cb$1
    }

    public static void Schedule$default(p6d96efb7 P0, string P1, long P2, Func<object> P3, int P4, object P5)
    {
        // str: "block"
        // str: "name"
        // call: p6d96efb7$p79985559$2.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p6d96efb7.schedule
        // type: p6d96efb7$p79985559$2
    }

    public static void Schedule$default(p6d96efb7 P0, peaeb30f9 P1, long P2, int P3, object P4)
    {
        // call: p6d96efb7.schedule
    }

    public void CancelAll()
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: p6d96efb7.cancelAllAndDecide$okhttp
        // call: p6d96efb7.getTaskRunner$okhttp
        // call: pf9f34f60.kickCoordinator$okhttp
        // call: AssertionError.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Thread.holdsLock
        // call: Thread.currentThread
        // call: Thread.getName
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        // type: AssertionError
        // type: StringBuilder
    }

    public bool CancelAllAndDecide$okhttp()
    {
        // str: "canceled"
        // call: Intrinsics.checkNotNull
        // call: List<object>.remove
        // call: List<object>.get
        // call: pf9f34f60$p910eef8c.getLogger
        // call: peaeb30f9.getCancelable
        // call: Logger.isLoggable
        // call: pa46e8396.access$log
        // call: List<object>.size
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.faa3bba7b
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fb2984645
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fdafe8693
        return false;
    }

    public void Execute(string P0, long P1, bool P2, Func<object> P3)
    {
        // str: "name"
        // str: "block"
        // call: p6d96efb7.schedule
        // call: Intrinsics.checkNotNullParameter
        // call: p6d96efb7$pec0cd3cb$1.<init>
        // type: p6d96efb7$pec0cd3cb$1
    }

    public peaeb30f9 GetActiveTask$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fb2984645
        return default!;
    }

    public bool GetCancelActiveTask$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fdafe8693
        return false;
    }

    public List<object> GetFutureTasks$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.faa3bba7b
        return default!;
    }

    public string GetName$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fb068931c
        return string.Empty;
    }

    public List<object> GetScheduledTasks()
    {
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: CollectionsKt.toList
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        return default!;
    }

    public bool GetShutdown$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5924f03a
        return false;
    }

    public pf9f34f60 GetTaskRunner$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        return default!;
    }

    public CountdownEvent IdleLatch()
    {
        // call: p6d96efb7.getActiveTask$okhttp
        // call: p6d96efb7$pd47987f3.getLatch
        // call: p6d96efb7$pd47987f3.<init>
        // call: p6d96efb7.scheduleAndDecide$okhttp
        // call: p6d96efb7.getTaskRunner$okhttp
        // call: pf9f34f60.kickCoordinator$okhttp
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.isEmpty
        // call: CountdownEvent.<init>
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        // type: p6d96efb7$pd47987f3
        // type: CountdownEvent
        return default!;
    }

    public void Schedule(string P0, long P1, Func<object> P2)
    {
        // str: "name"
        // str: "block"
        // call: Intrinsics.checkNotNullParameter
        // call: p6d96efb7$p79985559$2.<init>
        // call: p6d96efb7.schedule
        // type: p6d96efb7$p79985559$2
    }

    public void Schedule(peaeb30f9 P0, long P1)
    {
        // str: "schedule canceled (queue is shutdown)"
        // str: "task"
        // str: "schedule failed (queue is shutdown)"
        // call: p6d96efb7.getShutdown$okhttp
        // call: peaeb30f9.getCancelable
        // call: pf9f34f60$p910eef8c.getLogger
        // call: Logger.isLoggable
        // call: pa46e8396.access$log
        // call: Intrinsics.checkNotNullParameter
        // call: RejectedExecutionException.<init>
        // call: p6d96efb7.scheduleAndDecide$okhttp
        // call: p6d96efb7.getTaskRunner$okhttp
        // call: pf9f34f60.kickCoordinator$okhttp
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
        // field: java.util.logging.Level.FINE
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        // type: RejectedExecutionException
    }

    public bool ScheduleAndDecide$okhttp(peaeb30f9 P0, long P1, bool P2)
    {
        // str: "task"
        // str: "already scheduled"
        // str: "scheduled after "
        // str: "run again after "
        // call: peaeb30f9.getNextExecuteNanoTime$okhttp
        // call: Logger.isLoggable
        // call: List<object>.indexOf
        // call: IEnumerator<object>.next
        // call: pf9f34f60.getBackend
        // call: Intrinsics.checkNotNullParameter
        // call: pa46e8396.access$log
        // call: List<object>.size
        // call: pf9f34f60$p2e427c26.nanoTime
        // call: pf9f34f60$p910eef8c.getLogger
        // call: List<object>.iterator
        // call: List<object>.remove
        // call: Intrinsics.stringPlus
        // call: pa46e8396.formatDuration
        // call: IEnumerator<object>.hasNext
        // call: peaeb30f9.initQueue$okhttp
        // call: peaeb30f9.setNextExecuteNanoTime$okhttp
        // call: List<object>.add
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.faa3bba7b
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        // field: java.util.logging.Level.FINE
        return false;
    }

    public void SetActiveTask$okhttp(peaeb30f9 P0)
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fb2984645
    }

    public void SetCancelActiveTask$okhttp(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fdafe8693
    }

    public void SetShutdown$okhttp(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5924f03a
    }

    public void Shutdown()
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: AssertionError.<init>
        // call: StringBuilder.toString
        // call: Thread.getName
        // call: StringBuilder.append
        // call: Thread.currentThread
        // call: Thread.holdsLock
        // call: p6d96efb7.setShutdown$okhttp
        // call: p6d96efb7.cancelAllAndDecide$okhttp
        // call: p6d96efb7.getTaskRunner$okhttp
        // call: pf9f34f60.kickCoordinator$okhttp
        // call: StringBuilder.<init>
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.f5c0e4218
        // field: kotlin.Unit.INSTANCE
        // type: AssertionError
        // type: StringBuilder
    }

    public string ToString()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.fb068931c
        return string.Empty;
    }

}
