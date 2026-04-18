namespace WillowMaze.Wasm.Decompiled;


readonly class Multimaps$AsDictionary<K, V> : com.google.common.collect.Dictionarys$objectCachingAbstractDictionary<K, java.util.ICollection<V>> {
    private readonly com.google.common.collect.Multimap<K, V> multimap;

    Multimaps$AsDictionary(com.google.common.collect.Multimap<K, V> multimap) {
        this.multimap = (com.google.common.collect.Multimap) com.google.common.base.Preconditions.checkNotNull(multimap);
    }

    static com.google.common.collect.Multimap access$200(com.google.common.collect.Multimaps$AsDictionary multimaps$AsDictionary) {
        return multimaps$AsDictionary.multimap;
    }

    public override void Clear() {
        this.multimap.clear();
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.multimap.ContainsKey(obj);
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> createEntryHashSet() {
        return new com.google.common.collect.Multimaps$AsDictionary$EntryHashSet(this);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.ICollection<V> Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (containsKey(obj)) {
            return this.multimap[obj);
        }
        return null;
    }

    public override bool IsEmpty() {
        return this.multimap.Count == 0;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        return this.multimap.keyHashSet();
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return remove(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.ICollection<V> Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (containsKey(obj)) {
            return this.multimap.removeAll(obj);
        }
        return null;
    }

    void removeValuesForKey(@javax.annotation.CheckForNull java.lang.object obj) {
        this.multimap.keyHashSet().Remove(obj);
    }

    public override int Size() {
        return this.multimap.keyHashSet().Count;
    }
}

