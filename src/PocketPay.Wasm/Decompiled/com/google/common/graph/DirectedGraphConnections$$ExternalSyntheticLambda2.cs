namespace WillowMaze.Wasm.Decompiled;


public readonly class DirectedGraphConnections$$ExternalSyntheticLambda2 : com.google.common.base.Function {
    public readonly java.lang.object f$0;

    public DirectedGraphConnections$$ExternalSyntheticLambda2(java.lang.object obj) {
        this.f$0 = obj;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return com.google.common.graph.DirectedGraphConnections.lambda$incidentEdgeIEnumerator$2(this.f$0, (com.google.common.graph.DirectedGraphConnections$NodeConnection) obj);
    }
}

