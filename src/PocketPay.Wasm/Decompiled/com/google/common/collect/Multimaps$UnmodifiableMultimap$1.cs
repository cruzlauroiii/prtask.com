namespace WillowMaze.Wasm.Decompiled;


class Multimaps$UnmodifiableMultimap$1<V> : com.google.common.base.Function<java.util.ICollection<V>, java.util.ICollection<V>> {
    Multimaps$UnmodifiableMultimap$1(com.google.common.collect.Multimaps$UnmodifiableMultimap multimaps$UnmodifiableMultimap) {
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.ICollection) obj);
    }

    public java.util.ICollection<V> Apply(java.util.ICollection<V> collection) {
        return com.google.common.collect.Multimaps.access$000(collection);
    }
}

