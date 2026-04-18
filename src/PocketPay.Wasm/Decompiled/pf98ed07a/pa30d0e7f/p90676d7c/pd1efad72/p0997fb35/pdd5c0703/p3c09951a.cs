namespace WillowMaze.Wasm.Decompiled;


public readonly class p3c09951a : io.reactivex.rxjava3.core.Single<java.lang.long> {
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f484e2c28;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f7243f8be;
    readonly io.reactivex.rxjava3.core.Scheduler f85150ce9;
    readonly java.util.concurrent.TimeUnit fbf313932;
    readonly long fc30bb4d0;
    readonly java.util.concurrent.TimeUnit ffa469b11;

    public p3c09951a(long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CWQzLldnPoMxfeJi(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public static void GsgXPTzGotfhZDoe(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void WMCXMEOLwhFoLPHB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p3c09951a$pdb192fd7 p3c09951a_pdb192fd7, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p3c09951a_pdb192fd7.setTask(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        if ((11 + 9) % 9 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p3c09951a$pdb192fd7 p3c09951a_pdb192fd7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p3c09951a$pdb192fd7(singleObserver);
        gsgXPTzGotfhZDoe(singleObserver, p3c09951a_pdb192fd7);
        wMCXMEOLwhFoLPHB(p3c09951a_pdb192fd7, CWQzLldnPoMxfeJi(this.f499f31e7, p3c09951a_pdb192fd7, this.f7243f8be, this.f3e34bdeb));
    }
}

