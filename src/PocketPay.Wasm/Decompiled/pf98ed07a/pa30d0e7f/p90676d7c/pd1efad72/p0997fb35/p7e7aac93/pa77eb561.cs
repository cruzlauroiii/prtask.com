namespace WillowMaze.Wasm.Decompiled;


public readonly class pa77eb561 : io.reactivex.rxjava3.functions.Function<io.reactivex.rxjava3.core.MaybeSource<java.lang.object>, org.reactivestreams.Publisher<java.lang.object>> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561 f76425f17;

    static {
        if ((15 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561 pa77eb561Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561(tboIkZttLwHNTJmE("ac95f705aeca2beb1a0b0e8c45a216306be9c6a1b80ced3c3ccb397c985adab39888fa63"), 0);
        f76425f17 = pa77eb561Var;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561[]{pa77eb561Var};
    }

    private pa77eb561(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object LkYMwiUECqaKQqIB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561[] pa77eb561VarArr) {
        return pa77eb561VarArr.clone();
    }

    public static java.lang.Enum WbGuJlRNoNBFXsgc(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static <T> io.reactivex.rxjava3.functions.Function<io.reactivex.rxjava3.core.MaybeSource<T>, org.reactivestreams.Publisher<T>> Instance() {
        return f76425f17;
    }

    public static p5a445d71.p18f29add.p32c73be0 TNKSTjdFfmoxVWgw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561 pa77eb561Var, io.reactivex.rxjava3.core.MaybeSource maybeSource) {
        return pa77eb561Var.apply((io.reactivex.rxjava3.core.MaybeSource<java.lang.object>) maybeSource);
    }

    public static java.lang.string TboIkZttLwHNTJmE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561 ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561) WbGuJlRNoNBFXsgc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa77eb561[]) LkYMwiUECqaKQqIB($VALUES);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return tNKSTjdFfmoxVWgw(this, (io.reactivex.rxjava3.core.MaybeSource) obj);
    }

    public org.reactivestreams.Publisher<java.lang.object> Apply(io.reactivex.rxjava3.core.MaybeSource<java.lang.object> maybeSource) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4bc0a080(maybeSource);
    }
}

