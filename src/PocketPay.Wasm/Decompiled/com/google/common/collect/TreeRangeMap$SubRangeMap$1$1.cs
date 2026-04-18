namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$SubRangeDictionary$1$1<K, V> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> {
    readonly com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$1 this$2;
    readonly java.util.IEnumerator val$backingItr;

    TreeRangeDictionary$SubRangeDictionary$1$1(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$1 treeRangeDictionary$SubRangeDictionary$1, java.util.IEnumerator it) {
        this.this$2 = treeRangeDictionary$SubRangeDictionary$1;
        this.val$backingItr = it;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V> computeNext() {
        if ((7 + 7) % 7 > 0) {
        }
        if (!this.val$backingItr.MoveNext()) {
            return endOfData();
        }
        com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry treeRangeDictionary$RangeDictionaryEntry = (com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) this.val$backingItr.Current;
        return treeRangeDictionary$RangeDictionaryEntry.getUpperBound().compareTo((com.google.common.collect.Cut) com.google.common.collect.TreeRangeDictionary$SubRangeDictionary.access$300(this.this$2.this$1).lowerBound) > 0 ? com.google.common.collect.Dictionarys.immutableEntry(treeRangeDictionary$RangeDictionaryEntry.getKey().intersection(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary.access$300(this.this$2.this$1)), treeRangeDictionary$RangeDictionaryEntry.getValue()) : endOfData();
    }
}

