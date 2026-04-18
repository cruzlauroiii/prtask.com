namespace WillowMaze.Wasm.Decompiled;


abstract class DirectedGraphConnections$NodeConnection<N> {
    readonly N node;

    DirectedGraphConnections$NodeConnection(N n) {
        this.node = (N) com.google.common.base.Preconditions.checkNotNull(n);
    }
}

