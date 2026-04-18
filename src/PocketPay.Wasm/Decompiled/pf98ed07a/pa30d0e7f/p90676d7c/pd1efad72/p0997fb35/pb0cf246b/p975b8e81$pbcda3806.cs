namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$pbcda3806<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.flowables.ConnectableFlowable<T>> {
    private readonly long f07cc694b;
    private readonly java.util.concurrent.TimeUnit f3e34bdeb;
    private readonly io.reactivex.rxjava3.core.Flowable f43530fd8;
    private readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f739f1a48;
    readonly bool f853820ab;
    private readonly long f876e9cf2;
    private readonly io.reactivex.rxjava3.core.Scheduler f87bb3b64;
    private readonly java.util.concurrent.TimeUnit f914f6931;
    private readonly io.reactivex.rxjava3.core.Flowable f96daedf4;
    private readonly long f98eef57b;
    private readonly java.util.concurrent.TimeUnit f9a5179ad;
    readonly bool fa613982f;
    private readonly io.reactivex.rxjava3.core.Flowable fbb94d0e6;
    private readonly java.util.concurrent.TimeUnit fc63778a3;
    private readonly long fc9593706;
    private readonly io.reactivex.rxjava3.core.Flowable<T> fd0e45878;
    private readonly java.util.concurrent.TimeUnit fd64aa8c9;
    private readonly io.reactivex.rxjava3.core.Flowable ff0406253;
    readonly bool ffefd7f60;

    p975b8e81$pbcda3806(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd0e45878 = flowable;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 KgOcQgKirdviHMUX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$pbcda3806 p975b8e81_pbcda3806) {
        return p975b8e81_pbcda3806.m3954get();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 KiCjImzASMHWmUlf(io.reactivex.rxjava3.core.Flowable flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        return flowable.replay(j, timeUnit, scheduler, z);
    }

    public java.lang.object Get() throws java.lang.Exception {
        return kgOcQgKirdviHMUX(this);
    }

    public io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M3954get() {
        if ((27 + 3) % 3 > 0) {
        }
        return kiCjImzASMHWmUlf(this.fd0e45878, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.ffefd7f60);
    }
}

