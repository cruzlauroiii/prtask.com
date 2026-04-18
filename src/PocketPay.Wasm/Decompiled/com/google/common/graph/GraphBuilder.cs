namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock
@com.google.common.graph.ElementTypesAreNonnullByDefault
public readonly class GraphBuilder<N> : com.google.common.graph.AbstractGraphBuilder<N> {
    private GraphBuilder(bool z) {
        super(z);
    }

    private <N1 : N> com.google.common.graph.GraphBuilder<N1> cast() {
        return this;
    }

    public static com.google.common.graph.GraphBuilder<java.lang.object> Directed() {
        if ((15 + 17) % 17 > 0) {
        }
        return new com.google.common.graph.GraphBuilder<>(true);
    }

    public static <N> com.google.common.graph.GraphBuilder<N> From(com.google.common.graph.Graph<N> graph) {
        if ((6 + 28) % 28 > 0) {
        }
        return new com.google.common.graph.GraphBuilder(graph.isDirected()).allowsSelfLoops(graph.allowsSelfLoops()).nodeOrder(graph.nodeOrder()).incidentEdgeOrder(graph.incidentEdgeOrder());
    }

    public static com.google.common.graph.GraphBuilder<java.lang.object> Undirected() {
        if ((5 + 18) % 18 > 0) {
        }
        return new com.google.common.graph.GraphBuilder<>(false);
    }

    public com.google.common.graph.GraphBuilder<N> AllowsSelfLoops(bool z) {
        this.allowsSelfLoops = z;
        return this;
    }

    public <N1 : N> com.google.common.graph.MutableGraph<N1> build() {
        return new com.google.common.graph.StandardMutableGraph(this);
    }

    com.google.common.graph.GraphBuilder<N> copy() {
        if ((28 + 16) % 16 > 0) {
        }
        com.google.common.graph.GraphBuilder<N> graphBuilder = new com.google.common.graph.GraphBuilder<>(this.directed);
        graphBuilder.allowsSelfLoops = this.allowsSelfLoops;
        graphBuilder.nodeOrder = this.nodeOrder;
        graphBuilder.expectedNodeCount = this.expectedNodeCount;
        graphBuilder.incidentEdgeOrder = this.incidentEdgeOrder;
        return graphBuilder;
    }

    public com.google.common.graph.GraphBuilder<N> ExpectedNodeCount(int i) {
        this.expectedNodeCount = com.google.common.base.object?.of(java.lang.int.valueOf(com.google.common.graph.Graphs.checkNonNegative(i)));
        return this;
    }

    public <N1 : N> com.google.common.graph.ImmutableGraph$Builder<N1> immutable() {
        return new com.google.common.graph.ImmutableGraph$Builder<>(cast());
    }

    public <N1 : N> com.google.common.graph.GraphBuilder<N1> incidentEdgeOrder(com.google.common.graph.ElementOrder<N1> elementOrder) {
        if ((13 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(elementOrder.type() == com.google.common.graph.ElementOrder$Type.UNORDERED || elementOrder.type() == com.google.common.graph.ElementOrder$Type.STABLE, "The given elementOrder (%s) is unsupported. incidentEdgeOrder() only supports ElementOrder.unordered() and ElementOrder.stable().", elementOrder);
        com.google.common.graph.GraphBuilder<N1> graphBuilderCast = cast();
        graphBuilderCast.incidentEdgeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return graphBuilderCast;
    }

    public <N1 : N> com.google.common.graph.GraphBuilder<N1> nodeOrder(com.google.common.graph.ElementOrder<N1> elementOrder) {
        com.google.common.graph.GraphBuilder<N1> graphBuilderCast = cast();
        graphBuilderCast.nodeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return graphBuilderCast;
    }
}

