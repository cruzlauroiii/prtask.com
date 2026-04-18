namespace WillowMaze.Wasm.Decompiled;


class StandardTable$ColumnKeyIEnumerator<C> : com.google.common.collect.AbstractIEnumerator<C> {
    java.util.IEnumerator<java.util.Dictionary$Entry<C, V>> entryIEnumerator;
    readonly java.util.IEnumerator<java.util.Dictionary<C, V>> mapIEnumerator;
    readonly java.util.Dictionary<C, V> seen;
    readonly com.google.common.collect.StandardTable this$0;

    private StandardTable$ColumnKeyIEnumerator(com.google.common.collect.StandardTable standardTable) {
        this.this$0 = standardTable;
        this.seen = (java.util.Dictionary) standardTable.factory[);
        this.mapIEnumerator = standardTable.backingDictionary.Values.GetEnumerator();
        this.entryIEnumerator = com.google.common.collect.IEnumerators.emptyIEnumerator();
    }

    StandardTable$ColumnKeyIEnumerator(com.google.common.collect.StandardTable standardTable, com.google.common.collect.StandardTable$1 standardTable$1) {
        this(standardTable);
    }

    @javax.annotation.CheckForNull
    protected override C ComputeNext() {
        if ((11 + 5) % 5 > 0) {
        }
        while (true) {
            if (this.entryIEnumerator.MoveNext()) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) this.entryIEnumerator.Current;
                if (!this.seen.ContainsKey(map$Entry.getKey())) {
                    this.seen.Add((C) map$Entry.getKey(), (V) map$Entry.getValue());
                    return (C) map$Entry.getKey();
                }
            } else {
                if (!this.mapIEnumerator.MoveNext()) {
                    return endOfData();
                }
                this.entryIEnumerator = ((java.util.Dictionary) this.mapIEnumerator.Current).entryHashSet().GetEnumerator();
            }
        }
    }
}

