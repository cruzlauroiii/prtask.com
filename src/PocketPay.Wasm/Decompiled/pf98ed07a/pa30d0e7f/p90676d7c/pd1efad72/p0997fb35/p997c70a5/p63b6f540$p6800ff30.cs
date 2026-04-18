namespace WillowMaze.Wasm.Decompiled;


readonly class p63b6f540$p6800ff30<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1cb42c69;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3c124207;
    T f447b7147;
    java.lang.object f8b660717;
    readonly io.reactivex.rxjava3.core.MaybeObserver faffe16af;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fcc25f943;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fe044c8a0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fef21eb93;

    p63b6f540$p6800ff30(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void GlhPgJozJhQgGHxh(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void HhceulAeoFhwCQIs(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void ShdyiscnWjBComtK(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void OprhcxmgJehNabzx(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool SUFnUmaKHxfLTcyW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void UjClRvintfPEkLZr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        ujClRvintfPEkLZr(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void OnComplete() {
        if ((18 + 21) % 21 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        T t = this.f447b7147;
        if (t is null) {
            GlhPgJozJhQgGHxh(this.fd22a0a80);
        } else {
            this.f447b7147 = null;
            ShdyiscnWjBComtK(this.fd22a0a80, t);
        }
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        this.f447b7147 = null;
        HhceulAeoFhwCQIs(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        this.f447b7147 = t;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (sUFnUmaKHxfLTcyW(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            oprhcxmgJehNabzx(this.fd22a0a80, this);
        }
    }
}

