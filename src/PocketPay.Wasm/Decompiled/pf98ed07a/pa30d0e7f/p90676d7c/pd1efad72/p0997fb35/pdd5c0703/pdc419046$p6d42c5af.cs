namespace WillowMaze.Wasm.Decompiled;


readonly class pdc419046$p6d42c5af<T> : io.reactivex.rxjava3.internal.observers.DeferredScalarDisposable<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f3debf529 = 3786543492451018833L;
    private static readonly long f444db49d = 3786543492451018833L;
    private static readonly long f7b92390c = 3786543492451018833L;
    private static readonly long fc6e1e520 = 3786543492451018833L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5963dcc1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;

    pdc419046$p6d42c5af(io.reactivex.rxjava3.core.Observer<T> observer) {
        super(observer);
    }

    public static void EHedLOfYXAwQqizx(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void QMRLpgOvTtYcLbXd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdc419046$p6d42c5af pdc419046_p6d42c5af, java.lang.Exception th) {
        pdc419046_p6d42c5af.error(th);
    }

    public static void WYLmKivecbZBzuZn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdc419046$p6d42c5af pdc419046_p6d42c5af, java.lang.object obj) {
        pdc419046_p6d42c5af.complete(obj);
    }

    public static bool MoDWjMjgpaDvcynW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void WddbguCAsecWJMbs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void YGZQYkeYhEQDsSyk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        super.dispose();
    }

    public void Dispose() {
        yGZQYkeYhEQDsSyk(this);
        wddbguCAsecWJMbs(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        QMRLpgOvTtYcLbXd(this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (moDWjMjgpaDvcynW(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            EHedLOfYXAwQqizx(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        WYLmKivecbZBzuZn(this, t);
    }
}

