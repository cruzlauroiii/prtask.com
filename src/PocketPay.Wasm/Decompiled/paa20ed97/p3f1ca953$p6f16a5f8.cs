namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p6f16a5f8<T> : retrofit2.ParameterHandler<T> {
    private readonly retrofit2.Converter<T, java.lang.string> f14f69dd6;
    private readonly bool f2ef2a03b;
    private readonly paa20ed97.p60ad5b1d f41d15139;
    private readonly bool f4b719ace;
    private readonly paa20ed97.p60ad5b1d f89182fc5;
    private readonly bool f8d6a4972;
    private readonly java.lang.string fb068931c;
    private readonly java.lang.string fd1bc83e0;
    private readonly bool fd222541f;
    private readonly paa20ed97.p60ad5b1d fe633fb7e;

    p3f1ca953$p6f16a5f8(java.lang.string str, retrofit2.Converter<T, java.lang.string> converter, bool z) {
        this.fb068931c = (java.lang.string) java.util.objects.requireNonNull(str, "name is null");
        this.f14f69dd6 = converter;
        this.f4b719ace = z;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException {
        java.lang.string str;
        if (t is null || (str = (java.lang.string) this.f14f69dd6.convert(t)) is null) {
            return;
        }
        pffdc9a40Var.addFormField(this.fb068931c, str, this.f4b719ace);
    }
}

