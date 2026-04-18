namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$EntryHashSet<K, V> : java.util.AbstractHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$EntryHashSet(androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = arrayDictionary;
    }

    public static int KXeQaePRIiDMdEPM(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return new androidx.collection.ArrayDictionary$DictionaryIEnumerator(this.this$0);
    }

    public override int Size() {
        return KXeQaePRIiDMdEPM(this.this$0);
    }
}

