namespace WillowMaze.Wasm.Decompiled;


readonly class pddde33a6$p14a4df76$pa5808edd<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    readonly java.util.concurrent.atomic.object f4632a496;
    readonly io.reactivex.rxjava3.core.MaybeObserver f47947b51;
    readonly io.reactivex.rxjava3.core.MaybeObserver f5374c86a;
    readonly java.util.concurrent.atomic.object f5ae9521f;
    readonly java.util.concurrent.atomic.object f79bacc50;
    readonly java.util.concurrent.atomic.object f8c687133;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc5433e57;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    pddde33a6$p14a4df76$pa5808edd(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.fd22a0a80 = maybeObserver;
        this.fd0e45878 = atomicReference;
    }

    public static void AsElzJVJXmsmOiIg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void DmgVEwoFcZqDaKSN(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void OSJoGYUxLwZDyOTb(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool YNUeuOXtqLNwGIeT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void OnComplete() {
        dmgVEwoFcZqDaKSN(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        AsElzJVJXmsmOiIg(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        yNUeuOXtqLNwGIeT(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        oSJoGYUxLwZDyOTb(this.fd22a0a80, t);
    }
}

