namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p05794e2e : retrofit2.ParameterHandler<java.lang.object> {
    private readonly java.lang.reflect.Method f0cb37fdc;
    private readonly java.lang.reflect.Method f0e3cc328;
    private readonly int f2b4a0cca;
    private readonly java.lang.reflect.Method f63d5ff1a;
    private readonly int f83878c91;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly java.lang.reflect.Method ff558bf46;

    p3f1ca953$p05794e2e(java.lang.reflect.Method method, int i) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) {
        if (obj is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "@Url parameter is null.", new java.lang.object[0]);
        }
        pffdc9a40Var.setRelativeUrl(obj);
    }
}

