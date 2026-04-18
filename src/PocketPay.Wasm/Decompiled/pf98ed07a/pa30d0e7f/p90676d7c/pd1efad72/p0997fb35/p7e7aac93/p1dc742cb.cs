namespace WillowMaze.Wasm.Decompiled;


public readonly class p1dc742cb<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly java.util.concurrent.TimeUnit f24e8d150;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.Task f45accc31;
    readonly long f90272dda;
    readonly long fc046ab35;
    readonly java.util.concurrent.Task<? : T> fda907a1b;
    readonly long ffd5052d6;

    public p1dc742cb(java.util.concurrent.Task<? : T> future, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.fda907a1b = future;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
    }

    public static java.lang.object KnVEFaXIvMGqhyQk(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit) {
        return future[j, timeUnit);
    }

    public static bool NQemyActLTEpTiBz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void TucbYFmTNmHuiOkA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void UQlAINTyoKPmZViS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object AnowxFcHVHoDQoXr(java.util.concurrent.Task future) {
        return future[);
    }

    public static void BzGagLZyzWnrlwAq(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static java.lang.Exception FIBrnFglVqkjukNZ(java.lang.Exception th) {
        return th.getCause();
    }

    public static void FXHPksOahUugYcJV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HuzNkuFEEWDSBFRV() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static bool IlNIjAJVBxhddTLD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool IuzoXBGoEHsIfxYK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void MYPXcCmdlLtCIeGU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void REDtFaXsSsgnwMLm(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((15 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarHuzNkuFEEWDSBFRV = huzNkuFEEWDSBFRV();
        rEDtFaXsSsgnwMLm(maybeObserver, p7beea252VarHuzNkuFEEWDSBFRV);
        if (NQemyActLTEpTiBz(p7beea252VarHuzNkuFEEWDSBFRV)) {
            return;
        }
        try {
            long j = this.f90272dda;
            java.lang.object objAnowxFcHVHoDQoXr = j <= 0 ? anowxFcHVHoDQoXr(this.fda907a1b) : KnVEFaXIvMGqhyQk(this.fda907a1b, j, this.f3e34bdeb);
            if (iuzoXBGoEHsIfxYK(p7beea252VarHuzNkuFEEWDSBFRV)) {
                return;
            }
            if (objAnowxFcHVHoDQoXr is not null) {
                bzGagLZyzWnrlwAq(maybeObserver, objAnowxFcHVHoDQoXr);
            } else {
                mYPXcCmdlLtCIeGU(maybeObserver);
            }
        } catch (java.lang.Exception th) {
            th = th;
            TucbYFmTNmHuiOkA(th);
            if (th is java.util.concurrent.ExecutionException) {
                th = fIBrnFglVqkjukNZ(th);
            }
            fXHPksOahUugYcJV(th);
            if (ilNIjAJVBxhddTLD(p7beea252VarHuzNkuFEEWDSBFRV)) {
                return;
            }
            UQlAINTyoKPmZViS(maybeObserver, th);
        }
    }
}

