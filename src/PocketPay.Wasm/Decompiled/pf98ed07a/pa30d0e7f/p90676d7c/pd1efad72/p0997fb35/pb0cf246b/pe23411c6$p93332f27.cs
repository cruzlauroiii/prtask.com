namespace WillowMaze.Wasm.Decompiled;


public readonly class pe23411c6$p93332f27<T> : io.reactivex.rxjava3.internal.fuseable.AbstractEmptyQueueFuseable<T> : io.reactivex.rxjava3.core.CompletableObserver {
    readonly p5a445d71.p18f29add.p992c4a5b f8487625f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc1507683;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd04f560a;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    public pe23411c6$p93332f27(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void ChNWnxrkYzKpkmXf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool EhkxpUYcCVOgGqvI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LRqghWSkPTBAHoGW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void NoNFsOczGgxpnURa(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WbAYDPCsQGWyMkhA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void Cancel() {
        ChNWnxrkYzKpkmXf(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        wbAYDPCsQGWyMkhA(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        LRqghWSkPTBAHoGW(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EhkxpUYcCVOgGqvI(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            noNFsOczGgxpnURa(this.fd22a0a80, this);
        }
    }
}

