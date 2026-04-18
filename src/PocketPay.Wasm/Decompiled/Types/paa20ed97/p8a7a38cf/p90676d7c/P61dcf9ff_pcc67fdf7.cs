namespace WillowMaze.Wasm.Decompiled;

public class P61dcf9ff_pcc67fdf7 : P7beea252, P406c70d6
{
    private bool F44750ba4;
    private readonly pc3755e61 F47499fc2;
    private readonly pc3755e61 F53b9e967;
    private bool F7849d7e7;
    private readonly pc3755e61 F7c8793c8;
    private readonly pc3755e61 F80636ea3;
    private readonly Observer F859160fe;
    private readonly pc3755e61 F87de0763;
    private bool F8baf33cb;
    private bool Fbd26e07a;
    private bool Fdd4b8c76;
    private readonly Observer Fdfda0d32;
    private bool Ff8b2648d;

    public void Dispose()
    {
        // call: pc3755e61.cancel
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.ff8b2648d
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.f53b9e967
    }

    public bool IsDisposed()
    {
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.ff8b2648d
        return false;
    }

    public void OnFailure(pc3755e61 P0, Exception P1)
    {
        // call: Observer.onError
        // call: pd5f1381c.m9f2b335f
        // call: pc3755e61.isCanceled
        // call: p1489c99e.<init>
        // call: pd36704fd.mdcce2ff2
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.fdfda0d32
        // type: p1489c99e
    }

    public void OnResponse(pc3755e61 P0, Response P1)
    {
        // call: Observer.onNext
        // call: Observer.onComplete
        // call: pd36704fd.mdcce2ff2
        // call: p1489c99e.<init>
        // call: pd5f1381c.m9f2b335f
        // call: Observer.onError
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.fdfda0d32
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.ff8b2648d
        // field: paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7.fdd4b8c76
        // type: p1489c99e
    }

}
