namespace WillowMaze.Wasm.Decompiled;


public readonly class p1432991f<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f3cc70d69;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;

    public p1432991f(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(maybeSource);
        this.f499f31e7 = scheduler;
    }

    public static bool MznSZdIwFDLVmEAt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void NmWZxWSCegCXvoRj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 YXGPJAwpCsDKurOb(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((30 + 5) % 5 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1432991f$p718ca250 p1432991f_p718ca250 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1432991f$p718ca250(maybeObserver);
        NmWZxWSCegCXvoRj(maybeObserver, p1432991f_p718ca250);
        MznSZdIwFDLVmEAt(p1432991f_p718ca250.f478f3a4c, yXGPJAwpCsDKurOb(this.f499f31e7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1432991f$ped40debe(p1432991f_p718ca250, this.f36cd38f4)));
    }
}

