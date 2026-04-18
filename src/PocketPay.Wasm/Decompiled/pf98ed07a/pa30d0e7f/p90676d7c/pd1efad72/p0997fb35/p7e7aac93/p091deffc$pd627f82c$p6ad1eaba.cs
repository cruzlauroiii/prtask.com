namespace WillowMaze.Wasm.Decompiled;


readonly class p091deffc$pd627f82c$p6ad1eaba<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    readonly java.util.concurrent.atomic.object f05d98407;
    readonly java.util.concurrent.atomic.object f0bb32a0f;
    readonly java.util.concurrent.atomic.object f459403ea;
    readonly io.reactivex.rxjava3.core.MaybeObserver f488618d3;
    readonly io.reactivex.rxjava3.core.MaybeObserver f573ca3ce;
    readonly io.reactivex.rxjava3.core.MaybeObserver f85e1a3cb;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fe6150c07;
    readonly java.util.concurrent.atomic.object ffaf5c010;

    p091deffc$pd627f82c$p6ad1eaba(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.fd22a0a80 = maybeObserver;
        this.fbc3b0556 = atomicReference;
    }

    public static void AGiGVkuMtfkpgGpg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void CKcwoFsSTKqeUsoQ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool LrkqicQcqbAlYIvZ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void YAVOfvmWiPalltsv(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnComplete() {
        aGiGVkuMtfkpgGpg(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        yAVOfvmWiPalltsv(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        lrkqicQcqbAlYIvZ(this.fbc3b0556, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        cKcwoFsSTKqeUsoQ(this.fd22a0a80, t);
    }
}

