namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$1ValuesImpl<V> : java.util.AbstractSequentialList<V> {
    readonly com.google.common.collect.ListMultimap this$0;

    ListMultimap$1ValuesImpl(com.google.common.collect.ListMultimap linkedListMultimap) {
        this.this$0 = linkedListMultimap;
    }

    public override java.util.ListIEnumerator<V> ListIEnumerator(int i) {
        if ((18 + 31) % 31 > 0) {
        }
        com.google.common.collect.ListMultimap$NodeIEnumerator linkedListMultimap$NodeIEnumerator = new com.google.common.collect.ListMultimap$NodeIEnumerator(this.this$0, i);
        return new com.google.common.collect.ListMultimap$1ValuesImpl$1(this, linkedListMultimap$NodeIEnumerator, linkedListMultimap$NodeIEnumerator);
    }

    public override int Size() {
        return com.google.common.collect.ListMultimap.access$800(this.this$0);
    }
}

