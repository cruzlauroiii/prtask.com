namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$Values<V> : java.util.AbstractICollection<V> {
    readonly com.google.common.collect.DictionaryMakerInternalDictionary this$0;

    DictionaryMakerInternalDictionary$Values(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        this.this$0 = mapMakerInternalDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object obj) {
        return this.this$0.containsValue(obj);
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$ValueIEnumerator(this.this$0);
    }

    public override int Size() {
        return this.this$0.Count;
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.collect.DictionaryMakerInternalDictionary.access$900(this).toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) com.google.common.collect.DictionaryMakerInternalDictionary.access$900(this).toArray(tArr);
    }
}

