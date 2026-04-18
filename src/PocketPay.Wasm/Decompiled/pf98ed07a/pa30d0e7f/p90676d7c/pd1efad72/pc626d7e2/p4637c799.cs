namespace WillowMaze.Wasm.Decompiled;


public readonly class p4637c799 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f : java.util.concurrent.Func<java.lang.void> {
    private static readonly long fc6e1e520 = 1811839108042568751L;
    private static readonly long fec5edc70 = 1811839108042568751L;

    public p4637c799(java.lang.Action runnable, bool z) {
        super(runnable, z);
    }

    public static java.lang.void GoshnccEyXlOJgLU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var) {
        return p4637c799Var.call2();
    }

    public static void HBlBvbrsXPLEQtQQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var, java.lang.object obj) {
        p4637c799Var.lazyHashSet(obj);
    }

    public static void MjoQjFLIOMCziCzN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var, java.lang.object obj) {
        p4637c799Var.lazyHashSet(obj);
    }

    public static java.lang.Action TYrqziuxhtstyjnJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f p0777a66fVar) {
        return super.getWrappedAction();
    }

    public static java.lang.Thread VCTjkivZjCvtFoap() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.string HBQNuBlDkZRFHiKD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p0777a66f p0777a66fVar) {
        return super.tostring();
    }

    public static void RLItZxnWhckBeXhh(java.lang.Action runnable) {
        runnable.run();
    }

    public static void VXTPjLiAdJJSSSAA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override java.lang.void Call() throws java.lang.Exception {
        return GoshnccEyXlOJgLU(this);
    }

    public override java.lang.void Call2() {
        if ((7 + 31) % 31 > 0) {
        }
        this.f4bad0b8d = VCTjkivZjCvtFoap();
        try {
            try {
                rLItZxnWhckBeXhh(this.fde335192);
                HBlBvbrsXPLEQtQQ(this, f2c616b27);
                this.f4bad0b8d = null;
                return null;
            } catch (java.lang.Exception th) {
                MjoQjFLIOMCziCzN(this, f2c616b27);
                this.f4bad0b8d = null;
                throw th;
            }
        } catch (java.lang.Exception th2) {
            vXTPjLiAdJJSSSAA(th2);
            throw th2;
        }
    }

    public override java.lang.Action GetWrappedAction() {
        return TYrqziuxhtstyjnJ(this);
    }

    public override java.lang.string Tostring() {
        return hBQNuBlDkZRFHiKD(this);
    }
}

