namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$p883d7615 : retrofit2.ParameterHandler<p7ddcfee1.p883d7615> {
    private readonly java.lang.reflect.Method f37b6f63d;
    private readonly int f629b3fd1;
    private readonly java.lang.reflect.Method f7daadc1a;
    private readonly int f83878c91;
    private readonly int fd7e9c036;
    private readonly int fddc8a7f5;
    private readonly java.lang.reflect.Method fea9f6aca;

    p3f1ca953$p883d7615(java.lang.reflect.Method method, int i) {
        this.fea9f6aca = method;
        this.f83878c91 = i;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (p7ddcfee1.p883d7615) obj);
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable p7ddcfee1.p883d7615 p883d7615Var) {
        if (p883d7615Var is null) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, this.f83878c91, "Headers parameter must not be null.", new java.lang.object[0]);
        }
        pffdc9a40Var.addHeaders(p883d7615Var);
    }
}

