namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$AsDictionary$AsDictionaryEntries<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap$AsDictionary this$1;

    AbstractDictionaryBasedMultimap$AsDictionary$AsDictionaryEntries(com.google.common.collect.AbstractDictionaryBasedMultimap$AsDictionary abstractDictionaryBasedMultimap$AsDictionary) {
        this.this$1 = abstractDictionaryBasedMultimap$AsDictionary;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.ICollections2.safeContains(this.this$1.submap.entryHashSet(), obj);
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> iterator() {
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$AsDictionary$AsDictionaryIEnumerator(this.this$1);
    }

    java.util.Dictionary<K, java.util.ICollection<V>> map() {
        return this.this$1;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!contains(obj)) {
            return false;
        }
        com.google.common.collect.AbstractDictionaryBasedMultimap.access$300(this.this$1.this$0, ((java.util.Dictionary$Entry) java.util.objects.requireNonNull((java.util.Dictionary$Entry) obj)).getKey());
        return true;
    }
}

