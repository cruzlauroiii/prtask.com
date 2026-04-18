namespace WillowMaze.Wasm.Decompiled;


public readonly class p161f90f2<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.lang.Action f67c155d5;
    readonly java.lang.Action fa53108f7;
    readonly java.lang.Action fc660c648;

    public p161f90f2(java.lang.Action runnable) {
        this.fa53108f7 = runnable;
    }

    public static void BtSPhpFBvVtXWUNw(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool DzpPjdQiXtkBrMpR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static bool JDobOUrRnVVTGQea(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void JjEFrpyxyBEhnyck(java.lang.Action runnable) {
        runnable.run();
    }

    public static void MKMvrKeSfFPgKTjw(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void WtsjyFbPyUFbKSKA(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void LsdgtdJmoWIhLcst(java.lang.Action runnable) {
        runnable.run();
    }

    public static void SrZBpaoQRbnUsyOg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool SwRAgjGxNbuNMZPD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void WVlSfAiHOxxjEVNW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public T Get() throws java.lang.Exception {
        lsdgtdJmoWIhLcst(this.fa53108f7);
        return null;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((4 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025();
        MKMvrKeSfFPgKTjw(observer, p9ec25025Var);
        if (swRAgjGxNbuNMZPD(p9ec25025Var)) {
            return;
        }
        try {
            JjEFrpyxyBEhnyck(this.fa53108f7);
            if (DzpPjdQiXtkBrMpR(p9ec25025Var)) {
                return;
            }
            WtsjyFbPyUFbKSKA(observer);
        } catch (java.lang.Exception th) {
            wVlSfAiHOxxjEVNW(th);
            if (JDobOUrRnVVTGQea(p9ec25025Var)) {
                srZBpaoQRbnUsyOg(th);
            } else {
                BtSPhpFBvVtXWUNw(observer, th);
            }
        }
    }
}

