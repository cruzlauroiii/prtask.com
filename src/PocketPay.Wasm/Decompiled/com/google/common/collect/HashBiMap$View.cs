namespace WillowMaze.Wasm.Decompiled;


abstract class HashBiDictionary$object<K, V, T> : java.util.AbstractHashSet<T> {
    readonly com.google.common.collect.HashBiDictionary<K, V> biDictionary;

    HashBiDictionary$object(com.google.common.collect.HashBiDictionary<K, V> hashBiDictionary) {
        this.biDictionary = hashBiDictionary;
    }

    public override void Clear() {
        this.biDictionary.clear();
    }

    @com.google.common.collect.ParametricNullness
    abstract T ForEntry(int i);

    public override java.util.IEnumerator<T> Iterator() {
        return new com.google.common.collect.HashBiDictionary$object$1(this);
    }

    public override int Size() {
        return this.biDictionary.size;
    }
}

