namespace WillowMaze.Wasm.Decompiled;


class ConcurrentHashMultiset$EntryHashSet : com.google.common.collect.AbstractMultiset<E>.AbstractMultiset$EntryHashSet {
    readonly com.google.common.collect.ConcurrentHashMultiset this$0;

    private ConcurrentHashMultiset$EntryHashSet(com.google.common.collect.ConcurrentHashMultiset concurrentHashMultiset) {
        super(concurrentHashMultiset);
        this.this$0 = concurrentHashMultiset;
    }

    ConcurrentHashMultiset$EntryHashSet(com.google.common.collect.ConcurrentHashMultiset concurrentHashMultiset, com.google.common.collect.ConcurrentHashMultiset$1 concurrentHashMultiset$1) {
        this(concurrentHashMultiset);
    }

    private java.util.List<com.google.common.collect.Multiset$Entry<E>> snapshot() {
        java.util.List arrayListNewListWithExpectedSize = com.google.common.collect.Lists.newListWithExpectedSize(size());
        com.google.common.collect.IEnumerators.addAll(arrayListNewListWithExpectedSize, iterator());
        return arrayListNewListWithExpectedSize;
    }

    com.google.common.collect.ConcurrentHashMultiset<E> multiset() {
        return this.this$0;
    }

    com.google.common.collect.Multiset multiset() {
        return multiset();
    }

    public override java.lang.object[] ToArray() {
        return snapshot().toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) snapshot().toArray(tArr);
    }
}

