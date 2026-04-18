namespace WillowMaze.Wasm.Decompiled;


class p96729ad9$pc212f0d4 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p5a6746c3 {
    private readonly long f259d5b1b;
    private readonly java.util.concurrent.TimeUnit f3e34bdeb;
    private readonly java.lang.Action f418c5509;
    private readonly java.util.concurrent.TimeUnit f57e4cee6;
    private readonly java.util.concurrent.TimeUnit f6b2a7492;
    private readonly long f6ba6148e;
    private readonly java.lang.Action f743fc1f5;
    private readonly long fae89394c;
    private readonly java.lang.Action fca32e61d;
    private readonly java.util.concurrent.TimeUnit fe86712be;
    private readonly long ff8a06d27;

    p96729ad9$pc212f0d4(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.f418c5509 = runnable;
        this.fae89394c = j;
        this.f3e34bdeb = timeUnit;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 GFiXOHBbsZwdvmKl(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    protected override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CallActual(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((3 + 28) % 28 > 0) {
        }
        return GFiXOHBbsZwdvmKl(scheduler$Worker, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p6e1677fc(this.f418c5509, completableObserver), this.fae89394c, this.f3e34bdeb);
    }
}

