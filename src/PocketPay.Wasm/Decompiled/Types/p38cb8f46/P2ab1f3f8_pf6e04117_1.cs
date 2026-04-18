namespace WillowMaze.Wasm.Decompiled;

public class P2ab1f3f8_pf6e04117_1 : P1eb558b5
{
    private readonly pc85a251c F09623df7;
    private readonly pc85a251c F1730d620;
    private readonly pc85a251c F6e225e3a;
    private readonly pc85a251c F70d4cec7;
    private readonly pc85a251c F90272dda;
    private readonly p2ab1f3f8 This$0;

    public void Close()
    {
        // str: "source is closed"
        // call: pc85a251c.hasDeadline
        // call: pc85a251c.clearDeadline
        // call: pc85a251c.timeout
        // call: pc85a251c.deadlineNanoTime
        // call: p1eb558b5.close
        // call: p2ab1f3f8.getFoldedSink$okio
        // call: p2ab1f3f8.getSourceClosed$okio
        // call: p2ab1f3f8.getBuffer$okio
        // call: p7e62bc34.size
        // call: IOException.<init>
        // call: p2ab1f3f8.setSinkClosed$okio
        // call: p2ab1f3f8.getCondition
        // call: Condition.signalAll
        // call: Math.min
        // call: p1eb558b5.timeout
        // call: Lock.unlock
        // call: p2ab1f3f8.sink
        // call: pc85a251c$p910eef8c.minTimeout
        // call: pc85a251c.timeoutNanos
        // call: p2ab1f3f8.getLock
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p2ab1f3f8$pf6e04117$1.this$0
        // field: p38cb8f46.pc85a251c.f910eef8c
        // type: IOException
    }

    public void Flush()
    {
        // str: "source is closed"
        // str: "canceled"
        // str: "closed"
        // call: pc85a251c.hasDeadline
        // call: Lock.lock
        // call: p2ab1f3f8.getSinkClosed$okio
        // call: p2ab1f3f8.getCanceled$okio
        // call: p2ab1f3f8.getFoldedSink$okio
        // call: p2ab1f3f8.getSourceClosed$okio
        // call: p2ab1f3f8.getBuffer$okio
        // call: p7e62bc34.size
        // call: IOException.<init>
        // call: pc85a251c.deadlineNanoTime
        // call: pc85a251c$p910eef8c.minTimeout
        // call: pc85a251c.timeout
        // call: Math.min
        // call: p1eb558b5.timeout
        // call: pc85a251c.clearDeadline
        // call: p1eb558b5.flush
        // call: pc85a251c.timeoutNanos
        // call: Lock.unlock
        // call: p2ab1f3f8.getLock
        // call: p2ab1f3f8.sink
        // field: kotlin.Unit.INSTANCE
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: p38cb8f46.p2ab1f3f8$pf6e04117$1.this$0
        // field: p38cb8f46.pc85a251c.f910eef8c
        // type: IOException
        // type: IllegalStateException
    }

    public pc85a251c Timeout()
    {
        // field: p38cb8f46.p2ab1f3f8$pf6e04117$1.f90272dda
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "canceled"
        // str: "closed"
        // str: "source"
        // str: "source is closed"
        // call: pc85a251c.timeoutNanos
        // call: pc85a251c.deadlineNanoTime
        // call: pc85a251c.timeout
        // call: Intrinsics.checkNotNullParameter
        // call: Lock.unlock
        // call: p1eb558b5.write
        // call: pc85a251c.hasDeadline
        // call: IOException.<init>
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p1eb558b5.timeout
        // call: pc85a251c$p910eef8c.minTimeout
        // call: pc85a251c.clearDeadline
        // call: Math.min
        // call: p2ab1f3f8.sink
        // call: p2ab1f3f8.getFoldedSink$okio
        // call: p2ab1f3f8.getSourceClosed$okio
        // call: p2ab1f3f8.getMaxBufferSize$okio
        // call: p2ab1f3f8.getBuffer$okio
        // call: p7e62bc34.size
        // field: p38cb8f46.pc85a251c.f910eef8c
        // field: kotlin.Unit.INSTANCE
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: p38cb8f46.p2ab1f3f8$pf6e04117$1.this$0
        // field: p38cb8f46.p2ab1f3f8$pf6e04117$1.f90272dda
        // type: IOException
        // type: IllegalStateException
    }

}
