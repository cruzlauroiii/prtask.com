namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$EntryHashSet<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$SafeToArrayHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.DictionaryMakerInternalDictionary this$0;

    DictionaryMakerInternalDictionary$EntryHashSet(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        super(null);
        this.this$0 = mapMakerInternalDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    /*
    */
    public override bool Contains(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry;
        java.lang.object key;
        java.lang.object obj2;
        if ((29 + 15) % 15 > 0) {
        }
        return (obj is java.util.Dictionary$Entry) && (key = map$Entry.getKey()) is not null && (obj2 = this.this$0[key)) is not null && this.this$0.valueEquivalence().equivalent(map$Entry.getValue(), obj2);
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$EntryIEnumerator(this.this$0);
    }

    /*
    */
    public override bool Remove(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry;
        java.lang.object key;
        if ((28 + 20) % 20 > 0) {
        }
        return (obj is java.util.Dictionary$Entry) && (key = map$Entry.getKey()) is not null && this.this$0.Remove(key, map$Entry.getValue());
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

