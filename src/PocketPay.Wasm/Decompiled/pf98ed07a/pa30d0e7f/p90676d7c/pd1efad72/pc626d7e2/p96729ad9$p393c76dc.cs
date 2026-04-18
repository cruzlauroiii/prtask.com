namespace WillowMaze.Wasm.Decompiled;


readonly class p96729ad9$p393c76dc : io.reactivex.rxjava3.core.Scheduler$Worker {
    private readonly java.util.concurrent.atomic.Atomicbool f1d089574;
    private readonly io.reactivex.rxjava3.core.Scheduler$Worker f36f55c4d;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f56dd015d;
    private readonly io.reactivex.rxjava3.core.Scheduler$Worker f6fc2907f;
    private readonly io.reactivex.rxjava3.core.Scheduler$Worker f6fdfdf6b;
    private readonly io.reactivex.rxjava3.processors.FlowableProcessor<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p5a6746c3> f9246c104;
    private readonly java.util.concurrent.atomic.Atomicbool fa0f39894 = new java.util.concurrent.atomic.Atomicbool();
    private readonly io.reactivex.rxjava3.core.Scheduler$Worker fb6f43f07;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d fb76aed2a;
    private readonly java.util.concurrent.atomic.Atomicbool fd80615c8;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d ff4ce38ed;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d ff9e21b53;

    p96729ad9$p393c76dc(io.reactivex.rxjava3.processors.FlowableProcessor<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p5a6746c3> flowableProcessor, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.f9246c104 = flowableProcessor;
        this.f6fdfdf6b = scheduler$Worker;
    }

    public static bool AabIzMaasAWJmHXV(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void DcsBJOHbpfpofifI(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar) {
        p82cca76dVar.onComplete();
    }

    public static void IHMoxwAtcKQUINak(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar, java.lang.object obj) {
        p82cca76dVar.onNext(obj);
    }

    public static bool XQQjFrojyjWOYbDF(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void JtoOEVaByzooQwws(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar, java.lang.object obj) {
        p82cca76dVar.onNext(obj);
    }

    public static void XAyBHJkPKwsvnJbp(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public override void Dispose() {
        if ((32 + 10) % 10 > 0) {
        }
        if (AabIzMaasAWJmHXV(this.fa0f39894, false, true)) {
            DcsBJOHbpfpofifI(this.f9246c104);
            xAyBHJkPKwsvnJbp(this.f6fdfdf6b);
        }
    }

    public override bool IsDisposed() {
        return XQQjFrojyjWOYbDF(this.fa0f39894);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p241daa16 p96729ad9_p241daa16 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$p241daa16(runnable);
        IHMoxwAtcKQUINak(this.f9246c104, p96729ad9_p241daa16);
        return p96729ad9_p241daa16;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$pc212f0d4 p96729ad9_pc212f0d4 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p96729ad9$pc212f0d4(runnable, j, timeUnit);
        jtoOEVaByzooQwws(this.f9246c104, p96729ad9_pc212f0d4);
        return p96729ad9_pc212f0d4;
    }
}

