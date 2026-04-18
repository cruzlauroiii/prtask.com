namespace WillowMaze.Wasm.Decompiled;


class p96729ad9$p241daa16 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p5a6746c3 {
    private readonly java.lang.Action f2bbd35d5;
    private readonly java.lang.Action f418c5509;
    private readonly java.lang.Action f49aa1a40;
    private readonly java.lang.Action f73d9929c;
    private readonly java.lang.Action f78542427;

    p96729ad9$p241daa16(java.lang.Action runnable) {
        this.f418c5509 = runnable;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WdVFeEkZtBkmlLgF(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    protected override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CallActual(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        return WdVFeEkZtBkmlLgF(scheduler$Worker, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p6e1677fc(this.f418c5509, completableObserver));
    }
}

