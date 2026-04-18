namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p66c1b4c7<T> : retrofit2.ParameterHandler<T> {
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly paa20ed97.p60ad5b1d f2cf767dd;
    private readonly bool f4b719ace;
    private readonly bool f59f543b7;
    private readonly java.lang.string f62221be5;
    private readonly paa20ed97.p60ad5b1d f7d6b8bbe;
    private readonly bool f8c0d45dc;
    private readonly paa20ed97.p60ad5b1d f8d4d1831;
    private readonly java.lang.string fb068931c;
    private readonly bool fbea56f0e;
    private readonly java.lang.string fe1ba1338;
    private readonly bool ff76c0cda;
    private readonly paa20ed97.p60ad5b1d ffe6df967;

    p3f1ca953$p66c1b4c7(java.lang.string str, retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.fb068931c = (java.lang.string) java.util.objects.requireNonNull(str, "name is null");
        this.f14f69dd6 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException {
        java.lang.string str;
        if (t is null || (str = (java.lang.string) this.f14f69dd6.convert(t)) is null) {
            return;
        }
        pffdc9a40Var.addQueryParam(this.fb068931c, str, this.f4b719ace);
    }
}

