namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ddfe0cd : io.reactivex.rxjava3.functions.Supplier<java.util.List<java.lang.object>>, io.reactivex.rxjava3.functions.Function<java.lang.object, java.util.List<java.lang.object>> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd f76425f17;

    static {
        if ((4 + 24) % 24 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd p0ddfe0cdVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd(bkXDMugmnCHrEpeh("d6c6a8587295ae927b9e4f8b45c38d4658261c04e1270b993dcedbe30abeb0be398dfbb1"), 0);
        f76425f17 = p0ddfe0cdVar;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd[]{p0ddfe0cdVar};
    }

    private p0ddfe0cd(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object KaTzXJvhuzRhAVtG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd[] p0ddfe0cdVarArr) {
        return p0ddfe0cdVarArr.clone();
    }

    public static java.util.List LRsAzPstuPblNLEU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd p0ddfe0cdVar, java.lang.object obj) {
        return p0ddfe0cdVar.m3934apply(obj);
    }

    public static java.lang.Enum ZmtITGkeWvJOOMSZ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static <T, O> io.reactivex.rxjava3.functions.Function<O, java.util.List<T>> AsFunction() {
        return f76425f17;
    }

    public static <T> io.reactivex.rxjava3.functions.Supplier<java.util.List<T>> AsSupplier() {
        return f76425f17;
    }

    public static java.lang.string BkXDMugmnCHrEpeh(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.util.List QrfoqBbMNPOUagnv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd p0ddfe0cdVar) {
        return p0ddfe0cdVar.m3935get();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd) ZmtITGkeWvJOOMSZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd[]) KaTzXJvhuzRhAVtG($VALUES);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return LRsAzPstuPblNLEU(this, obj);
    }

    public java.util.List<java.lang.object> M3934apply(java.lang.object obj) {
        return new java.util.List();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return qrfoqBbMNPOUagnv(this);
    }

    public java.util.List<java.lang.object> M3935get() {
        return new java.util.List();
    }
}

