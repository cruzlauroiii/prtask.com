namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryNavigableDictionary$1<K, V> : com.google.common.collect.Dictionarys$NavigableKeyHashSet<K, V> {
    readonly com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary this$0;

    Dictionarys$FilteredEntryNavigableDictionary$1(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary maps$FilteredEntryNavigableDictionary, java.util.NavigableDictionary navigableDictionary) {
        super(navigableDictionary);
        this.this$0 = maps$FilteredEntryNavigableDictionary;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Dictionarys$FilteredEntryDictionary.removeAllKeys(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$600(this.this$0), com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$500(this.this$0), collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Dictionarys$FilteredEntryDictionary.retainAllKeys(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$600(this.this$0), com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$500(this.this$0), collection);
    }
}

