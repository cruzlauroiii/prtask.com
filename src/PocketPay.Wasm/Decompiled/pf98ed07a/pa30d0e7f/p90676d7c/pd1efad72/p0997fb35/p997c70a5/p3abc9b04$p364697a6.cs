namespace WillowMaze.Wasm.Decompiled;


readonly class p3abc9b04$p364697a6<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f98d3337b = -7098360935104053232L;
    private static readonly long fc05e45fb = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f347b1c2e;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Observer f503d3da4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 f56f4f8bf;
    readonly io.reactivex.rxjava3.core.Observer f5cdfb0e8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f70ccd1be;
    readonly io.reactivex.rxjava3.core.ObservableSource f7d693266;
    readonly io.reactivex.rxjava3.core.ObservableSource f82e958e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 f83e30040;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 faa08562c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fbc3b0556;
    readonly io.reactivex.rxjava3.core.ObservableSource fc5c6fead;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 fd7583031;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 fe35e5a71;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fe47b89d1;
    readonly io.reactivex.rxjava3.core.ObservableSource fe8c128f5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 fef399b2d;
    readonly io.reactivex.rxjava3.core.Observer ffa41f72e;

    p3abc9b04$p364697a6(io.reactivex.rxjava3.core.Observer<T> observer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.fbc3b0556 = pa7808658Var;
        this.f36cd38f4 = observableSource;
        this.fef399b2d = pf113d791Var;
    }

    public static void EVwxVtnguTtiUKkE(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void FfZSNhRQUhGFThgg(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void VOwbdruvYNKJcZfC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3abc9b04$p364697a6 p3abc9b04_p364697a6) {
        p3abc9b04_p364697a6.subscribeNext();
    }

    public static int CXLsozdhbMaKLnmo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3abc9b04$p364697a6 p3abc9b04_p364697a6) {
        return p3abc9b04_p364697a6.getAndIncrement();
    }

    public static void CZndeXuWbVHHVPhb(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool EGlmTDxSNJmuwHqa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void GnDirOAPoiORhkVL(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool MArJmscDQKOzHejP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var) {
        return pf113d791Var.getAsbool();
    }

    public static void PQuFTrKAtYXahqnj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QpxbiJjTtTtAYugS(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int TKtzeCdCKjyPRooS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3abc9b04$p364697a6 p3abc9b04_p364697a6, int i) {
        return p3abc9b04_p364697a6.addAndGet(i);
    }

    public override void OnComplete() {
        try {
            if (mArJmscDQKOzHejP(this.fef399b2d)) {
                FfZSNhRQUhGFThgg(this.fd22a0a80);
            } else {
                VOwbdruvYNKJcZfC(this);
            }
        } catch (java.lang.Exception th) {
            pQuFTrKAtYXahqnj(th);
            EVwxVtnguTtiUKkE(this.fd22a0a80, th);
        }
    }

    public override void OnError(java.lang.Exception th) {
        qpxbiJjTtTtAYugS(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        gnDirOAPoiORhkVL(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        eGlmTDxSNJmuwHqa(this.fbc3b0556, p7beea252Var);
    }

    void subscribeNext() {
        if ((26 + 16) % 16 > 0) {
        }
        if (cXLsozdhbMaKLnmo(this) != 0) {
            return;
        }
        int iTKtzeCdCKjyPRooS = 1;
        do {
            cZndeXuWbVHHVPhb(this.f36cd38f4, this);
            iTKtzeCdCKjyPRooS = tKtzeCdCKjyPRooS(this, -iTKtzeCdCKjyPRooS);
        } while (iTKtzeCdCKjyPRooS != 0);
    }
}

