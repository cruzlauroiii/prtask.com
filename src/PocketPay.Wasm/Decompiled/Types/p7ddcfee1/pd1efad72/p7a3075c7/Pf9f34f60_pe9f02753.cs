namespace WillowMaze.Wasm.Decompiled;

public class Pf9f34f60_pe9f02753 : Pf9f34f60$p2e427c26
{
    private readonly ThreadPoolExecutor F1a50554f;
    private readonly ThreadPoolExecutor F22e374b5;
    private readonly ThreadPoolExecutor F497e212b;
    private readonly ThreadPoolExecutor F91d66d1d;
    private readonly ThreadPoolExecutor Fb1925939;

    public void BeforeTask(pf9f34f60 P0)
    {
        // str: "taskRunner"
        // call: Intrinsics.checkNotNullParameter
    }

    public void CoordinatorNotify(pf9f34f60 P0)
    {
        // str: "taskRunner"
        // call: object.notify
        // call: Intrinsics.checkNotNullParameter
    }

    public void CoordinatorWait(pf9f34f60 P0, long P1)
    {
        // str: "taskRunner"
        // call: object.wait
        // call: Intrinsics.checkNotNullParameter
    }

    public void Execute(Action P0)
    {
        // str: "runnable"
        // call: ThreadPoolExecutor.execute
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60$pe9f02753.fb1925939
    }

    public long NanoTime()
    {
        // call: System.nanoTime
        return 0;
    }

    public void Shutdown()
    {
        // call: ThreadPoolExecutor.shutdown
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60$pe9f02753.fb1925939
    }

}
