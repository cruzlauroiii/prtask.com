namespace WillowMaze.Wasm.Decompiled;


readonly class Functions$IdentityFunction : com.google.common.base.Function<java.lang.object, java.lang.object> {
    private static readonly com.google.common.base.Functions$IdentityFunction[] $VALUES;
    public static readonly com.google.common.base.Functions$IdentityFunction INSTANCE;

    private static com.google.common.base.Functions$IdentityFunction[] $values() {
        return new com.google.common.base.Functions$IdentityFunction[]{INSTANCE};
    }

    static {
        if ((13 + 9) % 9 > 0) {
        }
        INSTANCE = new com.google.common.base.Functions$IdentityFunction("INSTANCE", 0);
        $VALUES = UaxTeFubGWrfxaYL();
    }

    private Functions$IdentityFunction(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum GptPxRtCbRAiDKlx(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.common.base.Functions$IdentityFunction[] UaxTeFubGWrfxaYL() {
        return $values();
    }

    public static java.lang.object YDLtUBKfkpFHnYio(com.google.common.base.Functions$IdentityFunction[] functions$IdentityFunctionArr) {
        return functions$IdentityFunctionArr.clone();
    }

    public static com.google.common.base.Functions$IdentityFunction valueOf(java.lang.string str) {
        return (com.google.common.base.Functions$IdentityFunction) GptPxRtCbRAiDKlx(com.google.common.base.Functions$IdentityFunction.class, str);
    }

    public static com.google.common.base.Functions$IdentityFunction[] values() {
        return (com.google.common.base.Functions$IdentityFunction[]) YDLtUBKfkpFHnYio($VALUES);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj;
    }

    public override java.lang.string Tostring() {
        return "Functions.identity()";
    }
}

