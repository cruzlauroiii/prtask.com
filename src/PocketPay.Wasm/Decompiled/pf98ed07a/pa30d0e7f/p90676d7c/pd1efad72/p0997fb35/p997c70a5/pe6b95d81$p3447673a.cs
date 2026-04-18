namespace WillowMaze.Wasm.Decompiled;


readonly class pe6b95d81$p3447673a<U> : io.reactivex.rxjava3.core.Observer<U> {
    bool f1301f8df;
    readonly io.reactivex.rxjava3.core.Observer f16b31fb7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f1775f59b;
    readonly io.reactivex.rxjava3.core.Observer f180f41b2;
    readonly io.reactivex.rxjava3.core.Observer<T> f1b7d5726;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f260a2133;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f2bc0f1e2;
    bool f49a683ea;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f6c470a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f74136b24;
    readonly io.reactivex.rxjava3.core.Observer fb1dc93c1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81 this$0;

    pe6b95d81$p3447673a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81 pe6b95d81Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, io.reactivex.rxjava3.core.Observer<T> observer) {
        this.this$0 = pe6b95d81Var;
        this.f74136b24 = pa7808658Var;
        this.f1b7d5726 = observer;
    }

    public static void ARQTBivncTfYPWHL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HqiJWBhSJBwcluki(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81$p3447673a pe6b95d81_p3447673a) {
        pe6b95d81_p3447673a.onComplete();
    }

    public static void NDyDJKQBmSzLrjxT(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void GWZoTHSTYLoEmTPj(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool NgnmhFARsbhkAqbb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.update(p7beea252Var);
    }

    public override void OnComplete() {
        if ((28 + 27) % 27 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        gWZoTHSTYLoEmTPj(this.this$0.ffad58de7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81$p3447673a$pce8a7b54(this));
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            ARQTBivncTfYPWHL(th);
        } else {
            this.f6b2ded51 = true;
            NDyDJKQBmSzLrjxT(this.f1b7d5726, th);
        }
    }

    public override void OnNext(U u) {
        HqiJWBhSJBwcluki(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ngnmhFARsbhkAqbb(this.f74136b24, p7beea252Var);
    }
}

