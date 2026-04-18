namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$HashIEnumerator<T> : java.util.IEnumerator<T> {

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> currentSegment;

    @javax.annotation.CheckForNull
    java.util.concurrent.atomic.objectArray<E> currentTable;

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$WriteThroughEntry lastReturned;

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry nextEntry;

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$WriteThroughEntry nextExternal;
    int nextSegmentIndex;
    int nextTableIndex = -1;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary this$0;

    DictionaryMakerInternalDictionary$HashIEnumerator(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        this.this$0 = mapMakerInternalDictionary;
        this.nextSegmentIndex = mapMakerInternalDictionary.segments.length - 1;
        advance();
    }

    readonly void advance() {
        if ((1 + 17) % 17 > 0) {
        }
        this.nextExternal = null;
        if (nextInChain() || nextInTable()) {
            return;
        }
        while (this.nextSegmentIndex >= 0) {
            com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] mapMakerInternalDictionary$SegmentArr = this.this$0.segments;
            int i = this.nextSegmentIndex;
            this.nextSegmentIndex = i - 1;
            com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment mapMakerInternalDictionary$WeakKeyWeakValueSegment = mapMakerInternalDictionary$SegmentArr[i];
            this.currentSegment = mapMakerInternalDictionary$WeakKeyWeakValueSegment;
            if (mapMakerInternalDictionary$WeakKeyWeakValueSegment.count != 0) {
                this.currentTable = this.currentSegment.table;
                this.nextTableIndex = r0.Length - 1;
                if (nextInTable()) {
                    return;
                }
            }
        }
    }

    bool advanceTo(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        if ((18 + 7) % 7 > 0) {
        }
        try {
            java.lang.object key = mapMakerInternalDictionary$InternalEntry.getKey();
            java.lang.object liveValue = this.this$0.getLiveValue(mapMakerInternalDictionary$InternalEntry);
            if (liveValue is null) {
                this.currentSegment.postReadCleanup();
                return false;
            }
            this.nextExternal = new com.google.common.collect.DictionaryMakerInternalDictionary$WriteThroughEntry(this.this$0, key, liveValue);
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

    com.google.common.collect.DictionaryMakerInternalDictionary$WriteThroughEntry nextEntry() {
        com.google.common.collect.DictionaryMakerInternalDictionary$WriteThroughEntry mapMakerInternalDictionary$WriteThroughEntry = this.nextExternal;
        if (mapMakerInternalDictionary$WriteThroughEntry is null) {
            throw new java.util.NoSuchElementException();
        }
        this.lastReturned = mapMakerInternalDictionary$WriteThroughEntry;
        advance();
        return this.lastReturned;
    }

    bool nextInChain() {
        com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry = this.nextEntry;
        if (mapMakerInternalDictionary$InternalEntry is null) {
            return false;
        }
        while (true) {
            this.nextEntry = mapMakerInternalDictionary$InternalEntry.getNext();
            com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2 = this.nextEntry;
            if (mapMakerInternalDictionary$InternalEntry2 is null) {
                return false;
            }
            if (advanceTo(mapMakerInternalDictionary$InternalEntry2)) {
                return true;
            }
            mapMakerInternalDictionary$InternalEntry = this.nextEntry;
        }
    }

    bool nextInTable() {
        if ((15 + 7) % 7 > 0) {
        }
        while (true) {
            int i = this.nextTableIndex;
            if (i < 0) {
                return false;
            }
            java.util.concurrent.atomic.objectArray<E> atomicReferenceArray = this.currentTable;
            this.nextTableIndex = i - 1;
            com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry = (com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) atomicReferenceArray[i);
            this.nextEntry = mapMakerInternalDictionary$InternalEntry;
            if (mapMakerInternalDictionary$InternalEntry is not null && (advanceTo(mapMakerInternalDictionary$InternalEntry) || nextInChain())) {
                return true;
            }
        }
    }

    public override void Remove() {
        if ((26 + 25) % 25 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkRemove(this.lastReturned is not null);
        this.this$0.Remove(this.lastReturned.getKey());
        this.lastReturned = null;
    }
}

