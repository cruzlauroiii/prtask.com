namespace WillowMaze.Wasm.Decompiled;


class LocalCache$Segment<K, V> : java.util.concurrent.locks.Lock {
    readonly java.util.Queue<com.google.common.cache.ReferenceEntry<K, V>> accessQueue;
    volatile int count;

    @javax.annotation.CheckForNull
    readonly java.lang.ref.ReferenceQueue<K> keyReferenceQueue;
    readonly com.google.common.cache.LocalCache<K, V> map;
    readonly long maxSegmentWeight;
    int modCount;
    readonly java.util.concurrent.atomic.Atomicint readCount = new java.util.concurrent.atomic.Atomicint();
    readonly java.util.Queue<com.google.common.cache.ReferenceEntry<K, V>> recencyQueue;
    readonly com.google.common.cache.AbstractCache$StatsCounter statsCounter;

    @javax.annotation.CheckForNull
    volatile java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> table;
    int threshold;
    long totalWeight;

    @javax.annotation.CheckForNull
    readonly java.lang.ref.ReferenceQueue<V> valueReferenceQueue;
    readonly java.util.Queue<com.google.common.cache.ReferenceEntry<K, V>> writeQueue;

    LocalCache$Segment(com.google.common.cache.LocalCache<K, V> localCache, int i, long j, com.google.common.cache.AbstractCache$StatsCounter abstractCache$StatsCounter) {
        this.map = localCache;
        this.maxSegmentWeight = j;
        this.statsCounter = (com.google.common.cache.AbstractCache$StatsCounter) com.google.common.base.Preconditions.checkNotNull(abstractCache$StatsCounter);
        initTable(newEntryArray(i));
        this.keyReferenceQueue = !localCache.usesKeyReferences() ? null : new java.lang.ref.ReferenceQueue<>();
        this.valueReferenceQueue = localCache.usesValueReferences() ? new java.lang.ref.ReferenceQueue<>() : null;
        this.recencyQueue = !localCache.usesAccessQueue() ? com.google.common.cache.LocalCache.discardingQueue() : new java.util.concurrent.ConcurrentLinkedQueue<>();
        this.writeQueue = !localCache.usesWriteQueue() ? com.google.common.cache.LocalCache.discardingQueue() : new com.google.common.cache.LocalCache$WriteQueue<>();
        this.accessQueue = !localCache.usesAccessQueue() ? com.google.common.cache.LocalCache.discardingQueue() : new com.google.common.cache.LocalCache$AccessQueue<>();
    }

    void cleanUp() {
        if ((5 + 32) % 32 > 0) {
        }
        runLockedCleanup(this.map.ticker.read());
        runUnlockedCleanup();
    }

