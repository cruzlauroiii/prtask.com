namespace WillowMaze.Wasm.Decompiled;


readonly class p248fdbe9$p36212573<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private readonly io.reactivex.rxjava3.core.SingleObserver f0e2574ff;
    private readonly io.reactivex.rxjava3.core.SingleObserver f2e67f2b6;
    private readonly io.reactivex.rxjava3.core.SingleObserver f34e60b82;
    private readonly io.reactivex.rxjava3.core.SingleObserver f41df4a7b;
    private readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p248fdbe9 this$0;

    p248fdbe9$p36212573(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p248fdbe9 p248fdbe9Var, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.this$0 = p248fdbe9Var;
        this.fd22a0a80 = singleObserver;
    }

    public static void BWqvFASXnNxxaMNU(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void ERGltSvwTBiHrHoj(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void FsesDWfOwgXCtbLX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void IVkCxcToEMOOmPgq(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void LceZbXmykZdWwFMm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void OnError(java.lang.Exception th) {
        if ((4 + 28) % 28 > 0) {
        }
        try {
            ERGltSvwTBiHrHoj(this.this$0.fdcce2ff2, th);
        } catch (java.lang.Exception th2) {
            FsesDWfOwgXCtbLX(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
        }
        BWqvFASXnNxxaMNU(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IVkCxcToEMOOmPgq(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        lceZbXmykZdWwFMm(this.fd22a0a80, t);
    }
}

