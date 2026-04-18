namespace WillowMaze.Wasm.Decompiled;


public readonly class p6c7f344b : io.reactivex.rxjava3.core.Maybe<java.lang.long> {
    readonly io.reactivex.rxjava3.core.Scheduler f25b3981c;
    readonly long f3928cfd8;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f65a06f1f;
    readonly long f7243f8be;
    readonly java.util.concurrent.TimeUnit fa7bcfa9e;
    readonly java.util.concurrent.TimeUnit fc3b99a98;
    readonly long fcb1ad794;
    readonly io.reactivex.rxjava3.core.Scheduler fce205d0e;
    readonly java.util.concurrent.TimeUnit fde3564d0;
    readonly io.reactivex.rxjava3.core.Scheduler ff1dc936f;

    public p6c7f344b(long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void AQhtApWDfiPlKsRi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void RmOVMMDdybKlaUYo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p6c7f344b$pdb192fd7 p6c7f344b_pdb192fd7, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p6c7f344b_pdb192fd7.setTask(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RmbybgupQPfbKDXy(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<java.lang.long> maybeObserver) {
        if ((23 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p6c7f344b$pdb192fd7 p6c7f344b_pdb192fd7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p6c7f344b$pdb192fd7(maybeObserver);
        AQhtApWDfiPlKsRi(maybeObserver, p6c7f344b_pdb192fd7);
        RmOVMMDdybKlaUYo(p6c7f344b_pdb192fd7, rmbybgupQPfbKDXy(this.f499f31e7, p6c7f344b_pdb192fd7, this.f7243f8be, this.f3e34bdeb));
    }
}

