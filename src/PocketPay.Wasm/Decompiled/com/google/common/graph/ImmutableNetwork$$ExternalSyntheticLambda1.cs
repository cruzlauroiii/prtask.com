namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableNetwork$$ExternalSyntheticLambda1 : com.google.common.base.Function {
    public readonly com.google.common.graph.Network f$0;
    public readonly java.lang.object f$1;

    public ImmutableNetwork$$ExternalSyntheticLambda1(com.google.common.graph.Network network, java.lang.object obj) {
        this.f$0 = network;
        this.f$1 = obj;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return com.google.common.graph.ImmutableNetwork.lambda$adjacentNodeFn$2(this.f$0, this.f$1, obj);
    }
}

