namespace WillowMaze.Wasm.Decompiled;


readonly class pddde33a6$p14a4df76<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f08eb333f = -2223459372976438024L;
    private static readonly long fc6e1e520 = -2223459372976438024L;
    private static readonly long fccc12add = -2223459372976438024L;
    private static readonly long ff7a1fc4b = -2223459372976438024L;
    private static readonly long ffff29f9a = -2223459372976438024L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1fd3253b;
    readonly io.reactivex.rxjava3.core.MaybeObserver f3a9b5c55;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource f92657cb2;
    readonly io.reactivex.rxjava3.core.MaybeObserver fa9050526;
    readonly io.reactivex.rxjava3.core.MaybeSource fa9cc0010;
    readonly io.reactivex.rxjava3.core.MaybeSource fb00dd087;
    readonly io.reactivex.rxjava3.core.MaybeSource fbdf999c5;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    pddde33a6$p14a4df76(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        this.fd22a0a80 = maybeObserver;
        this.f795f3202 = maybeSource;
    }

    public static bool BBnmFEzZrBgkxkEg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool BYLYuxMAWjnQhCCZ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object MwEkuuOqGcFYHoks(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pddde33a6$p14a4df76 pddde33a6_p14a4df76) {
        return pddde33a6_p14a4df76[);
    }

    public static java.lang.object WQVSmktmYZNbBJZw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pddde33a6$p14a4df76 pddde33a6_p14a4df76) {
        return pddde33a6_p14a4df76[);
    }

    public static bool EZzExOLzFJCCFVdR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void FuCHfDevmqNNKxfY(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void SjktVIWDwZBIfFoS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool SrxDSOPGbIdynfto(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pddde33a6$p14a4df76 pddde33a6_p14a4df76, java.lang.object obj, java.lang.object obj2) {
        return pddde33a6_p14a4df76.compareAndHashSet(obj, obj2);
    }

    public static void TLQDZiLXjNqTbWhG(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void XARHgZChKnUGEhva(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        eZzExOLzFJCCFVdR(this);
    }

    public override bool IsDisposed() {
        return BBnmFEzZrBgkxkEg((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) WQVSmktmYZNbBJZw(this));
    }

    public override void OnComplete() {
        if ((22 + 9) % 9 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) MwEkuuOqGcFYHoks(this);
        if (p7beea252Var != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8 && srxDSOPGbIdynfto(this, p7beea252Var, null)) {
            tLQDZiLXjNqTbWhG(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pddde33a6$p14a4df76$pa5808edd(this.fd22a0a80, this));
        }
    }

    public override void OnError(java.lang.Exception th) {
        xARHgZChKnUGEhva(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (BYLYuxMAWjnQhCCZ(this, p7beea252Var)) {
            sjktVIWDwZBIfFoS(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        fuCHfDevmqNNKxfY(this.fd22a0a80, t);
    }
}

