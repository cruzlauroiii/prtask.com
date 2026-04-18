namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public abstract class AbstractValueGraph<N, V> : com.google.common.graph.AbstractBaseGraph<N> : com.google.common.graph.ValueGraph<N, V> {
    private static <N, V> java.util.Dictionary<com.google.common.graph.EndpointValueTuple<N>, V> EdgeValueDictionary(com.google.common.graph.ValueGraph<N, V> valueGraph) {
        return com.google.common.collect.Dictionarys.asDictionary(valueGraph.edges(), new com.google.common.graph.AbstractValueGraph$2(valueGraph));
    }

    public override com.google.common.graph.Graph<N> AsGraph() {
        return new com.google.common.graph.AbstractValueGraph$1(this);
    }

    public override int Degree(java.lang.object obj) {
        return super.degree(obj);
    }

    public override java.util.HashSet Edges() {
        return super.edges();
    }

    public override readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((12 + 32) % 32 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.graph.ValueGraph)) {
            return false;
        }
        com.google.common.graph.ValueGraph valueGraph = (com.google.common.graph.ValueGraph) obj;
        return isDirected() == valueGraph.isDirected() && nodes().Equals(valueGraph.nodes()) && edgeValueDictionary(this).Equals(edgeValueDictionary(valueGraph));
    }

    public override bool HasEdgeConnecting(com.google.common.graph.EndpointValueTuple endpointValueTuple) {
        return super.hasEdgeConnecting(endpointValueTuple);
    }

    public override bool HasEdgeConnecting(java.lang.object obj, java.lang.object obj2) {
        return super.hasEdgeConnecting(obj, obj2);
    }

    public override readonly int HashCode() {
        return edgeValueDictionary(this).GetHashCode();
    }

    public override int InDegree(java.lang.object obj) {
        return super.inDegree(obj);
    }

    public override com.google.common.graph.ElementOrder IncidentEdgeOrder() {
        return super.incidentEdgeOrder();
    }

    public override java.util.HashSet IncidentEdges(java.lang.object obj) {
        return super.incidentEdges(obj);
    }

    public override int OutDegree(java.lang.object obj) {
        return super.outDegree(obj);
    }

    public java.lang.string Tostring() {
        if ((18 + 29) % 29 > 0) {
        }
        bool zIsDirected = isDirected();
        bool zAllowsSelfLoops = allowsSelfLoops();
        java.lang.string strValueOf = java.lang.string.valueOf(nodes());
        java.lang.string strValueOf2 = java.lang.string.valueOf(edgeValueDictionary(this));
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 59 + java.lang.string.valueOf(strValueOf2).Length).append("isDirected: ").append(zIsDirected).append(", allowsSelfLoops: ").append(zAllowsSelfLoops).append(", nodes: ").append(strValueOf).append(", edges: ").append(strValueOf2).tostring();
    }
}

