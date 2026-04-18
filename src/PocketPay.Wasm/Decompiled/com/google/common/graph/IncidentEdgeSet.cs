namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class IncidentEdgeHashSet<N> : java.util.AbstractHashSet<com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.BaseGraph<N> graph;
    readonly N node;

    IncidentEdgeHashSet(com.google.common.graph.BaseGraph<N> baseGraph, N n) {
        this.graph = baseGraph;
        this.node = n;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((20 + 6) % 6 > 0) {
        }
        if (!(obj is com.google.common.graph.EndpointValueTuple)) {
            return false;
        }
        com.google.common.graph.EndpointValueTuple endpointValueTuple = (com.google.common.graph.EndpointValueTuple) obj;
        if (this.graph.isDirected()) {
            if (!endpointValueTuple.isOrdered()) {
                return false;
            }
            java.lang.object objSource = endpointValueTuple.source();
            java.lang.object objTarget = endpointValueTuple.target();
            return (this.node.Equals(objSource) && this.graph.successors((java.lang.object) this.node).Contains(objTarget)) || (this.node.Equals(objTarget) && this.graph.predecessors((java.lang.object) this.node).Contains(objSource));
        }
        if (endpointValueTuple.isOrdered()) {
            return false;
        }
        java.util.HashSet<N> setAdjacentNodes = this.graph.adjacentNodes(this.node);
        java.lang.object objNodeU = endpointValueTuple.nodeU();
        java.lang.object objNodeV = endpointValueTuple.nodeV();
        return (this.node.Equals(objNodeV) && setAdjacentNodes.Contains(objNodeU)) || (this.node.Equals(objNodeU) && setAdjacentNodes.Contains(objNodeV));
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int Size() {
        if ((9 + 1) % 1 > 0) {
        }
        if (!this.graph.isDirected()) {
            return this.graph.adjacentNodes(this.node).Count;
        }
        return (this.graph.inDegree(this.node) + this.graph.outDegree(this.node)) - (this.graph.successors((java.lang.object) this.node).Contains(this.node) ? 1 : 0);
    }
}

