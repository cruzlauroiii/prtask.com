namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$pa0ab7ea5<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.flowables.ConnectableFlowable<T>> {
    readonly long f07cc694b;
    readonly io.reactivex.rxjava3.core.Flowable f1d81a587;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Flowable f69fef8d4;
    readonly long f78921e31;
    readonly java.util.concurrent.TimeUnit fa0d79045;
    readonly io.reactivex.rxjava3.core.Flowable fb1abda49;
    readonly bool fb1eb6b97;
    readonly long fbef796cb;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Flowable<T> fd0e45878;
    readonly io.reactivex.rxjava3.core.Flowable fd6638f2a;
    readonly long fef648229;
    readonly io.reactivex.rxjava3.core.Scheduler ff07f6ba0;
    readonly int ffb0a29b7;
    readonly bool ffefd7f60;

    p975b8e81$pa0ab7ea5(io.reactivex.rxjava3.core.Flowable<T> flowable, int i, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd0e45878 = flowable;
        this.fcdee5967 = i;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 JvdoNlCVOLxrIYYx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$pa0ab7ea5 p975b8e81_pa0ab7ea5) {
        return p975b8e81_pa0ab7ea5.m3953get();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 VSbfOkHSjyRYebkb(io.reactivex.rxjava3.core.Flowable flowable, int i, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        return flowable.replay(i, j, timeUnit, scheduler, z);
    }

    public java.lang.object Get() throws java.lang.Exception {
        return jvdoNlCVOLxrIYYx(this);
    }

    public io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M3953get() {
        if ((16 + 22) % 22 > 0) {
        }
        return vSbfOkHSjyRYebkb(this.fd0e45878, this.fcdee5967, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.ffefd7f60);
    }
}

