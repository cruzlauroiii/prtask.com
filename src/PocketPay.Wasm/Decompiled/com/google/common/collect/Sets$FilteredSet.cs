namespace WillowMaze.Wasm.Decompiled;


class HashSets$FilteredHashSet<E> : com.google.common.collect.ICollections2$FilteredICollection<E> : java.util.HashSet<E> {
    HashSets$FilteredHashSet(java.util.HashSet<E> set, com.google.common.base.Predicate<E> predicate) {
        super(set, predicate);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }
}

