namespace WillowMaze.Wasm.Decompiled;

public class P2ab1f3f8
{
    private readonly long F1454a7c2;
    private bool F159626d1;
    private readonly long F1e74ff3e;
    private readonly p7e62bc34 F23b17a1a;
    private readonly Lock F266bb83b;
    private readonly p7e62bc34 F300e4e6e;
    private p1eb558b5 F35a7f98b;
    private readonly pf31bbdd1 F36cd38f4;
    private bool F3a429f75;
    private bool F3e2936ea;
    private readonly Condition F3f9178c2;
    private readonly pf31bbdd1 F4c524369;
    private readonly pf31bbdd1 F56316961;
    private p1eb558b5 F5c73162a;
    private readonly p1eb558b5 F65d71d53;
    private readonly p7e62bc34 F7cab4167;
    private bool F7e66e13b;
    private readonly p7e62bc34 F7f2db423;
    private readonly pf31bbdd1 F9d8bf354;
    private readonly Lock Fb7de834a;
    private readonly pf31bbdd1 Fbd219fff;
    private bool Fc96bb838;
    private readonly Condition Fcfa768dd;
    private bool Fd5c39a1d;
    private bool Fda5112f8;
    private readonly p1eb558b5 Fda895491;
    private readonly Lock Fdce7c417;
    private readonly p1eb558b5 Fdfccd747;
    private readonly p1eb558b5 Fefdec27b;
    private p1eb558b5 Ff3fb0c21;
    private readonly p1eb558b5 Ff6e04117;
    private p1eb558b5 Ffff91ece;

    private void M965dbaac(p1eb558b5 P0, Func<object, object> P1)
    {
        // call: pc85a251c.timeoutNanos
        // call: pc85a251c.hasDeadline
        // call: pc85a251c.timeout
        // call: pc85a251c.clearDeadline
        // call: pc85a251c.deadlineNanoTime
        // call: Math.min
        // call: Func<object, object>.invoke
        // call: pc85a251c$p910eef8c.minTimeout
        // call: p1eb558b5.timeout
        // call: p2ab1f3f8.sink
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.pc85a251c.f910eef8c
    }

    public p1eb558b5 -deprecated_sink()
    {
        // field: p38cb8f46.p2ab1f3f8.ff6e04117
        return default!;
    }

    public pf31bbdd1 -deprecated_source()
    {
        // field: p38cb8f46.p2ab1f3f8.f36cd38f4
        return default!;
    }

    public void Cancel()
    {
        // call: Lock.unlock
        // call: Lock.lock
        // call: p7e62bc34.clear
        // call: Condition.signalAll
        // field: p38cb8f46.p2ab1f3f8.fdce7c417
        // field: p38cb8f46.p2ab1f3f8.fd5c39a1d
        // field: p38cb8f46.p2ab1f3f8.f7f2db423
        // field: p38cb8f46.p2ab1f3f8.f3f9178c2
        // field: kotlin.Unit.INSTANCE
    }

    public void Fold(p1eb558b5 P0)
    {
        // str: "sink"
        // str: "canceled"
        // str: "sink already folded"
        // call: Lock.unlock
        // call: p7e62bc34.size
        // call: p1eb558b5.write
        // call: p1eb558b5.close
        // call: p1eb558b5.flush
        // call: Intrinsics.checkNotNullParameter
        // call: Lock.lock
        // call: p7e62bc34.exhausted
        // call: Condition.signalAll
        // call: p7e62bc34.<init>
        // call: p7e62bc34.write
        // call: IOException.<init>
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p2ab1f3f8.f5c73162a
        // field: p38cb8f46.p2ab1f3f8.fd5c39a1d
        // field: p38cb8f46.p2ab1f3f8.f7f2db423
        // field: p38cb8f46.p2ab1f3f8.fda5112f8
        // field: p38cb8f46.p2ab1f3f8.fdce7c417
        // field: p38cb8f46.p2ab1f3f8.f3f9178c2
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p2ab1f3f8.f3a429f75
        // type: p7e62bc34
        // type: IOException
        // type: IllegalStateException
    }

    public p7e62bc34 GetBuffer$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.f7f2db423
        return default!;
    }

    public bool GetCanceled$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.fd5c39a1d
        return false;
    }

    public Condition GetCondition()
    {
        // field: p38cb8f46.p2ab1f3f8.f3f9178c2
        return default!;
    }

    public p1eb558b5 GetFoldedSink$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.f5c73162a
        return default!;
    }

    public Lock GetLock()
    {
        // field: p38cb8f46.p2ab1f3f8.fdce7c417
        return default!;
    }

    public long GetMaxBufferSize$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.f1e74ff3e
        return 0;
    }

    public bool GetSinkClosed$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.f3a429f75
        return false;
    }

    public bool GetSourceClosed$okio()
    {
        // field: p38cb8f46.p2ab1f3f8.fda5112f8
        return false;
    }

    public void SetCanceled$okio(bool P0)
    {
        // field: p38cb8f46.p2ab1f3f8.fd5c39a1d
    }

    public void SetFoldedSink$okio(p1eb558b5 P0)
    {
        // field: p38cb8f46.p2ab1f3f8.f5c73162a
    }

    public void SetSinkClosed$okio(bool P0)
    {
        // field: p38cb8f46.p2ab1f3f8.f3a429f75
    }

    public void SetSourceClosed$okio(bool P0)
    {
        // field: p38cb8f46.p2ab1f3f8.fda5112f8
    }

    public p1eb558b5 Sink()
    {
        // field: p38cb8f46.p2ab1f3f8.ff6e04117
        return default!;
    }

    public pf31bbdd1 Source()
    {
        // field: p38cb8f46.p2ab1f3f8.f36cd38f4
        return default!;
    }

}
