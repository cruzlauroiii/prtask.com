namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$AsDictionaryobject$1EntryHashSetImpl<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, V> {
    readonly com.google.common.collect.Dictionarys$AsDictionaryobject this$0;

    Dictionarys$AsDictionaryobject$1EntryHashSetImpl(com.google.common.collect.Dictionarys$AsDictionaryobject maps$AsDictionaryobject) {
        this.this$0 = maps$AsDictionaryobject;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return com.google.common.collect.Dictionarys.asDictionaryEntryIEnumerator(this.this$0.backingHashSet(), this.this$0.function);
    }

    java.util.Dictionary<K, V> map() {
        return this.this$0;
    }
}

