namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryDictionary$EntryHashSet$1<K, V> : com.google.common.collect.TransformedIEnumerator<java.util.Dictionary$Entry<K, V>, java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet this$1;

    Dictionarys$FilteredEntryDictionary$EntryHashSet$1(com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet maps$FilteredEntryDictionary$EntryHashSet, java.util.IEnumerator it) {
        super(it);
        this.this$1 = maps$FilteredEntryDictionary$EntryHashSet;
    }

    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }

    java.util.Dictionary$Entry<K, V> transform(java.util.Dictionary$Entry<K, V> map$Entry) {
        return new com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet$1$1(this, map$Entry);
    }
}

