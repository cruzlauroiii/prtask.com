namespace WillowMaze.Wasm.Decompiled;


readonly class p93865d37$p3b67d670<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> {
    private readonly long f06d3873e;
    private readonly long f1e0ac3b9;
    private readonly int f3d5efaf8;
    private readonly java.util.concurrent.TimeUnit f3e34bdeb;
    private readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f5a8e44cc;
    private readonly io.reactivex.rxjava3.core.Scheduler f71af1dcd;
    private readonly int f811857f0;
    private readonly int f85ab0768;
    readonly bool f9c36b075;
    private readonly int fb38e9a1f;
    private readonly int fcdee5967;
    private readonly java.util.concurrent.TimeUnit fcfef90cf;
    private readonly io.reactivex.rxjava3.core.Scheduler ff6311091;
    readonly bool ffefd7f60;

    p93865d37$p3b67d670(int i, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fcdee5967 = i;
        this.f1e0ac3b9 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf aTPrDJiYWDtGFpaY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p3b67d670 p93865d37_p3b67d670) {
        return p93865d37_p3b67d670.m3947get();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return aTPrDJiYWDtGFpaY(this);
    }

    public io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T> m3947get() {
        if ((4 + 16) % 16 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pdd4e539e(this.fcdee5967, this.f1e0ac3b9, this.f3e34bdeb, this.f499f31e7, this.ffefd7f60);
    }
}

