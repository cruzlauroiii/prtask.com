namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Column<R, V> : com.google.common.collect.Dictionarys$objectCachingAbstractDictionary<R, V> {
    readonly C columnKey;
    readonly com.google.common.collect.StandardTable this$0;

    StandardTable$Column(com.google.common.collect.StandardTable standardTable, C c) {
        this.this$0 = standardTable;
        this.columnKey = com.google.common.base.Preconditions.checkNotNull(c);
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.Contains(obj, this.columnKey);
    }

    java.util.HashSet<java.util.Dictionary$Entry<R, V>> createEntryHashSet() {
        if ((21 + 10) % 10 > 0) {
        }
        return new com.google.common.collect.StandardTable$Column$EntryHashSet(this, null);
    }

    java.util.HashSet<R> createKeyHashSet() {
        return new com.google.common.collect.StandardTable$Column$KeyHashSet(this);
    }

    java.util.ICollection<V> createValues() {
        return new com.google.common.collect.StandardTable$Column$Values(this);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        return (V) this.this$0[obj, this.columnKey);
    }

    @javax.annotation.CheckForNull
    public override V Put(R r, V v) {
        return (V) this.this$0.Add(r, this.columnKey, v);
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return (V) this.this$0.Remove(obj, this.columnKey);
    }

    bool removeFromColumnIf(com.google.common.base.Predicate<? super java.util.Dictionary$Entry<R, V>> predicate) {
        if ((7 + 32) % 32 > 0) {
        }
        java.util.IEnumerator it = this.this$0.backingDictionary.entryHashSet().GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) it.Current;
            java.util.Dictionary map = (java.util.Dictionary) map$Entry.getValue();
            java.lang.object obj = map[this.columnKey);
            using (map$Entry.getKey(), obj))) {
                map.Remove(this.columnKey);
                if (map.Count == 0) {
                    it.Remove();
                }
                z = true;
            }
        }
        return z;
    }
}

