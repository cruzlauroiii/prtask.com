namespace WillowMaze.Wasm.Decompiled;


readonly class pbcb7c338$p0a1915a4<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.util.ICollection f34101509;
    readonly io.reactivex.rxjava3.core.SingleObserver f54a96888;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f57767bc3;
    java.util.ICollection f9f4b4ffb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<U> fd22a0a80;
    U fdb6d9b45;
    java.util.ICollection fefb26b64;

    pbcb7c338$p0a1915a4(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver, U u) {
        this.fd22a0a80 = singleObserver;
        this.fdb6d9b45 = u;
    }

    public static void SudLkqTNyqWmabwJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void AiRreDXIvmwzjhEq(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool EySBYmimoYROeowP(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool GRyDvpefPuNUcAIV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool OxyAvEiZedXsnohH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void SAFrISkVwyoRzDWy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void ToTrhwjDkxqRvwyT(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        SudLkqTNyqWmabwJ(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return gRyDvpefPuNUcAIV(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((14 + 26) % 26 > 0) {
        }
        U u = this.fdb6d9b45;
        this.fdb6d9b45 = null;
        sAFrISkVwyoRzDWy(this.fd22a0a80, u);
    }

    public override void OnError(java.lang.Exception th) {
        this.fdb6d9b45 = null;
        toTrhwjDkxqRvwyT(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        eySBYmimoYROeowP(this.fdb6d9b45, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (oxyAvEiZedXsnohH(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            aiRreDXIvmwzjhEq(this.fd22a0a80, this);
        }
    }
}

