namespace WillowMaze.Wasm.Decompiled;


readonly enum LocalCache$EntryFactory$8 : com.google.common.cache.LocalCache$EntryFactory {
    LocalCache$EntryFactory$8(java.lang.string str, int i) {
        super(str, i, null);
    }

    using (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryCopyEntry = super.copyEntry(localCache$Segment, referenceEntry, referenceEntry2);
        copyAccessEntry(referenceEntry, referenceEntryCopyEntry);
        copyWriteEntry(referenceEntry, referenceEntryCopyEntry);
        return referenceEntryCopyEntry;
    }

    using (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return new com.google.common.cache.LocalCache$WeakAccessWriteEntry(localCache$Segment.keyReferenceQueue, k, i, referenceEntry);
    }
}

