namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableNetwork$$ExternalSyntheticLambda0 : com.google.common.base.Function {
    public readonly com.google.common.graph.Network f$0;

    public ImmutableNetwork$$ExternalSyntheticLambda0(com.google.common.graph.Network network) {
        this.f$0 = network;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return com.google.common.graph.ImmutableNetwork.lambda$sourceNodeFn$0(this.f$0, obj);
    }
}

