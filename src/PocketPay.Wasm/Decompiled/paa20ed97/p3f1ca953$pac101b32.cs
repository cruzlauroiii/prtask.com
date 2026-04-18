namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$pac101b32<T> : retrofit2.ParameterHandler<T> {
    private readonly paa20ed97.p60ad5b1d f023ef231;
    private readonly retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> f0ea7dd4d;
    private readonly java.lang.reflect.Method f4b2a3fbe;
    private readonly paa20ed97.p60ad5b1d f5906857f;
    private readonly int f66be7663;
    private readonly int f83878c91;
    private readonly paa20ed97.p60ad5b1d f849457ec;
    private readonly int f85917649;
    private readonly int f874ff794;
    private readonly paa20ed97.p60ad5b1d f888d5606;
    private readonly int f994ac3cf;
    private readonly java.lang.reflect.Method fea9f6aca;

    p3f1ca953$pac101b32(java.lang.reflect.Method method, int i, retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> converter) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f0ea7dd4d = converter;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) {
        if ((2 + 22) % 22 > 0) {
        }
        if (t is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Body parameter value must not be null.", new java.lang.object[0]);
        }
        try {
            pffdc9a40Var.setBody((p7ddcfee1.p0d3cf03b) this.f0ea7dd4d.convert(t));
        } catch (java.io.IOException e) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, e, this.f83878c91, "Unable to convert " + t + " to RequestBody", new java.lang.object[0]);
        }
    }
}

