namespace WillowMaze.Wasm.Decompiled;

public class P87a6e6e6_p4842ffc1 : Pf31bbdd1
{
    private readonly p7e62bc34 F0f94522d;
    private readonly long F153a7b52;
    private readonly p7e62bc34 F3296ef7b;
    private bool F349e6863;
    private readonly p7e62bc34 F49bf5f8c;
    private readonly p7e62bc34 F7fff1532;
    private bool F8321ddf4;
    private readonly p7e62bc34 F8d6b2264;
    private bool F92f22efd;
    private bool Fa5d7ceb2;
    private bool Fa5e0c963;
    private readonly long Fb62c9646;
    private readonly p7e62bc34 Fca3bbd31;
    private readonly p7e62bc34 Fcf886249;
    private bool Fda0794b8;
    private bool Fda76365f;
    private p883d7615 Fe0749eac;
    private p883d7615 Ffbfe9809;
    private readonly long Ffd8d9875;
    private readonly p87a6e6e6 This$0;

    private void UpdateConnectionFlowControl(long P0)
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: Thread.currentThread
        // call: StringBuilder.<init>
        // call: Thread.getName
        // call: p87a6e6e6.getConnection
        // call: AssertionError.<init>
        // call: p2d68e184.updateConnectionFlowControl$okhttp
        // call: Thread.holdsLock
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.this$0
        // type: StringBuilder
        // type: AssertionError
    }

    public void Close()
    {
        // call: p87a6e6e6$p4842ffc1.setClosed$okhttp
        // call: p87a6e6e6$p4842ffc1.getReadBuffer
        // call: p7e62bc34.size
        // call: p7e62bc34.clear
        // call: object.notifyAll
        // call: p87a6e6e6.cancelStreamIfNecessary$okhttp
        // call: p87a6e6e6$p4842ffc1.updateConnectionFlowControl
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.this$0
        // field: kotlin.Unit.INSTANCE
    }

    public bool GetClosed$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.f349e6863
        return false;
    }

    public bool GetFinished$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.fa5d7ceb2
        return false;
    }

    public p7e62bc34 GetReadBuffer()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.fcf886249
        return default!;
    }

    public p7e62bc34 GetReceiveBuffer()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.f3296ef7b
        return default!;
    }

    public p883d7615 GetTrailers()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.ffbfe9809
        return default!;
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // str: "byteCount < 0: "
        // str: "stream closed"
        // call: p87a6e6e6.getReadTimeout$okhttp
        // call: p87a6e6e6$p6a2e05b1.enter
        // call: p87a6e6e6.getErrorCode$okhttp
        // call: p87a6e6e6.getErrorException$okhttp
        // call: Intrinsics.checkNotNull
        // call: p1bf03f78.<init>
        // call: p87a6e6e6$p4842ffc1.getClosed$okhttp
        // call: p87a6e6e6$p4842ffc1.getReadBuffer
        // call: p7e62bc34.size
        // call: Math.min
        // call: p7e62bc34.read
        // call: p87a6e6e6.getReadBytesTotal
        // call: p87a6e6e6.setReadBytesTotal$okhttp
        // call: p87a6e6e6.getReadBytesAcknowledged
        // call: p87a6e6e6.getConnection
        // call: p2d68e184.getOkHttpSettings
        // call: pf4f70727.getInitialWindowSize
        // call: p87a6e6e6.getId
        // call: p2d68e184.writeWindowUpdateLater$okhttp
        // call: p87a6e6e6.setReadBytesAcknowledged$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.this$0
        // field: kotlin.Unit.INSTANCE
        // type: p1bf03f78
        // type: IOException
        // type: IllegalArgumentException
        return 0;
    }

    public void Receive$okhttp(pcc81e3f6 P0, long P1)
    {
        // str: "source"
        // str: "Thread "
        // str: " MUST NOT hold lock on "
        // call: p87a6e6e6$p4842ffc1.getFinished$okhttp
        // call: p87a6e6e6$p4842ffc1.getReadBuffer
        // call: p7e62bc34.size
        // call: EOFException.<init>
        // call: Thread.holdsLock
        // call: Intrinsics.checkNotNullParameter
        // call: Thread.currentThread
        // call: pcc81e3f6.read
        // call: StringBuilder.<init>
        // call: p87a6e6e6$p4842ffc1.getClosed$okhttp
        // call: p87a6e6e6$p4842ffc1.getReceiveBuffer
        // call: p7e62bc34.clear
        // call: p7e62bc34.writeAll
        // call: object.notifyAll
        // call: Thread.getName
        // call: p87a6e6e6.closeLater
        // call: StringBuilder.toString
        // call: pcc81e3f6.skip
        // call: StringBuilder.append
        // call: p87a6e6e6$p4842ffc1.updateConnectionFlowControl
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.ffd8d9875
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.this$0
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.f3296ef7b
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f20973c7b
        // type: StringBuilder
        // type: EOFException
        // type: AssertionError
    }

    public void SetClosed$okhttp(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.f349e6863
    }

    public void SetFinished$okhttp(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.fa5d7ceb2
    }

    public void SetTrailers(p883d7615 P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.ffbfe9809
    }

    public pc85a251c Timeout()
    {
        // call: p87a6e6e6.getReadTimeout$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p4842ffc1.this$0
        return default!;
    }

}
