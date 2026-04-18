namespace WillowMaze.Wasm.Decompiled;


public readonly class p550d897b<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f6aec8173;
    readonly io.reactivex.rxjava3.core.Scheduler f7212b9a6;
    readonly io.reactivex.rxjava3.core.SingleSource fea53df6d;

    public p550d897b(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f36cd38f4 = singleSource;
        this.f499f31e7 = scheduler;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 UznFtjwOMwxgXRjX(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void VLiKYbnnnsrCewAX(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool PUOceYPIOuHnIFrk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((7 + 32) % 32 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p550d897b$pa453bafa p550d897b_pa453bafa = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p550d897b$pa453bafa(singleObserver, this.f36cd38f4);
        VLiKYbnnnsrCewAX(singleObserver, p550d897b_pa453bafa);
        pUOceYPIOuHnIFrk(p550d897b_pa453bafa.f478f3a4c, UznFtjwOMwxgXRjX(this.f499f31e7, p550d897b_pa453bafa));
    }
}

