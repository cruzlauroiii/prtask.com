namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p5bfce74a<T> : retrofit2.ParameterHandler<T> {
    private readonly p7ddcfee1.p883d7615 f02f08137;
    private readonly retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> f0ea7dd4d;
    private readonly int f2462c4b5;
    private readonly int f26e94dbe;
    private readonly p7ddcfee1.p883d7615 f273602fb;
    private readonly paa20ed97.p60ad5b1d f32b25088;
    private readonly int f32f13e64;
    private readonly p7ddcfee1.p883d7615 f364c8209;
    private readonly p7ddcfee1.p883d7615 f4340fd73;
    private readonly java.lang.reflect.Method f582b8e1c;
    private readonly int f6426fec0;
    private readonly int f83878c91;
    private readonly java.lang.reflect.Method fea9f6aca;

    p3f1ca953$p5bfce74a(java.lang.reflect.Method method, int i, p7ddcfee1.p883d7615 p883d7615Var, retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> converter) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.f4340fd73 = p883d7615Var;
        this.f0ea7dd4d = converter;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) {
        if ((11 + 26) % 26 > 0) {
        }
        if (t is not null) {
            try {
                pffdc9a40Var.addPart(this.f4340fd73, (p7ddcfee1.p0d3cf03b) this.f0ea7dd4d.convert(t));
            } catch (java.io.IOException e) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Unable to convert " + t + " to RequestBody", e);
            }
        }
    }
}

