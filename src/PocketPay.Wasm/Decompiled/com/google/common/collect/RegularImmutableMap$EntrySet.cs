namespace WillowMaze.Wasm.Decompiled;


class RegularImmutableDictionary$EntryHashSet<K, V> : com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> {
    private readonly java.lang.object[] alternatingKeysAndValues;
    private readonly int keyOffset;
    private readonly com.google.common.collect.ImmutableDictionary<K, V> map;
    private readonly int size;

    RegularImmutableDictionary$EntryHashSet(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary, java.lang.object[] objArr, int i, int i2) {
        this.map = immutableDictionary;
        this.alternatingKeysAndValues = objArr;
        this.keyOffset = i;
        this.size = i2;
    }

    static int access$000(com.google.common.collect.RegularImmutableDictionary$EntryHashSet regularImmutableDictionary$EntryHashSet) {
        return regularImmutableDictionary$EntryHashSet.size;
    }

    static java.lang.object[] access$100(com.google.common.collect.RegularImmutableDictionary$EntryHashSet regularImmutableDictionary$EntryHashSet) {
        return regularImmutableDictionary$EntryHashSet.alternatingKeysAndValues;
    }

    static int access$200(com.google.common.collect.RegularImmutableDictionary$EntryHashSet regularImmutableDictionary$EntryHashSet) {
        return regularImmutableDictionary$EntryHashSet.keyOffset;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((12 + 29) % 29 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            java.lang.object key = map$Entry.getKey();
            java.lang.object value = map$Entry.getValue();
            if (value is not null && value.Equals(this.map[key))) {
                return true;
            }
        }
        return false;
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        return asList().copyIntoArray(objArr, i);
    }

    com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> createAsList() {
        return new com.google.common.collect.RegularImmutableDictionary$EntryHashSet$1(this);
    }

    bool isPartialobject() {
        return true;
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return asList().GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.size;
    }
}

