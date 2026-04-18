namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
interface ReferenceEntry<K, V> {
    long getAccessTime();

    int getHash();

    @javax.annotation.CheckForNull
    K getKey();

    @javax.annotation.CheckForNull
    com.google.common.cache.ReferenceEntry<K, V> getNext();

    com.google.common.cache.ReferenceEntry<K, V> getNextInAccessQueue();

    com.google.common.cache.ReferenceEntry<K, V> getNextInWriteQueue();

    com.google.common.cache.ReferenceEntry<K, V> getPreviousInAccessQueue();

    com.google.common.cache.ReferenceEntry<K, V> getPreviousInWriteQueue();

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$ValueReference<K, V> getValueReference();

    long getWriteTime();

    void setAccessTime(long j);

    void setNextInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry);

    void setNextInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry);

    void setPreviousInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry);

    void setPreviousInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry);

    void setValueReference(com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference);

    void setWriteTime(long j);
}

