namespace WillowMaze.Wasm.Decompiled;


readonly class pd8768b96$p7c9324ab<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc6e1e520 = 4375739915521278546L;
    private static readonly long fda8e1206 = 4375739915521278546L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1ced284c;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.MaybeObserver f9055e555;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb2028318;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbce96964;
    readonly io.reactivex.rxjava3.core.MaybeObserver fcbdf2761;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd81e1f8d;
    readonly io.reactivex.rxjava3.core.MaybeObserver fde9ab86a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff8448d9a;

    pd8768b96$p7c9324ab(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function) {
        this.fd22a0a80 = maybeObserver;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object CVAHRRLHBleneWgg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab pd8768b96_p7c9324ab) {
        return pd8768b96_p7c9324ab[);
    }

    public static void LldxHEVGWWyjwSDG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool OdqmIjbxiMWgTyhN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool QIXWMEOjsTbKiDbc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void XlXbzYAQScfyrpsK(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void YogfWcLFzyuzGGiv(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void DTXBgljImRyApVPw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void HOfZyDVKNpPXtwce(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object HZhEAQAEUJiniRfc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool IDRnpwYaIwuAZwKS(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object MFIGLksQpswVQabg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void OUxSCcwpCQZsaROZ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool PiGuWvbJZoEGvIQQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab pd8768b96_p7c9324ab) {
        return pd8768b96_p7c9324ab.isDisposed();
    }

    public static void QpflcFIZPqzeZXOT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void Dispose() {
        iDRnpwYaIwuAZwKS(this);
        hOfZyDVKNpPXtwce(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return QIXWMEOjsTbKiDbc((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) CVAHRRLHBleneWgg(this));
    }

    public override void OnComplete() {
        YogfWcLFzyuzGGiv(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        LldxHEVGWWyjwSDG(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (OdqmIjbxiMWgTyhN(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            dTXBgljImRyApVPw(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) mFIGLksQpswVQabg(hZhEAQAEUJiniRfc(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            if (piGuWvbJZoEGvIQQ(this)) {
                return;
            }
            XlXbzYAQScfyrpsK(maybeSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab$p9192f42a(this));
        } catch (java.lang.Exception th) {
            qpflcFIZPqzeZXOT(th);
            oUxSCcwpCQZsaROZ(this.fd22a0a80, th);
        }
    }
}

