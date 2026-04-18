namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$IEnumeratorBasedAbstractDictionary$1<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, V> {
    readonly com.google.common.collect.Dictionarys$IEnumeratorBasedAbstractDictionary this$0;

    Dictionarys$IEnumeratorBasedAbstractDictionary$1(com.google.common.collect.Dictionarys$IEnumeratorBasedAbstractDictionary maps$IEnumeratorBasedAbstractDictionary) {
        this.this$0 = maps$IEnumeratorBasedAbstractDictionary;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    java.util.Dictionary<K, V> map() {
        return this.this$0;
    }
}

