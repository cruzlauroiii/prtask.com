namespace WillowMaze.Wasm.Decompiled;


readonly class p1513144b$p1b6b5d9e$p5825d198<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R> {
    private static readonly long f9a0fed24 = -3051469169682093892L;
    private static readonly long fa57754c3 = -3051469169682093892L;
    private static readonly long fb15416eb = -3051469169682093892L;
    private static readonly long fc6e1e520 = -3051469169682093892L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e f215520b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e fa8f08dac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e fb8420598;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionarySingle$ConcatDictionarySingleMainObserver<object, R> fd0e45878;

    p1513144b$p1b6b5d9e$p5825d198(io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionarySingle$ConcatDictionarySingleMainObserver<object, R> observableConcatDictionarySingle$ConcatDictionarySingleMainObserver) {
        this.fd0e45878 = observableConcatDictionarySingle$ConcatDictionarySingleMainObserver;
    }

    public static bool MaNKcAcZzKdrZgHk(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void SZvmDothfrXgoLTi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e, java.lang.object obj) {
        p1513144b_p1b6b5d9e.innerSuccess(obj);
    }

    public static void ACaNumCQfkZMSCFX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e, java.lang.Exception th) {
        p1513144b_p1b6b5d9e.innerError(th);
    }

    public static bool YKcjmfkeYDAMHWOc(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    void dispose() {
        MaNKcAcZzKdrZgHk(this);
    }

    public override void OnError(java.lang.Exception th) {
        aCaNumCQfkZMSCFX(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        yKcjmfkeYDAMHWOc(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        SZvmDothfrXgoLTi(this.fd0e45878, r);
    }
}

