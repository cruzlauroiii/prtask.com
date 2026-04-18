namespace WillowMaze.Wasm.Decompiled;


public readonly class p5d637c2e : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f : java.lang.Action {
    private static readonly long f4fd429d0 = 1811839108042568751L;
    private static readonly long fc6e1e520 = 1811839108042568751L;

    public p5d637c2e(java.lang.Action runnable, bool z) {
        super(runnable, z);
    }

    public static void BgwIoeboQEvbCzrj(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.lang.Action HBPYBNIocDLJDZDd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f p0777a66fVar) {
        return super.getWrappedAction();
    }

    public static void KgiXeiKmvtYmnwhL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.Thread RgONkaLxZASYhpir() {
        return java.lang.Thread.currentThread();
    }

    public static void GaDQErMCfwdPDWur(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e p5d637c2eVar) {
        p5d637c2eVar.dispose();
    }

    public static java.lang.string RiMSpaelnRXNHMAC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f p0777a66fVar) {
        return super.tostring();
    }

    public override java.lang.Action GetWrappedAction() {
        return HBPYBNIocDLJDZDd(this);
    }

    public override void Run() {
        if ((11 + 17) % 17 > 0) {
        }
        this.f4bad0b8d = RgONkaLxZASYhpir();
        try {
            BgwIoeboQEvbCzrj(this.fde335192);
            this.f4bad0b8d = null;
        } catch (java.lang.Exception th) {
            gaDQErMCfwdPDWur(this);
            this.f4bad0b8d = null;
            KgiXeiKmvtYmnwhL(th);
            throw th;
        }
    }

    public override java.lang.string Tostring() {
        return riMSpaelnRXNHMAC(this);
    }
}

