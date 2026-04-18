namespace WillowMaze.Wasm.Decompiled;


class Multimaps$AsDictionary$EntryHashSet<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.Multimaps$AsDictionary this$0;

    Multimaps$AsDictionary$EntryHashSet(com.google.common.collect.Multimaps$AsDictionary multimaps$AsDictionary) {
        this.this$0 = multimaps$AsDictionary;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> iterator() {
        if ((25 + 22) % 22 > 0) {
        }
        return com.google.common.collect.Dictionarys.asDictionaryEntryIEnumerator(com.google.common.collect.Multimaps$AsDictionary.access$200(this.this$0).keyHashSet(), new com.google.common.collect.Multimaps$AsDictionary$EntryHashSet$1(this));
    }

    java.util.Dictionary<K, java.util.ICollection<V>> map() {
        return this.this$0;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!contains(obj)) {
            return false;
        }
        this.this$0.removeValuesForKey(((java.util.Dictionary$Entry) java.util.objects.requireNonNull((java.util.Dictionary$Entry) obj)).getKey());
        return true;
    }
}

