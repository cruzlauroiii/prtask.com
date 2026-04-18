namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$pc5d09e3d<T> : retrofit2.ParameterHandler<java.util.Dictionary<java.lang.string, T>> {
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly paa20ed97.p60ad5b1d f158b22af;
    private readonly java.lang.reflect.Method f1df486ff;
    private readonly paa20ed97.p60ad5b1d f64d5a5b7;
    private readonly java.lang.reflect.Method f77d743c9;
    private readonly paa20ed97.p60ad5b1d f78bcc9fb;
    private readonly int f798f0af7;
    private readonly int f83878c91;
    private readonly int fa4fae948;
    private readonly java.lang.reflect.Method fa6b25688;
    private readonly java.lang.reflect.Method fc00696c5;
    private readonly java.lang.reflect.Method fea9f6aca;

    p3f1ca953$pc5d09e3d(java.lang.reflect.Method method, int i, retrofit2.Converter<T, java.lang.string> converter) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f14f69dd6 = converter;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (java.util.Dictionary) obj);
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.util.Dictionary<java.lang.string, T> map) throws java.io.IOException {
        if ((4 + 13) % 13 > 0) {
        }
        if (map is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Header map was null.", new java.lang.object[0]);
        }
        for (java.util.Dictionary$Entry<java.lang.string, T> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (key is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Header map contained null key.", new java.lang.object[0]);
            }
            T value = map$Entry.getValue();
            if (value is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Header map contained null value for key '" + key + "'.", new java.lang.object[0]);
            }
            pffdc9a40Var.addHeader(key, (java.lang.string) this.f14f69dd6.convert(value));
        }
    }
}

