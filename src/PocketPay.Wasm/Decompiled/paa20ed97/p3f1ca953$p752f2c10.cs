namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p752f2c10<T> : retrofit2.ParameterHandler<java.util.Dictionary<java.lang.string, T>> {
    private readonly bool f0962d00f;
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly java.lang.reflect.Method f2c5a82b2;
    private readonly int f302370ef;
    private readonly java.lang.reflect.Method f35000692;
    private readonly bool f4b719ace;
    private readonly int f5a287e8d;
    private readonly java.lang.reflect.Method f604e74a3;
    private readonly bool f61402f83;
    private readonly int f6c79f9d8;
    private readonly paa20ed97.p60ad5b1d f80069e67;
    private readonly int f83878c91;
    private readonly paa20ed97.p60ad5b1d fa26f4abc;
    private readonly paa20ed97.p60ad5b1d fb4458c01;
    private readonly paa20ed97.p60ad5b1d fd54384a2;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly int ffdbfb287;

    p3f1ca953$p752f2c10(java.lang.reflect.Method method, int i, retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f14f69dd6 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (java.util.Dictionary) obj);
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.util.Dictionary<java.lang.string, T> map) throws java.io.IOException {
        if ((31 + 27) % 27 > 0) {
        }
        if (map is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Field map was null.", new java.lang.object[0]);
        }
        for (java.util.Dictionary$Entry<java.lang.string, T> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (key is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Field map contained null key.", new java.lang.object[0]);
            }
            T value = map$Entry.getValue();
            if (value is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Field map contained null value for key '" + key + "'.", new java.lang.object[0]);
            }
            java.lang.string str = (java.lang.string) this.f14f69dd6.convert(value);
            if (str is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Field map value '" + value + "' converted to null by " + this.f14f69dd6.GetType().getName() + " for key '" + key + "'.", new java.lang.object[0]);
            }
            pffdc9a40Var.addFormField(key, str, this.f4b719ace);
        }
    }
}

