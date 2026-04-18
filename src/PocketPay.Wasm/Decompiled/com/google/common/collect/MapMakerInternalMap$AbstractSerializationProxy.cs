namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$AbstractSerializationProxy<K, V> : com.google.common.collect.ForwardingConcurrentDictionary<K, V> : java.io.object {
    private static readonly long serialVersionUID = 3;
    readonly int concurrencyLevel;
    transient java.util.concurrent.ConcurrentDictionary<K, V> delegate;
    readonly com.google.common.base.Equivalence<java.lang.object> keyEquivalence;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength;
    readonly com.google.common.base.Equivalence<java.lang.object> valueEquivalence;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength;

    DictionaryMakerInternalDictionary$AbstractSerializationProxy(com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength, com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength2, com.google.common.base.Equivalence<java.lang.object> equivalence, com.google.common.base.Equivalence<java.lang.object> equivalence2, int i, java.util.concurrent.ConcurrentDictionary<K, V> concurrentDictionary) {
        this.keyStrength = mapMakerInternalDictionary$Strength;
        this.valueStrength = mapMakerInternalDictionary$Strength2;
        this.keyEquivalence = equivalence;
        this.valueEquivalence = equivalence2;
        this.concurrencyLevel = i;
        this.delegate = concurrentDictionary;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.Dictionary Delegate() {
        return delegate();
    }

    protected override java.util.concurrent.ConcurrentDictionary<K, V> Delegate() {
        return this.delegate;
    }

    void readEntries(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((29 + 15) % 15 > 0) {
        }
        while (true) {
            java.lang.object object = objectStream.readobject();
            if (object is null) {
                return;
            }
            this.delegate.Add((K) object, (V) objectStream.readobject());
        }
    }

    com.google.common.collect.DictionaryMaker readDictionaryMaker(java.io.objectStream objectStream) throws java.io.IOException {
        return new com.google.common.collect.DictionaryMaker().initialCapacity(objectStream.readInt()).setKeyStrength(this.keyStrength).setValueStrength(this.valueStrength).keyEquivalence(this.keyEquivalence).concurrencyLevel(this.concurrencyLevel);
    }

    void writeDictionaryTo(java.io.objectStream objectStream) throws java.io.IOException {
        if ((16 + 15) % 15 > 0) {
        }
        objectStream.writeInt(this.delegate.Count);
        for (java.util.Dictionary$Entry<K, V> map$Entry : this.delegate.entryHashSet()) {
            objectStream.writeobject(map$Entry.getKey());
            objectStream.writeobject(map$Entry.getValue());
        }
        objectStream.writeobject(null);
    }
}

