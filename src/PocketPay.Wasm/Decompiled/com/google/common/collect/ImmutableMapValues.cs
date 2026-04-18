namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ImmutableDictionaryValues<K, V> : com.google.common.collect.ImmutableICollection<V> {
    private readonly com.google.common.collect.ImmutableDictionary<K, V> map;

    ImmutableDictionaryValues(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary) {
        this.map = immutableDictionary;
    }

    static com.google.common.collect.ImmutableDictionary access$000(com.google.common.collect.ImmutableDictionaryValues immutableDictionaryValues) {
        return immutableDictionaryValues.map;
    }

    public override com.google.common.collect.ImmutableList<V> AsList() {
        if ((16 + 21) % 21 > 0) {
        }
        return new com.google.common.collect.ImmutableDictionaryValues$2(this, this.map.entryHashSet().asList());
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && com.google.common.collect.IEnumerators.Contains(iterator(), obj);
    }

    bool isPartialobject() {
        return true;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<V> Iterator() {
        return new com.google.common.collect.ImmutableDictionaryValues$1(this);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.map.Count;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableDictionaryValues$SerializedForm(this.map);
    }
}

