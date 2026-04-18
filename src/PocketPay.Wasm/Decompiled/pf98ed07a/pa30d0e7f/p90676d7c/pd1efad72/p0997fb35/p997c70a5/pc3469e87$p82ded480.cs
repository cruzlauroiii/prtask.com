namespace WillowMaze.Wasm.Decompiled;


readonly class pc3469e87$p82ded480<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly java.util.concurrent.atomic.object f422b6b0e;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f79106d6f;
    readonly java.util.concurrent.atomic.object f8a6f73bf;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fe17ffab2;
    readonly java.util.concurrent.atomic.object fee03cb51;

    pc3469e87$p82ded480(io.reactivex.rxjava3.core.Observer<T> observer, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.fd22a0a80 = observer;
        this.f79106d6f = atomicReference;
    }

    public static void HCEEGitgSPlRnnir(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void IFvoWsgdLLkQwEYK(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool NbnPSPJstvXVGsAG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void OjDyCKqMFcARbAUo(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void OnComplete() {
        IFvoWsgdLLkQwEYK(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        HCEEGitgSPlRnnir(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        ojDyCKqMFcARbAUo(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NbnPSPJstvXVGsAG(this.f79106d6f, p7beea252Var);
    }
}

