namespace WillowMaze.Wasm.Decompiled;


readonly class p688eca25$pfbe13cef<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fc6e1e520 = 3256698449646456986L;
    private static readonly long fff4889b6 = 3256698449646456986L;
    readonly io.reactivex.rxjava3.core.SingleObserver f3a3a0835;
    readonly io.reactivex.rxjava3.core.Scheduler f3efcc80e;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f52274852;
    readonly io.reactivex.rxjava3.core.Scheduler f600ecf55;
    readonly io.reactivex.rxjava3.core.SingleObserver f6d14199d;
    readonly io.reactivex.rxjava3.core.Scheduler f9eb82166;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fde070849;
    readonly io.reactivex.rxjava3.core.SingleObserver fe847182b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ffcc35fd9;

    p688eca25$pfbe13cef(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = singleObserver;
        this.f499f31e7 = scheduler;
    }

    public static void FxvrtbCchxkxStGb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HJTsyTQxTyWIhifW(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static java.lang.object QRzRQPyFXLvYIHek(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p688eca25$pfbe13cef p688eca25_pfbe13cef) {
        return p688eca25_pfbe13cef[);
    }

    public static void WtHmCVHjFxRURQxB(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool BfvKnPwIfjaqRhyV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object KefrqnKsPHQCgcwD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p688eca25$pfbe13cef p688eca25_pfbe13cef, java.lang.object obj) {
        return p688eca25_pfbe13cef.getAndHashSet(obj);
    }

    public static void NKiknwIDDHNwYZDs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void UgfMnVWTUSwmeaND(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool XAjgXFXEHdUbtVaK(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        if ((6 + 1) % 1 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) kefrqnKsPHQCgcwD(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8);
        if (p7beea252Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        this.f52274852 = p7beea252Var;
        HJTsyTQxTyWIhifW(this.f499f31e7, this);
    }

    public override bool IsDisposed() {
        return bfvKnPwIfjaqRhyV((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) QRzRQPyFXLvYIHek(this));
    }

    public override void OnError(java.lang.Exception th) {
        FxvrtbCchxkxStGb(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (xAjgXFXEHdUbtVaK(this, p7beea252Var)) {
            WtHmCVHjFxRURQxB(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        ugfMnVWTUSwmeaND(this.fd22a0a80, t);
    }

    public override void Run() {
        nKiknwIDDHNwYZDs(this.f52274852);
    }
}

