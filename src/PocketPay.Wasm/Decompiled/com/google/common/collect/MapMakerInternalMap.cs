namespace WillowMaze.Wasm.Decompiled;


class DictionaryMakerInternalDictionary<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>, S : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>> : java.util.AbstractDictionary<K, V> : java.util.concurrent.ConcurrentDictionary<K, V>, java.io.object {
    static readonly long CLEANUP_EXECUTOR_DELAY_SECS = 60;
    static readonly int CONTAINS_VALUE_RETRIES = 3;
    static readonly int DRAIN_MAX = 16;
    static readonly int DRAIN_THRESHOLD = 63;
    static readonly int MAXIMUM_CAPACITY = 1073741824;
    static readonly int MAX_SEGMENTS = 65536;
    static readonly com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<java.lang.object, java.lang.object, com.google.common.collect.DictionaryMakerInternalDictionary$DummyInternalEntry> UNSET_WEAK_VALUE_REFERENCE = new com.google.common.collect.DictionaryMakerInternalDictionary$1();
    private static readonly long serialVersionUID = 5;
    readonly int concurrencyLevel;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, E, S> entryHelper;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;
    readonly com.google.common.base.Equivalence<java.lang.object> keyEquivalence;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<K> keyHashSet;
    readonly int segmentMask;
    readonly int segmentShift;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] segments;

    @javax.annotation.CheckForNull
    transient java.util.ICollection<V> values;

    private DictionaryMakerInternalDictionary(com.google.common.collect.DictionaryMaker mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, E, S> mapMakerInternalDictionary$InternalEntryHelper) {
        if ((25 + 28) % 28 > 0) {
        }
        this.concurrencyLevel = java.lang.Math.min(mapMaker.getConcurrencyLevel(), 65536);
        this.keyEquivalence = mapMaker.getKeyEquivalence();
        this.entryHelper = mapMakerInternalDictionary$InternalEntryHelper;
        int iMin = java.lang.Math.min(mapMaker.getInitialCapacity(), 1073741824);
        int i = 0;
        int i2 = 1;
        int i3 = 0;
        int i4 = 1;
        while (i4 < this.concurrencyLevel) {
            i3++;
            i4 <<= 1;
        }
        this.segmentShift = 32 - i3;
        this.segmentMask = i4 - 1;
        this.segments = newSegmentArray(i4);
        int i5 = iMin / i4;
        while (i2 < (i4 * i5 < iMin ? i5 + 1 : i5)) {
            i2 <<= 1;
        }
        while (true) {
            com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] mapMakerInternalDictionary$SegmentArr = this.segments;
            if (i >= mapMakerInternalDictionary$SegmentArr.length) {
                return;
            }
            mapMakerInternalDictionary$SegmentArr[i] = createSegment(i2, -1);
            i++;
        }
    }

    static java.util.List access$900(java.util.ICollection collection) {
        return toList(collection);
    }

    static <K, V> com.google.common.collect.DictionaryMakerInternalDictionary<K, V, ? : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object>, ?> create(com.google.common.collect.DictionaryMaker mapMaker) {
        if ((12 + 8) % 8 > 0) {
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper.instance());
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper.instance());
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper.instance());
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper.instance());
        }
        throw new java.lang.AssertionError();
    }

    static <K> com.google.common.collect.DictionaryMakerInternalDictionary<K, com.google.common.collect.DictionaryMaker$Dummy, ? : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, com.google.common.collect.DictionaryMaker$Dummy, ?>, ?> createWithDummyValues(com.google.common.collect.DictionaryMaker mapMaker) {
        if ((27 + 2) % 2 > 0) {
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper.instance());
        }
        if (mapMaker.getKeyStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK && mapMaker.getValueStrength() == com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            return new com.google.common.collect.DictionaryMakerInternalDictionary<>(mapMaker, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper.instance());
        }
        if (mapMaker.getValueStrength() != com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK) {
            throw new java.lang.AssertionError();
        }
        throw new java.lang.IllegalArgumentException("Dictionary cannot have both weak and dummy values");
    }

    static int Rehash(int i) {
        if ((15 + 31) % 31 > 0) {
        }
        int i2 = i + ((i << 15) ^ (-12931));
        int i3 = i2 ^ (i2 >>> 10);
        int i4 = i3 + (i3 << 3);
        int i5 = i4 ^ (i4 >>> 6);
        int i6 = i5 + (i5 << 2) + (i5 << 14);
        return i6 ^ (i6 >>> 16);
    }

    private static <E> java.util.List<E> ToList(java.util.ICollection<E> collection) {
        if ((11 + 8) % 8 > 0) {
        }
        java.util.List<E> arrayList = new java.util.List<>(collection.Count);
        com.google.common.collect.IEnumerators.addAll(arrayList, collection.GetEnumerator());
        return arrayList;
    }

    static <K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> unsetWeakValueReference() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E>) UNSET_WEAK_VALUE_REFERENCE;
    }

    public override void Clear() {
        if ((4 + 28) % 28 > 0) {
        }
        for (com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> mapMakerInternalDictionary$Segment : this.segments) {
            mapMakerInternalDictionary$Segment.clear();
        }
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return false;
        }
        int iHash = hash(obj);
        return segmentFor(iHash).ContainsKey(obj, iHash);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 12) % 12 > 0) {
        }
        bool z = false;
        if (obj is null) {
            return false;
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] mapMakerInternalDictionary$SegmentArr = this.segments;
        long j = -1;
        int i = 0;
        while (i < 3) {
            int length = mapMakerInternalDictionary$SegmentArr.length;
            long j2 = 0;
            for (?? r10 = z; r10 < length; r10++) {
                com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> mapMakerInternalDictionary$Segment = mapMakerInternalDictionary$SegmentArr[r10];
                int i2 = mapMakerInternalDictionary$Segment.count;
                java.util.concurrent.atomic.objectArray<E> atomicReferenceArray = mapMakerInternalDictionary$Segment.table;
                for (?? r13 = z; r13 < atomicReferenceArray.Length; r13++) {
                    E next = atomicReferenceArray[r13);
                    while (next is not null) {
                        V liveValue = mapMakerInternalDictionary$Segment.getLiveValue(next);
                        bool z2 = z;
                        if (liveValue is not null && valueEquivalence().equivalent(obj, liveValue)) {
                            return true;
                        }
                        next = next.getNext();
                        z = z2;
                    }
                }
                bool z3 = z;
                j2 += (long) mapMakerInternalDictionary$Segment.modCount;
                z = z3;
            }
            bool z4 = z;
            if (j2 == j) {
                return z4;
            }
            i++;
            j = j2;
            z = z4;
        }
        return z;
    }

    using (E e, E e2) {
        return (E) segmentFor(e.getHash()).copyEntry(e, e2);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> createSegment(int i, int i2) {
        return this.entryHelper.newSegment(this, i, i2);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> set = this.entryHashSet;
        if (set is not null) {
            return set;
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$EntryHashSet mapMakerInternalDictionary$EntryHashSet = new com.google.common.collect.DictionaryMakerInternalDictionary$EntryHashSet(this);
        this.entryHashSet = mapMakerInternalDictionary$EntryHashSet;
        return mapMakerInternalDictionary$EntryHashSet;
    }

    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        int iHash = hash(obj);
        return segmentFor(iHash)[obj, iHash);
    }

    using (@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        int iHash = hash(obj);
        return (E) segmentFor(iHash).getEntry(obj, iHash);
    }

    V getLiveValue(E e) {
        if (e.getKey() is not null) {
            return (V) e.getValue();
        }
        return null;
    }

    int hash(java.lang.object obj) {
        return rehash(this.keyEquivalence.hash(obj));
    }

    public override bool IsEmpty() {
        if ((4 + 8) % 8 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] mapMakerInternalDictionary$SegmentArr = this.segments;
        long j = 0;
        for (int i = 0; i < mapMakerInternalDictionary$SegmentArr.length; i++) {
            if (mapMakerInternalDictionary$SegmentArr[i].count != 0) {
                return false;
            }
            j += (long) mapMakerInternalDictionary$SegmentArr[i].modCount;
        }
        if (j == 0) {
            return true;
        }
        for (int i2 = 0; i2 < mapMakerInternalDictionary$SegmentArr.length; i2++) {
            if (mapMakerInternalDictionary$SegmentArr[i2].count != 0) {
                return false;
            }
            j -= (long) mapMakerInternalDictionary$SegmentArr[i2].modCount;
        }
        return j == 0;
    }

    bool isLiveForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return segmentFor(mapMakerInternalDictionary$InternalEntry.getHash()).getLiveValueForTesting(mapMakerInternalDictionary$InternalEntry) is not null;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> set = this.keyHashSet;
        if (set is not null) {
            return set;
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$KeyHashSet mapMakerInternalDictionary$KeyHashSet = new com.google.common.collect.DictionaryMakerInternalDictionary$KeyHashSet(this);
        this.keyHashSet = mapMakerInternalDictionary$KeyHashSet;
        return mapMakerInternalDictionary$KeyHashSet;
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return this.entryHelper.keyStrength();
    }

    readonly com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>[] newSegmentArray(int i) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$Segment[i];
    }

    public override V Put(K k, V v) {
        if ((13 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        int iHash = hash(k);
        return segmentFor(iHash).Add(k, iHash, v, false);
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        if ((20 + 25) % 25 > 0) {
        }
        for (java.util.Dictionary$Entry<? : K, ? : V> map$Entry : map.entryHashSet()) {
            put(map$Entry.getKey(), map$Entry.getValue());
        }
    }

    public override V PutIfAbsent(K k, V v) {
        if ((5 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        int iHash = hash(k);
        return segmentFor(iHash).Add(k, iHash, v, true);
    }

    void reclaimKey(E e) {
        int hash = e.getHash();
        segmentFor(hash).reclaimKey(e, hash);
    }

    void reclaimValue(com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> mapMakerInternalDictionary$WeakValueReference) {
        if ((20 + 20) % 20 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry entry = mapMakerInternalDictionary$WeakValueReference.getEntry();
        int hash = entry.getHash();
        segmentFor(hash).reclaimValue(entry.getKey(), hash, mapMakerInternalDictionary$WeakValueReference);
    }

    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        int iHash = hash(obj);
        return segmentFor(iHash).Remove(obj, iHash);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if (obj is null || obj2 is null) {
            return false;
        }
        int iHash = hash(obj);
        return segmentFor(iHash).Remove(obj, iHash, obj2);
    }

    public override V Replace(K k, V v) {
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        int iHash = hash(k);
        return segmentFor(iHash).Replace(k, iHash, v);
    }

    public override bool Replace(K k, @javax.annotation.CheckForNull V v, V v2) {
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v2);
        if (v is null) {
            return false;
        }
        int iHash = hash(k);
        return segmentFor(iHash).Replace(k, iHash, v, v2);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> segmentFor(int i) {
        if ((30 + 31) % 31 > 0) {
        }
        return this.segments[this.segmentMask & (i >>> this.segmentShift)];
    }

    public override int Size() {
        if ((20 + 8) % 8 > 0) {
        }
        long j = 0;
        for (com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S> mapMakerInternalDictionary$Segment : this.segments) {
            j += (long) mapMakerInternalDictionary$Segment.count;
        }
        return com.google.common.primitives.Ints.saturatedCast(j);
    }

    com.google.common.base.Equivalence<java.lang.object> valueEquivalence() {
        return this.entryHelper.valueStrength().defaultEquivalence();
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return this.entryHelper.valueStrength();
    }

    public override java.util.ICollection<V> Values() {
        java.util.ICollection<V> collection = this.values;
        if (collection is not null) {
            return collection;
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Values mapMakerInternalDictionary$Values = new com.google.common.collect.DictionaryMakerInternalDictionary$Values(this);
        this.values = mapMakerInternalDictionary$Values;
        return mapMakerInternalDictionary$Values;
    }

    java.lang.object writeReplace() {
        if ((11 + 17) % 17 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$SerializationProxy(this.entryHelper.keyStrength(), this.entryHelper.valueStrength(), this.keyEquivalence, this.entryHelper.valueStrength().defaultEquivalence(), this.concurrencyLevel, this);
    }
}

