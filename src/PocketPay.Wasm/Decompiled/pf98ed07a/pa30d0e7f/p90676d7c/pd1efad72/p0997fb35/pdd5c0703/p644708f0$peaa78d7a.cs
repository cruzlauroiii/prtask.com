namespace WillowMaze.Wasm.Decompiled;


readonly class p644708f0$peaa78d7a<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0b8972cb;
    readonly io.reactivex.rxjava3.core.SingleObserver f5b9f6b30;
    readonly io.reactivex.rxjava3.core.SingleObserver f628fee10;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver fcba693b1;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p644708f0$peaa78d7a(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static bool BjHBkWPeFfEsJEMJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void HFLArNRNwxTnAlUD(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void HOpCSvxaqiQMUXge(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool ISrJwjyJRVZStLre(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void KPdkoemqTyJvSkdk(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void TzgogUCxwGXoAZgM(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        HOpCSvxaqiQMUXge(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return BjHBkWPeFfEsJEMJ(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        tzgogUCxwGXoAZgM(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (iSrJwjyJRVZStLre(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            HFLArNRNwxTnAlUD(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        kPdkoemqTyJvSkdk(this.fd22a0a80, t);
    }
}

