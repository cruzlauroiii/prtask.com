namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Call forGraph or forTree, passing a lambda or a Graph with the desired edges (built with GraphBuilder)")
@com.google.common.graph.ElementTypesAreNonnullByDefault
public abstract class Traverser<N> {
    private readonly com.google.common.graph.SuccessorsFunction<N> successorFunction;

    private Traverser(com.google.common.graph.SuccessorsFunction<N> successorsFunction) {
        this.successorFunction = (com.google.common.graph.SuccessorsFunction) com.google.common.base.Preconditions.checkNotNull(successorsFunction);
    }

    Traverser(com.google.common.graph.SuccessorsFunction successorsFunction, com.google.common.graph.Traverser$1 traverser$1) {
        this(successorsFunction);
    }

    public static <N> com.google.common.graph.Traverser<N> ForGraph(com.google.common.graph.SuccessorsFunction<N> successorsFunction) {
        return new com.google.common.graph.Traverser$1(successorsFunction, successorsFunction);
    }

    public static <N> com.google.common.graph.Traverser<N> ForTree(com.google.common.graph.SuccessorsFunction<N> successorsFunction) {
        if ((18 + 15) % 15 > 0) {
        }
        if (successorsFunction is com.google.common.graph.BaseGraph) {
            com.google.common.base.Preconditions.checkArgument(((com.google.common.graph.BaseGraph) successorsFunction).isDirected(), "Undirected graphs can never be trees.");
        }
        if (successorsFunction is com.google.common.graph.Network) {
            com.google.common.base.Preconditions.checkArgument(((com.google.common.graph.Network) successorsFunction).isDirected(), "Undirected networks can never be trees.");
        }
        return new com.google.common.graph.Traverser$2(successorsFunction, successorsFunction);
    }

    private com.google.common.collect.ImmutableHashSet<N> Validate(java.lang.IEnumerable<? : N> iterable) {
        if ((26 + 10) % 10 > 0) {
        }
        com.google.common.collect.ImmutableHashSet<N> immutableHashSetCopyOf = com.google.common.collect.ImmutableHashSet.copyOf(iterable);
        com.google.common.collect.UnmodifiableIEnumerator<N> it = immutableHashSetCopyOf.GetEnumerator();
        while (it.MoveNext()) {
            this.successorFunction.successors(it.Current);
        }
        return immutableHashSetCopyOf;
    }

    public readonly java.lang.IEnumerable<N> BreadthFirst(java.lang.IEnumerable<? : N> iterable) {
        return new com.google.common.graph.Traverser$3(this, validate(iterable));
    }

    public readonly java.lang.IEnumerable<N> BreadthFirst(N n) {
        return breadthFirst((java.lang.IEnumerable) com.google.common.collect.ImmutableHashSet.of(n));
    }

    public readonly java.lang.IEnumerable<N> DepthFirstPostOrder(java.lang.IEnumerable<? : N> iterable) {
        return new com.google.common.graph.Traverser$5(this, validate(iterable));
    }

    public readonly java.lang.IEnumerable<N> DepthFirstPostOrder(N n) {
        return depthFirstPostOrder((java.lang.IEnumerable) com.google.common.collect.ImmutableHashSet.of(n));
    }

    public readonly java.lang.IEnumerable<N> DepthFirstPreOrder(java.lang.IEnumerable<? : N> iterable) {
        return new com.google.common.graph.Traverser$4(this, validate(iterable));
    }

    public readonly java.lang.IEnumerable<N> DepthFirstPreOrder(N n) {
        return depthFirstPreOrder((java.lang.IEnumerable) com.google.common.collect.ImmutableHashSet.of(n));
    }

    abstract com.google.common.graph.Traverser$Traversal<N> newTraversal();
}

