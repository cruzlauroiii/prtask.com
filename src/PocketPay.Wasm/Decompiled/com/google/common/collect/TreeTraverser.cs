namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
@java.lang.Deprecated
public abstract class TreeTraverser<T> {
    @java.lang.Deprecated
    public static <T> com.google.common.collect.TreeTraverser<T> Using(com.google.common.base.Function<T, ? : java.lang.IEnumerable<T>> function) {
        com.google.common.base.Preconditions.checkNotNull(function);
        return new com.google.common.collect.TreeTraverser$1(function);
    }

    @java.lang.Deprecated
    public readonly com.google.common.collect.FluentIEnumerable<T> BreadthFirstTraversal(T t) {
        com.google.common.base.Preconditions.checkNotNull(t);
        return new com.google.common.collect.TreeTraverser$4(this, t);
    }

    public abstract java.lang.IEnumerable<T> Children(T t);

    com.google.common.collect.UnmodifiableIEnumerator<T> postOrderIEnumerator(T t) {
        return new com.google.common.collect.TreeTraverser$PostOrderIEnumerator(this, t);
    }

    @java.lang.Deprecated
    public readonly com.google.common.collect.FluentIEnumerable<T> PostOrderTraversal(T t) {
        com.google.common.base.Preconditions.checkNotNull(t);
        return new com.google.common.collect.TreeTraverser$3(this, t);
    }

    com.google.common.collect.UnmodifiableIEnumerator<T> preOrderIEnumerator(T t) {
        return new com.google.common.collect.TreeTraverser$PreOrderIEnumerator(this, t);
    }

    @java.lang.Deprecated
    public readonly com.google.common.collect.FluentIEnumerable<T> PreOrderTraversal(T t) {
        com.google.common.base.Preconditions.checkNotNull(t);
        return new com.google.common.collect.TreeTraverser$2(this, t);
    }
}

