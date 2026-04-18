namespace WillowMaze.Wasm.Decompiled;

public class Pc2042e23 : Pcfbb73bb
{
    private p9cd72ef0 F25a0c403;
    private EnumMap F8e418f5e;
    private EnumMap Fce93f0f5;
    private p9cd72ef0 Fef797f40;

    public void FinishRouter(p6ce2a79b P0)
    {
        // str: "routerType"
        // str: "<get-values>(...)"
        // call: Intrinsics.checkNotNullParameter
        // call: EnumMap.remove
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pc2042e23.getGlobalRouter
        // call: EnumMap.values
        // call: p5c15168d.getRouter
        // call: CollectionsKt.last
        // field: pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.f6eecfba7
        // field: pd2a57dc1.pfd9160bb.pc2042e23.f25a0c403
        // field: pd2a57dc1.pfd9160bb.pc2042e23.fce93f0f5
    }

    public p5c15168d GetCicerone(p6ce2a79b P0)
    {
        // str: "routerType"
        // str: "Cicerone not created"
        // call: Intrinsics.checkNotNullParameter
        // call: p5c15168d$p910eef8c.create
        // call: EnumMap.get
        // call: IllegalStateException.<init>
        // call: EnumMap.containsKey
        // call: p5c15168d.getRouter
        // call: object.toString
        // call: Dictionary<string, object>.put
        // field: pd2a57dc1.pfd9160bb.pc2042e23.fce93f0f5
        // field: p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p5c15168d.f910eef8c
        // field: pd2a57dc1.pfd9160bb.pc2042e23.f25a0c403
        // type: IllegalStateException
        return default!;
    }

    public p9cd72ef0 GetGlobalRouter()
    {
        // call: pc2042e23.getCicerone
        // call: p5c15168d.getRouter
        // field: pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.f6eecfba7
        return default!;
    }

    public p9cd72ef0 GetRouter()
    {
        // field: pd2a57dc1.pfd9160bb.pc2042e23.f25a0c403
        return default!;
    }

}
