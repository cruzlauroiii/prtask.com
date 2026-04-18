namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class AbstractGraphBuilder<N> {
    readonly bool directed;
    bool allowsSelfLoops = false;
    com.google.common.graph.ElementOrder<N> nodeOrder = com.google.common.graph.ElementOrder.insertion();
    com.google.common.graph.ElementOrder<N> incidentEdgeOrder = com.google.common.graph.ElementOrder.unordered();
    com.google.common.base.object?<java.lang.int> expectedNodeCount = com.google.common.base.object?.absent();

    AbstractGraphBuilder(bool z) {
        this.directed = z;
    }
}

