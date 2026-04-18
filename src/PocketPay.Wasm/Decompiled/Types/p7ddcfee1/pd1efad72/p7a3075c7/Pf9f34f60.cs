namespace WillowMaze.Wasm.Decompiled;

public class Pf9f34f60
{
    public static pf9f34f60$p910eef8c F3d273d2b;
    private static Logger F3fb642e7;
    private static Logger F4efadc03;
    private static Logger F4fe4d418;
    private static Logger F6db435f3;
    public static pf9f34f60 F71492d19;
    public static pf9f34f60 F76425f17;
    public static pf9f34f60$p910eef8c F910eef8c;
    public static pf9f34f60 Fb1e2c3f7;
    private static Logger Fd70cf542;
    public static pf9f34f60$p910eef8c Fe76553d7;
    public static pf9f34f60$p910eef8c Fec28a38c;
    public static pf9f34f60$p910eef8c Ffafdf621;
    private long F07514cf1;
    private bool F075abfd0;
    private int F0b4c89f6;
    private readonly Action F23568c91;
    private readonly pf9f34f60$p2e427c26 F250a6265;
    private bool F25654413;
    private int F2cff3f68;
    private bool F33bd3a01;
    private bool F34cd0899;
    private int F4ec8d05f;
    private readonly List<object> F65795c98;
    private bool F674cd4d7;
    private readonly List<object> F78180310;
    private readonly Action F8ba984ed;
    private readonly List<object> F8e721db2;
    private long F9605caba;
    private readonly List<object> F9b2fb45e;
    private long F9cb89243;
    private readonly Action Fb01a1afa;
    private readonly pf9f34f60$p2e427c26 Fb43fdd98;
    private int Fb7c3b023;
    private int Fb9b8c123;
    private readonly List<object> Fbcb3cde2;
    private readonly pf9f34f60$p2e427c26 Fc1eec6fd;
    private readonly pf9f34f60$p2e427c26 Fc1fe7a2c;
    private readonly Action Fc70d2661;
    private readonly Action Fde335192;
    private long Fe3e636d5;
    private long Ff733e7f3;
    private readonly List<object> Ffef1149c;

    public static Logger Access$getLogger$cp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f6db435f3
        return default!;
    }

    public static void Access$runTask(pf9f34f60 P0, peaeb30f9 P1)
    {
        // call: pf9f34f60.runTask
    }

    private void AfterRun(peaeb30f9 P0, long P1)
    {
        // str: "Thread "
        // str: " MUST hold lock on "
        // str: "Check failed."
        // call: p6d96efb7.getShutdown$okhttp
        // call: StringBuilder.<init>
        // call: AssertionError.<init>
        // call: p6d96efb7.setActiveTask$okhttp
        // call: Intrinsics.checkNotNull
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: object.toString
        // call: Thread.holdsLock
        // call: List<object>.remove
        // call: p6d96efb7.getActiveTask$okhttp
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p6d96efb7.getCancelActiveTask$okhttp
        // call: p6d96efb7.scheduleAndDecide$okhttp
        // call: IllegalStateException.<init>
        // call: List<object>.add
        // call: peaeb30f9.getQueue$okhttp
        // call: p6d96efb7.setCancelActiveTask$okhttp
        // call: Thread.getName
        // call: Thread.currentThread
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f9b2fb45e
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: IllegalStateException
        // type: AssertionError
    }

    private void BeforeRun(peaeb30f9 P0)
    {
        // str: "Thread "
        // str: " MUST hold lock on "
        // call: Thread.currentThread
        // call: p6d96efb7.setActiveTask$okhttp
        // call: peaeb30f9.setNextExecuteNanoTime$okhttp
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNull
        // call: List<object>.remove
        // call: Thread.holdsLock
        // call: AssertionError.<init>
        // call: peaeb30f9.getQueue$okhttp
        // call: StringBuilder.append
        // call: List<object>.add
        // call: StringBuilder.<init>
        // call: Thread.getName
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f9b2fb45e
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        // type: AssertionError
        // type: StringBuilder
    }

    private void RunTask(peaeb30f9 P0)
    {
        // str: "Thread "
        // str: " MUST NOT hold lock on "
        // call: Thread.getName
        // call: Thread.setName
        // call: Thread.currentThread
        // call: AssertionError.<init>
        // call: pf9f34f60.afterRun
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: peaeb30f9.getName
        // call: StringBuilder.<init>
        // call: peaeb30f9.runOnce
        // call: Thread.holdsLock
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: AssertionError
    }

    public List<object> ActiveQueues()
    {
        // call: CollectionsKt.plus
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f9b2fb45e
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        return default!;
    }

    public peaeb30f9 AwaitTaskToRun()
    {
        // str: " MUST hold lock on "
        // str: "Thread "
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: ICollection<object>.isEmpty
        // call: StringBuilder.append
        // call: AssertionError.<init>
        // call: Thread.getName
        // call: List<object>.get
        // call: IEnumerator<object>.next
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: pf9f34f60$p2e427c26.execute
        // call: pf9f34f60$p2e427c26.coordinatorWait
        // call: pf9f34f60$p2e427c26.coordinatorNotify
        // call: pf9f34f60.beforeRun
        // call: List<object>.isEmpty
        // call: Thread.currentThread
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pf9f34f60$p2e427c26.nanoTime
        // call: pf9f34f60.cancelAll
        // call: Math.min
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fb43fdd98
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fe3e636d5
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fde335192
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f33bd3a01
        // type: StringBuilder
        // type: AssertionError
        return default!;
    }

    public void CancelAll()
    {
        // call: List<object>.get
        // call: List<object>.size
        // call: List<object>.isEmpty
        // call: p6d96efb7.cancelAllAndDecide$okhttp
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: List<object>.remove
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f9b2fb45e
    }

    public pf9f34f60$p2e427c26 GetBackend()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fb43fdd98
        return default!;
    }

    public void KickCoordinator$okhttp(p6d96efb7 P0)
    {
        // str: "Thread "
        // str: "taskQueue"
        // str: " MUST hold lock on "
        // call: pf9f34f60$p2e427c26.execute
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Thread.getName
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4.addIfAbsent
        // call: pf9f34f60$p2e427c26.coordinatorNotify
        // call: List<object>.remove
        // call: ICollection<object>.isEmpty
        // call: StringBuilder.toString
        // call: AssertionError.<init>
        // call: p6d96efb7.getActiveTask$okhttp
        // call: Thread.holdsLock
        // call: p6d96efb7.getFutureTasks$okhttp
        // call: Thread.currentThread
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fb43fdd98
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fde335192
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f33bd3a01
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f78180310
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: AssertionError
        // type: StringBuilder
    }

    public p6d96efb7 NewQueue()
    {
        // str: "Q"
        // call: Intrinsics.stringPlus
        // call: p6d96efb7.<init>
        // call: int.valueOf
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.fb7c3b023
        // type: p6d96efb7
        return default!;
    }

}
