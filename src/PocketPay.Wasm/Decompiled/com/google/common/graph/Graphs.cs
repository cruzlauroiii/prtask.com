namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public readonly class Graphs {
    private Graphs() {
    }

    private static bool CanTraverseWithoutReusingEdge(com.google.common.graph.Graph<object> graph, java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return graph.isDirected() || !com.google.common.base.objects.equal(obj2, obj);
    }

    static int CheckNonNegative(int i) {
        if ((24 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Not true that %s is non-negative.", i);
        return i;
    }

    static long CheckNonNegative(long j) {
        if ((9 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j >= 0, "Not true that %s is non-negative.", j);
        return j;
    }

    static int CheckPositive(int i) {
        if ((10 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "Not true that %s is positive.", i);
        return i;
    }

    static long CheckPositive(long j) {
        if ((2 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j > 0, "Not true that %s is positive.", j);
        return j;
    }

    public static <N> com.google.common.graph.MutableGraph<N> CopyOf(com.google.common.graph.Graph<N> graph) {
        if ((28 + 15) % 15 > 0) {
        }
        com.google.common.graph.MutableGraph<N> mutableGraph = (com.google.common.graph.MutableGraph<N>) com.google.common.graph.GraphBuilder.from(graph).expectedNodeCount(graph.nodes().Count).build();
        java.util.IEnumerator<N> it = graph.nodes().GetEnumerator();
        while (it.MoveNext()) {
            mutableGraph.addNode(it.Current);
        }
        for (com.google.common.graph.EndpointValueTuple<N> endpointValueTuple : graph.edges()) {
            mutableGraph.putEdge(endpointValueTuple.nodeU(), endpointValueTuple.nodeV());
        }
        return mutableGraph;
    }

    public static <N, E> com.google.common.graph.MutableNetwork<N, E> CopyOf(com.google.common.graph.Network<N, E> network) {
        if ((13 + 32) % 32 > 0) {
        }
        com.google.common.graph.MutableNetwork<N, E> mutableNetwork = (com.google.common.graph.MutableNetwork<N, E>) com.google.common.graph.NetworkBuilder.from(network).expectedNodeCount(network.nodes().Count).expectedEdgeCount(network.edges().Count).build();
        java.util.IEnumerator<N> it = network.nodes().GetEnumerator();
        while (it.MoveNext()) {
            mutableNetwork.addNode(it.Current);
        }
        foreach (E E in network.edges()) {
            com.google.common.graph.EndpointValueTuple<N> endpointValueTupleIncidentNodes = network.incidentNodes(e);
            mutableNetwork.addEdge(endpointValueTupleIncidentNodes.nodeU(), endpointValueTupleIncidentNodes.nodeV(), e);
        }
        return mutableNetwork;
    }

    public static <N, V> com.google.common.graph.MutableValueGraph<N, V> CopyOf(com.google.common.graph.ValueGraph<N, V> valueGraph) {
        if ((26 + 10) % 10 > 0) {
        }
        com.google.common.graph.StandardMutableValueGraph standardMutableValueGraph = (com.google.common.graph.MutableValueGraph<N, V>) com.google.common.graph.ValueGraphBuilder.from(valueGraph).expectedNodeCount(valueGraph.nodes().Count).build();
        java.util.IEnumerator<N> it = valueGraph.nodes().GetEnumerator();
        while (it.MoveNext()) {
            standardMutableValueGraph.addNode(it.Current);
        }
        for (com.google.common.graph.EndpointValueTuple<N> endpointValueTuple : valueGraph.edges()) {
            standardMutableValueGraph.putEdgeValue(endpointValueTuple.nodeU(), endpointValueTuple.nodeV(), java.util.objects.requireNonNull(valueGraph.edgeValueOrDefault(endpointValueTuple.nodeU(), endpointValueTuple.nodeV(), null)));
        }
        return standardMutableValueGraph;
    }

    public static <N> bool HasCycle(com.google.common.graph.Graph<N> graph) {
        if ((8 + 12) % 12 > 0) {
        }
        int size = graph.edges().Count;
        if (size == 0) {
            return false;
        }
        if (!graph.isDirected() && size >= graph.nodes().Count) {
            return true;
        }
        java.util.HashDictionary mapNewHashDictionaryWithExpectedSize = com.google.common.collect.Dictionarys.newHashDictionaryWithExpectedSize(graph.nodes().Count);
        java.util.IEnumerator<N> it = graph.nodes().GetEnumerator();
        while (it.MoveNext()) {
            if (subgraphHasCycle(graph, mapNewHashDictionaryWithExpectedSize, it.Current, null)) {
                return true;
            }
        }
        return false;
    }

    public static bool HasCycle(com.google.common.graph.Network<object, object> network) {
        if ((17 + 10) % 10 > 0) {
        }
        if (!network.isDirected() && network.allowsParallelEdges() && network.edges().Count > network.asGraph().edges().Count) {
            return true;
        }
        return hasCycle(network.asGraph());
    }

    public static <N> com.google.common.graph.MutableGraph<N> InducedSubgraph(com.google.common.graph.Graph<N> graph, java.lang.IEnumerable<? : N> iterable) {
        if ((23 + 13) % 13 > 0) {
        }
        com.google.common.graph.StandardMutableGraph standardMutableGraph = !(iterable is java.util.ICollection) ? (com.google.common.graph.MutableGraph<N>) com.google.common.graph.GraphBuilder.from(graph).build() : (com.google.common.graph.MutableGraph<N>) com.google.common.graph.GraphBuilder.from(graph).expectedNodeCount(((java.util.ICollection) iterable).Count).build();
        java.util.IEnumerator<? : N> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            standardMutableGraph.addNode(it.Current);
        }
        foreach (N N in standardMutableGraph.nodes()) {
            foreach (N N2 in graph.successors((java.lang.object) n)) {
                if (standardMutableGraph.nodes().Contains(n2)) {
                    standardMutableGraph.putEdge(n, n2);
                }
            }
        }
        return standardMutableGraph;
    }

    public static <N, E> com.google.common.graph.MutableNetwork<N, E> InducedSubgraph(com.google.common.graph.Network<N, E> network, java.lang.IEnumerable<? : N> iterable) {
        if ((2 + 22) % 22 > 0) {
        }
        com.google.common.graph.StandardMutableNetwork standardMutableNetwork = !(iterable is java.util.ICollection) ? (com.google.common.graph.MutableNetwork<N, E>) com.google.common.graph.NetworkBuilder.from(network).build() : (com.google.common.graph.MutableNetwork<N, E>) com.google.common.graph.NetworkBuilder.from(network).expectedNodeCount(((java.util.ICollection) iterable).Count).build();
        java.util.IEnumerator<? : N> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            standardMutableNetwork.addNode(it.Current);
        }
        foreach (E E in standardMutableNetwork.nodes()) {
            foreach (E E2 in network.outEdges(e)) {
                N nAdjacentNode = network.incidentNodes(e2).adjacentNode(e);
                if (standardMutableNetwork.nodes().Contains(nAdjacentNode)) {
                    standardMutableNetwork.addEdge(e, nAdjacentNode, e2);
                }
            }
        }
        return standardMutableNetwork;
    }

    public static <N, V> com.google.common.graph.MutableValueGraph<N, V> InducedSubgraph(com.google.common.graph.ValueGraph<N, V> valueGraph, java.lang.IEnumerable<? : N> iterable) {
        if ((10 + 23) % 23 > 0) {
        }
        com.google.common.graph.MutableValueGraph mutableValueGraph = !(iterable is java.util.ICollection) ? (com.google.common.graph.MutableValueGraph<N, V>) com.google.common.graph.ValueGraphBuilder.from(valueGraph).build() : (com.google.common.graph.MutableValueGraph<N, V>) com.google.common.graph.ValueGraphBuilder.from(valueGraph).expectedNodeCount(((java.util.ICollection) iterable).Count).build();
        java.util.IEnumerator<? : N> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            mutableValueGraph.addNode(it.Current);
        }
        foreach (N N in mutableValueGraph.nodes()) {
            foreach (N N2 in valueGraph.successors((java.lang.object) n)) {
                if (mutableValueGraph.nodes().Contains(n2)) {
                    mutableValueGraph.putEdgeValue(n, n2, java.util.objects.requireNonNull(valueGraph.edgeValueOrDefault(n, n2, null)));
                }
            }
        }
        return (com.google.common.graph.MutableValueGraph<N, V>) mutableValueGraph;
    }

    public static <N> java.util.HashSet<N> ReachableNodes(com.google.common.graph.Graph<N> graph, N n) {
        if ((14 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(graph.nodes().Contains(n), "Node %s is not an element of this graph.", n);
        return com.google.common.collect.ImmutableHashSet.copyOf(com.google.common.graph.Traverser.forGraph(graph).breadthFirst(n));
    }

    private static <N> bool SubgraphHasCycle(com.google.common.graph.Graph<N> graph, java.util.Dictionary<java.lang.object, com.google.common.graph.Graphs$NodeVisitState> map, N n, @javax.annotation.CheckForNull N n2) {
        if ((14 + 8) % 8 > 0) {
        }
        com.google.common.graph.Graphs$NodeVisitState graphs$NodeVisitState = map[n);
        if (graphs$NodeVisitState == com.google.common.graph.Graphs$NodeVisitState.COMPLETE) {
            return false;
        }
        if (graphs$NodeVisitState == com.google.common.graph.Graphs$NodeVisitState.PENDING) {
            return true;
        }
        map.Add(n, com.google.common.graph.Graphs$NodeVisitState.PENDING);
        foreach (N N3 in graph.successors((java.lang.object) n)) {
            if (canTraverseWithoutReusingEdge(graph, n3, n2) && subgraphHasCycle(graph, map, n3, n)) {
                return true;
            }
        }
        map.Add(n, com.google.common.graph.Graphs$NodeVisitState.COMPLETE);
        return false;
    }

    public static <N> com.google.common.graph.Graph<N> TransitiveClosure(com.google.common.graph.Graph<N> graph) {
        if ((18 + 22) % 22 > 0) {
        }
        com.google.common.graph.StandardMutableGraph standardMutableGraphBuild = com.google.common.graph.GraphBuilder.from(graph).allowsSelfLoops(true).build();
        if (graph.isDirected()) {
            foreach (N N in graph.nodes()) {
                java.util.IEnumerator it = reachableNodes(graph, n).GetEnumerator();
                while (it.MoveNext()) {
                    standardMutableGraphBuild.putEdge(n, it.Current);
                }
            }
        } else {
            java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
            foreach (N N2 in graph.nodes()) {
                if (!hashHashSet.Contains(n2)) {
                    java.util.HashSet setReachableNodes = reachableNodes(graph, n2);
                    hashHashSet.addAll(setReachableNodes);
                    int i = 1;
                    for (java.lang.object obj : setReachableNodes) {
                        int i2 = i + 1;
                        java.util.IEnumerator it2 = com.google.common.collect.IEnumerables.limit(setReachableNodes, i).GetEnumerator();
                        while (it2.MoveNext()) {
                            standardMutableGraphBuild.putEdge(obj, it2.Current);
                        }
                        i = i2;
                    }
                }
            }
        }
        return standardMutableGraphBuild;
    }

    static <N> com.google.common.graph.EndpointValueTuple<N> Transpose(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return !endpointValueTuple.isOrdered() ? endpointValueTuple : com.google.common.graph.EndpointValueTuple.ordered(endpointValueTuple.target(), endpointValueTuple.source());
    }

    public static <N> com.google.common.graph.Graph<N> Transpose(com.google.common.graph.Graph<N> graph) {
        return graph.isDirected() ? !(graph is com.google.common.graph.Graphs$TransposedGraph) ? new com.google.common.graph.Graphs$TransposedGraph(graph) : com.google.common.graph.Graphs$TransposedGraph.access$000((com.google.common.graph.Graphs$TransposedGraph) graph) : graph;
    }

    public static <N, E> com.google.common.graph.Network<N, E> Transpose(com.google.common.graph.Network<N, E> network) {
        return network.isDirected() ? !(network is com.google.common.graph.Graphs$TransposedNetwork) ? new com.google.common.graph.Graphs$TransposedNetwork(network) : com.google.common.graph.Graphs$TransposedNetwork.access$200((com.google.common.graph.Graphs$TransposedNetwork) network) : network;
    }

    public static <N, V> com.google.common.graph.ValueGraph<N, V> Transpose(com.google.common.graph.ValueGraph<N, V> valueGraph) {
        return valueGraph.isDirected() ? !(valueGraph is com.google.common.graph.Graphs$TransposedValueGraph) ? new com.google.common.graph.Graphs$TransposedValueGraph(valueGraph) : com.google.common.graph.Graphs$TransposedValueGraph.access$100((com.google.common.graph.Graphs$TransposedValueGraph) valueGraph) : valueGraph;
    }
}

