namespace WillowMaze.Wasm.Decompiled;


public readonly class p34948870 : io.reactivex.rxjava3.functions.Supplier<java.util.Dictionary<java.lang.object, java.lang.object>> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870 f76425f17;

    static {
        if ((13 + 12) % 12 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870 p34948870Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870(OhbvpFZqLAqkwFme("fe35641d9928a3b6ad4be82c09d8d51cd4e7658d2b7c194e4c9c8674d4009f696d3efc76"), 0);
        f76425f17 = p34948870Var;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870[]{p34948870Var};
    }

    private p34948870(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MlubUHQxoxYYOovt(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string OhbvpFZqLAqkwFme(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object UeJTBOWvIqhlMTRF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870[] p34948870VarArr) {
        return p34948870VarArr.clone();
    }

    public static java.util.Dictionary ZRMrXLxDsWUQqhub(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870 p34948870Var) {
        return p34948870Var.m3936get();
    }

    public static <K, V> io.reactivex.rxjava3.functions.Supplier<java.util.Dictionary<K, V>> AsSupplier() {
        return f76425f17;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870 ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870) MlubUHQxoxYYOovt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p34948870[]) UeJTBOWvIqhlMTRF($VALUES);
    }

    public java.lang.object Get() throws java.lang.Exception {
        return ZRMrXLxDsWUQqhub(this);
    }

    public java.util.Dictionary<java.lang.object, java.lang.object> M3936get() {
        return new java.util.HashDictionary();
    }
}

