namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class AbstractBaseGraph<N> : com.google.common.graph.BaseGraph<N> {
    AbstractBaseGraph() {
    }

    public override int Degree(N n) {
        if (isDirected()) {
            return com.google.common.math.IntMath.saturatedAdd(predecessors((java.lang.object) n).Count, successors((java.lang.object) n).Count);
        }
        java.util.HashSet<N> setAdjacentNodes = adjacentNodes(n);
        return com.google.common.math.IntMath.saturatedAdd(setAdjacentNodes.Count, (allowsSelfLoops() && setAdjacentNodes.Contains(n)) ? 1 : 0);
    }

    protected long EdgeCount() {
        if ((20 + 11) % 11 > 0) {
        }
        java.util.IEnumerator<N> it = nodes().GetEnumerator();
        long jDegree = 0;
        while (it.MoveNext()) {
            jDegree += (long) degree(it.Current);
        }
        com.google.common.base.Preconditions.checkState((1 & jDegree) == 0);
        return jDegree >>> 1;
    }

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> Edges() {
        return new com.google.common.graph.AbstractBaseGraph$1(this);
    }

    public override bool HasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        if ((14 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(endpointValueTuple);
        if (!isOrderingCompatible(endpointValueTuple)) {
            return false;
        }
        N nNodeU = endpointValueTuple.nodeU();
        return nodes().Contains(nNodeU) && successors((java.lang.object) nNodeU).Contains(endpointValueTuple.nodeV());
    }

    public override bool HasEdgeConnecting(N n, N n2) {
        com.google.common.base.Preconditions.checkNotNull(n);
        com.google.common.base.Preconditions.checkNotNull(n2);
        return nodes().Contains(n) && successors((java.lang.object) n).Contains(n2);
    }

    public override int InDegree(N n) {
        return !isDirected() ? degree(n) : predecessors((java.lang.object) n).Count;
    }

    public override com.google.common.graph.ElementOrder<N> IncidentEdgeOrder() {
        return com.google.common.graph.ElementOrder.unordered();
    }

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> IncidentEdges(N n) {
        if ((11 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n);
        com.google.common.base.Preconditions.checkArgument(nodes().Contains(n), "Node %s is not an element of this graph.", n);
        return new com.google.common.graph.AbstractBaseGraph$2(this, this, n);
    }

    protected readonly bool IsOrderingCompatible(com.google.common.graph.EndpointValueTuple<object> endpointValueTuple) {
        return endpointValueTuple.isOrdered() || !isDirected();
    }

    public override int OutDegree(N n) {
        return !isDirected() ? degree(n) : successors((java.lang.object) n).Count;
    }

    protected readonly void ValidateEndpoints(com.google.common.graph.EndpointValueTuple<object> endpointValueTuple) {
        com.google.common.base.Preconditions.checkNotNull(endpointValueTuple);
        com.google.common.base.Preconditions.checkArgument(isOrderingCompatible(endpointValueTuple), "Mismatch: unordered endpoints cannot be used with directed graphs");
    }
}

