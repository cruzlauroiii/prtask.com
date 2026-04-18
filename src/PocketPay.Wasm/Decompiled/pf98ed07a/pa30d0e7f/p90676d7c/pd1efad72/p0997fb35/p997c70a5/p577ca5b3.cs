namespace WillowMaze.Wasm.Decompiled;


public readonly class p577ca5b3 : io.reactivex.rxjava3.core.Observable<java.lang.long> {
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f537245ed;
    readonly io.reactivex.rxjava3.core.Scheduler f60686d84;
    readonly long f7243f8be;
    readonly java.util.concurrent.TimeUnit f990d545e;
    readonly long fb5d057c3;
    readonly long feb89e497;

    public p577ca5b3(long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void EyYgytHLdZygHRiR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052 p577ca5b3_p17faf052, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p577ca5b3_p17faf052.setResource(p7beea252Var);
    }

    public static void MbmIlhAlspnSvaKo(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 UydPiagelyTBuvKN(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        if ((7 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052 p577ca5b3_p17faf052 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052(observer);
        mbmIlhAlspnSvaKo(observer, p577ca5b3_p17faf052);
        eyYgytHLdZygHRiR(p577ca5b3_p17faf052, uydPiagelyTBuvKN(this.f499f31e7, p577ca5b3_p17faf052, this.f7243f8be, this.f3e34bdeb));
    }
}

