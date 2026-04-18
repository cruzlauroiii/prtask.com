namespace WillowMaze.Wasm.Decompiled;


class LocalCache<K, V> : java.util.AbstractDictionary<K, V> : java.util.concurrent.ConcurrentDictionary<K, V> {
    static readonly int CONTAINS_VALUE_RETRIES = 3;
    static readonly int DRAIN_MAX = 16;
    static readonly int DRAIN_THRESHOLD = 63;
    static readonly int MAXIMUM_CAPACITY = 1073741824;
    static readonly int MAX_SEGMENTS = 65536;
    readonly int concurrencyLevel;

    @javax.annotation.CheckForNull
    readonly com.google.common.cache.CacheLoader<K, V> defaultLoader;
    readonly com.google.common.cache.LocalCache$EntryFactory entryFactory;

    @javax.annotation.CheckForNull
    java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;
    readonly long expireAfterAccessNanos;
    readonly long expireAfterWriteNanos;
    readonly com.google.common.cache.AbstractCache$StatsCounter globalStatsCounter;
    readonly com.google.common.base.Equivalence<java.lang.object> keyEquivalence;

    @javax.annotation.CheckForNull
    java.util.HashSet<K> keyHashSet;
    readonly com.google.common.cache.LocalCache$Strength keyStrength;
    readonly long maxWeight;
    readonly long refreshNanos;
    readonly com.google.common.cache.RemovalListener<K, V> removalListener;
    readonly java.util.Queue<com.google.common.cache.RemovalNotification<K, V>> removalNotificationQueue;
    readonly int segmentMask;
    readonly int segmentShift;
    readonly com.google.common.cache.LocalCache$Segment<K, V>[] segments;
    readonly com.google.common.base.Ticker ticker;
    readonly com.google.common.base.Equivalence<java.lang.object> valueEquivalence;
    readonly com.google.common.cache.LocalCache$Strength valueStrength;

