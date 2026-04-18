namespace WillowMaze.Wasm.Decompiled;


readonly class pff055e0f$pe0c0183e : io.reactivex.rxjava3.core.Scheduler$Worker {
    pff055e0f$pe0c0183e() {
    }

    public static void QMvGYXjyrEPSjcWl(java.lang.Action runnable) {
        runnable.run();
    }

    public override void Dispose() {
    }

    public override bool IsDisposed() {
        return false;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        QMvGYXjyrEPSjcWl(runnable);
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pff055e0f.fa7cc3ad8;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException("This scheduler doesn't support delayed execution");
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SchedulePeriodically(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException("This scheduler doesn't support periodic execution");
    }
}

