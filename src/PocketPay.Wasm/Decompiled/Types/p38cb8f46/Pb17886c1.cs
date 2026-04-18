namespace WillowMaze.Wasm.Decompiled;

public class Pb17886c1
{
    private long F14d2f99a;
    private long F1672b124;
    private long F2e587ab2;
    private long F2fd499c1;
    private readonly Condition F3f9178c2;
    private readonly Lock F4df0e0e8;
    private long F57f0210e;
    private readonly Lock F58f02ccd;
    private long F7bd8bf9e;
    private readonly Condition F7d1a0eea;
    private readonly Lock F7f58721b;
    private long F83e1b86f;
    private long F8e753048;
    private readonly Lock Fa461e3d5;
    private long Fa50d6663;
    private readonly Condition Fa6618ac9;
    private long Fcc7a2aff;
    private readonly Condition Fd76ccd16;
    private readonly Lock Fdce7c417;
    private readonly Condition Ff8b294e1;
    private long Ffd8d9875;

    private long M52ef5770(long P0)
    {
        // field: p38cb8f46.pb17886c1.fcc7a2aff
        return 0;
    }

    public static void Ma5d61be5(pb17886c1 P0, long P1, long P2, long P3, int P4, object P5)
    {
        // call: pb17886c1.bytesPerSecond
        // field: p38cb8f46.pb17886c1.f57f0210e
        // field: p38cb8f46.pb17886c1.ffd8d9875
    }

    private long Mc27b2ab7(long P0)
    {
        // field: p38cb8f46.pb17886c1.fcc7a2aff
        return 0;
    }

    public long ByteCountOrWaitNanos$okio(long P0, long P1)
    {
        // call: pb17886c1.m52ef5770
        // call: Math.min
        // call: pb17886c1.mc27b2ab7
        // call: Math.max
        // field: p38cb8f46.pb17886c1.fcc7a2aff
        // field: p38cb8f46.pb17886c1.ffd8d9875
        // field: p38cb8f46.pb17886c1.fa50d6663
        // field: p38cb8f46.pb17886c1.f57f0210e
        return 0;
    }

    public void BytesPerSecond(long P0)
    {
        // call: pb17886c1.ma5d61be5
    }

    public void BytesPerSecond(long P0, long P1)
    {
        // call: pb17886c1.ma5d61be5
    }

    public void BytesPerSecond(long P0, long P1, long P2)
    {
        // str: "Failed requirement."
        // call: Condition.signalAll
        // call: Lock.unlock
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: Lock.lock
        // field: p38cb8f46.pb17886c1.fcc7a2aff
        // field: p38cb8f46.pb17886c1.f57f0210e
        // field: p38cb8f46.pb17886c1.ffd8d9875
        // field: p38cb8f46.pb17886c1.f3f9178c2
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.pb17886c1.fdce7c417
        // type: IllegalArgumentException
    }

    public Condition GetCondition()
    {
        // field: p38cb8f46.pb17886c1.f3f9178c2
        return default!;
    }

    public Lock GetLock()
    {
        // field: p38cb8f46.pb17886c1.fdce7c417
        return default!;
    }

    public p1eb558b5 Sink(p1eb558b5 P0)
    {
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: pb17886c1$pf6e04117$1.<init>
        // type: pb17886c1$pf6e04117$1
        return default!;
    }

    public pf31bbdd1 Source(pf31bbdd1 P0)
    {
        // str: "source"
        // call: pb17886c1$p36cd38f4$1.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: pb17886c1$p36cd38f4$1
        return default!;
    }

    public long Take$okio(long P0)
    {
        // str: "Failed requirement."
        // call: object.toString
        // call: Lock.lock
        // call: System.nanoTime
        // call: pb17886c1.byteCountOrWaitNanos$okio
        // call: IllegalArgumentException.<init>
        // call: Lock.unlock
        // call: Condition.awaitNanos
        // field: p38cb8f46.pb17886c1.fdce7c417
        // field: p38cb8f46.pb17886c1.f3f9178c2
        // type: IllegalArgumentException
        return 0;
    }

}
