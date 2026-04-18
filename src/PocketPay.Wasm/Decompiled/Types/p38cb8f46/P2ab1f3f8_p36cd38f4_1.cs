namespace WillowMaze.Wasm.Decompiled;

public class P2ab1f3f8_p36cd38f4_1 : Pf31bbdd1
{
    private readonly pc85a251c F5a89307e;
    private readonly pc85a251c F90272dda;
    private readonly pc85a251c Fde8ca95d;
    private readonly pc85a251c Ff49bc165;
    private readonly p2ab1f3f8 This$0;

    public void Close()
    {
        // call: Lock.lock
        // call: p2ab1f3f8.setSourceClosed$okio
        // call: p2ab1f3f8.getCondition
        // call: Condition.signalAll
        // call: Lock.unlock
        // call: p2ab1f3f8.getLock
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p2ab1f3f8$p36cd38f4$1.this$0
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "closed"
        // str: "sink"
        // str: "canceled"
        // call: Lock.unlock
        // call: p2ab1f3f8.getLock
        // call: IOException.<init>
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Lock.lock
        // call: p2ab1f3f8.getSourceClosed$okio
        // call: p2ab1f3f8.getCanceled$okio
        // call: p2ab1f3f8.getBuffer$okio
        // call: p7e62bc34.size
        // call: p2ab1f3f8.getSinkClosed$okio
        // call: Intrinsics.checkNotNullParameter
        // call: p2ab1f3f8.getCondition
        // call: pc85a251c.awaitSignal
        // call: p7e62bc34.read
        // call: Condition.signalAll
        // field: p38cb8f46.p2ab1f3f8$p36cd38f4$1.this$0
        // field: p38cb8f46.p2ab1f3f8$p36cd38f4$1.f90272dda
        // type: IOException
        // type: IllegalStateException
        return 0;
    }

    public pc85a251c Timeout()
    {
        // field: p38cb8f46.p2ab1f3f8$p36cd38f4$1.f90272dda
        return default!;
    }

}
