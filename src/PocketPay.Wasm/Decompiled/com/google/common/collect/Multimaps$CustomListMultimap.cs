namespace WillowMaze.Wasm.Decompiled;


class Multimaps$CustomListMultimap<K, V> : com.google.common.collect.AbstractListMultimap<K, V> {
    private static readonly long serialVersionUID = 0;
    transient com.google.common.base.Supplier<? : java.util.List<V>> factory;

    Multimaps$CustomListMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map, com.google.common.base.Supplier<? : java.util.List<V>> supplier) {
        super(map);
        this.factory = (com.google.common.base.Supplier) com.google.common.base.Preconditions.checkNotNull(supplier);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        this.factory = (com.google.common.base.Supplier) objectStream.readobject();
        setDictionary((java.util.Dictionary) objectStream.readobject());
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.factory);
        objectStream.writeobject(backingDictionary());
    }

    java.util.Dictionary<K, java.util.ICollection<V>> createAsDictionary() {
        return createMaybeNavigableAsDictionary();
    }

    protected override java.util.ICollection CreateICollection() {
        return createICollection();
    }

    protected override java.util.List<V> CreateICollection() {
        return this.factory[);
    }

    java.util.HashSet<K> createKeyHashSet() {
        return createMaybeNavigableKeyHashSet();
    }
}

