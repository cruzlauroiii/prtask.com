namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableValueGraph$$ExternalSyntheticLambda0 : com.google.common.base.Function {
    public readonly com.google.common.graph.ValueGraph f$0;
    public readonly java.lang.object f$1;

    public ImmutableValueGraph$$ExternalSyntheticLambda0(com.google.common.graph.ValueGraph valueGraph, java.lang.object obj) {
        this.f$0 = valueGraph;
        this.f$1 = obj;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return com.google.common.graph.ImmutableValueGraph.lambda$connectionsOf$0(this.f$0, this.f$1, obj);
    }
}

