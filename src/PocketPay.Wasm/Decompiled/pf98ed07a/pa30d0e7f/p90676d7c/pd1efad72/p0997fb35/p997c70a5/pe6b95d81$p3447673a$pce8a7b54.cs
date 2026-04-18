namespace WillowMaze.Wasm.Decompiled;


readonly class pe6b95d81$p3447673a$pce8a7b54<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81$p3447673a this$1;

    pe6b95d81$p3447673a$pce8a7b54(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81$p3447673a pe6b95d81_p3447673a) {
        this.this$1 = pe6b95d81_p3447673a;
    }

    public static void UeXPVuwkFZaHtGLg(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void ATJCPAYloZGvvHFS(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool HnDSybJJjSinrBIp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.update(p7beea252Var);
    }

    public static void LxjeWIbqfGOtobGs(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void OnComplete() {
        UeXPVuwkFZaHtGLg(this.this$1.f1b7d5726);
    }

    public override void OnError(java.lang.Exception th) {
        aTJCPAYloZGvvHFS(this.this$1.f1b7d5726, th);
    }

    public override void OnNext(T t) {
        lxjeWIbqfGOtobGs(this.this$1.f1b7d5726, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        hnDSybJJjSinrBIp(this.this$1.f74136b24, p7beea252Var);
    }
}

