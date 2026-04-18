namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$SerializationProxy<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$AbstractSerializationProxy<K, V> {
    private static readonly long serialVersionUID = 3;

    DictionaryMakerInternalDictionary$SerializationProxy(com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength, com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength2, com.google.common.base.Equivalence<java.lang.object> equivalence, com.google.common.base.Equivalence<java.lang.object> equivalence2, int i, java.util.concurrent.ConcurrentDictionary<K, V> concurrentDictionary) {
        super(mapMakerInternalDictionary$Strength, mapMakerInternalDictionary$Strength2, equivalence, equivalence2, i, concurrentDictionary);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        this.delegate = readDictionaryMaker(objectStream).makeDictionary();
        readEntries(objectStream);
    }

    private java.lang.object ReadResolve() {
        return this.delegate;
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        writeDictionaryTo(objectStream);
    }
}

