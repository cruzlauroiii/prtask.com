namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$pbf50d5e6<T> : retrofit2.ParameterHandler<T> {
    private readonly java.lang.string f016a9ac6;
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly java.lang.string f4d99a22f;
    private readonly java.lang.string f518cdea0;
    private readonly java.lang.string f84690c77;
    private readonly java.lang.string fb068931c;
    private readonly paa20ed97.p60ad5b1d fcfd1407a;
    private readonly paa20ed97.p60ad5b1d ff4c4647e;

    p3f1ca953$pbf50d5e6(java.lang.string str, retrofit2.Converter<T, java.lang.string> converter) {
        this.fb068931c = (java.lang.string) java.util.objects.requireNonNull(str, "name is null");
        this.f14f69dd6 = converter;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException {
        java.lang.string str;
        if (t is null || (str = (java.lang.string) this.f14f69dd6.convert(t)) is null) {
            return;
        }
        pffdc9a40Var.addHeader(this.fb068931c, str);
    }
}

