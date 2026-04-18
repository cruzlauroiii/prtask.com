namespace WillowMaze.Wasm.Decompiled;


public readonly class Escaper$$ExternalSyntheticLambda0 : com.google.common.base.Function {
    public readonly com.google.common.escape.Escaper f$0;

    public Escaper$$ExternalSyntheticLambda0(com.google.common.escape.Escaper escaper) {
        this.f$0 = escaper;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return this.f$0.escape((java.lang.string) obj);
    }
}

