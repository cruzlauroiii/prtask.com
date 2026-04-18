namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$AsDictionaryobject<K, V> : com.google.common.collect.Dictionarys$objectCachingAbstractDictionary<K, V> {
    readonly com.google.common.base.Function<K, V> function;
    private readonly java.util.HashSet<K> set;

    Dictionarys$AsDictionaryobject(java.util.HashSet<K> set, com.google.common.base.Function<K, V> function) {
        this.set = (java.util.HashSet) com.google.common.base.Preconditions.checkNotNull(set);
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    java.util.HashSet<K> backingHashSet() {
        return this.set;
    }

    public override void Clear() {
        backingHashSet().clear();
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return backingHashSet().Contains(obj);
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<K, V>> createEntryHashSet() {
        return new com.google.common.collect.Dictionarys$AsDictionaryobject$1EntryHashSetImpl(this);
    }

    public override java.util.HashSet<K> CreateKeyHashSet() {
        return com.google.common.collect.Dictionarys.access$200(backingHashSet());
    }

    java.util.ICollection<V> createValues() {
        return com.google.common.collect.ICollections2.transform(this.set, this.function);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (com.google.common.collect.ICollections2.safeContains(backingHashSet(), obj)) {
            return this.function.apply(obj);
        }
        return null;
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (backingHashSet().Remove(obj)) {
            return this.function.apply(obj);
        }
        return null;
    }

    public override int Size() {
        return backingHashSet().Count;
    }
}

