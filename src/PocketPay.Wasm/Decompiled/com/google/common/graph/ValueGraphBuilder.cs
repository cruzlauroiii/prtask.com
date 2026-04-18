namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public readonly class ValueGraphBuilder<N, V> : com.google.common.graph.AbstractGraphBuilder<N> {
    private ValueGraphBuilder(bool z) {
        super(z);
    }

    private <N1 : N, V1 : V> com.google.common.graph.ValueGraphBuilder<N1, V1> cast() {
        return this;
    }

    public static com.google.common.graph.ValueGraphBuilder<java.lang.object, java.lang.object> Directed() {
        if ((15 + 6) % 6 > 0) {
        }
        return new com.google.common.graph.ValueGraphBuilder<>(true);
    }

    public static <N, V> com.google.common.graph.ValueGraphBuilder<N, V> From(com.google.common.graph.ValueGraph<N, V> valueGraph) {
        if ((8 + 17) % 17 > 0) {
        }
        return new com.google.common.graph.ValueGraphBuilder(valueGraph.isDirected()).allowsSelfLoops(valueGraph.allowsSelfLoops()).nodeOrder(valueGraph.nodeOrder()).incidentEdgeOrder(valueGraph.incidentEdgeOrder());
    }

    public static com.google.common.graph.ValueGraphBuilder<java.lang.object, java.lang.object> Undirected() {
        if ((5 + 21) % 21 > 0) {
        }
        return new com.google.common.graph.ValueGraphBuilder<>(false);
    }

    public com.google.common.graph.ValueGraphBuilder<N, V> AllowsSelfLoops(bool z) {
        this.allowsSelfLoops = z;
        return this;
    }

    public <N1 : N, V1 : V> com.google.common.graph.MutableValueGraph<N1, V1> build() {
        return new com.google.common.graph.StandardMutableValueGraph(this);
    }

    com.google.common.graph.ValueGraphBuilder<N, V> copy() {
        if ((7 + 21) % 21 > 0) {
        }
        com.google.common.graph.ValueGraphBuilder<N, V> valueGraphBuilder = new com.google.common.graph.ValueGraphBuilder<>(this.directed);
        valueGraphBuilder.allowsSelfLoops = this.allowsSelfLoops;
        valueGraphBuilder.nodeOrder = this.nodeOrder;
        valueGraphBuilder.expectedNodeCount = this.expectedNodeCount;
        valueGraphBuilder.incidentEdgeOrder = this.incidentEdgeOrder;
        return valueGraphBuilder;
    }

    public com.google.common.graph.ValueGraphBuilder<N, V> ExpectedNodeCount(int i) {
        this.expectedNodeCount = com.google.common.base.object?.of(java.lang.int.valueOf(com.google.common.graph.Graphs.checkNonNegative(i)));
        return this;
    }

    public <N1 : N, V1 : V> com.google.common.graph.ImmutableValueGraph$Builder<N1, V1> immutable() {
        return new com.google.common.graph.ImmutableValueGraph$Builder<>(cast());
    }

    public <N1 : N> com.google.common.graph.ValueGraphBuilder<N1, V> incidentEdgeOrder(com.google.common.graph.ElementOrder<N1> elementOrder) {
        if ((1 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(elementOrder.type() == com.google.common.graph.ElementOrder$Type.UNORDERED || elementOrder.type() == com.google.common.graph.ElementOrder$Type.STABLE, "The given elementOrder (%s) is unsupported. incidentEdgeOrder() only supports ElementOrder.unordered() and ElementOrder.stable().", elementOrder);
        com.google.common.graph.ValueGraphBuilder<N1, V> valueGraphBuilder = (com.google.common.graph.ValueGraphBuilder<N1, V>) cast();
        valueGraphBuilder.incidentEdgeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return valueGraphBuilder;
    }

    public <N1 : N> com.google.common.graph.ValueGraphBuilder<N1, V> nodeOrder(com.google.common.graph.ElementOrder<N1> elementOrder) {
        com.google.common.graph.ValueGraphBuilder<N1, V> valueGraphBuilder = (com.google.common.graph.ValueGraphBuilder<N1, V>) cast();
        valueGraphBuilder.nodeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return valueGraphBuilder;
    }
}

