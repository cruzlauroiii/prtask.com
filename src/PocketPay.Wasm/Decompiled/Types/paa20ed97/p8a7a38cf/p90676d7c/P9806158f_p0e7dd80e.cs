namespace WillowMaze.Wasm.Decompiled;

public class P9806158f_p0e7dd80e : Observer
{
    private readonly Observer F0eea83dc;
    private bool F92dcd9ed;
    private bool Fb6f4f1ea;
    private bool Fdd4b8c76;
    private readonly Observer Fdfda0d32;

    public void OnComplete()
    {
        // call: Observer.onComplete
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdd4b8c76
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdfda0d32
    }

    public void OnError(Exception P0)
    {
        // str: "This should never happen! Report as a bug with the full stacktrace."
        // call: AssertionError.<init>
        // call: Observer.onError
        // call: Exception.initCause
        // call: pd36704fd.mdcce2ff2
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdd4b8c76
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdfda0d32
        // type: AssertionError
    }

    public void OnNext(object P0)
    {
        // call: p9806158f$p0e7dd80e.onNext
    }

    public void OnNext(Response P0)
    {
        // call: p1489c99e.<init>
        // call: pd36704fd.mdcce2ff2
        // call: Observer.onNext
        // call: p8a8cef05.<init>
        // call: Observer.onError
        // call: Response.isSuccessful
        // call: pd5f1381c.m9f2b335f
        // call: Response.body
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdfda0d32
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdd4b8c76
        // type: p1489c99e
        // type: p8a8cef05
    }

    public void OnSubscribe(p7beea252 P0)
    {
        // call: Observer.onSubscribe
        // field: paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e.fdfda0d32
    }

}
