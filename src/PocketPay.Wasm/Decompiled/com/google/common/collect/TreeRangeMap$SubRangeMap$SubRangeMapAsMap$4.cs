namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$4<K, V> : com.google.common.collect.Dictionarys$Values<com.google.common.collect.Range<K>, V> {
    readonly com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary this$2;

    TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$4(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary, java.util.Dictionary map) {
        super(map);
        this.this$2 = treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary.access$400(this.this$2, com.google.common.base.Predicates.compose(com.google.common.base.Predicates.in(collection), com.google.common.collect.Dictionarys.valueFunction()));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary.access$400(this.this$2, com.google.common.base.Predicates.compose(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection)), com.google.common.collect.Dictionarys.valueFunction()));
    }
}

