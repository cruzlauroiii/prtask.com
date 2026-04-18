namespace WillowMaze.Wasm.Decompiled;


readonly class pdd53a422$p0fec7980<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private readonly io.reactivex.rxjava3.core.SingleObserver f4a421af0;
    private readonly io.reactivex.rxjava3.core.SingleObserver f4b3fcbac;
    private readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdd53a422 this$0;

    pdd53a422$p0fec7980(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdd53a422 pdd53a422Var, io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        this.this$0 = pdd53a422Var;
        this.fd22a0a80 = singleObserver;
    }

    public static void DgdRXeluJKuMPXwI(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void IwHSZebHQbuDmhOA(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void JfzumgirTPjEAFsV(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.bool RJrEVHLjLgmiodDG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JpIuCBypXzIJZjYw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool LlqhvYqrdjEaktMM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void OzsjOFbPgSuJujyt(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void OnError(java.lang.Exception th) {
        DgdRXeluJKuMPXwI(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IwHSZebHQbuDmhOA(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((9 + 14) % 14 > 0) {
        }
        try {
            ozsjOFbPgSuJujyt(this.fd22a0a80, RJrEVHLjLgmiodDG(llqhvYqrdjEaktMM(this.this$0.f9f89a861, t, this.this$0.f2063c160)));
        } catch (java.lang.Exception th) {
            jpIuCBypXzIJZjYw(th);
            JfzumgirTPjEAFsV(this.fd22a0a80, th);
        }
    }
}

