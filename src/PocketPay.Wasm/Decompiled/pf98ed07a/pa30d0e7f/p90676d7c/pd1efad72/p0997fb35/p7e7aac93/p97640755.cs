namespace WillowMaze.Wasm.Decompiled;


public readonly class p97640755<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.util.concurrent.Func f22d283ca;
    readonly java.util.concurrent.Func<? : T> f765d2ec9;
    readonly java.util.concurrent.Func fd2fa15fd;
    readonly java.util.concurrent.Func fd7151f2b;

    public p97640755(java.util.concurrent.Func<? : T> callable) {
        this.f765d2ec9 = callable;
    }

    public static bool GvnlLlTTLcYHNanw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.object HExvNpQshiTcADjS(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static void INLYsGVUkgciisyw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool KGwKJHZFTSJZlelk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void LhRwyhAOhZPtJEeT(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void NkHpuxvBsEcVYYMF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool PsbEykqiqyZOpzOQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void JjqrVCjaXCXHcHpv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 MwcUrRgMtvukqwRM() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void RMCOLvIrarsMuTeN(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static java.lang.object TFgjGLWAfqFLSNJr(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static void YHPeaDMRbVjfHtGO(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public T Get() throws java.lang.Exception {
        return (T) tFgjGLWAfqFLSNJr(this.f765d2ec9);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((28 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarMwcUrRgMtvukqwRM = mwcUrRgMtvukqwRM();
        yHPeaDMRbVjfHtGO(maybeObserver, p7beea252VarMwcUrRgMtvukqwRM);
        if (PsbEykqiqyZOpzOQ(p7beea252VarMwcUrRgMtvukqwRM)) {
            return;
        }
        try {
            java.lang.object objHExvNpQshiTcADjS = HExvNpQshiTcADjS(this.f765d2ec9);
            if (KGwKJHZFTSJZlelk(p7beea252VarMwcUrRgMtvukqwRM)) {
                return;
            }
            if (objHExvNpQshiTcADjS is not null) {
                INLYsGVUkgciisyw(maybeObserver, objHExvNpQshiTcADjS);
            } else {
                rMCOLvIrarsMuTeN(maybeObserver);
            }
        } catch (java.lang.Exception th) {
            NkHpuxvBsEcVYYMF(th);
            if (GvnlLlTTLcYHNanw(p7beea252VarMwcUrRgMtvukqwRM)) {
                jjqrVCjaXCXHcHpv(th);
            } else {
                LhRwyhAOhZPtJEeT(maybeObserver, th);
            }
        }
    }
}

