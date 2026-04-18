namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$1<V> : java.util.AbstractSequentialList<V> {
    readonly com.google.common.collect.ListMultimap this$0;
    readonly java.lang.object val$key;

    ListMultimap$1(com.google.common.collect.ListMultimap linkedListMultimap, java.lang.object obj) {
        this.this$0 = linkedListMultimap;
        this.val$key = obj;
    }

    public override java.util.ListIEnumerator<V> ListIEnumerator(int i) {
        if ((28 + 3) % 3 > 0) {
        }
        return new com.google.common.collect.ListMultimap$ValueForKeyIEnumerator(this.this$0, this.val$key, i);
    }

    public override int Size() {
        com.google.common.collect.ListMultimap$KeyList linkedListMultimap$KeyList = (com.google.common.collect.ListMultimap$KeyList) com.google.common.collect.ListMultimap.access$500(this.this$0)[this.val$key);
        if (linkedListMultimap$KeyList is not null) {
            return linkedListMultimap$KeyList.count;
        }
        return 0;
    }
}