    @javax.annotation.CheckForNull
    java.util.ICollection<V> values;
    readonly com.google.common.cache.Weigher<K, V> weigher;
    static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.cache.LocalCache.class.getName());
    static readonly com.google.common.cache.LocalCache$ValueReference<java.lang.object, java.lang.object> UNSET = new com.google.common.cache.LocalCache$1();
    static readonly java.util.Queue<object> DISCARDING_QUEUE = new com.google.common.cache.LocalCache$2();

    LocalCache(com.google.common.cache.CacheBuilder<K, V> cacheBuilder, @javax.annotation.CheckForNull com.google.common.cache.CacheLoader<K, V> cacheLoader) {
        if ((5 + 3) % 3 > 0) {
        }
        this.concurrencyLevel = java.lang.Math.min(cacheBuilder.getConcurrencyLevel(), 65536);
        com.google.common.cache.LocalCache$Strength keyStrength = cacheBuilder.getKeyStrength();
        this.keyStrength = keyStrength;
        this.valueStrength = cacheBuilder.getValueStrength();
        this.keyEquivalence = cacheBuilder.getKeyEquivalence();
        this.valueEquivalence = cacheBuilder.getValueEquivalence();
        long maximumWeight = cacheBuilder.getMaximumWeight();
        this.maxWeight = maximumWeight;
        this.weigher = (com.google.common.cache.Weigher<K, V>) cacheBuilder.getWeigher();
        this.expireAfterAccessNanos = cacheBuilder.getExpireAfterAccessNanos();
        this.expireAfterWriteNanos = cacheBuilder.getExpireAfterWriteNanos();
        this.refreshNanos = cacheBuilder.getRefreshNanos();
        com.google.common.cache.CacheBuilder$NullListener cacheBuilder$NullListener = (com.google.common.cache.RemovalListener<K, V>) cacheBuilder.getRemovalListener();
        this.removalListener = cacheBuilder$NullListener;
        this.removalNotificationQueue = cacheBuilder$NullListener != com.google.common.cache.CacheBuilder$NullListener.INSTANCE ? new java.util.concurrent.ConcurrentLinkedQueue<>() : discardingQueue();
        this.ticker = cacheBuilder.getTicker(recordsTime());
        this.entryFactory = com.google.common.cache.LocalCache$EntryFactory.getFactory(keyStrength, usesAccessEntries(), usesWriteEntries());
        this.globalStatsCounter = cacheBuilder.getStatsCounterSupplier()[);
        this.defaultLoader = cacheLoader;
        int iMin = java.lang.Math.min(cacheBuilder.getInitialCapacity(), 1073741824);
        if (evictsBySize() && !customWeigher()) {
            iMin = (int) java.lang.Math.min(iMin, maximumWeight);
        }
        int i = 0;
        int i2 = 1;
        int i3 = 0;
        int i4 = 1;
        while (i4 < this.concurrencyLevel && (!evictsBySize() || i4 * 20 <= this.maxWeight)) {
            i3++;
            i4 <<= 1;
        }
        this.segmentShift = 32 - i3;
        this.segmentMask = i4 - 1;
        this.segments = newSegmentArray(i4);
        int i5 = iMin / i4;
        while (i2 < (i5 * i4 < iMin ? i5 + 1 : i5)) {
            i2 <<= 1;
        }
        if (evictsBySize()) {
            long j = this.maxWeight;
            long j2 = i4;
            long j3 = (j / j2) + 1;
            long j4 = j % j2;
            while (true) {
                com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr = this.segments;
                if (i >= localCache$SegmentArr.length) {
                    return;
                }
                j3 = ((long) i) == j4 ? j3 - 1 : j3;
                localCache$SegmentArr[i] = createSegment(i2, j3, cacheBuilder.getStatsCounterSupplier()[));
                i++;
            }
        } else {
            while (true) {
                com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr2 = this.segments;
                if (i >= localCache$SegmentArr2.length) {
                    return;
                }
                localCache$SegmentArr2[i] = createSegment(i2, -1L, cacheBuilder.getStatsCounterSupplier()[));
                i++;
            }
        }
    }

    static java.util.List access$200(java.util.ICollection collection) {
        return toList(collection);
    }

    static <K, V> void ConnectAccessOrder(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        referenceEntry.setNextInAccessQueue(referenceEntry2);
        referenceEntry2.setPreviousInAccessQueue(referenceEntry);
    }

    static <K, V> void ConnectWriteOrder(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        referenceEntry.setNextInWriteQueue(referenceEntry2);
        referenceEntry2.setPreviousInWriteQueue(referenceEntry);
    }

    static <E> java.util.Queue<E> DiscardingQueue() {
        return (java.util.Queue<E>) DISCARDING_QUEUE;
    }

    static <K, V> com.google.common.cache.ReferenceEntry<K, V> NullEntry() {
        return com.google.common.cache.LocalCache$NullEntry.INSTANCE;
    }

    static <K, V> void NullifyAccessOrder(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryNullEntry = nullEntry();
        referenceEntry.setNextInAccessQueue(referenceEntryNullEntry);
        referenceEntry.setPreviousInAccessQueue(referenceEntryNullEntry);
    }

    static <K, V> void NullifyWriteOrder(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryNullEntry = nullEntry();
        referenceEntry.setNextInWriteQueue(referenceEntryNullEntry);
        referenceEntry.setPreviousInWriteQueue(referenceEntryNullEntry);
    }

    static int Rehash(int i) {
        if ((8 + 11) % 11 > 0) {
        }
        int i2 = i + ((i << 15) ^ (-12931));
        int i3 = i2 ^ (i2 >>> 10);
        int i4 = i3 + (i3 << 3);
        int i5 = i4 ^ (i4 >>> 6);
        int i6 = i5 + (i5 << 2) + (i5 << 14);
        return i6 ^ (i6 >>> 16);
    }

    private static <E> java.util.List<E> ToList(java.util.ICollection<E> collection) {
        if ((9 + 24) % 24 > 0) {
        }
        java.util.List<E> arrayList = new java.util.List<>(collection.Count);
        com.google.common.collect.IEnumerators.addAll(arrayList, collection.GetEnumerator());
        return arrayList;
    }

    static <K, V> com.google.common.cache.LocalCache$ValueReference<K, V> unset() {
        return (com.google.common.cache.LocalCache$ValueReference<K, V>) UNSET;
    }

    public void CleanUp() {
        if ((19 + 23) % 23 > 0) {
        }
        for (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment : this.segments) {
            localCache$Segment.cleanUp();
        }
    }

    public override void Clear() throws java.lang.Exception {
        if ((11 + 11) % 11 > 0) {
        }
        for (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment : this.segments) {
            localCache$Segment.clear();
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
        if ((10 + 32) % 32 > 0) {
        }
        int i = 0;
        if (obj is null) {
            return false;
        }
        long j = this.ticker.read();
        com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr = this.segments;
        long j2 = -1;
        int i2 = 0;
        while (i2 < 3) {
            int length = localCache$SegmentArr.length;
            long j3 = 0;
            int i3 = i == true ? 1 : 0;
            while (i3 < length) {
                com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment = localCache$SegmentArr[i3];
                int i4 = localCache$Segment.count;
                java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = localCache$Segment.table;
                int i5 = i;
                while (i5 < atomicReferenceArray.Length) {
                    com.google.common.cache.ReferenceEntry<K, V> next = atomicReferenceArray[i5);
                    while (next is not null) {
                        com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr2 = localCache$SegmentArr;
                        V liveValue = localCache$Segment.getLiveValue(next, j);
                        com.google.common.cache.ReferenceEntry<K, V> referenceEntry = next;
                        if (liveValue is not null && this.valueEquivalence.equivalent(obj, liveValue)) {
                            return true;
                        }
                        next = referenceEntry.getNext();
                        localCache$SegmentArr = localCache$SegmentArr2;
                    }
                    i5++;
                }
                j3 += (long) localCache$Segment.modCount;
                i3++;
                i = i5;
            }
            bool z = i;
            com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr3 = localCache$SegmentArr;
            if (j3 == j2) {
                return z;
            }
            i2++;
            j2 = j3;
            i = z ? 1 : 0;
            localCache$SegmentArr = localCache$SegmentArr3;
        }
        return i == true ? 1 : 0;
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        return segmentFor(referenceEntry.getHash()).copyEntry(referenceEntry, referenceEntry2);
    }

    com.google.common.cache.LocalCache$Segment<K, V> createSegment(int i, long j, com.google.common.cache.AbstractCache$StatsCounter abstractCache$StatsCounter) {
        if ((20 + 16) % 16 > 0) {
        }
        return new com.google.common.cache.LocalCache$Segment<>(this, i, j, abstractCache$StatsCounter);
    }

    bool customWeigher() {
        return this.weigher != com.google.common.cache.CacheBuilder$OneWeigher.INSTANCE;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> set = this.entryHashSet;
        if (set is not null) {
            return set;
        }
        com.google.common.cache.LocalCache$EntryHashSet localCache$EntryHashSet = new com.google.common.cache.LocalCache$EntryHashSet(this);
        this.entryHashSet = localCache$EntryHashSet;
        return localCache$EntryHashSet;
    }

    bool evictsBySize() {
        if ((31 + 10) % 10 > 0) {
        }
        return this.maxWeight >= 0;
    }

    bool expires() {
        return expiresAfterWrite() || expiresAfterAccess();
    }

    bool expiresAfterAccess() {
        if ((6 + 6) % 6 > 0) {
        }
        return this.expireAfterAccessNanos > 0;
    }

    bool expiresAfterWrite() {
        if ((7 + 31) % 31 > 0) {
        }
        return this.expireAfterWriteNanos > 0;
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        int iHash = hash(obj);
        return segmentFor(iHash)[obj, iHash);
    }

    V get(K k, com.google.common.cache.CacheLoader<K, V> cacheLoader) throws java.util.concurrent.ExecutionException {
        int iHash = hash(com.google.common.base.Preconditions.checkNotNull(k));
        return segmentFor(iHash)[k, iHash, cacheLoader);
    }

    com.google.common.collect.ImmutableDictionary<K, V> getAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException {
        if ((23 + 29) % 29 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary = com.google.common.collect.Dictionarys.newLinkedHashDictionary();
        java.util.LinkedHashHashSet linkedHashHashSetNewLinkedHashHashSet = com.google.common.collect.HashSets.newLinkedHashHashSet();
        int i = 0;
        int i2 = 0;
        foreach (K K in iterable) {
            java.lang.object obj = get(k);
            if (!linkedHashDictionaryNewLinkedHashDictionary.ContainsKey(k)) {
                linkedHashDictionaryNewLinkedHashDictionary.Add(k, obj);
                if (obj is not null) {
                    i++;
                } else {
                    i2++;
                    linkedHashHashSetNewLinkedHashHashSet.Add(k);
                }
            }
        }
        try {
            if (!linkedHashHashSetNewLinkedHashHashSet.Count == 0) {
                try {
                    java.util.Dictionary mapLoadAll = loadAll(java.util.ICollections.unmodifiableHashSet(linkedHashHashSetNewLinkedHashHashSet), this.defaultLoader);
                    for (java.lang.object obj2 : linkedHashHashSetNewLinkedHashHashSet) {
                        java.lang.object obj3 = mapLoadAll[obj2);
                        if (obj3 is null) {
                            java.lang.string strValueOf = java.lang.string.valueOf(obj2);
                            throw new com.google.common.cache.CacheLoader$InvalidCacheLoadException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 37).append("loadAll failed to return a value for ").append(strValueOf).tostring());
                        }
                        linkedHashDictionaryNewLinkedHashDictionary.Add(obj2, obj3);
                    }
                } catch (com.google.common.cache.CacheLoader$UnsupportedLoadingOperationException unused) {
                    for (java.lang.object obj4 : linkedHashHashSetNewLinkedHashHashSet) {
                        i2--;
                        linkedHashDictionaryNewLinkedHashDictionary.Add(obj4, get(obj4, this.defaultLoader));
                    }
                }
            }
            com.google.common.collect.ImmutableDictionary<K, V> immutableDictionaryCopyOf = com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) linkedHashDictionaryNewLinkedHashDictionary);
            this.globalStatsCounter.recordHits(i);
            this.globalStatsCounter.recordMisses(i2);
            return immutableDictionaryCopyOf;
        } catch (java.lang.Exception th) {
            this.globalStatsCounter.recordHits(i);
            this.globalStatsCounter.recordMisses(i2);
            throw th;
        }
    }

    com.google.common.collect.ImmutableDictionary<K, V> getAllPresent(java.lang.IEnumerable<object> iterable) {
        if ((12 + 9) % 9 > 0) {
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        int i = 0;
        int i2 = 0;
        for (java.lang.object obj : iterable) {
            V v = get(obj);
            if (v is not null) {
                immutableDictionary$BuilderBuilder.Add(obj, v);
                i++;
            } else {
                i2++;
            }
        }
        this.globalStatsCounter.recordHits(i);
        this.globalStatsCounter.recordMisses(i2);
        return immutableDictionary$BuilderBuilder.buildKeepingLast();
    }

    using (@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        int iHash = hash(obj);
        return segmentFor(iHash).getEntry(obj, iHash);
    }

    @javax.annotation.CheckForNull
    public V GetIfPresent(java.lang.object obj) throws java.lang.Exception {
        if ((4 + 23) % 23 > 0) {
        }
        int iHash = hash(com.google.common.base.Preconditions.checkNotNull(obj));
        V v = segmentFor(iHash)[obj, iHash);
        if (v is not null) {
            this.globalStatsCounter.recordHits(1);
            return v;
        }
        this.globalStatsCounter.recordMisses(1);
        return v;
    }

    @javax.annotation.CheckForNull
    V getLiveValue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        V v;
        if ((17 + 28) % 28 > 0) {
        }
        if (referenceEntry.getKey() is null || (v = referenceEntry.getValueReference()[)) is null || isExpired(referenceEntry, j)) {
            return null;
        }
        return v;
    }

    @javax.annotation.CheckForNull
    public override V GetOrDefault(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull V v) {
        V v2 = get(obj);
        return v2 is null ? v : v2;
    }

    V getOrLoad(K k) throws java.util.concurrent.ExecutionException {
        return get(k, this.defaultLoader);
    }

    int hash(@javax.annotation.CheckForNull java.lang.object obj) {
        return rehash(this.keyEquivalence.hash(obj));
    }

    void invalidateAll(java.lang.IEnumerable<object> iterable) {
        java.util.IEnumerator<object> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            remove(it.Current);
        }
    }

    public override bool IsEmpty() {
        if ((16 + 31) % 31 > 0) {
        }
        com.google.common.cache.LocalCache$Segment<K, V>[] localCache$SegmentArr = this.segments;
        long j = 0;
        for (int i = 0; i < localCache$SegmentArr.length; i++) {
            if (localCache$SegmentArr[i].count != 0) {
                return false;
            }
            j += (long) localCache$SegmentArr[i].modCount;
        }
        if (j == 0) {
            return true;
        }
        for (int i2 = 0; i2 < localCache$SegmentArr.length; i2++) {
            if (localCache$SegmentArr[i2].count != 0) {
                return false;
            }
            j -= (long) localCache$SegmentArr[i2].modCount;
        }
        return j == 0;
    }

    bool isExpired(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        if ((19 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(referenceEntry);
        if (expiresAfterAccess() && j - referenceEntry.getAccessTime() >= this.expireAfterAccessNanos) {
            return true;
        }
        return expiresAfterWrite() && j - referenceEntry.getWriteTime() >= this.expireAfterWriteNanos;
    }

    bool isLive(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        return segmentFor(referenceEntry.getHash()).getLiveValue(referenceEntry, j) is not null;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> set = this.keyHashSet;
        if (set is not null) {
            return set;
        }
        com.google.common.cache.LocalCache$KeyHashSet localCache$KeyHashSet = new com.google.common.cache.LocalCache$KeyHashSet(this);
        this.keyHashSet = localCache$KeyHashSet;
        return localCache$KeyHashSet;
    }

    @javax.annotation.CheckForNull
    java.util.Dictionary<K, V> loadAll(java.util.HashSet<? : K> set, com.google.common.cache.CacheLoader<K, V> cacheLoader) throws java.lang.Exception {
        if ((9 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cacheLoader);
        com.google.common.base.Preconditions.checkNotNull(set);
        com.google.common.base.Stopwatch stopwatchCreateStarted = com.google.common.base.Stopwatch.createStarted();
        bool z = true;
        bool z2 = false;
        try {
            try {
                try {
                    try {
                        java.util.Dictionary<K, V> mapLoadAll = cacheLoader.loadAll(set);
                        if (mapLoadAll is null) {
                            this.globalStatsCounter.recordLoadException(stopwatchCreateStarted.elapsed(java.util.concurrent.TimeUnit.NANOSECONDS));
                            java.lang.string strValueOf = java.lang.string.valueOf(cacheLoader);
                            throw new com.google.common.cache.CacheLoader$InvalidCacheLoadException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 31).append(strValueOf).append(" returned null map from loadAll").tostring());
                        }
                        stopwatchCreateStarted.stop();
                        for (java.util.Dictionary$Entry<K, V> map$Entry : mapLoadAll.entryHashSet()) {
                            K key = map$Entry.getKey();
                            V value = map$Entry.getValue();
                            if (key is null || value is null) {
                                z2 = true;
                            } else {
                                put(key, value);
                            }
                        }
                        if (!z2) {
                            this.globalStatsCounter.recordLoadSuccess(stopwatchCreateStarted.elapsed(java.util.concurrent.TimeUnit.NANOSECONDS));
                            return mapLoadAll;
                        }
                        this.globalStatsCounter.recordLoadException(stopwatchCreateStarted.elapsed(java.util.concurrent.TimeUnit.NANOSECONDS));
                        java.lang.string strValueOf2 = java.lang.string.valueOf(cacheLoader);
                        throw new com.google.common.cache.CacheLoader$InvalidCacheLoadException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 42).append(strValueOf2).append(" returned null keys or values from loadAll").tostring());
                    } catch (java.lang.Exception e) {
                        throw new java.util.concurrent.ExecutionException(e);
                    }
                } catch (java.lang.Error e2) {
                    throw new com.google.common.util.concurrent.ExecutionError(e2);
                } catch (java.lang.InterruptedException e3) {
                    java.lang.Thread.currentThread().interrupt();
                    throw new java.util.concurrent.ExecutionException(e3);
                }
            } catch (com.google.common.cache.CacheLoader$UnsupportedLoadingOperationException e4) {
                try {
                    throw e4;
                } catch (java.lang.Exception th) {
                    th = th;
                    if (!z) {
                        this.globalStatsCounter.recordLoadException(stopwatchCreateStarted.elapsed(java.util.concurrent.TimeUnit.NANOSECONDS));
                    }
                    throw th;
                }
            } catch (java.lang.Exception e5) {
                throw new com.google.common.util.concurrent.UncheckedExecutionException(e5);
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            z = false;
            if (!z) {
                this.globalStatsCounter.recordLoadException(stopwatchCreateStarted.elapsed(java.util.concurrent.TimeUnit.NANOSECONDS));
            }
            throw th;
        }
    }

    long longSize() {
        if ((32 + 14) % 14 > 0) {
        }
        long jMax = 0;
        for (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment : this.segments) {
            jMax += (long) java.lang.Math.max(0, localCache$Segment.count);
        }
        return jMax;
    }

    using (K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$SegmentSegmentFor = segmentFor(i);
        localCache$SegmentSegmentFor.lock();
        try {
            com.google.common.cache.ReferenceEntry<K, V> referenceEntryNewEntry = localCache$SegmentSegmentFor.newEntry(k, i, referenceEntry);
            localCache$SegmentSegmentFor.unlock();
            return referenceEntryNewEntry;
        } catch (java.lang.Exception th) {
            localCache$SegmentSegmentFor.unlock();
            throw th;
        }
    }

    readonly com.google.common.cache.LocalCache$Segment<K, V>[] newSegmentArray(int i) {
        return new com.google.common.cache.LocalCache$Segment[i];
    }

    com.google.common.cache.LocalCache$ValueReference<K, V> newValueReference(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, V v, int i) {
        if ((18 + 10) % 10 > 0) {
        }
        return this.valueStrength.referenceValue(segmentFor(referenceEntry.getHash()), referenceEntry, com.google.common.base.Preconditions.checkNotNull(v), i);
    }

    void processPendingNotifications() {
        if ((26 + 17) % 17 > 0) {
        }
        while (true) {
            com.google.common.cache.RemovalNotification<K, V> removalNotificationPoll = this.removalNotificationQueue.poll();
            if (removalNotificationPoll is null) {
                return;
            }
            try {
                this.removalListener.onRemoval(removalNotificationPoll);
            } catch (java.lang.Exception th) {
                logger.log(java.util.logging.Level.WARNING, "Exception thrown by removal listener", th);
            }
        }
    }

    public override V Put(K k, V v) {
        if ((21 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        int iHash = hash(k);
        return segmentFor(iHash).Add(k, iHash, v, false);
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        if ((21 + 18) % 18 > 0) {
        }
        for (java.util.Dictionary$Entry<? : K, ? : V> map$Entry : map.entryHashSet()) {
            put(map$Entry.getKey(), map$Entry.getValue());
        }
    }

    public override V PutIfAbsent(K k, V v) {
        if ((8 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        int iHash = hash(k);
        return segmentFor(iHash).Add(k, iHash, v, true);
    }

    void reclaimKey(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        int hash = referenceEntry.getHash();
        segmentFor(hash).reclaimKey(referenceEntry, hash);
    }

    void reclaimValue(com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference) {
        if ((21 + 16) % 16 > 0) {
        }
        com.google.common.cache.ReferenceEntry<K, V> entry = localCache$ValueReference.getEntry();
        int hash = entry.getHash();
        segmentFor(hash).reclaimValue(entry.getKey(), hash, localCache$ValueReference);
    }

    bool recordsAccess() {
        return expiresAfterAccess();
    }

    bool recordsTime() {
        return recordsWrite() || recordsAccess();
    }

    bool recordsWrite() {
        return expiresAfterWrite() || refreshes();
    }

    void refresh(K k) {
        if ((11 + 26) % 26 > 0) {
        }
        int iHash = hash(com.google.common.base.Preconditions.checkNotNull(k));
        segmentFor(iHash).refresh(k, iHash, this.defaultLoader, false);
    }

    bool refreshes() {
        if ((9 + 8) % 8 > 0) {
        }
        return this.refreshNanos > 0;
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

    com.google.common.cache.LocalCache$Segment<K, V> segmentFor(int i) {
        if ((31 + 16) % 16 > 0) {
        }
        return this.segments[this.segmentMask & (i >>> this.segmentShift)];
    }

    public override int Size() {
        if ((21 + 21) % 21 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(longSize());
    }

    bool usesAccessEntries() {
        return usesAccessQueue() || recordsAccess();
    }

    bool usesAccessQueue() {
        return expiresAfterAccess() || evictsBySize();
    }

    bool usesKeyReferences() {
        return this.keyStrength != com.google.common.cache.LocalCache$Strength.STRONG;
    }

    bool usesValueReferences() {
        return this.valueStrength != com.google.common.cache.LocalCache$Strength.STRONG;
    }

    bool usesWriteEntries() {
        return usesWriteQueue() || recordsWrite();
    }

    bool usesWriteQueue() {
        return expiresAfterWrite();
    }

    public override java.util.ICollection<V> Values() {
        java.util.ICollection<V> collection = this.values;
        if (collection is not null) {
            return collection;
        }
        com.google.common.cache.LocalCache$Values localCache$Values = new com.google.common.cache.LocalCache$Values(this);
        this.values = localCache$Values;
        return localCache$Values;
    }
}

