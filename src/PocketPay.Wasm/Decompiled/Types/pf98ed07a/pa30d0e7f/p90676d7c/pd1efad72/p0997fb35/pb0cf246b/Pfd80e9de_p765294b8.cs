namespace WillowMaze.Wasm.Decompiled;

public class Pfd80e9de_p765294b8 : FlowableSubscriber, P5d5a5670
{
    private p787ad0b7 F1467fc2c;
    private p787ad0b7 F1b24ab21;
    private p787ad0b7 F70938c6a;
    private readonly p992c4a5b F865f8305;
    private p787ad0b7 Fa58b876d;
    private p787ad0b7 Fbc3b0556;
    private readonly p992c4a5b Fd22a0a80;

    public static void HocIGDWsSuUSJKBa(p787ad0b7 P0, long P1)
    {
        // call: p787ad0b7.request
    }

    public static void SYSUezybSrjPyDqM(p992c4a5b P0, Exception P1)
    {
        // call: p992c4a5b.onError
    }

    public static bool JCTlPPqajtPJncHu(p787ad0b7 P0, p787ad0b7 P1)
    {
        // call: p449cd152.validate
        return false;
    }

    public static void SejjnUnHUrNkLLvK(p992c4a5b P0, p787ad0b7 P1)
    {
        // call: p992c4a5b.onSubscribe
    }

    public static void UbcNxboXNZDBqMYD(p787ad0b7 P0)
    {
        // call: p787ad0b7.cancel
    }

    public static void WRCdpxdmJDzEblgO(p992c4a5b P0)
    {
        // call: p992c4a5b.onComplete
    }

    public void Cancel()
    {
        // call: pfd80e9de$p765294b8.ubcNxboXNZDBqMYD
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de$p765294b8.fbc3b0556
    }

    public void Clear()
    {
    }

    public bool IsEmpty()
    {
        return false;
    }

    public bool Offer(object P0)
    {
        // str: "Should not be called!"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return false;
    }

    public bool Offer(object P0, object P1)
    {
        // str: "Should not be called!"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return false;
    }

    public void OnComplete()
    {
        // call: pfd80e9de$p765294b8.wRCdpxdmJDzEblgO
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de$p765294b8.fd22a0a80
    }

    public void OnError(Exception P0)
    {
        // call: pfd80e9de$p765294b8.SYSUezybSrjPyDqM
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de$p765294b8.fd22a0a80
    }

    public void OnNext(object P0)
    {
    }

    public void OnSubscribe(p787ad0b7 P0)
    {
        // call: pfd80e9de$p765294b8.sejjnUnHUrNkLLvK
        // call: pfd80e9de$p765294b8.HocIGDWsSuUSJKBa
        // call: pfd80e9de$p765294b8.jCTlPPqajtPJncHu
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de$p765294b8.fd22a0a80
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de$p765294b8.fbc3b0556
    }

    public object Poll()
    {
        return default!;
    }

    public void Request(long P0)
    {
    }

    public int RequestFusion(int P0)
    {
        return 0;
    }

}
