namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$2<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<com.google.common.collect.Range<K>, V> {
    readonly com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary this$2;

    TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$2(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary) {
        this.this$2 = treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary;
    }

    public override bool IsEmpty() {
        return !iterator().MoveNext();
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> iterator() {
        return this.this$2.entryIEnumerator();
    }

    java.util.Dictionary<com.google.common.collect.Range<K>, V> map() {
        return this.this$2;
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary.access$400(this.this$2, com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection)));
    }

    public override int Size() {
        return com.google.common.collect.IEnumerators.size(iterator());
    }
}

