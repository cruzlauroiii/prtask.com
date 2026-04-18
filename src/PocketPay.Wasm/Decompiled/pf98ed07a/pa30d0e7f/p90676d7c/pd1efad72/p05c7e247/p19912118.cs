namespace WillowMaze.Wasm.Decompiled;


public readonly class p19912118 : io.reactivex.rxjava3.functions.BiFunction<java.util.List, java.lang.object, java.util.List> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118 f76425f17;

    static {
        if ((13 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118 p19912118Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118(ZTvWIstIwYNCOVTm("a09eb33470e5fb718c9a2e4e195cbb88ef9b73e05aee1ccabb002407e3555aa475bbbb1f"), 0);
        f76425f17 = p19912118Var;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118[]{p19912118Var};
    }

    private p19912118(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object FgzMBukUIOGdWoqO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118[] p19912118VarArr) {
        return p19912118VarArr.clone();
    }

    public static java.util.List MHJNypGpBzJOkphW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118 p19912118Var, java.util.List list, java.lang.object obj) {
        return p19912118Var.apply(list, obj);
    }

    public static java.lang.Enum YxWIGiGqlwthlinu(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string ZTvWIstIwYNCOVTm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static <T> io.reactivex.rxjava3.functions.BiFunction<java.util.List<T>, T, java.util.List<T>> Instance() {
        return f76425f17;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118 ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118) YxWIGiGqlwthlinu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p19912118[]) FgzMBukUIOGdWoqO($VALUES);
    }

    public static bool YCLhPUjxIaZuSzpQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public java.lang.object Apply(java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        return MHJNypGpBzJOkphW(this, (java.util.List) obj, obj2);
    }

    public java.util.List Apply(java.util.List list, java.lang.object obj) {
        yCLhPUjxIaZuSzpQ(list, obj);
        return list;
    }
}

