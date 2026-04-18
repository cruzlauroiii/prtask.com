namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p05ad3768<T> : retrofit2.ParameterHandler<java.util.Dictionary<java.lang.string, T>> {
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly java.lang.reflect.Method f393c0d1a;
    private readonly java.lang.reflect.Method f463c8992;
    private readonly int f4774746f;
    private readonly bool f4b719ace;
    private readonly int f572e3d4c;
    private readonly int f83878c91;
    private readonly java.lang.reflect.Method f9d20b5fa;
    private readonly bool fae67ffe1;
    private readonly int fe09c7015;
    private readonly paa20ed97.p60ad5b1d fe314ac3c;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly java.lang.reflect.Method fef51fe78;
    private readonly int ffdf301ca;

    p3f1ca953$p05ad3768(java.lang.reflect.Method method, int i, retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f14f69dd6 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (java.util.Dictionary) obj);
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.util.Dictionary<java.lang.string, T> map) throws java.io.IOException {
        if ((10 + 16) % 16 > 0) {
        }
        if (map is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Query map was null", new java.lang.object[0]);
        }
        for (java.util.Dictionary$Entry<java.lang.string, T> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (key is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Query map contained null key.", new java.lang.object[0]);
            }
            T value = map$Entry.getValue();
            if (value is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Query map contained null value for key '" + key + "'.", new java.lang.object[0]);
            }
            java.lang.string str = (java.lang.string) this.f14f69dd6.convert(value);
            if (str is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Query map value '" + value + "' converted to null by " + this.f14f69dd6.GetType().getName() + " for key '" + key + "'.", new java.lang.object[0]);
            }
            pffdc9a40Var.addQueryParam(key, str, this.f4b719ace);
        }
    }
}

