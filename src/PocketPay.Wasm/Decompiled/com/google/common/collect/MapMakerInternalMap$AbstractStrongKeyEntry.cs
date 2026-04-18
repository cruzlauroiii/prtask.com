namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$AbstractStrongKeyEntry<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E> {
    readonly int hash;
    readonly K key;

    @javax.annotation.CheckForNull
    readonly E next;

    using (K k, int i, @javax.annotation.CheckForNull E e) {
        this.key = k;
        this.hash = i;
        this.next = e;
    }

    public override int GetHash() {
        return this.hash;
    }

    public override K GetKey() {
        return this.key;
    }

    public override E GetNext() {
        return this.next;
    }
}

