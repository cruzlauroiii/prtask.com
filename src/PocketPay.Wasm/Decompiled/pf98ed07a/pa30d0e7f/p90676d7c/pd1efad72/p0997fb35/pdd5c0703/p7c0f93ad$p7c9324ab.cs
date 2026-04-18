namespace WillowMaze.Wasm.Decompiled;


readonly class p7c0f93ad$p7c9324ab<R> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    readonly io.reactivex.rxjava3.core.MaybeObserver f60be4ef8;
    readonly io.reactivex.rxjava3.core.MaybeObserver f63e4b4d1;
    readonly java.util.concurrent.atomic.object f73fefded;
    readonly java.util.concurrent.atomic.object f8a979a44;
    readonly io.reactivex.rxjava3.core.MaybeObserver f9d5a6e69;
    readonly java.util.concurrent.atomic.object fa0c1187e;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    readonly java.util.concurrent.atomic.object fd8c17302;

    p7c0f93ad$p7c9324ab(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference, io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        this.fd0e45878 = atomicReference;
        this.fd22a0a80 = maybeObserver;
    }

    public static bool AcdOcASsUBqyCjOY(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void LurHkoettgZObdUQ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void RdLqoNGxhEBjKpqD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void UcZLgmalIHSMUdwS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public override void OnComplete() {
        UcZLgmalIHSMUdwS(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        LurHkoettgZObdUQ(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        AcdOcASsUBqyCjOY(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        RdLqoNGxhEBjKpqD(this.fd22a0a80, r);
    }
}

