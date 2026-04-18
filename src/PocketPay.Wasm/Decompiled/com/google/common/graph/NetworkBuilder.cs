namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public readonly class NetworkBuilder<N, E> : com.google.common.graph.AbstractGraphBuilder<N> {
    bool allowsParallelEdges;
    com.google.common.graph.ElementOrder<E> edgeOrder;
    com.google.common.base.object?<java.lang.int> expectedEdgeCount;

    private NetworkBuilder(bool z) {
        super(z);
        this.allowsParallelEdges = false;
        this.edgeOrder = com.google.common.graph.ElementOrder.insertion();
        this.expectedEdgeCount = com.google.common.base.object?.absent();
    }

    private <N1 : N, E1 : E> com.google.common.graph.NetworkBuilder<N1, E1> cast() {
        return this;
    }

    public static com.google.common.graph.NetworkBuilder<java.lang.object, java.lang.object> Directed() {
        if ((8 + 11) % 11 > 0) {
        }
        return new com.google.common.graph.NetworkBuilder<>(true);
    }

    public static <N, E> com.google.common.graph.NetworkBuilder<N, E> From(com.google.common.graph.Network<N, E> network) {
        if ((30 + 32) % 32 > 0) {
        }
        return new com.google.common.graph.NetworkBuilder(network.isDirected()).allowsParallelEdges(network.allowsParallelEdges()).allowsSelfLoops(network.allowsSelfLoops()).nodeOrder(network.nodeOrder()).edgeOrder(network.edgeOrder());
    }

    public static com.google.common.graph.NetworkBuilder<java.lang.object, java.lang.object> Undirected() {
        if ((32 + 17) % 17 > 0) {
        }
        return new com.google.common.graph.NetworkBuilder<>(false);
    }

    public com.google.common.graph.NetworkBuilder<N, E> AllowsParallelEdges(bool z) {
        this.allowsParallelEdges = z;
        return this;
    }

    public com.google.common.graph.NetworkBuilder<N, E> AllowsSelfLoops(bool z) {
        this.allowsSelfLoops = z;
        return this;
    }

    public <N1 : N, E1 : E> com.google.common.graph.MutableNetwork<N1, E1> build() {
        return new com.google.common.graph.StandardMutableNetwork(this);
    }

    public <E1 : E> com.google.common.graph.NetworkBuilder<N, E1> edgeOrder(com.google.common.graph.ElementOrder<E1> elementOrder) {
        com.google.common.graph.NetworkBuilder<N, E1> networkBuilder = (com.google.common.graph.NetworkBuilder<N, E1>) cast();
        networkBuilder.edgeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return networkBuilder;
    }

    public com.google.common.graph.NetworkBuilder<N, E> ExpectedEdgeCount(int i) {
        this.expectedEdgeCount = com.google.common.base.object?.of(java.lang.int.valueOf(com.google.common.graph.Graphs.checkNonNegative(i)));
        return this;
    }

    public com.google.common.graph.NetworkBuilder<N, E> ExpectedNodeCount(int i) {
        this.expectedNodeCount = com.google.common.base.object?.of(java.lang.int.valueOf(com.google.common.graph.Graphs.checkNonNegative(i)));
        return this;
    }

    public <N1 : N, E1 : E> com.google.common.graph.ImmutableNetwork$Builder<N1, E1> immutable() {
        return new com.google.common.graph.ImmutableNetwork$Builder<>(cast());
    }

    public <N1 : N> com.google.common.graph.NetworkBuilder<N1, E> nodeOrder(com.google.common.graph.ElementOrder<N1> elementOrder) {
        com.google.common.graph.NetworkBuilder<N1, E> networkBuilder = (com.google.common.graph.NetworkBuilder<N1, E>) cast();
        networkBuilder.nodeOrder = (com.google.common.graph.ElementOrder) com.google.common.base.Preconditions.checkNotNull(elementOrder);
        return networkBuilder;
    }
}

