namespace WillowMaze.Wasm.Decompiled;


public readonly class p136ea8dd<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> f6906652a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f8f9b4ad8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f9ce3a8b3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fb078d76d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fec1e64e1;

    public p136ea8dd(io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> supplier) {
        this.f6906652a = supplier;
    }

    public static java.lang.object CFhTgzlnwGHsAWBS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object ONNywyxqDsXCyWLM(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void UBpIkxyQiXauhJPv(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void CBONPnHqevTuVUEE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        try {
            th = (java.lang.Exception) ONNywyxqDsXCyWLM(CFhTgzlnwGHsAWBS(this.f6906652a), "Func returned a null Exception.");
        } catch (java.lang.Exception th) {
            th = th;
            cBONPnHqevTuVUEE(th);
        }
        UBpIkxyQiXauhJPv(th, subscriber);
    }
}

