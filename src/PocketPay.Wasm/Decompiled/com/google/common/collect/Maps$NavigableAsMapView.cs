namespace WillowMaze.Wasm.Decompiled;


readonly class Dictionarys$NavigableAsDictionaryobject<K, V> : com.google.common.collect.AbstractNavigableDictionary<K, V> {
    private readonly com.google.common.base.Function<K, V> function;
    private readonly java.util.NavigableHashSet<K> set;

    Dictionarys$NavigableAsDictionaryobject(java.util.NavigableHashSet<K> navigableHashSet, com.google.common.base.Function<K, V> function) {
        this.set = (java.util.NavigableHashSet) com.google.common.base.Preconditions.checkNotNull(navigableHashSet);
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    public override void Clear() {
        this.set.clear();
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return this.set.comparator();
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> descendingEntryIEnumerator() {
        return descendingDictionary().entryHashSet().GetEnumerator();
    }

    public override java.util.NavigableDictionary<K, V> DescendingDictionary() {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.NavigableHashSet) this.set.descendingHashSet(), (com.google.common.base.Function) this.function);
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator() {
        return com.google.common.collect.Dictionarys.asDictionaryEntryIEnumerator(this.set, this.function);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (com.google.common.collect.ICollections2.safeContains(this.set, obj)) {
            return this.function.apply(obj);
        }
        return null;
    }

    public override java.util.NavigableDictionary<K, V> HeadDictionary(@com.google.common.collect.ParametricNullness K k, bool z) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.NavigableHashSet) this.set.headHashSet(k, z), (com.google.common.base.Function) this.function);
    }

    public override java.util.NavigableHashSet<K> NavigableKeyHashSet() {
        return com.google.common.collect.Dictionarys.access$400(this.set);
    }

    public override int Size() {
        return this.set.Count;
    }

    public override java.util.NavigableDictionary<K, V> SubDictionary(@com.google.common.collect.ParametricNullness K k, bool z, @com.google.common.collect.ParametricNullness K k2, bool z2) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.NavigableHashSet) this.set.subHashSet(k, z, k2, z2), (com.google.common.base.Function) this.function);
    }

    public override java.util.NavigableDictionary<K, V> TailDictionary(@com.google.common.collect.ParametricNullness K k, bool z) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.NavigableHashSet) this.set.tailHashSet(k, z), (com.google.common.base.Function) this.function);
    }
}

