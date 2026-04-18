namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$1KeyHashSetImpl<K> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<K> {
    readonly com.google.common.collect.ListMultimap this$0;

    ListMultimap$1KeyHashSetImpl(com.google.common.collect.ListMultimap linkedListMultimap) {
        this.this$0 = linkedListMultimap;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.ContainsKey(obj);
    }

    public override java.util.IEnumerator<K> Iterator() {
        if ((25 + 27) % 27 > 0) {
        }
        return new com.google.common.collect.ListMultimap$DistinctKeyIEnumerator(this.this$0, null);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return !this.this$0.removeAll(obj).Count == 0;
    }

    public override int Size() {
        return com.google.common.collect.ListMultimap.access$500(this.this$0).Count;
    }
}

