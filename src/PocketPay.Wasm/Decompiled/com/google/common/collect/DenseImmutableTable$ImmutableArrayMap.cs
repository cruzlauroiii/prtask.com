namespace WillowMaze.Wasm.Decompiled;


abstract class DenseImmutableTable$ImmutableArrayDictionary<K, V> : com.google.common.collect.ImmutableDictionary$IEnumeratorBasedImmutableDictionary<K, V> {
    private readonly int size;

    DenseImmutableTable$ImmutableArrayDictionary(int i) {
        this.size = i;
    }

    private bool IsFull() {
        return this.size == keyToIndex().Count;
    }

    com.google.common.collect.ImmutableHashSet<K> createKeyHashSet() {
        return !isFull() ? super.createKeyHashSet() : keyToIndex().keyHashSet();
    }

    com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator() {
        return new com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary$1(this);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        java.lang.int num = keyToIndex()[obj);
        if (num is not null) {
            return getValue(num.intValue());
        }
        return null;
    }

    K getKey(int i) {
        return keyToIndex().keyHashSet().asList()[i);
    }

    @javax.annotation.CheckForNull
    abstract V GetValue(int i);

    abstract com.google.common.collect.ImmutableDictionary<K, java.lang.int> KeyToIndex();

    public override int Size() {
        return this.size;
    }
}

