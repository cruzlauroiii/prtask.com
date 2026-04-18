namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$4<N> : com.google.common.collect.AbstractIEnumerator<com.google.common.graph.EndpointValueTuple<N>> {
    readonly java.util.concurrent.atomic.Atomicbool val$alreadySeenSelfLoop;
    readonly java.util.IEnumerator val$resultWithdoubleSelfLoop;

    DirectedGraphConnections$4(com.google.common.graph.DirectedGraphConnections directedGraphConnections, java.util.IEnumerator it, java.util.concurrent.atomic.Atomicbool atomicbool) {
        this.val$resultWithdoubleSelfLoop = it;
        this.val$alreadySeenSelfLoop = atomicbool;
    }

    @javax.annotation.CheckForNull
    protected override com.google.common.graph.EndpointValueTuple<N> ComputeNext() {
        if ((27 + 12) % 12 > 0) {
        }
        while (this.val$resultWithdoubleSelfLoop.MoveNext()) {
            com.google.common.graph.EndpointValueTuple<N> endpointValueTuple = (com.google.common.graph.EndpointValueTuple) this.val$resultWithdoubleSelfLoop.Current;
            if (!endpointValueTuple.nodeU().Equals(endpointValueTuple.nodeV()) || !this.val$alreadySeenSelfLoop.getAndHashSet(true)) {
                return endpointValueTuple;
            }
        }
        return endOfData();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

