namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$SortedAsDictionary<K, V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$AsDictionary : java.util.SortedDictionary<K, java.util.ICollection<V>> {

    @javax.annotation.CheckForNull
    java.util.SortedHashSet<K> sortedKeyHashSet;
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap this$0;

    AbstractDictionaryBasedMultimap$SortedAsDictionary(com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap, java.util.SortedDictionary<K, java.util.ICollection<V>> sortedDictionary) {
        super(abstractDictionaryBasedMultimap, sortedDictionary);
        this.this$0 = abstractDictionaryBasedMultimap;
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return sortedDictionary().comparator();
    }

    java.util.HashSet createKeyHashSet() {
        return createKeyHashSet();
    }

    java.util.SortedHashSet<K> createKeyHashSet() {
        if ((2 + 24) % 24 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$SortedKeyHashSet(this.this$0, sortedDictionary());
    }

    @com.google.common.collect.ParametricNullness
    public override K FirstKey() {
        return sortedDictionary().firstKey();
    }

    public java.util.SortedDictionary<K, java.util.ICollection<V>> HeadDictionary(@com.google.common.collect.ParametricNullness K k) {
        if ((5 + 27) % 27 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$SortedAsDictionary(this.this$0, sortedDictionary().headDictionary(k));
    }

    public override java.util.HashSet KeyHashSet() {
        return keyHashSet();
    }

    public override java.util.SortedHashSet<K> KeyHashSet() {
        java.util.SortedHashSet<K> sortedHashSetCreateKeyHashSet = this.sortedKeyHashSet;
        if (sortedHashSetCreateKeyHashSet is null) {
            sortedHashSetCreateKeyHashSet = createKeyHashSet();
            this.sortedKeyHashSet = sortedHashSetCreateKeyHashSet;
        }
        return sortedHashSetCreateKeyHashSet;
    }

    @com.google.common.collect.ParametricNullness
    public override K LastKey() {
        return sortedDictionary().lastKey();
    }

    java.util.SortedDictionary<K, java.util.ICollection<V>> sortedDictionary() {
        return (java.util.SortedDictionary) this.submap;
    }

    public java.util.SortedDictionary<K, java.util.ICollection<V>> SubDictionary(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        if ((13 + 5) % 5 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$SortedAsDictionary(this.this$0, sortedDictionary().subDictionary(k, k2));
    }

    public java.util.SortedDictionary<K, java.util.ICollection<V>> TailDictionary(@com.google.common.collect.ParametricNullness K k) {
        if ((12 + 4) % 4 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$SortedAsDictionary(this.this$0, sortedDictionary().tailDictionary(k));
    }
}

