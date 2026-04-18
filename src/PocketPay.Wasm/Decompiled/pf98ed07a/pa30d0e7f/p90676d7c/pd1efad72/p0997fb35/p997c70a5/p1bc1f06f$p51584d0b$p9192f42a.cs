namespace WillowMaze.Wasm.Decompiled;


readonly class p1bc1f06f$p51584d0b$p9192f42a<U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<U> {
    private static readonly long f684c09a4 = -7449079488798789337L;
    private static readonly long f74edb163 = -7449079488798789337L;
    private static readonly long f8fa42192 = -7449079488798789337L;
    private static readonly long fc6e1e520 = -7449079488798789337L;
    private static readonly long fc8d3f0ac = -7449079488798789337L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b faea5860f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b fbaa750d1;
    readonly io.reactivex.rxjava3.core.Observer fbdb8fe14;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$SourceObserver<object, object> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;

    p1bc1f06f$p51584d0b$p9192f42a(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$SourceObserver<object, object> observableConcatDictionary$SourceObserver) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = observableConcatDictionary$SourceObserver;
    }

    public static void KREssmkQpJZTPjVV(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void LLfUMlFUWIjgAlEc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.innerComplete();
    }

    public static bool XufsqmcpGVHnkcBo(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void ZqWszMiCSNSfomTX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.dispose();
    }

    public static bool GdMzZGURGTzbgwAH(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void MNTmQHRYrwJXXwCl(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    void dispose() {
        gdMzZGURGTzbgwAH(this);
    }

    public override void OnComplete() {
        LLfUMlFUWIjgAlEc(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        ZqWszMiCSNSfomTX(this.fd0e45878);
        KREssmkQpJZTPjVV(this.fd22a0a80, th);
    }

    public override void OnNext(U u) {
        mNTmQHRYrwJXXwCl(this.fd22a0a80, u);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XufsqmcpGVHnkcBo(this, p7beea252Var);
    }
}

