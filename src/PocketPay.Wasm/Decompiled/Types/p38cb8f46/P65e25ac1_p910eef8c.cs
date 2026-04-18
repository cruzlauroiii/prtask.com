namespace WillowMaze.Wasm.Decompiled;

public class P65e25ac1_p910eef8c
{
    public static bool M146cac6c(p65e25ac1$p910eef8c P0, p65e25ac1 P1)
    {
        // call: p65e25ac1$p910eef8c.m26bc341f
        return false;
    }

    public static void M20ac200f(p65e25ac1$p910eef8c P0, p65e25ac1 P1, long P2, bool P3)
    {
        // call: p65e25ac1$p910eef8c.ma216380d
    }

    private bool M26bc341f(p65e25ac1 P0)
    {
        // call: Lock.unlock
        // call: p65e25ac1.m5118124e
        // call: p65e25ac1$p910eef8c.getLock
        // call: p65e25ac1.m0945c617
        // call: p65e25ac1.mb46e0a02
        // call: p65e25ac1.m6a275a6f
        // call: Lock.lock
        // call: p65e25ac1.m726c53bc
        // field: p38cb8f46.p65e25ac1.f910eef8c
        return false;
    }

    private void Ma216380d(p65e25ac1 P0, long P1, bool P2)
    {
        // str: "Unbalanced enter/exit"
        // call: AssertionError.<init>
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Lock.unlock
        // call: Lock.lock
        // call: p65e25ac1.m726c53bc
        // call: p65e25ac1.m0945c617
        // call: p65e25ac1.mb46e0a02
        // call: p65e25ac1.<init>
        // call: p65e25ac1.mdfb0d185
        // call: p65e25ac1$p55eb0f30.<init>
        // call: p65e25ac1$p55eb0f30.start
        // call: System.nanoTime
        // call: p65e25ac1.deadlineNanoTime
        // call: Math.min
        // call: p65e25ac1.m3ef75f6c
        // call: p65e25ac1.mcb23885c
        // call: Intrinsics.checkNotNull
        // call: p65e25ac1.m5118124e
        // call: p65e25ac1.m6a275a6f
        // field: p38cb8f46.p65e25ac1.f910eef8c
        // field: kotlin.Unit.INSTANCE
        // type: AssertionError
        // type: IllegalStateException
        // type: p65e25ac1
        // type: p65e25ac1$p55eb0f30
    }

    public p65e25ac1 AwaitTimeout$okio()
    {
        // call: p65e25ac1.mcb23885c
        // call: p65e25ac1.m5118124e
        // call: p65e25ac1$p910eef8c.getCondition
        // call: System.nanoTime
        // call: p65e25ac1.mb46e0a02
        // call: p65e25ac1.m6a275a6f
        // call: p65e25ac1.m35edcdfa
        // call: Intrinsics.checkNotNull
        // call: Condition.await
        // call: p65e25ac1.m048f335d
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
        return default!;
    }

    public Condition GetCondition()
    {
        // call: p65e25ac1.mbad45449
        return default!;
    }

    public Lock GetLock()
    {
        // call: p65e25ac1.m1053c222
        return default!;
    }

}
