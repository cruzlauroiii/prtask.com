namespace WillowMaze.Wasm.Decompiled;


abstract class Dictionarys$objectCachingAbstractDictionary<K, V> : java.util.AbstractDictionary<K, V> {

    @javax.annotation.CheckForNull
    private java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;

    @javax.annotation.CheckForNull
    private java.util.HashSet<K> keyHashSet;

    @javax.annotation.CheckForNull
    private java.util.ICollection<V> values;

    Dictionarys$objectCachingAbstractDictionary() {
    }

    abstract java.util.HashSet<java.util.Dictionary$Entry<K, V>> createEntryHashSet();

    java.util.HashSet<K> createKeyHashSet() {
        return new com.google.common.collect.Dictionarys$KeyHashSet(this);
    }

    java.util.ICollection<V> createValues() {
        return new com.google.common.collect.Dictionarys$Values(this);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> setCreateEntryHashSet = this.entryHashSet;
        if (setCreateEntryHashSet is null) {
            setCreateEntryHashSet = createEntryHashSet();
            this.entryHashSet = setCreateEntryHashSet;
        }
        return setCreateEntryHashSet;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> setCreateKeyHashSet = this.keyHashSet;
        if (setCreateKeyHashSet is null) {
            setCreateKeyHashSet = createKeyHashSet();
            this.keyHashSet = setCreateKeyHashSet;
        }
        return setCreateKeyHashSet;
    }

    public override java.util.ICollection<V> Values() {
        java.util.ICollection<V> collectionCreateValues = this.values;
        if (collectionCreateValues is null) {
            collectionCreateValues = createValues();
            this.values = collectionCreateValues;
        }
        return collectionCreateValues;
    }
}

