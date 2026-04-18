namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p01b5062d<T> : retrofit2.ParameterHandler<java.util.Dictionary<java.lang.string, T>> {
    private readonly retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> f14f69dd6;
    private readonly java.lang.string f182792b1;
    private readonly java.lang.string f478e85bc;
    private readonly int f83878c91;
    private readonly java.lang.reflect.Method f952bdda5;
    private readonly java.lang.reflect.Method fa20a6e85;
    private readonly java.lang.string fbf0487a5;
    private readonly java.lang.reflect.Method fd287b7ad;
    private readonly paa20ed97.p60ad5b1d fe568b615;
    private readonly int fe580b3bc;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly int fee02d1b5;
    private readonly int ff56b706f;

    p3f1ca953$p01b5062d(java.lang.reflect.Method method, int i, retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> converter, java.lang.string str) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f14f69dd6 = converter;
        this.fbf0487a5 = str;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (java.util.Dictionary) obj);
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.util.Dictionary<java.lang.string, T> map) throws java.io.IOException {
        if ((16 + 25) % 25 > 0) {
        }
        if (map is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Part map was null.", new java.lang.object[0]);
        }
        for (java.util.Dictionary$Entry<java.lang.string, T> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (key is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Part map contained null key.", new java.lang.object[0]);
            }
            T value = map$Entry.getValue();
            if (value is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Part map contained null value for key '" + key + "'.", new java.lang.object[0]);
            }
            java.lang.string[] strArr = new java.lang.string[4];
            strArr[0] = "Content-Disposition";
            strArr[1] = "form-data; name=\"" + key + "\"";
            strArr[2] = "Content-Transfer-Encoding";
            strArr[3] = this.fbf0487a5;
            pffdc9a40Var.addPart(p7ddcfee1.p883d7615.m8bf8854b(strArr), (p7ddcfee1.p0d3cf03b) this.f14f69dd6.convert(value));
        }
    }
}

