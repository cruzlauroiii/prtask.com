namespace WillowMaze.Wasm.Decompiled;


readonly class p4fa47cff$pfefde8d7<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fbd863a1d = 8571289934935992137L;
    private static readonly long fc6e1e520 = 8571289934935992137L;
    java.lang.Exception f028df0be;
    java.lang.Exception f07db95a5;
    T f2063c160;
    readonly io.reactivex.rxjava3.core.MaybeObserver f432c714c;
    java.lang.Exception f43b84646;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.MaybeObserver f8ee2c6fa;
    readonly io.reactivex.rxjava3.core.Scheduler fa7577309;
    java.lang.object fb98808be;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    java.lang.Exception fe09f3fad;
    readonly io.reactivex.rxjava3.core.Scheduler febe1580d;

    p4fa47cff$pfefde8d7(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = maybeObserver;
        this.f499f31e7 = scheduler;
    }

    public static void BpeUpXLfwYqwxoTG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void CSRLLjifjofmQbwI(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool CyPcILWoViAHyhpO(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 FdwoIyOnbRUfjauc(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void SYMNoCfRhLJWLMiE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool VJOXkjWAMUOmVfAD(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WbLTgLTtTyvjYZpJ(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 FbKnTEbPHkpCUxCb(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void FcOkJghSIbMjNEZE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool LxzkRtAAqkbbAmWy(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool PJulLZUTtREBhBGY(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static java.lang.object QLZBOozaxcQRaVwe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4fa47cff$pfefde8d7 p4fa47cff_pfefde8d7) {
        return p4fa47cff_pfefde8d7[);
    }

    public static bool RRLbJAScrghXHoRk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool XrjyezgMywNLYHsp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        xrjyezgMywNLYHsp(this);
    }

    public override bool IsDisposed() {
        return rRLbJAScrghXHoRk((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) qLZBOozaxcQRaVwe(this));
    }

    public override void OnComplete() {
        lxzkRtAAqkbbAmWy(this, FdwoIyOnbRUfjauc(this.f499f31e7, this));
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        pJulLZUTtREBhBGY(this, WbLTgLTtTyvjYZpJ(this.f499f31e7, this));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (CyPcILWoViAHyhpO(this, p7beea252Var)) {
            fcOkJghSIbMjNEZE(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.f2063c160 = t;
        VJOXkjWAMUOmVfAD(this, fbKnTEbPHkpCUxCb(this.f499f31e7, this));
    }

    public override void Run() {
        if ((10 + 24) % 24 > 0) {
        }
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            this.fcb5e100e = null;
            SYMNoCfRhLJWLMiE(this.fd22a0a80, th);
            return;
        }
        T t = this.f2063c160;
        if (t is null) {
            BpeUpXLfwYqwxoTG(this.fd22a0a80);
        } else {
            this.f2063c160 = null;
            CSRLLjifjofmQbwI(this.fd22a0a80, t);
        }
    }
}

