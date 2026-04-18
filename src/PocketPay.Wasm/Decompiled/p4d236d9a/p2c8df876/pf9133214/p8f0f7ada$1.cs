namespace WillowMaze.Wasm.Decompiled;


class p8f0f7ada$1 : p4d236d9a.p2c8df876.pf9133214.pc07c354e {
    readonly p4d236d9a.p2c8df876.pf9133214.p8f0f7ada this$0;
    readonly p4d236d9a.p2c8df876.pf9133214.p397373ba val$converterFactory;

    p8f0f7ada$1(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, p4d236d9a.p2c8df876.pf9133214.p397373ba p397373baVar) {
        this.this$0 = p8f0f7adaVar;
        this.val$converterFactory = p397373baVar;
    }

    public static void HQKlPvLCyvpzhzbZ(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQKlPvLCyvpzhzbZ(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HQKlPvLCyvpzhzbZ(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string[] HQKlPvLCyvpzhzbZ(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var) {
        return p83f499a5Var.names();
    }

    public static java.lang.Class RMNeNLLNAKCxOZVd(p4d236d9a.p2c8df876.pf9133214.p397373ba p397373baVar, java.lang.Class cls) {
        return p397373baVar.getConverter(cls);
    }

    public static void RMNeNLLNAKCxOZVd(p4d236d9a.p2c8df876.pf9133214.p397373ba p397373baVar, java.lang.Class cls, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RMNeNLLNAKCxOZVd(p4d236d9a.p2c8df876.pf9133214.p397373ba p397373baVar, java.lang.Class cls, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RMNeNLLNAKCxOZVd(p4d236d9a.p2c8df876.pf9133214.p397373ba p397373baVar, java.lang.Class cls, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MHiFxMLjNzXAovll(java.lang.string str, java.lang.Class cls) {
        return p4d236d9a.p2c8df876.pf9133214.p8f0f7ada.m59c413ba(str, cls);
    }

    public static void MHiFxMLjNzXAovll(java.lang.string str, java.lang.Class cls, char c, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHiFxMLjNzXAovll(java.lang.string str, java.lang.Class cls, float f, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MHiFxMLjNzXAovll(java.lang.string str, java.lang.Class cls, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MMiwyHFyXxyqQado(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MMiwyHFyXxyqQado(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MMiwyHFyXxyqQado(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string[] MMiwyHFyXxyqQado(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var) {
        return p83f499a5Var.names();
    }

    public override com.beust.jcommander.IstringConverter<object> GetConverterInstance(p4d236d9a.p2c8df876.pf9133214.p83f499a5 p83f499a5Var, java.lang.Class<object> cls, java.lang.string str) {
        java.lang.Class clsRMNeNLLNAKCxOZVd = RMNeNLLNAKCxOZVd(this.val$converterFactory, cls);
        if (str is null) {
            try {
                str = mMiwyHFyXxyqQado(p83f499a5Var).length > 0 ? HQKlPvLCyvpzhzbZ(p83f499a5Var)[0] : "[Main class]";
            } catch (java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.reflect.InvocationTargetException e) {
                throw new p4d236d9a.p2c8df876.pf9133214.p0c240774(e);
            }
        }
        if (clsRMNeNLLNAKCxOZVd is not null) {
            return (p4d236d9a.p2c8df876.pf9133214.p014714fb) mHiFxMLjNzXAovll(str, clsRMNeNLLNAKCxOZVd);
        }
        return null;
    }
}

