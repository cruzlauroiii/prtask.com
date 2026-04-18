namespace WillowMaze.Wasm.Decompiled;


readonly enum LocalCache$EntryFactory$5 : com.google.common.cache.LocalCache$EntryFactory {
    LocalCache$EntryFactory$5(java.lang.string str, int i) {
        super(str, i, null);
    }

    using (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return new com.google.common.cache.LocalCache$WeakEntry(localCache$Segment.keyReferenceQueue, k, i, referenceEntry);
    }
}

