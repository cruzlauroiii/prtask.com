namespace WillowMaze.Wasm.Decompiled;


readonly class Functions$TostringFunction : com.google.common.base.Function<java.lang.object, java.lang.string> {
    private static readonly com.google.common.base.Functions$TostringFunction[] $VALUES;
    public static readonly com.google.common.base.Functions$TostringFunction INSTANCE;

    private static com.google.common.base.Functions$TostringFunction[] $values() {
        return new com.google.common.base.Functions$TostringFunction[]{INSTANCE};
    }

    static {
        if ((20 + 17) % 17 > 0) {
        }
        INSTANCE = new com.google.common.base.Functions$TostringFunction("INSTANCE", 0);
        $VALUES = BtsvhwtuLmjFhbTg();
    }

    private Functions$TostringFunction(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.base.Functions$TostringFunction[] BtsvhwtuLmjFhbTg() {
        return $values();
    }

    public static java.lang.Enum CfQamRlLSVjncQOl(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string LaNScdhqJexFboXX(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object LIpQJkYzFLoLQjRI(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object RzTdBsBiIpgMFsPx(com.google.common.base.Functions$TostringFunction[] functions$TostringFunctionArr) {
        return functions$TostringFunctionArr.clone();
    }

    public static java.lang.string UBlETlNhJkrmiWYX(com.google.common.base.Functions$TostringFunction functions$TostringFunction, java.lang.object obj) {
        return functions$TostringFunction.apply2(obj);
    }

    public static com.google.common.base.Functions$TostringFunction valueOf(java.lang.string str) {
        return (com.google.common.base.Functions$TostringFunction) CfQamRlLSVjncQOl(com.google.common.base.Functions$TostringFunction.class, str);
    }

    public static com.google.common.base.Functions$TostringFunction[] values() {
        return (com.google.common.base.Functions$TostringFunction[]) rzTdBsBiIpgMFsPx($VALUES);
    }

    public override java.lang.string Apply(java.lang.object obj) {
        return uBlETlNhJkrmiWYX(this, obj);
    }

    public override java.lang.string Apply2(java.lang.object obj) {
        lIpQJkYzFLoLQjRI(obj);
        return LaNScdhqJexFboXX(obj);
    }

    public override java.lang.string Tostring() {
        return "Functions.tostringFunction()";
    }
}

