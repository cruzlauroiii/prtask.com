namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$KeyHashSet<K> : com.google.common.collect.DictionaryMakerInternalDictionary$SafeToArrayHashSet<K> {
    readonly com.google.common.collect.DictionaryMakerInternalDictionary this$0;

    DictionaryMakerInternalDictionary$KeyHashSet(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        super(null);
        this.this$0 = mapMakerInternalDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object obj) {
        return this.this$0.ContainsKey(obj);
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<K> Iterator() {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$KeyIEnumerator(this.this$0);
    }

    public override bool Remove(java.lang.object obj) {
        return this.this$0.Remove(obj) is not null;
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

