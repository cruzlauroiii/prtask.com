namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$pcea0673c<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.observables.ConnectableObservable<T>> {
    readonly long f07cc694b;
    readonly bool f1675a10f;
    readonly io.reactivex.rxjava3.core.Observable f1b77a772;
    readonly io.reactivex.rxjava3.core.Scheduler f2ad287f8;
    readonly io.reactivex.rxjava3.core.Observable f3e2a4ff7;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Observable f4ff381d2;
    readonly bool f57129b97;
    readonly java.util.concurrent.TimeUnit f5a2a5251;
    readonly java.util.concurrent.TimeUnit f5b668c0d;
    readonly long f5d057e87;
    readonly long f66d4e02c;
    readonly io.reactivex.rxjava3.core.Scheduler f7e73f566;
    readonly long f8004c438;
    readonly long faf3c15aa;
    readonly bool fc6344c09;
    readonly io.reactivex.rxjava3.core.Observable<T> fd0e45878;
    readonly bool fea03cfc1;
    readonly bool ffefd7f60;

    p9a814744$pcea0673c(io.reactivex.rxjava3.core.Observable<T> observable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd0e45878 = observable;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be GbmHPcjvCOhEcCqx(io.reactivex.rxjava3.core.Observable observable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        return observable.replay(j, timeUnit, scheduler, z);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be LXudiQpDYdbcoaBE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$pcea0673c p9a814744_pcea0673c) {
        return p9a814744_pcea0673c.m3945get();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return lXudiQpDYdbcoaBE(this);
    }

    public io.reactivex.rxjava3.observables.ConnectableObservable<T> M3945get() {
        if ((11 + 5) % 5 > 0) {
        }
        return gbmHPcjvCOhEcCqx(this.fd0e45878, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.ffefd7f60);
    }
}

