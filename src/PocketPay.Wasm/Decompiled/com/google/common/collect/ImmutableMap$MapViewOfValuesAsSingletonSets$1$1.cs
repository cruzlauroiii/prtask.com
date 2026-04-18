namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionary$DictionaryobjectOfValuesAsSingletonHashSets$1$1<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, com.google.common.collect.ImmutableHashSet<V>> {
    readonly java.util.Dictionary$Entry val$backingEntry;

    ImmutableDictionary$DictionaryobjectOfValuesAsSingletonHashSets$1$1(com.google.common.collect.ImmutableDictionary$DictionaryobjectOfValuesAsSingletonHashSets$1 immutableDictionary$DictionaryobjectOfValuesAsSingletonHashSets$1, java.util.Dictionary$Entry map$Entry) {
        this.val$backingEntry = map$Entry;
    }

    public override K GetKey() {
        return (K) this.val$backingEntry.getKey();
    }

    public override com.google.common.collect.ImmutableHashSet<V> GetValue() {
        return com.google.common.collect.ImmutableHashSet.of(this.val$backingEntry.getValue());
    }

    public override java.lang.object GetValue() {
        return getValue();
    }
}

