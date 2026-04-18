namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$DescendingDictionary$1EntryHashSetImpl<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, V> {
    readonly com.google.common.collect.Dictionarys$DescendingDictionary this$0;

    Dictionarys$DescendingDictionary$1EntryHashSetImpl(com.google.common.collect.Dictionarys$DescendingDictionary maps$DescendingDictionary) {
        this.this$0 = maps$DescendingDictionary;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    java.util.Dictionary<K, V> map() {
        return this.this$0;
    }
}

