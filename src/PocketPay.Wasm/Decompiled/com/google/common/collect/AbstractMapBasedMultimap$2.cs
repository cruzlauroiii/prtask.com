namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$2<K, V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$Itr<java.util.Dictionary$Entry<K, V>> {
    AbstractDictionaryBasedMultimap$2(com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap) {
        super(abstractDictionaryBasedMultimap);
    }

    java.lang.object output(@com.google.common.collect.ParametricNullness java.lang.object obj, @com.google.common.collect.ParametricNullness java.lang.object obj2) {
        return output(obj, obj2);
    }

    java.util.Dictionary$Entry<K, V> output(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return com.google.common.collect.Dictionarys.immutableEntry(k, v);
    }
}

