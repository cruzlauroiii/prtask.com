namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$pac70412e<T> : retrofit2.ParameterHandler<T> {
    private readonly paa20ed97.p60ad5b1d f05f76b5c;
    private readonly bool f06ec27cf;
    private readonly java.lang.string f0dfe40b0;
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly int f2626c0e8;
    private readonly bool f4b719ace;
    private readonly int f54844d2e;
    private readonly java.lang.string f5df9969e;
    private readonly paa20ed97.p60ad5b1d f7c8fe71f;
    private readonly int f83878c91;
    private readonly paa20ed97.p60ad5b1d f960f7f87;
    private readonly int f9b9fff1e;
    private readonly java.lang.string fb068931c;
    private readonly java.lang.reflect.Method fb1189370;
    private readonly java.lang.string fb471f796;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly java.lang.reflect.Method ff6340236;
    private readonly paa20ed97.p60ad5b1d fff9f9e64;

    p3f1ca953$pac70412e(java.lang.reflect.Method method, int i, java.lang.string str, retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
        this.fb068931c = (java.lang.string) java.util.objects.requireNonNull(str, "name is null");
        this.f14f69dd6 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException {
        if ((2 + 21) % 21 > 0) {
        }
        if (t is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Path parameter \"" + this.fb068931c + "\" value must not be null.", new java.lang.object[0]);
        }
        pffdc9a40Var.addPathParam(this.fb068931c, (java.lang.string) this.f14f69dd6.convert(t), this.f4b719ace);
    }
}

