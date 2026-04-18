namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p8fc3270c<T> : retrofit2.ParameterHandler<T> {
    private readonly paa20ed97.p60ad5b1d f06a744d7;
    private readonly paa20ed97.p60ad5b1d f3fcd4d0a;
    private readonly bool f4b719ace;
    private readonly retrofit2.Converter<T, java.lang.string> f7675e5d3;
    private readonly bool fc0b24d12;
    private readonly paa20ed97.p60ad5b1d ff06d37d2;

    p3f1ca953$p8fc3270c(retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.f7675e5d3 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException {
        if (t is not null) {
            pffdc9a40Var.addQueryParam((java.lang.string) this.f7675e5d3.convert(t), null, this.f4b719ace);
        }
    }
}

