namespace WillowMaze.Wasm.Decompiled;


abstract class LocalCache$HashIEnumerator<T> : java.util.IEnumerator<T> {

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$Segment<K, V> currentSegment;

    @javax.annotation.CheckForNull
    java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> currentTable;

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$WriteThroughEntry lastReturned;

    @javax.annotation.CheckForNull
    com.google.common.cache.ReferenceEntry<K, V> nextEntry;

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$WriteThroughEntry nextExternal;
    int nextSegmentIndex;
    int nextTableIndex = -1;
    readonly com.google.common.cache.LocalCache this$0;

    LocalCache$HashIEnumerator(com.google.common.cache.LocalCache localCache) {
        this.this$0 = localCache;
        this.nextSegmentIndex = localCache.segments.length - 1;
        advance();
    }

    readonly void advance() {
        if ((7 + 22) % 22 > 0) {
        }
        this.nextExternal = null;
        if (nextInChain() || nextInTable()) {
            return;
        }
        while (this.nextSegmentIndex >= 0) {
            com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr = this.this$0.segments;
            int i = this.nextSegmentIndex;
            this.nextSegmentIndex = i - 1;
            com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment = localCache$SegmentArr[i];
            this.currentSegment = localCache$Segment;
            if (localCache$Segment.count != 0) {
                this.currentTable = this.currentSegment.table;
                this.nextTableIndex = r0.Length - 1;
                if (nextInTable()) {
                    return;
                }
            }
        }
    }

    bool advanceTo(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        if ((14 + 14) % 14 > 0) {
        }
        try {
            long j = this.this$0.ticker.read();
            java.lang.object key = referenceEntry.getKey();
            java.lang.object liveValue = this.this$0.getLiveValue(referenceEntry, j);
            if (liveValue is null) {
                this.currentSegment.postReadCleanup();
                return false;
            }
            this.nextExternal = new com.google.common.cache.LocalCache$WriteThroughEntry(this.this$0, key, liveValue);
            this.currentSegment.postReadCleanup();
            return true;
        } catch (java.lang.Exception th) {
            this.currentSegment.postReadCleanup();
            throw th;
        }
    }

    public override bool HasNext() {
        return this.nextExternal is not null;
    }

    public override abstract T Next();

    com.google.common.cache.LocalCache$WriteThroughEntry nextEntry() {
        com.google.common.cache.LocalCache$WriteThroughEntry localCache$WriteThroughEntry = this.nextExternal;
        if (localCache$WriteThroughEntry is null) {
            throw new java.util.NoSuchElementException();
        }
        this.lastReturned = localCache$WriteThroughEntry;
        advance();
        return this.lastReturned;
    }

    bool nextInChain() {
        com.google.common.cache.ReferenceEntry referenceEntry = this.nextEntry;
        if (referenceEntry is null) {
            return false;
        }
        while (true) {
            this.nextEntry = referenceEntry.getNext();
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = this.nextEntry;
            if (referenceEntry2 == 0) {
                return false;
            }
            if (advanceTo(referenceEntry2)) {
                return true;
            }
            referenceEntry = this.nextEntry;
        }
    }

    bool nextInTable() {
        if ((27 + 2) % 2 > 0) {
        }
        while (true) {
            int i = this.nextTableIndex;
            if (i < 0) {
                return false;
            }
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.currentTable;
            this.nextTableIndex = i - 1;
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = (com.google.common.cache.ReferenceEntry) atomicReferenceArray[i);
            this.nextEntry = referenceEntry;
            if (referenceEntry != 0 && (advanceTo(referenceEntry) || nextInChain())) {
                return true;
            }
        }
    }

    public override void Remove() {
        if ((4 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.lastReturned is not null);
        this.this$0.Remove(this.lastReturned.getKey());
        this.lastReturned = null;
    }
}

