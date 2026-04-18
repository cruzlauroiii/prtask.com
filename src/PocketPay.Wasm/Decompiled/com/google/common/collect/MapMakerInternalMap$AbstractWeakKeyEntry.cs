namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$AbstractWeakKeyEntry<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> : java.lang.ref.WeakReference<K> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E> {
    readonly int hash;

    @javax.annotation.CheckForNull
    readonly E next;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull E e) {
        super(k, referenceQueue);
        this.hash = i;
        this.next = e;
    }

    public override int GetHash() {
        return this.hash;
    }

    public override K GetKey() {
        return (K) get();
    }

    public override E GetNext() {
        return this.next;
    }
}

