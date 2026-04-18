namespace WillowMaze.Wasm.Decompiled;


readonly class p1901bdb3$pa4bce3d6<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    readonly io.reactivex.rxjava3.core.MaybeObserver f02a2ce27;
    readonly java.util.concurrent.atomic.object f30f0e007;
    readonly io.reactivex.rxjava3.core.MaybeObserver f64be44bb;
    readonly io.reactivex.rxjava3.core.MaybeObserver fbad2bf08;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p1901bdb3$pa4bce3d6(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference, io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd0e45878 = atomicReference;
        this.fd22a0a80 = maybeObserver;
    }

    public static bool OhKcqNwoVKmckKbb(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void KUVCPnBQAqgOuKFH(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void ZVRPPRnzGSLhjZjh(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void ZcfdxiqtXqOLikXd(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public override void OnComplete() {
        zcfdxiqtXqOLikXd(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        zVRPPRnzGSLhjZjh(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        OhKcqNwoVKmckKbb(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        kUVCPnBQAqgOuKFH(this.fd22a0a80, t);
    }
}

