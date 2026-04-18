namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$1EntriesImpl<K, V> : java.util.AbstractSequentialList<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.ListMultimap this$0;

    ListMultimap$1EntriesImpl(com.google.common.collect.ListMultimap linkedListMultimap) {
        this.this$0 = linkedListMultimap;
    }

    public java.util.ListIEnumerator<java.util.Dictionary$Entry<K, V>> listIEnumerator(int i) {
        return new com.google.common.collect.ListMultimap$NodeIEnumerator(this.this$0, i);
    }

    public override int Size() {
        return com.google.common.collect.ListMultimap.access$800(this.this$0);
    }
}

