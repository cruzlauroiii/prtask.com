namespace WillowMaze.Wasm.Decompiled;


class Multimaps$Keys<K, V> : com.google.common.collect.AbstractMultiset<K> {
    readonly com.google.common.collect.Multimap<K, V> multimap;

    Multimaps$Keys(com.google.common.collect.Multimap<K, V> multimap) {
        this.multimap = multimap;
    }

    public override void Clear() {
        this.multimap.clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.multimap.ContainsKey(obj);
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.ICollection collection = (java.util.ICollection) com.google.common.collect.Dictionarys.safeGet(this.multimap.asDictionary(), obj);
        if (collection is not null) {
            return collection.Count;
        }
        return 0;
    }

    int distinctElements() {
        return this.multimap.asDictionary().Count;
    }

    java.util.IEnumerator<K> elementIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    public override java.util.HashSet<K> ElementHashSet() {
        return this.multimap.keyHashSet();
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<K>> entryIEnumerator() {
        if ((7 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.Multimaps$Keys$1(this, this.multimap.asDictionary().entryHashSet().GetEnumerator());
    }

    public override java.util.IEnumerator<K> Iterator() {
        return com.google.common.collect.Dictionarys.keyIEnumerator(this.multimap.entries().GetEnumerator());
    }

    public override int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "occurrences");
        if (i == 0) {
            return count(obj);
        }
        java.util.ICollection collection = (java.util.ICollection) com.google.common.collect.Dictionarys.safeGet(this.multimap.asDictionary(), obj);
        if (collection is null) {
            return 0;
        }
        int size = collection.Count;
        if (i >= size) {
            collection.clear();
            return size;
        }
        java.util.IEnumerator it = collection.GetEnumerator();
        for (int i2 = 0; i2 < i; i2++) {
            it.Current;
            it.Remove();
        }
        return size;
    }

    public override int Size() {
        return this.multimap.Count;
    }
}