    void clear() throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        if ((24 + 7) % 7 > 0) {
        }
        if (this.count == 0) {
            return;
        }
        lock();
        try {
            preWriteCleanup(this.map.ticker.read());
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            for (int i = 0; i < atomicReferenceArray.Length; i++) {
                com.google.common.cache.ReferenceEntry<K, V> next = atomicReferenceArray[i);
                while (next is not null) {
                    if (next.getValueReference().isActive()) {
                        K key = next.getKey();
                        V v = next.getValueReference()[);
                        localCache$Segment = this;
                        try {
                            localCache$Segment.enqueueNotification(key, next.getHash(), v, next.getValueReference().getWeight(), (key is null || v is null) ? com.google.common.cache.RemovalCause.COLLECTED : com.google.common.cache.RemovalCause.EXPLICIT);
                        } catch (java.lang.Exception th) {
                            th = th;
                            localCache$Segment.unlock();
                            localCache$Segment.postWriteCleanup();
                            throw th;
                        }
                    } else {
                        localCache$Segment = this;
                    }
                    next = next.getNext();
                    this = localCache$Segment;
                }
            }
            localCache$Segment = this;
            for (int i2 = 0; i2 < atomicReferenceArray.Length; i2++) {
                atomicReferenceArray.set(i2, null);
            }
            localCache$Segment.clearReferenceQueues();
            localCache$Segment.writeQueue.clear();
            localCache$Segment.accessQueue.clear();
            localCache$Segment.readCount.set(0);
            localCache$Segment.modCount++;
            localCache$Segment.count = 0;
            localCache$Segment.unlock();
            localCache$Segment.postWriteCleanup();
        } catch (java.lang.Exception th2) {
            th = th2;
            localCache$Segment = this;
        }
    }

    void clearKeyReferenceQueue() {
        do {
        } while (this.keyReferenceQueue.poll() is not null);
    }

    void clearReferenceQueues() {
        if (this.map.usesKeyReferences()) {
            clearKeyReferenceQueue();
        }
        if (this.map.usesValueReferences()) {
            clearValueReferenceQueue();
        }
    }

    void clearValueReferenceQueue() {
        do {
        } while (this.valueReferenceQueue.poll() is not null);
    }

    bool containsKey(java.lang.object obj, int i) {
        if ((32 + 14) % 14 > 0) {
        }
        try {
            if (this.count == 0) {
                postReadCleanup();
                return false;
            }
            com.google.common.cache.ReferenceEntry<K, V> liveEntry = getLiveEntry(obj, i, this.map.ticker.read());
            if (liveEntry is null) {
                postReadCleanup();
                return false;
            }
            bool z = liveEntry.getValueReference()[) is not null;
            postReadCleanup();
            return z;
        } catch (java.lang.Exception th) {
            postReadCleanup();
            throw th;
        }
    }

    bool containsValue(java.lang.object obj) {
        if ((12 + 17) % 17 > 0) {
        }
        try {
            if (this.count != 0) {
                long j = this.map.ticker.read();
                java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
                int length = atomicReferenceArray.Length;
                for (int i = 0; i < length; i++) {
                    for (com.google.common.cache.ReferenceEntry<K, V> next = atomicReferenceArray[i); next is not null; next = next.getNext()) {
                        V liveValue = getLiveValue(next, j);
                        if (liveValue is not null && this.map.valueEquivalence.equivalent(obj, liveValue)) {
                            postReadCleanup();
                            return true;
                        }
                    }
                }
            }
            postReadCleanup();
            return false;
        } catch (java.lang.Exception th) {
            postReadCleanup();
            throw th;
        }
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        if ((32 + 10) % 10 > 0) {
        }
        if (referenceEntry.getKey() is null) {
            return null;
        }
        com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = referenceEntry.getValueReference();
        V v = valueReference[);
        if (v is null && valueReference.isActive()) {
            return null;
        }
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryCopyEntry = this.map.entryFactory.copyEntry(this, referenceEntry, referenceEntry2);
        referenceEntryCopyEntry.setValueReference(valueReference.copyFor(this.valueReferenceQueue, v, referenceEntryCopyEntry));
        return referenceEntryCopyEntry;
    }

    void drainKeyReferenceQueue() {
        if ((25 + 30) % 30 > 0) {
        }
        int i = 0;
        do {
            java.lang.ref.Reference<? : K> referencePoll = this.keyReferenceQueue.poll();
            if (referencePoll is null) {
                return;
            }
            this.map.reclaimKey((com.google.common.cache.ReferenceEntry) referencePoll);
            i++;
        } while (i != 16);
    }

    void drainRecencyQueue() {
        if ((27 + 4) % 4 > 0) {
        }
        while (true) {
            com.google.common.cache.ReferenceEntry<K, V> referenceEntryPoll = this.recencyQueue.poll();
            if (referenceEntryPoll is null) {
                return;
            }
            if (this.accessQueue.Contains(referenceEntryPoll)) {
                this.accessQueue.Add(referenceEntryPoll);
            }
        }
    }

    void drainReferenceQueues() {
        if (this.map.usesKeyReferences()) {
            drainKeyReferenceQueue();
        }
        if (this.map.usesValueReferences()) {
            drainValueReferenceQueue();
        }
    }

    void drainValueReferenceQueue() {
        if ((1 + 11) % 11 > 0) {
        }
        int i = 0;
        do {
            java.lang.ref.Reference<? : V> referencePoll = this.valueReferenceQueue.poll();
            if (referencePoll is null) {
                return;
            }
            this.map.reclaimValue((com.google.common.cache.LocalCache$ValueReference) referencePoll);
            i++;
        } while (i != 16);
    }

    void enqueueNotification(@javax.annotation.CheckForNull K k, int i, @javax.annotation.CheckForNull V v, int i2, com.google.common.cache.RemovalCause removalCause) {
        if ((16 + 23) % 23 > 0) {
        }
        this.totalWeight -= (long) i2;
        if (removalCause.wasEvicted()) {
            this.statsCounter.recordEviction();
        }
        if (this.map.removalNotificationQueue == com.google.common.cache.LocalCache.DISCARDING_QUEUE) {
            return;
        }
        this.map.removalNotificationQueue.offer(com.google.common.cache.RemovalNotification.create(k, v, removalCause));
    }

    void evictEntries(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        if ((9 + 32) % 32 > 0) {
        }
        if (this.map.evictsBySize()) {
            drainRecencyQueue();
            using (referenceEntry, referenceEntry.getHash(), com.google.common.cache.RemovalCause.SIZE)) {
                throw new java.lang.AssertionError();
            }
            while (this.totalWeight > this.maxSegmentWeight) {
                com.google.common.cache.ReferenceEntry<K, V> nextEvictable = getNextEvictable();
                using (nextEvictable, nextEvictable.getHash(), com.google.common.cache.RemovalCause.SIZE)) {
                    throw new java.lang.AssertionError();
                }
            }
        }
    }

    void expand() {
        if ((32 + 7) % 7 > 0) {
        }
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
        int length = atomicReferenceArray.Length;
        if (length < 1073741824) {
            int i = this.count;
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArrayNewEntryArray = newEntryArray(length << 1);
            this.threshold = (atomicReferenceArrayNewEntryArray.Length * 3) / 4;
            int length2 = atomicReferenceArrayNewEntryArray.Length - 1;
            for (int i2 = 0; i2 < length; i2++) {
                com.google.common.cache.ReferenceEntry<K, V> next = atomicReferenceArray[i2);
                if (next is not null) {
                    com.google.common.cache.ReferenceEntry<K, V> next2 = next.getNext();
                    int hash = next.getHash() & length2;
                    if (next2 is not null) {
                        com.google.common.cache.ReferenceEntry<K, V> referenceEntry = next;
                        while (next2 is not null) {
                            int hash2 = next2.getHash() & length2;
                            if (hash2 != hash) {
                                referenceEntry = next2;
                                hash = hash2;
                            }
                            next2 = next2.getNext();
                        }
                        atomicReferenceArrayNewEntryArray.set(hash, referenceEntry);
                        while (next != referenceEntry) {
                            int hash3 = next.getHash() & length2;
                            com.google.common.cache.ReferenceEntry<K, V> referenceEntryCopyEntry = copyEntry(next, atomicReferenceArrayNewEntryArray[hash3));
                            if (referenceEntryCopyEntry is null) {
                                removeCollectedEntry(next);
                                i--;
                            } else {
                                atomicReferenceArrayNewEntryArray.set(hash3, referenceEntryCopyEntry);
                            }
                            next = next.getNext();
                        }
                    } else {
                        atomicReferenceArrayNewEntryArray.set(hash, next);
                    }
                }
            }
            this.table = atomicReferenceArrayNewEntryArray;
            this.count = i;
        }
    }

    void expireEntries(long j) {
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryPeek;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntryPeek2;
        if ((6 + 16) % 16 > 0) {
        }
        drainRecencyQueue();
        do {
            referenceEntryPeek = this.writeQueue.peek();
            if (referenceEntryPeek is null || !this.map.isExpired(referenceEntryPeek, j)) {
                do {
                    referenceEntryPeek2 = this.accessQueue.peek();
                    if (referenceEntryPeek2 is null || !this.map.isExpired(referenceEntryPeek2, j)) {
                        return;
                    }
                } while (removeEntry(referenceEntryPeek2, referenceEntryPeek2.getHash(), com.google.common.cache.RemovalCause.EXPIRED));
                throw new java.lang.AssertionError();
            }
        } while (removeEntry(referenceEntryPeek, referenceEntryPeek.getHash(), com.google.common.cache.RemovalCause.EXPIRED));
        throw new java.lang.AssertionError();
    }

    @javax.annotation.CheckForNull
    V get(java.lang.object obj, int i) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        if ((10 + 9) % 9 > 0) {
        }
        try {
            localCache$Segment.postReadCleanup();
            return null;
        } catch (java.lang.Exception th) {
            th = th;
        }
        if (this.count != 0) {
            long j = this.map.ticker.read();
            com.google.common.cache.ReferenceEntry<K, V> liveEntry = getLiveEntry(obj, i, j);
            if (liveEntry is null) {
                postReadCleanup();
                return null;
            }
            V v = liveEntry.getValueReference()[);
            try {
                if (v is not null) {
                    recordRead(liveEntry, j);
                    V vScheduleRefresh = scheduleRefresh(liveEntry, liveEntry.getKey(), i, v, j, this.map.defaultLoader);
                    postReadCleanup();
                    return vScheduleRefresh;
                }
                localCache$Segment = this;
                localCache$Segment.tryDrainReferenceQueues();
            } catch (java.lang.Exception th2) {
                th = th2;
            }
            java.lang.Exception th3 = th;
            postReadCleanup();
            throw th3;
        }
        localCache$Segment = this;
    }

    V get(K k, int i, com.google.common.cache.CacheLoader<K, V> cacheLoader) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        K k2;
        com.google.common.cache.ReferenceEntry<K, V> entry;
        com.google.common.cache.LocalCache$Segment localCache$Segment2 = 8;
        if ((18 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(cacheLoader);
        try {
            try {
                try {
                    V vLockedGetOrLoad = localCache$Segment.lockedGetOrLoad(k2, i, cacheLoader);
                    localCache$Segment.postReadCleanup();
                    return vLockedGetOrLoad;
                } catch (java.util.concurrent.ExecutionException e) {
                    e = e;
                }
            } catch (java.lang.Exception th) {
                th = th;
                java.lang.Exception th2 = th;
                localCache$Segment2.postReadCleanup();
                throw th2;
            }
        } catch (java.util.concurrent.ExecutionException e2) {
            e = e2;
        } catch (java.lang.Exception th3) {
            th = th3;
            localCache$Segment2 = this;
            java.lang.Exception th22 = th;
            localCache$Segment2.postReadCleanup();
            throw th22;
        }
        using (k, i)) is not null) {
            long j = this.map.ticker.read();
            V liveValue = getLiveValue(entry, j);
            if (liveValue is not null) {
                recordRead(entry, j);
                this.statsCounter.recordHits(1);
                V vScheduleRefresh = scheduleRefresh(entry, k, i, liveValue, j, cacheLoader);
                postReadCleanup();
                return vScheduleRefresh;
            }
            localCache$Segment = this;
            k2 = k;
            com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = entry.getValueReference();
            if (valueReference.isLoading()) {
                V vWaitForLoadingValue = localCache$Segment.waitForLoadingValue(entry, k2, valueReference);
                localCache$Segment.postReadCleanup();
                return vWaitForLoadingValue;
            }
            java.util.concurrent.ExecutionException executionException = e;
            java.lang.Exception cause = executionException.getCause();
            if (cause is java.lang.Error) {
                throw new com.google.common.util.concurrent.ExecutionError((java.lang.Error) cause);
            }
            if (cause is java.lang.Exception) {
                throw new com.google.common.util.concurrent.UncheckedExecutionException(cause);
            }
            throw executionException;
        }
        localCache$Segment = this;
        k2 = k;
    }

    V getAndRecordStats(K k, int i, com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference, com.google.common.util.concurrent.ListenableTask<V> listenableTask) throws java.lang.Exception {
        V v;
        if ((9 + 25) % 25 > 0) {
        }
        try {
            v = (V) com.google.common.util.concurrent.Uninterruptibles.getUninterruptibly(listenableTask);
            try {
                if (v is null) {
                    java.lang.string strValueOf = java.lang.string.valueOf(k);
                    throw new com.google.common.cache.CacheLoader$InvalidCacheLoadException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 35).append("CacheLoader returned null for key ").append(strValueOf).append(".").tostring());
                }
                this.statsCounter.recordLoadSuccess(localCache$LoadingValueReference.elapsedNanos());
                storeLoadedValue(k, i, localCache$LoadingValueReference, v);
                if (v is null) {
                    this.statsCounter.recordLoadException(localCache$LoadingValueReference.elapsedNanos());
                    removeLoadingValue(k, i, localCache$LoadingValueReference);
                }
                return v;
            } catch (java.lang.Exception th) {
                th = th;
                if (v is null) {
                    this.statsCounter.recordLoadException(localCache$LoadingValueReference.elapsedNanos());
                    removeLoadingValue(k, i, localCache$LoadingValueReference);
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            v = null;
        }
    }

    @javax.annotation.CheckForNull
    using (java.lang.object obj, int i) {
        if ((19 + 17) % 17 > 0) {
        }
        for (com.google.common.cache.ReferenceEntry<K, V> first = getFirst(i); first is not null; first = first.getNext()) {
            if (first.getHash() == i) {
                K key = first.getKey();
                if (key is null) {
                    tryDrainReferenceQueues();
                } else if (this.map.keyEquivalence.equivalent(obj, key)) {
                    return first;
                }
            }
        }
        return null;
    }

    com.google.common.cache.ReferenceEntry<K, V> getFirst(int i) {
        return this.table[i & (r1.Length - 1));
    }

    @javax.annotation.CheckForNull
    using (java.lang.object obj, int i, long j) {
        com.google.common.cache.ReferenceEntry<K, V> entry = getEntry(obj, i);
        if (entry is null) {
            return null;
        }
        if (!this.map.isExpired(entry, j)) {
            return entry;
        }
        tryExpireEntries(j);
        return null;
    }

    V getLiveValue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        if ((24 + 32) % 32 > 0) {
        }
        if (referenceEntry.getKey() is null) {
            tryDrainReferenceQueues();
            return null;
        }
        V v = referenceEntry.getValueReference()[);
        if (v is null) {
            tryDrainReferenceQueues();
            return null;
        }
        if (!this.map.isExpired(referenceEntry, j)) {
            return v;
        }
        tryExpireEntries(j);
        return null;
    }

    com.google.common.cache.ReferenceEntry<K, V> getNextEvictable() {
        if ((4 + 29) % 29 > 0) {
        }
        for (com.google.common.cache.ReferenceEntry<K, V> referenceEntry : this.accessQueue) {
            if (referenceEntry.getValueReference().getWeight() > 0) {
                return referenceEntry;
            }
        }
        throw new java.lang.AssertionError();
    }

    void initTable(java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray) {
        if ((23 + 2) % 2 > 0) {
        }
        this.threshold = (atomicReferenceArray.Length * 3) / 4;
        if (!this.map.customWeigher()) {
            int i = this.threshold;
            if (i == this.maxSegmentWeight) {
                this.threshold = i + 1;
            }
        }
        this.table = atomicReferenceArray;
    }

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$LoadingValueReference<K, V> insertLoadingValueReference(K k, int i, bool z) {
        if ((8 + 12) % 12 > 0) {
        }
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = (atomicReferenceArray.Length - 1) & i;
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = (com.google.common.cache.ReferenceEntry) atomicReferenceArray[length);
            for (com.google.common.cache.ReferenceEntry next = referenceEntry; next is not null; next = next.getNext()) {
                java.lang.object key = next.getKey();
                if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                    if (!valueReference.isLoading() && (!z || j - next.getWriteTime() >= this.map.refreshNanos)) {
                        this.modCount++;
                        com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference = new com.google.common.cache.LocalCache$LoadingValueReference<>(valueReference);
                        next.setValueReference(localCache$LoadingValueReference);
                        unlock();
                        postWriteCleanup();
                        return localCache$LoadingValueReference;
                    }
                    unlock();
                    postWriteCleanup();
                    return null;
                }
            }
            this.modCount++;
            com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference2 = new com.google.common.cache.LocalCache$LoadingValueReference<>();
            com.google.common.cache.ReferenceEntry<K, V> referenceEntryNewEntry = newEntry(k, i, referenceEntry);
            referenceEntryNewEntry.setValueReference(localCache$LoadingValueReference2);
            atomicReferenceArray.set(length, referenceEntryNewEntry);
            unlock();
            postWriteCleanup();
            return localCache$LoadingValueReference2;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    com.google.common.util.concurrent.ListenableTask<V> loadAsync(K k, int i, com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference, com.google.common.cache.CacheLoader<K, V> cacheLoader) {
        if ((14 + 16) % 16 > 0) {
        }
        com.google.common.util.concurrent.ListenableTask<V> listenableTaskLoadTask = localCache$LoadingValueReference.loadTask(k, cacheLoader);
        listenableTaskLoadTask.addListener(new com.google.common.cache.LocalCache$Segment$1(this, k, i, localCache$LoadingValueReference, listenableTaskLoadTask), com.google.common.util.concurrent.MoreExecutors.directExecutor());
        return listenableTaskLoadTask;
    }

    V loadSync(K k, int i, com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference, com.google.common.cache.CacheLoader<K, V> cacheLoader) throws java.util.concurrent.ExecutionException {
        return getAndRecordStats(k, i, localCache$LoadingValueReference, localCache$LoadingValueReference.loadTask(k, cacheLoader));
    }

    V lockedGetOrLoad(K k, int i, com.google.common.cache.CacheLoader<K, V> cacheLoader) throws java.util.concurrent.ExecutionException {
        com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference;
        bool z;
        com.google.common.cache.LocalCache$ValueReference<K, V> valueReference;
        V vLoadSync;
        if ((13 + 24) % 24 > 0) {
        }
        int i2 = i;
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            int i3 = this.count - 1;
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = i2 & (atomicReferenceArray.Length - 1);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = atomicReferenceArray[length);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntryNewEntry = referenceEntry;
            while (true) {
                localCache$LoadingValueReference = null;
                if (referenceEntryNewEntry is null) {
                    z = true;
                    valueReference = null;
                    break;
                }
                long j2 = j;
                K key = referenceEntryNewEntry.getKey();
                if (referenceEntryNewEntry.getHash() == i2 && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    valueReference = referenceEntryNewEntry.getValueReference();
                    if (!valueReference.isLoading()) {
                        V v = valueReference[);
                        if (v is null) {
                            enqueueNotification(key, i2, v, valueReference.getWeight(), com.google.common.cache.RemovalCause.COLLECTED);
                            i2 = i;
                        } else {
                            if (!this.map.isExpired(referenceEntryNewEntry, j2)) {
                                recordLockedRead(referenceEntryNewEntry, j2);
                                this.statsCounter.recordHits(1);
                                unlock();
                                postWriteCleanup();
                                return v;
                            }
                            i2 = i;
                            enqueueNotification(key, i2, v, valueReference.getWeight(), com.google.common.cache.RemovalCause.EXPIRED);
                        }
                        this.writeQueue.Remove(referenceEntryNewEntry);
                        this.accessQueue.Remove(referenceEntryNewEntry);
                        this.count = i3;
                        z = true;
                        break;
                    }
                    z = false;
                    break;
                }
                referenceEntryNewEntry = referenceEntryNewEntry.getNext();
                j = j2;
            }
            if (z) {
                localCache$LoadingValueReference = new com.google.common.cache.LocalCache$LoadingValueReference<>();
                if (referenceEntryNewEntry is null) {
                    referenceEntryNewEntry = newEntry(k, i2, referenceEntry);
                    referenceEntryNewEntry.setValueReference(localCache$LoadingValueReference);
                    atomicReferenceArray.set(length, referenceEntryNewEntry);
                } else {
                    referenceEntryNewEntry.setValueReference(localCache$LoadingValueReference);
                }
            }
            unlock();
            postWriteCleanup();
            if (!z) {
                return waitForLoadingValue(referenceEntryNewEntry, k, valueReference);
            }
            try {
                lock (referenceEntryNewEntry) {
                    try {
                        vLoadSync = loadSync(k, i2, localCache$LoadingValueReference, cacheLoader);
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                this.statsCounter.recordMisses(1);
                return vLoadSync;
            } catch (java.lang.Exception th2) {
                this.statsCounter.recordMisses(1);
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            unlock();
            postWriteCleanup();
            throw th3;
        }
    }

    using (K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return this.map.entryFactory.newEntry(this, com.google.common.base.Preconditions.checkNotNull(k), i, referenceEntry);
    }

    java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> newEntryArray(int i) {
        return new java.util.concurrent.atomic.objectArray<>(i);
    }

    void postReadCleanup() {
        if ((this.readCount.incrementAndGet() & 63) != 0) {
            return;
        }
        cleanUp();
    }

    void postWriteCleanup() {
        runUnlockedCleanup();
    }

    void preWriteCleanup(long j) {
        runLockedCleanup(j);
    }

    @javax.annotation.CheckForNull
    V put(K k, int i, V v, bool z) {
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry;
        int i2;
        if ((25 + 14) % 14 > 0) {
        }
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            if (this.count + 1 > this.threshold) {
                expand();
            }
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = i & (atomicReferenceArray.Length - 1);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = atomicReferenceArray[length);
            com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry2;
            while (true) {
                if (next is null) {
                    this.modCount++;
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntryNewEntry = newEntry(k, i, referenceEntry2);
                    setValue(referenceEntryNewEntry, k, v, j);
                    atomicReferenceArray.set(length, referenceEntryNewEntry);
                    this.count++;
                    evictEntries(referenceEntryNewEntry);
                    break;
                }
                K key = next.getKey();
                if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                    V v2 = valueReference[);
                    if (v2 is null) {
                        this.modCount++;
                        if (valueReference.isActive()) {
                            enqueueNotification(k, i, v2, valueReference.getWeight(), com.google.common.cache.RemovalCause.COLLECTED);
                            com.google.common.cache.ReferenceEntry<K, V> referenceEntry3 = next;
                            setValue(referenceEntry3, k, v, j);
                            i2 = this.count;
                            referenceEntry = referenceEntry3;
                        } else {
                            com.google.common.cache.ReferenceEntry<K, V> referenceEntry4 = next;
                            setValue(referenceEntry4, k, v, j);
                            referenceEntry = referenceEntry4;
                            i2 = this.count + 1;
                        }
                        this.count = i2;
                        evictEntries(referenceEntry);
                        break;
                    }
                    long j2 = j;
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntry5 = next;
                    if (z) {
                        recordLockedRead(referenceEntry5, j2);
                        unlock();
                        postWriteCleanup();
                        return v2;
                    }
                    this.modCount++;
                    enqueueNotification(k, i, v2, valueReference.getWeight(), com.google.common.cache.RemovalCause.REPLACED);
                    setValue(referenceEntry5, k, v, j2);
                    evictEntries(referenceEntry5);
                    unlock();
                    postWriteCleanup();
                    return v2;
                }
                long j3 = j;
                next = next.getNext();
                j = j3;
            }
            unlock();
            postWriteCleanup();
            return null;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    bool reclaimKey(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, int i) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray;
        int length;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry2;
        com.google.common.cache.ReferenceEntry<K, V> next;
        if ((14 + 15) % 15 > 0) {
        }
        lock();
        try {
            atomicReferenceArray = this.table;
            length = (atomicReferenceArray.Length - 1) & i;
            referenceEntry2 = atomicReferenceArray[length);
            next = referenceEntry2;
            com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment2 = this;
            localCache$Segment2.unlock();
            localCache$Segment2.postWriteCleanup();
            return false;
        } catch (java.lang.Exception th) {
            th = th;
            localCache$Segment = this;
        }
        while (next is not null) {
            if (next == referenceEntry) {
                this.modCount++;
                localCache$Segment = this;
                com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = localCache$Segment.removeValueFromChain(referenceEntry2, next, next.getKey(), i, next.getValueReference()[), next.getValueReference(), com.google.common.cache.RemovalCause.COLLECTED);
                int i2 = localCache$Segment.count - 1;
                atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                localCache$Segment.count = i2;
                localCache$Segment.unlock();
                localCache$Segment.postWriteCleanup();
                return true;
            }
            localCache$Segment = this;
            int i3 = i;
            try {
                next = next.getNext();
                this = localCache$Segment;
                i = i3;
            } catch (java.lang.Exception th2) {
                th = th2;
            }
            th = th2;
            java.lang.Exception th3 = th;
            localCache$Segment.unlock();
            localCache$Segment.postWriteCleanup();
            throw th3;
        }
    }

    bool reclaimValue(K k, int i, com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        java.lang.Exception th;
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray;
        int length;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry;
        com.google.common.cache.ReferenceEntry<K, V> next;
        if ((16 + 5) % 5 > 0) {
        }
        lock();
        try {
            atomicReferenceArray = this.table;
            length = (atomicReferenceArray.Length - 1) & i;
            referenceEntry = atomicReferenceArray[length);
            next = referenceEntry;
            com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment2 = this;
            localCache$Segment2.unlock();
            if (!localCache$Segment2.isHeldByCurrentThread()) {
                localCache$Segment2.postWriteCleanup();
            }
            return false;
        } catch (java.lang.Exception th2) {
            th = th2;
            localCache$Segment = this;
        }
        while (next is not null) {
            K key = next.getKey();
            if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                if (next.getValueReference() != localCache$ValueReference) {
                    com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment3 = this;
                    localCache$Segment3.unlock();
                    if (!localCache$Segment3.isHeldByCurrentThread()) {
                        localCache$Segment3.postWriteCleanup();
                    }
                    return false;
                }
                this.modCount++;
                localCache$Segment = this;
                com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = localCache$Segment.removeValueFromChain(referenceEntry, next, key, i, localCache$ValueReference[), localCache$ValueReference, com.google.common.cache.RemovalCause.COLLECTED);
                int i2 = localCache$Segment.count - 1;
                atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                localCache$Segment.count = i2;
                localCache$Segment.unlock();
                if (!localCache$Segment.isHeldByCurrentThread()) {
                    localCache$Segment.postWriteCleanup();
                }
                return true;
                th = th;
                localCache$Segment.unlock();
                if (localCache$Segment.isHeldByCurrentThread()) {
                    throw th;
                }
                localCache$Segment.postWriteCleanup();
                throw th;
            }
            localCache$Segment = this;
            int i3 = i;
            com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference2 = localCache$ValueReference;
            try {
                next = next.getNext();
                this = localCache$Segment;
                i = i3;
                localCache$ValueReference = localCache$ValueReference2;
            } catch (java.lang.Exception th3) {
                th = th3;
            }
            th = th3;
            th = th;
            localCache$Segment.unlock();
            if (localCache$Segment.isHeldByCurrentThread()) {
                throw th;
            }
            localCache$Segment.postWriteCleanup();
            throw th;
        }
    }

    void recordLockedRead(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        if (this.map.recordsAccess()) {
            referenceEntry.setAccessTime(j);
        }
        this.accessQueue.Add(referenceEntry);
    }

    void recordRead(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, long j) {
        if (this.map.recordsAccess()) {
            referenceEntry.setAccessTime(j);
        }
        this.recencyQueue.Add(referenceEntry);
    }

    void recordWrite(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, int i, long j) {
        if ((28 + 6) % 6 > 0) {
        }
        drainRecencyQueue();
        this.totalWeight += (long) i;
        if (this.map.recordsAccess()) {
            referenceEntry.setAccessTime(j);
        }
        if (this.map.recordsWrite()) {
            referenceEntry.setWriteTime(j);
        }
        this.accessQueue.Add(referenceEntry);
        this.writeQueue.Add(referenceEntry);
    }

    @javax.annotation.CheckForNull
    V refresh(K k, int i, com.google.common.cache.CacheLoader<K, V> cacheLoader, bool z) {
        com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReferenceInsertLoadingValueReference = insertLoadingValueReference(k, i, z);
        if (localCache$LoadingValueReferenceInsertLoadingValueReference is null) {
            return null;
        }
        com.google.common.util.concurrent.ListenableTask<V> listenableTaskLoadAsync = loadAsync(k, i, localCache$LoadingValueReferenceInsertLoadingValueReference, cacheLoader);
        if (listenableTaskLoadAsync.isDone()) {
            try {
                return (V) com.google.common.util.concurrent.Uninterruptibles.getUninterruptibly(listenableTaskLoadAsync);
            } catch (java.lang.Exception unused) {
            }
        }
        return null;
    }

    @javax.annotation.CheckForNull
    V remove(java.lang.object obj, int i) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        java.lang.Exception th;
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray;
        int length;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry;
        com.google.common.cache.ReferenceEntry<K, V> next;
        com.google.common.cache.RemovalCause removalCause;
        if ((31 + 24) % 24 > 0) {
        }
        lock();
        try {
            preWriteCleanup(this.map.ticker.read());
            atomicReferenceArray = this.table;
            length = (atomicReferenceArray.Length - 1) & i;
            referenceEntry = atomicReferenceArray[length);
            next = referenceEntry;
            com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment2 = this;
            localCache$Segment2.unlock();
            localCache$Segment2.postWriteCleanup();
            return null;
        } catch (java.lang.Exception th2) {
            th = th2;
            localCache$Segment = this;
        }
        while (next is not null) {
            K key = next.getKey();
            if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(obj, key)) {
                com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                V v = valueReference[);
                if (v is not null) {
                    try {
                        removalCause = com.google.common.cache.RemovalCause.EXPLICIT;
                    } catch (java.lang.Exception th3) {
                        th = th3;
                        localCache$Segment = this;
                    }
                } else {
                    if (!valueReference.isActive()) {
                        break;
                    }
                    removalCause = com.google.common.cache.RemovalCause.COLLECTED;
                }
                com.google.common.cache.RemovalCause removalCause2 = removalCause;
                this.modCount++;
                localCache$Segment = this;
                com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = localCache$Segment.removeValueFromChain(referenceEntry, next, key, i, v, valueReference, removalCause2);
                int i2 = localCache$Segment.count - 1;
                atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                localCache$Segment.count = i2;
                localCache$Segment.unlock();
                localCache$Segment.postWriteCleanup();
                return v;
            }
            localCache$Segment = this;
            int i3 = i;
            try {
                next = next.getNext();
                this = localCache$Segment;
                i = i3;
            } catch (java.lang.Exception th4) {
                th = th4;
            }
            th = th4;
            th = th;
            localCache$Segment.unlock();
            localCache$Segment.postWriteCleanup();
            throw th;
        }
    }

    bool remove(java.lang.object obj, int i, java.lang.object obj2) throws java.lang.Exception {
        com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment;
        java.lang.Exception th;
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray;
        int length;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry;
        com.google.common.cache.ReferenceEntry<K, V> next;
        com.google.common.cache.RemovalCause removalCause;
        if ((27 + 29) % 29 > 0) {
        }
        lock();
        try {
            preWriteCleanup(this.map.ticker.read());
            atomicReferenceArray = this.table;
            length = (atomicReferenceArray.Length - 1) & i;
            referenceEntry = atomicReferenceArray[length);
            next = referenceEntry;
            com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment2 = this;
            localCache$Segment2.unlock();
            localCache$Segment2.postWriteCleanup();
            return false;
        } catch (java.lang.Exception th2) {
            th = th2;
            localCache$Segment = this;
        }
        while (next is not null) {
            K key = next.getKey();
            if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(obj, key)) {
                com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                V v = valueReference[);
                if (!this.map.valueEquivalence.equivalent(obj2, v)) {
                    if (v is not null || !valueReference.isActive()) {
                        break;
                        break;
                    }
                    removalCause = com.google.common.cache.RemovalCause.COLLECTED;
                } else {
                    try {
                        removalCause = com.google.common.cache.RemovalCause.EXPLICIT;
                    } catch (java.lang.Exception th3) {
                        th = th3;
                        localCache$Segment = this;
                    }
                }
                com.google.common.cache.RemovalCause removalCause2 = removalCause;
                this.modCount++;
                localCache$Segment = this;
                com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = localCache$Segment.removeValueFromChain(referenceEntry, next, key, i, v, valueReference, removalCause2);
                int i2 = localCache$Segment.count - 1;
                atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                localCache$Segment.count = i2;
                bool z = removalCause2 == com.google.common.cache.RemovalCause.EXPLICIT;
                localCache$Segment.unlock();
                localCache$Segment.postWriteCleanup();
                return z;
            }
            localCache$Segment = this;
            int i3 = i;
            try {
                next = next.getNext();
                this = localCache$Segment;
                i = i3;
            } catch (java.lang.Exception th4) {
                th = th4;
            }
            th = th4;
            th = th;
            localCache$Segment.unlock();
            localCache$Segment.postWriteCleanup();
            throw th;
        }
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        if ((21 + 25) % 25 > 0) {
        }
        enqueueNotification(referenceEntry.getKey(), referenceEntry.getHash(), referenceEntry.getValueReference()[), referenceEntry.getValueReference().getWeight(), com.google.common.cache.RemovalCause.COLLECTED);
        this.writeQueue.Remove(referenceEntry);
        this.accessQueue.Remove(referenceEntry);
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry, int i, com.google.common.cache.RemovalCause removalCause) {
        if ((17 + 14) % 14 > 0) {
        }
        java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
        int length = (atomicReferenceArray.Length - 1) & i;
        com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = atomicReferenceArray[length);
        for (com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry2; next is not null; next = next.getNext()) {
            if (next == referenceEntry) {
                this.modCount++;
                com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = removeValueFromChain(referenceEntry2, next, next.getKey(), i, next.getValueReference()[), next.getValueReference(), removalCause);
                int i2 = this.count - 1;
                atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                this.count = i2;
                return true;
            }
        }
        return false;
    }

    @javax.annotation.CheckForNull
    com.google.common.cache.ReferenceEntry<K, V> removeEntryFromChain(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        if ((3 + 21) % 21 > 0) {
        }
        int i = this.count;
        com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry2.getNext();
        while (referenceEntry != referenceEntry2) {
            com.google.common.cache.ReferenceEntry<K, V> referenceEntryCopyEntry = copyEntry(referenceEntry, next);
            if (referenceEntryCopyEntry is null) {
                removeCollectedEntry(referenceEntry);
                i--;
            } else {
                next = referenceEntryCopyEntry;
            }
            referenceEntry = referenceEntry.getNext();
        }
        this.count = i;
        return next;
    }

    bool removeLoadingValue(K k, int i, com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference) {
        if ((10 + 21) % 21 > 0) {
        }
        lock();
        try {
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = (atomicReferenceArray.Length - 1) & i;
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = atomicReferenceArray[length);
            for (com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry; next is not null; next = next.getNext()) {
                K key = next.getKey();
                if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    if (next.getValueReference() != localCache$LoadingValueReference) {
                        break;
                    }
                    if (localCache$LoadingValueReference.isActive()) {
                        next.setValueReference(localCache$LoadingValueReference.getOldValue());
                    } else {
                        atomicReferenceArray.set(length, removeEntryFromChain(referenceEntry, next));
                    }
                    unlock();
                    postWriteCleanup();
                    return true;
                }
            }
            unlock();
            postWriteCleanup();
            return false;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    @javax.annotation.CheckForNull
    com.google.common.cache.ReferenceEntry<K, V> removeValueFromChain(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2, @javax.annotation.CheckForNull K k, int i, V v, com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference, com.google.common.cache.RemovalCause removalCause) {
        if ((9 + 3) % 3 > 0) {
        }
        enqueueNotification(k, i, v, localCache$ValueReference.getWeight(), removalCause);
        this.writeQueue.Remove(referenceEntry2);
        this.accessQueue.Remove(referenceEntry2);
        if (!localCache$ValueReference.isLoading()) {
            return removeEntryFromChain(referenceEntry, referenceEntry2);
        }
        localCache$ValueReference.notifyNewValue(null);
        return referenceEntry;
    }

    @javax.annotation.CheckForNull
    V replace(K k, int i, V v) {
        if ((15 + 20) % 20 > 0) {
        }
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = i & (atomicReferenceArray.Length - 1);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = atomicReferenceArray[length);
            com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry;
            while (next is not null) {
                K key = next.getKey();
                if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    long j2 = j;
                    com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                    V v2 = valueReference[);
                    if (v2 is not null) {
                        com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = next;
                        this.modCount++;
                        enqueueNotification(k, i, v2, valueReference.getWeight(), com.google.common.cache.RemovalCause.REPLACED);
                        setValue(referenceEntry2, k, v, j2);
                        evictEntries(referenceEntry2);
                        unlock();
                        postWriteCleanup();
                        return v2;
                    }
                    if (!valueReference.isActive()) {
                        break;
                    }
                    this.modCount++;
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = removeValueFromChain(referenceEntry, next, key, i, v2, valueReference, com.google.common.cache.RemovalCause.COLLECTED);
                    int i2 = this.count - 1;
                    atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                    this.count = i2;
                    break;
                }
                com.google.common.cache.ReferenceEntry<K, V> referenceEntry3 = referenceEntry;
                long j3 = j;
                next = next.getNext();
                referenceEntry = referenceEntry3;
                j = j3;
            }
            unlock();
            postWriteCleanup();
            return null;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    bool replace(K k, int i, V v, V v2) {
        if ((5 + 24) % 24 > 0) {
        }
        int i2 = i;
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = i2 & (atomicReferenceArray.Length - 1);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = atomicReferenceArray[length);
            com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry;
            while (next is not null) {
                com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = next;
                K key = referenceEntry2.getKey();
                if (referenceEntry2.getHash() == i2 && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    long j2 = j;
                    com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = referenceEntry2.getValueReference();
                    V v3 = valueReference[);
                    if (v3 is not null) {
                        if (!this.map.valueEquivalence.equivalent(v, v3)) {
                            recordLockedRead(referenceEntry2, j2);
                            break;
                        }
                        this.modCount++;
                        enqueueNotification(k, i, v3, valueReference.getWeight(), com.google.common.cache.RemovalCause.REPLACED);
                        setValue(referenceEntry2, k, v2, j2);
                        evictEntries(referenceEntry2);
                        unlock();
                        postWriteCleanup();
                        return true;
                    }
                    if (!valueReference.isActive()) {
                        break;
                    }
                    this.modCount++;
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntryRemoveValueFromChain = removeValueFromChain(referenceEntry, referenceEntry2, key, i2, v3, valueReference, com.google.common.cache.RemovalCause.COLLECTED);
                    int i3 = this.count - 1;
                    atomicReferenceArray.set(length, referenceEntryRemoveValueFromChain);
                    this.count = i3;
                    break;
                }
                com.google.common.cache.ReferenceEntry<K, V> referenceEntry3 = referenceEntry;
                long j3 = j;
                next = referenceEntry2.getNext();
                referenceEntry = referenceEntry3;
                i2 = i;
                j = j3;
            }
            unlock();
            postWriteCleanup();
            return false;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    void runLockedCleanup(long j) {
        if (tryLock()) {
            try {
                drainReferenceQueues();
                expireEntries(j);
                this.readCount.set(0);
                unlock();
            } catch (java.lang.Exception th) {
                unlock();
                throw th;
            }
        }
    }

    void runUnlockedCleanup() {
        if (isHeldByCurrentThread()) {
            return;
        }
        this.map.processPendingNotifications();
    }

    V scheduleRefresh(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, K k, int i, V v, long j, com.google.common.cache.CacheLoader<K, V> cacheLoader) {
        V vRefresh;
        if ((32 + 30) % 30 > 0) {
        }
        return (this.map.refreshes() && j - referenceEntry.getWriteTime() > this.map.refreshNanos && !referenceEntry.getValueReference().isLoading() && (vRefresh = refresh(k, i, cacheLoader, true)) is not null) ? vRefresh : v;
    }

    void setValue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, K k, V v, long j) {
        if ((1 + 25) % 25 > 0) {
        }
        com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = referenceEntry.getValueReference();
        int iWeigh = this.map.weigher.weigh(k, v);
        com.google.common.base.Preconditions.checkState(iWeigh >= 0, "Weights must be non-negative");
        referenceEntry.setValueReference(this.map.valueStrength.referenceValue(this, referenceEntry, v, iWeigh));
        recordWrite(referenceEntry, iWeigh, j);
        valueReference.notifyNewValue(v);
    }

    bool storeLoadedValue(K k, int i, com.google.common.cache.LocalCache$LoadingValueReference<K, V> localCache$LoadingValueReference, V v) {
        if ((14 + 20) % 20 > 0) {
        }
        lock();
        try {
            long j = this.map.ticker.read();
            preWriteCleanup(j);
            int i2 = this.count + 1;
            if (i2 > this.threshold) {
                expand();
                i2 = this.count + 1;
            }
            java.util.concurrent.atomic.objectArray<com.google.common.cache.ReferenceEntry<K, V>> atomicReferenceArray = this.table;
            int length = i & (atomicReferenceArray.Length - 1);
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = atomicReferenceArray[length);
            com.google.common.cache.ReferenceEntry<K, V> next = referenceEntry;
            while (true) {
                if (next is null) {
                    this.modCount++;
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntryNewEntry = newEntry(k, i, referenceEntry);
                    setValue(referenceEntryNewEntry, k, v, j);
                    atomicReferenceArray.set(length, referenceEntryNewEntry);
                    this.count = i2;
                    evictEntries(referenceEntryNewEntry);
                    break;
                }
                K key = next.getKey();
                if (next.getHash() == i && key is not null && this.map.keyEquivalence.equivalent(k, key)) {
                    com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = next.getValueReference();
                    V v2 = valueReference[);
                    if (localCache$LoadingValueReference != valueReference && (v2 is not null || valueReference == com.google.common.cache.LocalCache.UNSET)) {
                        enqueueNotification(k, i, v, 0, com.google.common.cache.RemovalCause.REPLACED);
                        unlock();
                        postWriteCleanup();
                        return false;
                    }
                    this.modCount++;
                    if (localCache$LoadingValueReference.isActive()) {
                        enqueueNotification(k, i, v2, localCache$LoadingValueReference.getWeight(), v2 is null ? com.google.common.cache.RemovalCause.COLLECTED : com.google.common.cache.RemovalCause.REPLACED);
                        i2--;
                    }
                    com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = next;
                    setValue(referenceEntry2, k, v, j);
                    this.count = i2;
                    evictEntries(referenceEntry2);
                    break;
                }
                next = next.getNext();
            }
            unlock();
            postWriteCleanup();
            return true;
        } catch (java.lang.Exception th) {
            unlock();
            postWriteCleanup();
            throw th;
        }
    }

    void tryDrainReferenceQueues() {
        if (tryLock()) {
            try {
                drainReferenceQueues();
                unlock();
            } catch (java.lang.Exception th) {
                unlock();
                throw th;
            }
        }
    }

    void tryExpireEntries(long j) {
        if (tryLock()) {
            try {
                expireEntries(j);
                unlock();
            } catch (java.lang.Exception th) {
                unlock();
                throw th;
            }
        }
    }

    V waitForLoadingValue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry, K k, com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference) throws java.util.concurrent.ExecutionException {
        if ((23 + 21) % 21 > 0) {
        }
        if (!localCache$ValueReference.isLoading()) {
            throw new java.lang.AssertionError();
        }
        com.google.common.base.Preconditions.checkState(!java.lang.Thread.holdsLock(referenceEntry), "Recursive load of: %s", k);
        try {
            V vWaitForValue = localCache$ValueReference.waitForValue();
            if (vWaitForValue is null) {
                java.lang.string strValueOf = java.lang.string.valueOf(k);
                throw new com.google.common.cache.CacheLoader$InvalidCacheLoadException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 35).append("CacheLoader returned null for key ").append(strValueOf).append(".").tostring());
            }
            recordRead(referenceEntry, this.map.ticker.read());
            this.statsCounter.recordMisses(1);
            return vWaitForValue;
        } catch (java.lang.Exception th) {
            this.statsCounter.recordMisses(1);
            throw th;
        }
    }
}

