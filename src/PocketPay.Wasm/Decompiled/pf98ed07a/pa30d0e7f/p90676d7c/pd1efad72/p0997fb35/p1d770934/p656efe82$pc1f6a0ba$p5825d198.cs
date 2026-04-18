namespace WillowMaze.Wasm.Decompiled;


readonly class p656efe82$pc1f6a0ba$p5825d198<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R> {
    private static readonly long f63c10d42 = -3051469169682093892L;
    private static readonly long f91849003 = -3051469169682093892L;
    private static readonly long faa6269c0 = -3051469169682093892L;
    private static readonly long fbf876108 = -3051469169682093892L;
    private static readonly long fc6e1e520 = -3051469169682093892L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba f33c92ecb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba f96fb1b52;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba faee0c9ff;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionarySingle$ConcatDictionarySingleSubscriber<object, R> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba fd580bf12;

    p656efe82$pc1f6a0ba$p5825d198(io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionarySingle$ConcatDictionarySingleSubscriber<object, R> flowableConcatDictionarySingle$ConcatDictionarySingleSubscriber) {
        this.fd0e45878 = flowableConcatDictionarySingle$ConcatDictionarySingleSubscriber;
    }

    public static bool TMRPSRKFbINxudwJ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool ZzdYOcvGGHrpMxeg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void BUDxbHkywenddjGo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba p656efe82_pc1f6a0ba, java.lang.object obj) {
        p656efe82_pc1f6a0ba.innerSuccess(obj);
    }

    public static void QoqzXGpNgJDsFNzU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba p656efe82_pc1f6a0ba, java.lang.Exception th) {
        p656efe82_pc1f6a0ba.innerError(th);
    }

    void dispose() {
        TMRPSRKFbINxudwJ(this);
    }

    public override void OnError(java.lang.Exception th) {
        qoqzXGpNgJDsFNzU(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ZzdYOcvGGHrpMxeg(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        bUDxbHkywenddjGo(this.fd0e45878, r);
    }
}

