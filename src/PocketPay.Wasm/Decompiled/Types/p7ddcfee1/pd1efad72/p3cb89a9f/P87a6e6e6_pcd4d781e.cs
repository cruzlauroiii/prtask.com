namespace WillowMaze.Wasm.Decompiled;

public class P87a6e6e6_pcd4d781e : P1eb558b5
{
    private p883d7615 F1528b32d;
    private bool F23f66f47;
    private bool F349e6863;
    private p883d7615 F3b555045;
    private readonly p7e62bc34 F4a072ba6;
    private bool F51fe7742;
    private p883d7615 F5e927a7a;
    private bool F79b0e9ce;
    private readonly p7e62bc34 F8028054c;
    private bool Fa5d7ceb2;
    private bool Fc2edb96b;
    private readonly p7e62bc34 Fd21dc3db;
    private readonly p7e62bc34 Fea206018;
    private p883d7615 Fecb42ff0;
    private bool Ff2c56112;
    private p883d7615 Ffbfe9809;
    private readonly p87a6e6e6 This$0;

    private void EmitFrame(bool P0)
    {
        // call: p87a6e6e6.getWriteTimeout$okhttp
        // call: p87a6e6e6$p6a2e05b1.enter
        // call: p87a6e6e6.getConnection
        // call: p87a6e6e6.getId
        // call: p2d68e184.writeData
        // call: p87a6e6e6.getWriteBytesTotal
        // call: p87a6e6e6.getWriteBytesMaximum
        // call: p87a6e6e6$pcd4d781e.getFinished
        // call: p87a6e6e6$pcd4d781e.getClosed
        // call: p87a6e6e6.getErrorCode$okhttp
        // call: p87a6e6e6.waitForIo$okhttp
        // call: p87a6e6e6$p6a2e05b1.exitAndThrowIfTimedOut
        // call: p87a6e6e6.checkOutNotClosed$okhttp
        // call: p7e62bc34.size
        // call: Math.min
        // call: p87a6e6e6.setWriteBytesTotal$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.this$0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f8028054c
        // field: kotlin.Unit.INSTANCE
    }

    public void Close()
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: p87a6e6e6.getErrorCode$okhttp
        // call: p87a6e6e6.getConnection
        // call: p87a6e6e6.getId
        // call: p7e62bc34.size
        // call: Thread.currentThread
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNull
        // call: p87a6e6e6$pcd4d781e.getClosed
        // call: p2d68e184.writeData
        // call: p2d68e184.flush
        // call: StringBuilder.toString
        // call: p87a6e6e6$pcd4d781e.setClosed
        // call: p87a6e6e6$pcd4d781e.emitFrame
        // call: p23e8a4b4.toHeaderList
        // call: p87a6e6e6.cancelStreamIfNecessary$okhttp
        // call: Thread.holdsLock
        // call: AssertionError.<init>
        // call: p2d68e184.writeHeaders$okhttp
        // call: Thread.getName
        // call: StringBuilder.<init>
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.this$0
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f8028054c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.ffbfe9809
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.fa5d7ceb2
        // type: AssertionError
        // type: StringBuilder
    }

    public void Flush()
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: p87a6e6e6.checkOutNotClosed$okhttp
        // call: StringBuilder.append
        // call: Thread.getName
        // call: p87a6e6e6$pcd4d781e.emitFrame
        // call: Thread.currentThread
        // call: StringBuilder.toString
        // call: Thread.holdsLock
        // call: p2d68e184.flush
        // call: p7e62bc34.size
        // call: AssertionError.<init>
        // call: p87a6e6e6.getConnection
        // call: StringBuilder.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.this$0
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f8028054c
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: AssertionError
    }

    public bool GetClosed()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f349e6863
        return false;
    }

    public bool GetFinished()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.fa5d7ceb2
        return false;
    }

    public p883d7615 GetTrailers()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.ffbfe9809
        return default!;
    }

    public void SetClosed(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f349e6863
    }

    public void SetFinished(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.fa5d7ceb2
    }

    public void SetTrailers(p883d7615 P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.ffbfe9809
    }

    public pc85a251c Timeout()
    {
        // call: p87a6e6e6.getWriteTimeout$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.this$0
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "Thread "
        // str: " MUST NOT hold lock on "
        // str: "source"
        // call: StringBuilder.<init>
        // call: Thread.holdsLock
        // call: StringBuilder.append
        // call: p87a6e6e6$pcd4d781e.emitFrame
        // call: p7e62bc34.write
        // call: AssertionError.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.size
        // call: Thread.getName
        // call: StringBuilder.toString
        // call: Thread.currentThread
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.this$0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$pcd4d781e.f8028054c
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: AssertionError
    }

}
