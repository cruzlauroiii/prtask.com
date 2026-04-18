namespace WillowMaze.Wasm.Decompiled;


public readonly class p4fc6368c<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.operators.ScalarSupplier<T> {
    private readonly T f2063c160;
    private readonly java.lang.object f4f19d916;
    private readonly java.lang.object f8b695992;
    private readonly java.lang.object fcc035bb7;
    private readonly java.lang.object ffc04c4c0;

    public p4fc6368c(T t) {
        this.f2063c160 = t;
    }

    public static void BvbrvExdlFdUeljl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb) {
        pbaf6a245_p89d11deb.run();
    }

    public static void FgSBqBVsEvKsJVcA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public T Get() {
        return this.f2063c160;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb(observer, this.f2063c160);
        fgSBqBVsEvKsJVcA(observer, pbaf6a245_p89d11deb);
        BvbrvExdlFdUeljl(pbaf6a245_p89d11deb);
    }
}

