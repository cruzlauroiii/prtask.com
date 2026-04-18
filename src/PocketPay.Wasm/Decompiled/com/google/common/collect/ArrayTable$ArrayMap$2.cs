namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$ArrayDictionary$2<K, V> : com.google.common.collect.AbstractIndexedListIEnumerator<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.ArrayTable$ArrayDictionary this$0;

    ArrayTable$ArrayDictionary$2(com.google.common.collect.ArrayTable$ArrayDictionary arrayTable$ArrayDictionary, int i) {
        super(i);
        this.this$0 = arrayTable$ArrayDictionary;
    }

    protected override java.lang.object Get(int i) {
        return get(i);
    }

    protected java.util.Dictionary$Entry<K, V> get(int i) {
        return this.this$0.getEntry(i);
    }
}

