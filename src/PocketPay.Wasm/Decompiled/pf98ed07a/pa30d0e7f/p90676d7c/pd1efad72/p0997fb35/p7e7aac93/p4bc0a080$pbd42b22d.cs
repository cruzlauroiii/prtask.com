namespace WillowMaze.Wasm.Decompiled;


readonly class p4bc0a080$pbd42b22d<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f7982fee8 = 7603343402964826922L;
    private static readonly long fc6e1e520 = 7603343402964826922L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f83c1ee27;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd3b0bcf7;

    p4bc0a080$pbd42b22d(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static void FaIBdXjivPpVhVKm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static void VOEnZqkoBIzzJFnT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4bc0a080$pbd42b22d p4bc0a080_pbd42b22d, java.lang.object obj) {
        p4bc0a080_pbd42b22d.complete(obj);
    }

    public static void BUwEUZczsNbxyVLD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void DFUCxwDNjTcjOJjr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HNBhVpTlYpyOLGtw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void OjMjHnDOKGDhLiWv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool RclHjEonHUKKpyRr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public void Cancel() {
        FaIBdXjivPpVhVKm(this);
        dFUCxwDNjTcjOJjr(this.fbc3b0556);
    }

    public override void OnComplete() {
        ojMjHnDOKGDhLiWv(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        bUwEUZczsNbxyVLD(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (rclHjEonHUKKpyRr(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            hNBhVpTlYpyOLGtw(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        VOEnZqkoBIzzJFnT(this, t);
    }
}

