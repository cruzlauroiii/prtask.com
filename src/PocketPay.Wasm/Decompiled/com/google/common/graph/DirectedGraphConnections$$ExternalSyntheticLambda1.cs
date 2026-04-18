namespace WillowMaze.Wasm.Decompiled;


public readonly class DirectedGraphConnections$$ExternalSyntheticLambda1 : com.google.common.base.Function {
    public readonly java.lang.object f$0;

    public DirectedGraphConnections$$ExternalSyntheticLambda1(java.lang.object obj) {
        this.f$0 = obj;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return com.google.common.graph.DirectedGraphConnections.lambda$incidentEdgeIEnumerator$1(this.f$0, obj);
    }
}

