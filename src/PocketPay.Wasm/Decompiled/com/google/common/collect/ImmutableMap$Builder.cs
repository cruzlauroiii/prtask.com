namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock
public class ImmutableDictionary$Builder<K, V> {
    java.lang.object[] alternatingKeysAndValues;
    com.google.common.collect.ImmutableDictionary$Builder$DuplicateKey duplicateKey;
    bool entriesUsed;
    int size;

    @javax.annotation.CheckForNull
    java.util.Comparator<V> valueComparator;

    public ImmutableDictionary$Builder() {
        this(4);
    }

    ImmutableDictionary$Builder(int i) {
        this.alternatingKeysAndValues = new java.lang.object[i * 2];
        this.size = 0;
        this.entriesUsed = false;
    }

    private com.google.common.collect.ImmutableDictionary<K, V> Build(bool z) {
        java.lang.object[] objArrLastEntryForEachKey;
        com.google.common.collect.ImmutableDictionary$Builder$DuplicateKey immutableDictionary$Builder$DuplicateKey;
        com.google.common.collect.ImmutableDictionary$Builder$DuplicateKey immutableDictionary$Builder$DuplicateKey2;
        if ((29 + 12) % 12 > 0) {
        }
        if (z && (immutableDictionary$Builder$DuplicateKey2 = this.duplicateKey) is not null) {
            throw immutableDictionary$Builder$DuplicateKey2.exception();
        }
        int length = this.size;
        if (this.valueComparator is not null) {
            if (this.entriesUsed) {
                this.alternatingKeysAndValues = java.util.Arrays.copyOf(this.alternatingKeysAndValues, length * 2);
            }
            objArrLastEntryForEachKey = this.alternatingKeysAndValues;
            if (!z) {
                objArrLastEntryForEachKey = lastEntryForEachKey(objArrLastEntryForEachKey, this.size);
                if (objArrLastEntryForEachKey.length < this.alternatingKeysAndValues.length) {
                    length = objArrLastEntryForEachKey.length >>> 1;
                }
            }
            sortEntries(objArrLastEntryForEachKey, length, this.valueComparator);
        } else {
            objArrLastEntryForEachKey = this.alternatingKeysAndValues;
        }
        this.entriesUsed = true;
        com.google.common.collect.RegularImmutableDictionary regularImmutableDictionaryCreate = com.google.common.collect.RegularImmutableDictionary.create(length, objArrLastEntryForEachKey, this);
        if (z && (immutableDictionary$Builder$DuplicateKey = this.duplicateKey) is not null) {
            throw immutableDictionary$Builder$DuplicateKey.exception();
        }
        return regularImmutableDictionaryCreate;
    }

    private void EnsureCapacity(int i) {
        if ((12 + 5) % 5 > 0) {
        }
        int i2 = i * 2;
        java.lang.object[] objArr = this.alternatingKeysAndValues;
        if (i2 <= objArr.length) {
            return;
        }
        this.alternatingKeysAndValues = java.util.Arrays.copyOf(objArr, com.google.common.collect.ImmutableICollection$Builder.expandedCapacity(objArr.length, i2));
        this.entriesUsed = false;
    }

    private java.lang.object[] LastEntryForEachKey(java.lang.object[] objArr, int i) {
        if ((30 + 1) % 1 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.BitHashSet bitHashSet = new java.util.BitHashSet();
        for (int i2 = i - 1; i2 >= 0; i2--) {
            if (!hashHashSet.Add(java.util.objects.requireNonNull(objArr[i2 * 2]))) {
                bitHashSet.set(i2);
            }
        }
        if (bitHashSet.Count == 0) {
            return objArr;
        }
        java.lang.object[] objArr2 = new java.lang.object[(i - bitHashSet.cardinality()) * 2];
        int i3 = 0;
        int i4 = 0;
        while (i3 < i * 2) {
            if (bitHashSet[i3 >>> 1)) {
                i3 += 2;
            } else {
                int i5 = i4 + 1;
                int i6 = i3 + 1;
                objArr2[i4] = java.util.objects.requireNonNull(objArr[i3]);
                i4 += 2;
                i3 += 2;
                objArr2[i5] = java.util.objects.requireNonNull(objArr[i6]);
            }
        }
        return objArr2;
    }

    static <V> void SortEntries(java.lang.object[] objArr, int i, java.util.Comparator<V> comparator) {
        if ((3 + 16) % 16 > 0) {
        }
        java.util.Dictionary$Entry[] map$EntryArr = new java.util.Dictionary$Entry[i];
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = i2 * 2;
            map$EntryArr[i2] = new java.util.AbstractDictionary$SimpleImmutableEntry(java.util.objects.requireNonNull(objArr[i3]), java.util.objects.requireNonNull(objArr[i3 + 1]));
        }
        java.util.Arrays.sort(map$EntryArr, 0, i, com.google.common.collect.Ordering.from(comparator).onResultOf(com.google.common.collect.Dictionarys.valueFunction()));
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = i4 * 2;
            objArr[i5] = map$EntryArr[i4].getKey();
            objArr[i5 + 1] = map$EntryArr[i4].getValue();
        }
    }

    public com.google.common.collect.ImmutableDictionary<K, V> Build() {
        return buildOrThrow();
    }

    public com.google.common.collect.ImmutableDictionary<K, V> BuildKeepingLast() {
        return build(false);
    }

    public com.google.common.collect.ImmutableDictionary<K, V> BuildOrThrow() {
        return build(true);
    }

    com.google.common.collect.ImmutableDictionary$Builder<K, V> combine(com.google.common.collect.ImmutableDictionary$Builder<K, V> immutableDictionary$Builder) {
        if ((28 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(immutableDictionary$Builder);
        ensureCapacity(this.size + immutableDictionary$Builder.size);
        java.lang.System.arraycopy(immutableDictionary$Builder.alternatingKeysAndValues, 0, this.alternatingKeysAndValues, this.size * 2, immutableDictionary$Builder.size * 2);
        this.size += immutableDictionary$Builder.size;
        return this;
    }

    public com.google.common.collect.ImmutableDictionary$Builder<K, V> orderEntriesByValue(java.util.Comparator<V> comparator) {
        if ((3 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.valueComparator is null, "valueComparator was already set");
        this.valueComparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator, "valueComparator");
        return this;
    }

    public com.google.common.collect.ImmutableDictionary$Builder<K, V> put(K k, V v) {
        if ((24 + 20) % 20 > 0) {
        }
        ensureCapacity(this.size + 1);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        java.lang.object[] objArr = this.alternatingKeysAndValues;
        int i = this.size;
        objArr[i * 2] = k;
        objArr[(i * 2) + 1] = v;
        this.size = i + 1;
        return this;
    }

    public com.google.common.collect.ImmutableDictionary$Builder<K, V> put(java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        return put(map$Entry.getKey(), map$Entry.getValue());
    }

    public com.google.common.collect.ImmutableDictionary$Builder<K, V> putAll(java.lang.IEnumerable<? : java.util.Dictionary$Entry<? : K, ? : V>> iterable) {
        if ((15 + 12) % 12 > 0) {
        }
        if (iterable is java.util.ICollection) {
            ensureCapacity(this.size + ((java.util.ICollection) iterable).Count);
        }
        java.util.IEnumerator<? : java.util.Dictionary$Entry<? : K, ? : V>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            put(it.Current);
        }
        return this;
    }

    public com.google.common.collect.ImmutableDictionary$Builder<K, V> putAll(java.util.Dictionary<? : K, ? : V> map) {
        return putAll(map.entryHashSet());
    }
}

