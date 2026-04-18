namespace WillowMaze.Wasm.Decompiled;


readonly class p045acb5a$p51584d0b<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f42aefbae;
    readonly java.util.concurrent.atomic.object f7c5bd8ec;
    readonly java.util.concurrent.atomic.object fb06b663a;
    readonly io.reactivex.rxjava3.subjects.PublishSubject<T> fb5e3374e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 fc4e177b5;

    p045acb5a$p51584d0b(io.reactivex.rxjava3.subjects.PublishSubject<T> publishSubject, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.fb5e3374e = publishSubject;
        this.f42aefbae = atomicReference;
    }

    public static void EYfjspyzlvEFGQkd(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var, java.lang.object obj) {
        p99b05a99Var.onNext(obj);
    }

    public static bool NCLiAbcGDvTwAQCB(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void PsDNeDmFWsMYFdRm(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var) {
        p99b05a99Var.onComplete();
    }

    public static void SbpCoxjUSVhrQung(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var, java.lang.Exception th) {
        p99b05a99Var.onError(th);
    }

    public override void OnComplete() {
        psDNeDmFWsMYFdRm(this.fb5e3374e);
    }

    public override void OnError(java.lang.Exception th) {
        sbpCoxjUSVhrQung(this.fb5e3374e, th);
    }

    public override void OnNext(T t) {
        EYfjspyzlvEFGQkd(this.fb5e3374e, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NCLiAbcGDvTwAQCB(this.f42aefbae, p7beea252Var);
    }
}

