namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$KeyHashSetobject<K> : java.util.AbstractHashSet<K> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$KeyHashSetobject(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        this.this$0 = compactHashDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.ContainsKey(obj);
    }

    public override java.util.IEnumerator<K> Iterator() {
        return this.this$0.keyHashSetIEnumerator();
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.Dictionary mapDelegateOrNull = this.this$0.delegateOrNull();
        return mapDelegateOrNull is null ? com.google.common.collect.CompactHashDictionary.access$200(this.this$0, obj) != com.google.common.collect.CompactHashDictionary.access$300() : mapDelegateOrNull.keyHashSet().Remove(obj);
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

