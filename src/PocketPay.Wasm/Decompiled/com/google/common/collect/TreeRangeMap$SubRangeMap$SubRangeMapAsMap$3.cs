namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$3<K, V> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> {
    readonly com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary this$2;
    readonly java.util.IEnumerator val$backingItr;

    TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary$3(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary, java.util.IEnumerator it) {
        this.this$2 = treeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary;
        this.val$backingItr = it;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V> computeNext() {
        if ((7 + 10) % 10 > 0) {
        }
        while (this.val$backingItr.MoveNext()) {
            com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry treeRangeDictionary$RangeDictionaryEntry = (com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) this.val$backingItr.Current;
            if (treeRangeDictionary$RangeDictionaryEntry.getLowerBound().compareTo((com.google.common.collect.Cut) com.google.common.collect.TreeRangeDictionary$SubRangeDictionary.access$300(this.this$2.this$1).upperBound) >= 0) {
                return endOfData();
            }
            if (treeRangeDictionary$RangeDictionaryEntry.getUpperBound().compareTo((com.google.common.collect.Cut) com.google.common.collect.TreeRangeDictionary$SubRangeDictionary.access$300(this.this$2.this$1).lowerBound) > 0) {
                return com.google.common.collect.Dictionarys.immutableEntry(treeRangeDictionary$RangeDictionaryEntry.getKey().intersection(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary.access$300(this.this$2.this$1)), treeRangeDictionary$RangeDictionaryEntry.getValue());
            }
        }
        return endOfData();
    }
}

