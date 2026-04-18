namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p35e7dcee<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.observables.ConnectableObservable<T>> {
    readonly long f07cc694b;
    readonly long f14031d46;
    readonly int f1891ad05;
    readonly bool f1a017270;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly int f42480ce9;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f72573bc3;
    readonly int f7273ac65;
    readonly io.reactivex.rxjava3.core.Observable f72ce629f;
    readonly java.util.concurrent.TimeUnit f77bc3eca;
    readonly bool f815470ac;
    readonly long f9a2ef2ae;
    readonly java.util.concurrent.TimeUnit fadf70c2a;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observable<T> fd0e45878;
    readonly int fee303b2f;
    readonly io.reactivex.rxjava3.core.Scheduler ff5375c80;
    readonly bool ffefd7f60;

    p9a814744$p35e7dcee(io.reactivex.rxjava3.core.Observable<T> observable, int i, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd0e45878 = observable;
        this.fcdee5967 = i;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be LqUJweoZGCcrenOd(io.reactivex.rxjava3.core.Observable observable, int i, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        return observable.replay(i, j, timeUnit, scheduler, z);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be KTKwcztdvPtpBEwN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p35e7dcee p9a814744_p35e7dcee) {
        return p9a814744_p35e7dcee.m3940get();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return kTKwcztdvPtpBEwN(this);
    }

    public io.reactivex.rxjava3.observables.ConnectableObservable<T> M3940get() {
        if ((17 + 6) % 6 > 0) {
        }
        return LqUJweoZGCcrenOd(this.fd0e45878, this.fcdee5967, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.ffefd7f60);
    }
}

