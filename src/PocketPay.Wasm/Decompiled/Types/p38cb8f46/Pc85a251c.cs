namespace WillowMaze.Wasm.Decompiled;

public class Pc85a251c
{
    public static pc85a251c$p910eef8c F4395a05c;
    public static pc85a251c F549733e3;
    public static pc85a251c$p910eef8c F6e03c63b;
    public static pc85a251c$p910eef8c F910eef8c;
    public static pc85a251c Fb50339a1;
    public static pc85a251c$p910eef8c Fd7938302;
    public static pc85a251c Fd95223fb;
    public static pc85a251c Ffbda1dd7;
    private bool F1bd9c970;
    private long F1d070b07;
    private long F2232a071;
    private bool F52d06532;
    private long F572f7948;
    private long F5811544c;
    private bool F5e501557;
    private long F84c84f31;
    private long Fd4d7097c;
    private long Fe1979a67;
    private long Feae3c787;

    public void AwaitSignal(Condition P0)
    {
        // str: "condition"
        // str: "interrupted"
        // str: "timeout"
        // call: InterruptedIOException.<init>
        // call: Thread.currentThread
        // call: Thread.interrupt
        // call: Intrinsics.checkNotNullParameter
        // call: pc85a251c.hasDeadline
        // call: pc85a251c.timeoutNanos
        // call: Condition.await
        // call: System.nanoTime
        // call: pc85a251c.deadlineNanoTime
        // call: Math.min
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // type: InterruptedIOException
    }

    public pc85a251c ClearDeadline()
    {
        // field: p38cb8f46.pc85a251c.f52d06532
        return default!;
    }

    public pc85a251c ClearTimeout()
    {
        // field: p38cb8f46.pc85a251c.fd4d7097c
        return default!;
    }

    public pc85a251c Deadline(long P0, TimeUnit P1)
    {
        // str: "unit"
        // str: "duration <= 0: "
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // call: pc85a251c.deadlineNanoTime
        // call: System.nanoTime
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: TimeUnit.toNanos
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    public long DeadlineNanoTime()
    {
        // str: "No deadline"
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pc85a251c.feae3c787
        // field: p38cb8f46.pc85a251c.f52d06532
        // type: IllegalStateException
        return 0;
    }

    public pc85a251c DeadlineNanoTime(long P0)
    {
        // field: p38cb8f46.pc85a251c.f52d06532
        // field: p38cb8f46.pc85a251c.feae3c787
        return default!;
    }

    public bool HasDeadline()
    {
        // field: p38cb8f46.pc85a251c.f52d06532
        return false;
    }

    public object IntersectWith(pc85a251c P0, Func<object> P1)
    {
        // str: "block"
        // str: "other"
        // call: pc85a251c.hasDeadline
        // call: pc85a251c.deadlineNanoTime
        // call: pc85a251c.timeoutNanos
        // call: Math.min
        // call: pc85a251c.clearDeadline
        // call: Intrinsics.checkNotNullParameter
        // call: pc85a251c.timeout
        // call: Func<object>.invoke
        // call: pc85a251c$p910eef8c.minTimeout
        // field: p38cb8f46.pc85a251c.f910eef8c
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        return default!;
    }

    public void ThrowIfReached()
    {
        // str: "deadline reached"
        // str: "interrupted"
        // call: Thread.currentThread
        // call: System.nanoTime
        // call: InterruptedIOException.<init>
        // call: Thread.isInterrupted
        // field: p38cb8f46.pc85a251c.f52d06532
        // field: p38cb8f46.pc85a251c.feae3c787
        // type: InterruptedIOException
    }

    public pc85a251c Timeout(long P0, TimeUnit P1)
    {
        // str: "unit"
        // str: "timeout < 0: "
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: object.toString
        // call: TimeUnit.toNanos
        // field: p38cb8f46.pc85a251c.fd4d7097c
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    public long TimeoutNanos()
    {
        // field: p38cb8f46.pc85a251c.fd4d7097c
        return 0;
    }

    public void WaitUntilNotified(object P0)
    {
        // str: "monitor"
        // str: "timeout"
        // str: "interrupted"
        // call: InterruptedIOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: pc85a251c.hasDeadline
        // call: pc85a251c.timeoutNanos
        // call: object.wait
        // call: System.nanoTime
        // call: pc85a251c.deadlineNanoTime
        // call: Math.min
        // call: Thread.interrupt
        // call: Thread.currentThread
        // type: InterruptedIOException
    }

}
