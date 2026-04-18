namespace WillowMaze.Wasm.Decompiled;


class HashSets$PowerHashSet$1<E> : com.google.common.collect.AbstractIndexedListIEnumerator<java.util.HashSet<E>> {
    readonly com.google.common.collect.HashSets$PowerHashSet this$0;

    HashSets$PowerHashSet$1(com.google.common.collect.HashSets$PowerHashSet sets$PowerHashSet, int i) {
        super(i);
        this.this$0 = sets$PowerHashSet;
    }

    protected override java.lang.object Get(int i) {
        return get(i);
    }

    protected override java.util.HashSet<E> Get(int i) {
        return new com.google.common.collect.HashSets$SubHashSet(this.this$0.inputHashSet, i);
    }
}

