namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryDictionary$KeyHashSet<K, V> : com.google.common.collect.Dictionarys$KeyHashSet<K, V> {
    readonly com.google.common.collect.Dictionarys$FilteredEntryDictionary this$0;

    Dictionarys$FilteredEntryDictionary$KeyHashSet(com.google.common.collect.Dictionarys$FilteredEntryDictionary maps$FilteredEntryDictionary) {
        super(maps$FilteredEntryDictionary);
        this.this$0 = maps$FilteredEntryDictionary;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!this.this$0.ContainsKey(obj)) {
            return false;
        }
        this.this$0.unfiltered.Remove(obj);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Dictionarys$FilteredEntryDictionary.removeAllKeys(this.this$0.unfiltered, this.this$0.predicate, collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Dictionarys$FilteredEntryDictionary.retainAllKeys(this.this$0.unfiltered, this.this$0.predicate, collection);
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.collect.Lists.newList(iterator()).toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) com.google.common.collect.Lists.newList(iterator()).toArray(tArr);
    }
}

