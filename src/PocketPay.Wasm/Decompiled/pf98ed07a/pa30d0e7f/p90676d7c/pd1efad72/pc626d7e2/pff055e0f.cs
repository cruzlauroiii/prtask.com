namespace WillowMaze.Wasm.Decompiled;


public readonly class pff055e0f : io.reactivex.rxjava3.core.Scheduler {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2ed09605 = null;
    public static readonly io.reactivex.rxjava3.core.Scheduler f523ed066 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6477ca4b = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6da2702f = null;
    public static readonly io.reactivex.rxjava3.core.Scheduler f92946b6d = null;
    static readonly io.reactivex.rxjava3.core.Scheduler$Worker f999b61e7 = null;
    public static readonly io.reactivex.rxjava3.core.Scheduler fa24ad251 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa7cc3ad8;
    public static readonly io.reactivex.rxjava3.core.Scheduler fb9c43abb = null;
    public static readonly io.reactivex.rxjava3.core.Scheduler f76425f17 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pff055e0f();
    static readonly io.reactivex.rxjava3.core.Scheduler$Worker f531886e6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pff055e0f$pe0c0183e();

    static {
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarDLUDVoaPtxYhbdBT = DLUDVoaPtxYhbdBT();
        fa7cc3ad8 = p7beea252VarDLUDVoaPtxYhbdBT;
        DINzYeSXqGXdksmS(p7beea252VarDLUDVoaPtxYhbdBT);
    }

    private pff055e0f() {
    }

    public static void DINzYeSXqGXdksmS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 DLUDVoaPtxYhbdBT() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void XTGDBcFNZvdRmAQz(java.lang.Action runnable) {
        runnable.run();
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        return f531886e6;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable) {
        XTGDBcFNZvdRmAQz(runnable);
        return fa7cc3ad8;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException("This scheduler doesn't support delayed execution");
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SchedulePeriodicallyDirect(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException("This scheduler doesn't support periodic execution");
    }
}

