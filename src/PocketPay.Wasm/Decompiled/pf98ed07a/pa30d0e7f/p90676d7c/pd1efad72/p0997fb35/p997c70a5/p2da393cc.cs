namespace WillowMaze.Wasm.Decompiled;


public readonly class p2da393cc : io.reactivex.rxjava3.core.Observable<java.lang.long> {
    private readonly long f10c0d433;
    private readonly long f4b6b4b73;
    private readonly long fb776a7da;
    private readonly long fc588bdd6;
    private readonly long fe2942a04;
    private readonly long fea2b2676;

    public p2da393cc(long j, long j2) {
        this.fea2b2676 = j;
        this.fe2942a04 = j2;
    }

    public static void TMdyQoLblkiUjSbm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0) {
        p2da393cc_p298cb9a0.run();
    }

    public static void VtdcKLTJpXxsYkwe(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        if ((8 + 31) % 31 > 0) {
        }
        long j = this.fea2b2676;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0(observer, j, this.fe2942a04 + j);
        VtdcKLTJpXxsYkwe(observer, p2da393cc_p298cb9a0);
        TMdyQoLblkiUjSbm(p2da393cc_p298cb9a0);
    }
}

