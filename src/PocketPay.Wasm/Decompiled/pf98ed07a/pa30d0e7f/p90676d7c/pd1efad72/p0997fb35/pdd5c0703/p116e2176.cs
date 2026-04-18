namespace WillowMaze.Wasm.Decompiled;


public readonly class p116e2176<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly java.util.concurrent.Func f08f7447c;
    readonly java.util.concurrent.Func f6533e5fe;
    readonly java.util.concurrent.Func<? : T> f765d2ec9;
    readonly java.util.concurrent.Func f7f9b1846;
    readonly java.util.concurrent.Func fdfbb173b;

    public p116e2176(java.util.concurrent.Func<? : T> callable) {
        this.f765d2ec9 = callable;
    }

    public static bool FbhNiXTYYRugcGwX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void KjzBXnjHWEOMgSsJ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void PiAjCgtfORLAhtam(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QOqlFvQyTxPmAQCV(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool WyNmHZxaReRepHQw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 YNSznbBXqrcaKegp() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void IsGZFdHmSYYcnwmy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object JHCIueNcgfOqHGKF(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void LpBuOfpjtxsOpRbY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object PjIFkpHyOVLAZIBC(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static bool RSQkSNOWUBBNhkSN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((3 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarYNSznbBXqrcaKegp = YNSznbBXqrcaKegp();
        QOqlFvQyTxPmAQCV(singleObserver, p7beea252VarYNSznbBXqrcaKegp);
        if (FbhNiXTYYRugcGwX(p7beea252VarYNSznbBXqrcaKegp)) {
            return;
        }
        try {
            java.lang.object objJHCIueNcgfOqHGKF = jHCIueNcgfOqHGKF(pjIFkpHyOVLAZIBC(this.f765d2ec9), "The callable returned a null value");
            if (WyNmHZxaReRepHQw(p7beea252VarYNSznbBXqrcaKegp)) {
                return;
            }
            KjzBXnjHWEOMgSsJ(singleObserver, objJHCIueNcgfOqHGKF);
        } catch (java.lang.Exception th) {
            PiAjCgtfORLAhtam(th);
            if (rSQkSNOWUBBNhkSN(p7beea252VarYNSznbBXqrcaKegp)) {
                lpBuOfpjtxsOpRbY(th);
            } else {
                isGZFdHmSYYcnwmy(singleObserver, th);
            }
        }
    }
}

