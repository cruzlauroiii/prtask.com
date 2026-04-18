namespace WillowMaze.Wasm.Decompiled;


readonly class Scheduler$PeriodicDirectTask : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.pcc51858e {
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f060c702a;
    volatile bool f5bad2ec2;
    readonly java.lang.Action f6546fa3c;
    readonly java.lang.Action f6679d74f;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f70af2cd4;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f9352e0e5;
    readonly java.lang.Action fa53108f7;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    readonly java.lang.Action fdb49c852;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fec35346c;
    readonly java.lang.Action ff4ac2840;
    volatile bool ff8b2648d;

    Scheduler$PeriodicDirectTask(java.lang.Action runnable, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fa53108f7 = runnable;
        this.fb61822e8 = scheduler$Worker;
    }

    public static void IYxfbzFHbkEJDFuK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void IYxfbzFHbkEJDFuK(java.lang.Exception th, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IYxfbzFHbkEJDFuK(java.lang.Exception th, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IYxfbzFHbkEJDFuK(java.lang.Exception th, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYgiTGABTwkxxgIf(java.lang.Action runnable) {
        runnable.run();
    }

    public static void LYgiTGABTwkxxgIf(java.lang.Action runnable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYgiTGABTwkxxgIf(java.lang.Action runnable, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LYgiTGABTwkxxgIf(java.lang.Action runnable, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QolvcbOxTqxanIzC(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void QolvcbOxTqxanIzC(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QolvcbOxTqxanIzC(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QolvcbOxTqxanIzC(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VjezcwFwUMPwrAqV(io.reactivex.rxjava3.core.Scheduler$PeriodicDirectTask scheduler$PeriodicDirectTask) {
        scheduler$PeriodicDirectTask.dispose();
    }

    public static void VjezcwFwUMPwrAqV(io.reactivex.rxjava3.core.Scheduler$PeriodicDirectTask scheduler$PeriodicDirectTask, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VjezcwFwUMPwrAqV(io.reactivex.rxjava3.core.Scheduler$PeriodicDirectTask scheduler$PeriodicDirectTask, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VjezcwFwUMPwrAqV(io.reactivex.rxjava3.core.Scheduler$PeriodicDirectTask scheduler$PeriodicDirectTask, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        qolvcbOxTqxanIzC(this.fb61822e8);
    }

    public override java.lang.Action GetWrappedAction() {
        return this.fa53108f7;
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void Run() {
        if (this.ff8b2648d) {
            return;
        }
        try {
            lYgiTGABTwkxxgIf(this.fa53108f7);
        } catch (java.lang.Exception th) {
            vjezcwFwUMPwrAqV(this);
            IYxfbzFHbkEJDFuK(th);
            throw th;
        }
    }
}

