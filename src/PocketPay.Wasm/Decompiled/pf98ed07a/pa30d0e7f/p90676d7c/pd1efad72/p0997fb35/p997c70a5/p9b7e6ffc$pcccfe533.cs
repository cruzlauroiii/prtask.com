namespace WillowMaze.Wasm.Decompiled;


readonly class p9b7e6ffc$pcccfe533<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly io.reactivex.rxjava3.core.Observer f378af5bb;
    bool f44b7b715;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f85051ed5;
    readonly io.reactivex.rxjava3.core.Observer fa674ac5d;
    readonly io.reactivex.rxjava3.core.Observer facdff762;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer ff12c31ee;
    readonly io.reactivex.rxjava3.core.ObservableSource ffca9ee5f;
    bool fa2e4822a = true;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f79106d6f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();

    p9b7e6ffc$pcccfe533(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.f795f3202 = observableSource;
    }

    public static void EIyHMAzZdjophrUa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void HJfNMMECiYiGYRcm(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void XZcCiAkaSJrewMiP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool CJVlaWKExKLCidXR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.update(p7beea252Var);
    }

    public static void YXguJbWmckuHrtrs(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void OnComplete() {
        if (!this.fa2e4822a) {
            XZcCiAkaSJrewMiP(this.fd22a0a80);
        } else {
            this.fa2e4822a = false;
            HJfNMMECiYiGYRcm(this.f795f3202, this);
        }
    }

    public override void OnError(java.lang.Exception th) {
        yXguJbWmckuHrtrs(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if (this.fa2e4822a) {
            this.fa2e4822a = false;
        }
        EIyHMAzZdjophrUa(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        cJVlaWKExKLCidXR(this.f79106d6f, p7beea252Var);
    }
}

