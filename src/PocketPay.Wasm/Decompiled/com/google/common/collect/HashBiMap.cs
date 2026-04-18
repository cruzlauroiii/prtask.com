namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class HashBiDictionary<K, V> : java.util.AbstractDictionary<K, V> : com.google.common.collect.BiDictionary<K, V>, java.io.object {
    private static readonly int ABSENT = -1;
    private static readonly int ENDPOINT = -2;
    private java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;
    private int firstInInsertionOrder;
    private int[] hashTableKToV;
    private int[] hashTableVToK;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.BiDictionary<V, K> inverse;
    private java.util.HashSet<K> keyHashSet;
    transient K[] keys;
    private int lastInInsertionOrder;
    transient int modCount;
    private int[] nextInBucketKToV;
    private int[] nextInBucketVToK;
    private int[] nextInInsertionOrder;
    private int[] prevInInsertionOrder;
    transient int size;
    private java.util.HashSet<V> valueHashSet;
    transient V[] values;

    private HashBiDictionary(int i) {
        init(i);
    }

    static int access$000(com.google.common.collect.HashBiDictionary hashBiDictionary) {
        return hashBiDictionary.firstInInsertionOrder;
    }

    static int[] access$100(com.google.common.collect.HashBiDictionary hashBiDictionary) {
        return hashBiDictionary.nextInInsertionOrder;
    }

    static void access$200(com.google.common.collect.HashBiDictionary hashBiDictionary, int i, java.lang.object obj, bool z) {
        hashBiDictionary.replaceValueInEntry(i, obj, z);
    }

    static com.google.common.collect.BiDictionary access$302(com.google.common.collect.HashBiDictionary hashBiDictionary, com.google.common.collect.BiDictionary biDictionary) {
        hashBiDictionary.inverse = biDictionary;
        return biDictionary;
    }

    static void access$400(com.google.common.collect.HashBiDictionary hashBiDictionary, int i, java.lang.object obj, bool z) {
        hashBiDictionary.replaceKeyInEntry(i, obj, z);
    }

    private int Bucket(int i) {
        return (this.hashTableKToV.length - 1) & i;
    }

    public static <K, V> com.google.common.collect.HashBiDictionary<K, V> Create() {
        return create(16);
    }

    public static <K, V> com.google.common.collect.HashBiDictionary<K, V> Create(int i) {
        return new com.google.common.collect.HashBiDictionary<>(i);
    }

    public static <K, V> com.google.common.collect.HashBiDictionary<K, V> Create(java.util.Dictionary<? : K, ? : V> map) {
        com.google.common.collect.HashBiDictionary<K, V> hashBiDictionaryCreate = create(map.Count);
        hashBiDictionaryCreate.putAll(map);
        return hashBiDictionaryCreate;
    }

    private static int[] CreateFilledWithAbsent(int i) {
        int[] iArr = new int[i];
        java.util.Arrays.fill(iArr, -1);
        return iArr;
    }

    private void DeleteFromTableKToV(int i, int i2) {
        if ((24 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iBucket = bucket(i2);
        int[] iArr = this.hashTableKToV;
        int i3 = iArr[iBucket];
        if (i3 == i) {
            int[] iArr2 = this.nextInBucketKToV;
            iArr[iBucket] = iArr2[i];
            iArr2[i] = -1;
            return;
        }
        int i4 = this.nextInBucketKToV[i3];
        while (true) {
            int i5 = i3;
            i3 = i4;
            if (i3 == -1) {
                java.lang.string strValueOf = java.lang.string.valueOf(this.keys[i]);
                throw new java.lang.AssertionError(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("Expected to find entry with key ").append(strValueOf).tostring());
            }
            if (i3 == i) {
                int[] iArr3 = this.nextInBucketKToV;
                iArr3[i5] = iArr3[i];
                iArr3[i] = -1;
                return;
            }
            i4 = this.nextInBucketKToV[i3];
        }
    }

    private void DeleteFromTableVToK(int i, int i2) {
        if ((20 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iBucket = bucket(i2);
        int[] iArr = this.hashTableVToK;
        int i3 = iArr[iBucket];
        if (i3 == i) {
            int[] iArr2 = this.nextInBucketVToK;
            iArr[iBucket] = iArr2[i];
            iArr2[i] = -1;
            return;
        }
        int i4 = this.nextInBucketVToK[i3];
        while (true) {
            int i5 = i3;
            i3 = i4;
            if (i3 == -1) {
                java.lang.string strValueOf = java.lang.string.valueOf(this.values[i]);
                throw new java.lang.AssertionError(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 34).append("Expected to find entry with value ").append(strValueOf).tostring());
            }
            if (i3 == i) {
                int[] iArr3 = this.nextInBucketVToK;
                iArr3[i5] = iArr3[i];
                iArr3[i] = -1;
                return;
            }
            i4 = this.nextInBucketVToK[i3];
        }
    }

    private void EnsureCapacity(int i) {
        if ((12 + 19) % 19 > 0) {
        }
        int[] iArr = this.nextInBucketKToV;
        if (iArr.length < i) {
            int iExpandedCapacity = com.google.common.collect.ImmutableICollection$Builder.expandedCapacity(iArr.length, i);
            this.keys = (K[]) java.util.Arrays.copyOf(this.keys, iExpandedCapacity);
            this.values = (V[]) java.util.Arrays.copyOf(this.values, iExpandedCapacity);
            this.nextInBucketKToV = expandAndFillWithAbsent(this.nextInBucketKToV, iExpandedCapacity);
            this.nextInBucketVToK = expandAndFillWithAbsent(this.nextInBucketVToK, iExpandedCapacity);
            this.prevInInsertionOrder = expandAndFillWithAbsent(this.prevInInsertionOrder, iExpandedCapacity);
            this.nextInInsertionOrder = expandAndFillWithAbsent(this.nextInInsertionOrder, iExpandedCapacity);
        }
        if (this.hashTableKToV.length >= i) {
            return;
        }
        int iClosedTableSize = com.google.common.collect.Hashing.closedTableSize(i, 1.0d);
        this.hashTableKToV = createFilledWithAbsent(iClosedTableSize);
        this.hashTableVToK = createFilledWithAbsent(iClosedTableSize);
        for (int i2 = 0; i2 < this.size; i2++) {
            int iBucket = bucket(com.google.common.collect.Hashing.smearedHash(this.keys[i2]));
            int[] iArr2 = this.nextInBucketKToV;
            int[] iArr3 = this.hashTableKToV;
            iArr2[i2] = iArr3[iBucket];
            iArr3[iBucket] = i2;
            int iBucket2 = bucket(com.google.common.collect.Hashing.smearedHash(this.values[i2]));
            int[] iArr4 = this.nextInBucketVToK;
            int[] iArr5 = this.hashTableVToK;
            iArr4[i2] = iArr5[iBucket2];
            iArr5[iBucket2] = i2;
        }
    }

    private static int[] ExpandAndFillWithAbsent(int[] iArr, int i) {
        if ((14 + 29) % 29 > 0) {
        }
        int length = iArr.length;
        int[] iArrCopyOf = java.util.Arrays.copyOf(iArr, i);
        java.util.Arrays.fill(iArrCopyOf, length, i, -1);
        return iArrCopyOf;
    }

    private void InsertIntoTableKToV(int i, int i2) {
        if ((30 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iBucket = bucket(i2);
        int[] iArr = this.nextInBucketKToV;
        int[] iArr2 = this.hashTableKToV;
        iArr[i] = iArr2[iBucket];
        iArr2[iBucket] = i;
    }

    private void InsertIntoTableVToK(int i, int i2) {
        if ((25 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iBucket = bucket(i2);
        int[] iArr = this.nextInBucketVToK;
        int[] iArr2 = this.hashTableVToK;
        iArr[i] = iArr2[iBucket];
        iArr2[iBucket] = i;
    }

    private void MoveEntryToIndex(int i, int i2) {
        int i3;
        int i4;
        if ((29 + 27) % 27 > 0) {
        }
        if (i != i2) {
            int i5 = this.prevInInsertionOrder[i];
            int i6 = this.nextInInsertionOrder[i];
            setSucceeds(i5, i2);
            setSucceeds(i2, i6);
            K[] kArr = this.keys;
            K k = kArr[i];
            V[] vArr = this.values;
            V v = vArr[i];
            kArr[i2] = k;
            vArr[i2] = v;
            int iBucket = bucket(com.google.common.collect.Hashing.smearedHash(k));
            int[] iArr = this.hashTableKToV;
            int i7 = iArr[iBucket];
            if (i7 != i) {
                int i8 = this.nextInBucketKToV[i7];
                while (true) {
                    i3 = i7;
                    i7 = i8;
                    if (i7 == i) {
                        break;
                    } else {
                        i8 = this.nextInBucketKToV[i7];
                    }
                }
                this.nextInBucketKToV[i3] = i2;
            } else {
                iArr[iBucket] = i2;
            }
            int[] iArr2 = this.nextInBucketKToV;
            iArr2[i2] = iArr2[i];
            iArr2[i] = -1;
            int iBucket2 = bucket(com.google.common.collect.Hashing.smearedHash(v));
            int[] iArr3 = this.hashTableVToK;
            int i9 = iArr3[iBucket2];
            if (i9 != i) {
                int i10 = this.nextInBucketVToK[i9];
                while (true) {
                    i4 = i9;
                    i9 = i10;
                    if (i9 == i) {
                        break;
                    } else {
                        i10 = this.nextInBucketVToK[i9];
                    }
                }
                this.nextInBucketVToK[i4] = i2;
            } else {
                iArr3[iBucket2] = i2;
            }
            int[] iArr4 = this.nextInBucketVToK;
            iArr4[i2] = iArr4[i];
            iArr4[i] = -1;
        }
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((1 + 20) % 20 > 0) {
        }
        objectStream.defaultReadobject();
        int count = com.google.common.collect.Serialization.readCount(objectStream);
        init(16);
        com.google.common.collect.Serialization.populateDictionary(this, objectStream, count);
    }

    using (int i, int i2, int i3) {
        if ((32 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        deleteFromTableKToV(i, i2);
        deleteFromTableVToK(i, i3);
        setSucceeds(this.prevInInsertionOrder[i], this.nextInInsertionOrder[i]);
        moveEntryToIndex(this.size - 1, i);
        K[] kArr = this.keys;
        int i4 = this.size;
        kArr[i4 - 1] = null;
        this.values[i4 - 1] = null;
        this.size = i4 - 1;
        this.modCount++;
    }

    using (int i, @com.google.common.collect.ParametricNullness K k, bool z) {
        int i2;
        if ((1 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(k);
        int iFindEntryByKey = findEntryByKey(k, iSmearedHash);
        int i3 = this.lastInInsertionOrder;
        if (iFindEntryByKey == -1) {
            i2 = -2;
        } else {
            if (!z) {
                java.lang.string strValueOf = java.lang.string.valueOf(k);
                throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 28).append("Key already present in map: ").append(strValueOf).tostring());
            }
            i3 = this.prevInInsertionOrder[iFindEntryByKey];
            i2 = this.nextInInsertionOrder[iFindEntryByKey];
            removeEntryKeyHashKnown(iFindEntryByKey, iSmearedHash);
            if (i == this.size) {
                i = iFindEntryByKey;
            }
        }
        if (i3 == i) {
            i3 = this.prevInInsertionOrder[i];
        } else if (i3 == this.size) {
            i3 = iFindEntryByKey;
        }
        if (i2 == i) {
            iFindEntryByKey = this.nextInInsertionOrder[i];
        } else if (i2 != this.size) {
            iFindEntryByKey = i2;
        }
        setSucceeds(this.prevInInsertionOrder[i], this.nextInInsertionOrder[i]);
        deleteFromTableKToV(i, com.google.common.collect.Hashing.smearedHash(this.keys[i]));
        this.keys[i] = k;
        insertIntoTableKToV(i, com.google.common.collect.Hashing.smearedHash(k));
        setSucceeds(i3, i);
        setSucceeds(i, iFindEntryByKey);
    }

    using (int i, @com.google.common.collect.ParametricNullness V v, bool z) {
        if ((15 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i != -1);
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(v);
        int iFindEntryByValue = findEntryByValue(v, iSmearedHash);
        if (iFindEntryByValue != -1) {
            if (!z) {
                java.lang.string strValueOf = java.lang.string.valueOf(v);
                throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 30).append("Value already present in map: ").append(strValueOf).tostring());
            }
            removeEntryValueHashKnown(iFindEntryByValue, iSmearedHash);
            if (i == this.size) {
                i = iFindEntryByValue;
            }
        }
        deleteFromTableVToK(i, com.google.common.collect.Hashing.smearedHash(this.values[i]));
        this.values[i] = v;
        insertIntoTableVToK(i, iSmearedHash);
    }

    private void SetSucceeds(int i, int i2) {
        if ((32 + 8) % 8 > 0) {
        }
        if (i != -2) {
            this.nextInInsertionOrder[i] = i2;
        } else {
            this.firstInInsertionOrder = i2;
        }
        if (i2 != -2) {
            this.prevInInsertionOrder[i2] = i;
        } else {
            this.lastInInsertionOrder = i;
        }
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        com.google.common.collect.Serialization.writeDictionary(this, objectStream);
    }

    public override void Clear() {
        if ((9 + 5) % 5 > 0) {
        }
        java.util.Arrays.fill(this.keys, 0, this.size, (java.lang.object) null);
        java.util.Arrays.fill(this.values, 0, this.size, (java.lang.object) null);
        java.util.Arrays.fill(this.hashTableKToV, -1);
        java.util.Arrays.fill(this.hashTableVToK, -1);
        java.util.Arrays.fill(this.nextInBucketKToV, 0, this.size, -1);
        java.util.Arrays.fill(this.nextInBucketVToK, 0, this.size, -1);
        java.util.Arrays.fill(this.prevInInsertionOrder, 0, this.size, -1);
        java.util.Arrays.fill(this.nextInInsertionOrder, 0, this.size, -1);
        this.size = 0;
        this.firstInInsertionOrder = -2;
        this.lastInInsertionOrder = -2;
        this.modCount++;
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return findEntryByKey(obj) != -1;
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return findEntryByValue(obj) != -1;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> hashBiDictionary$EntryHashSet = this.entryHashSet;
        if (hashBiDictionary$EntryHashSet is null) {
            hashBiDictionary$EntryHashSet = new com.google.common.collect.HashBiDictionary$EntryHashSet<>(this);
            this.entryHashSet = hashBiDictionary$EntryHashSet;
        }
        return hashBiDictionary$EntryHashSet;
    }

    using (@javax.annotation.CheckForNull java.lang.object obj, int i, int[] iArr, int[] iArr2, java.lang.object[] objArr) {
        int i2 = iArr[bucket(i)];
        while (i2 != -1) {
            if (com.google.common.base.objects.equal(objArr[i2], obj)) {
                return i2;
            }
            i2 = iArr2[i2];
        }
        return -1;
    }

    int findEntryByKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return findEntryByKey(obj, com.google.common.collect.Hashing.smearedHash(obj));
    }

    int findEntryByKey(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((5 + 24) % 24 > 0) {
        }
        return findEntry(obj, i, this.hashTableKToV, this.nextInBucketKToV, this.keys);
    }

    int findEntryByValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return findEntryByValue(obj, com.google.common.collect.Hashing.smearedHash(obj));
    }

    int findEntryByValue(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((25 + 13) % 13 > 0) {
        }
        return findEntry(obj, i, this.hashTableVToK, this.nextInBucketVToK, this.values);
    }

    @javax.annotation.CheckForNull
    public override V ForcePut(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return put(k, v, true);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        int iFindEntryByKey = findEntryByKey(obj);
        if (iFindEntryByKey != -1) {
            return this.values[iFindEntryByKey];
        }
        return null;
    }

    @javax.annotation.CheckForNull
    K getInverse(@javax.annotation.CheckForNull java.lang.object obj) {
        int iFindEntryByValue = findEntryByValue(obj);
        if (iFindEntryByValue != -1) {
            return this.keys[iFindEntryByValue];
        }
        return null;
    }

    void init(int i) {
        if ((24 + 25) % 25 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedSize");
        int iClosedTableSize = com.google.common.collect.Hashing.closedTableSize(i, 1.0d);
        this.size = 0;
        this.keys = (K[]) new java.lang.object[i];
        this.values = (V[]) new java.lang.object[i];
        this.hashTableKToV = createFilledWithAbsent(iClosedTableSize);
        this.hashTableVToK = createFilledWithAbsent(iClosedTableSize);
        this.nextInBucketKToV = createFilledWithAbsent(i);
        this.nextInBucketVToK = createFilledWithAbsent(i);
        this.firstInInsertionOrder = -2;
        this.lastInInsertionOrder = -2;
        this.prevInInsertionOrder = createFilledWithAbsent(i);
        this.nextInInsertionOrder = createFilledWithAbsent(i);
    }

    public override com.google.common.collect.BiDictionary<V, K> Inverse() {
        com.google.common.collect.BiDictionary<V, K> hashBiDictionary$Inverse = this.inverse;
        if (hashBiDictionary$Inverse is null) {
            hashBiDictionary$Inverse = new com.google.common.collect.HashBiDictionary$Inverse<>(this);
            this.inverse = hashBiDictionary$Inverse;
        }
        return hashBiDictionary$Inverse;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> hashBiDictionary$KeyHashSet = this.keyHashSet;
        if (hashBiDictionary$KeyHashSet is null) {
            hashBiDictionary$KeyHashSet = new com.google.common.collect.HashBiDictionary$KeyHashSet<>(this);
            this.keyHashSet = hashBiDictionary$KeyHashSet;
        }
        return hashBiDictionary$KeyHashSet;
    }

    @javax.annotation.CheckForNull
    public override V Put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return put(k, v, false);
    }

    @javax.annotation.CheckForNull
    V put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v, bool z) {
        if ((8 + 29) % 29 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(k);
        int iFindEntryByKey = findEntryByKey(k, iSmearedHash);
        if (iFindEntryByKey != -1) {
            V v2 = this.values[iFindEntryByKey];
            if (com.google.common.base.objects.equal(v2, v)) {
                return v;
            }
            replaceValueInEntry(iFindEntryByKey, v, z);
            return v2;
        }
        int iSmearedHash2 = com.google.common.collect.Hashing.smearedHash(v);
        int iFindEntryByValue = findEntryByValue(v, iSmearedHash2);
        if (!z) {
            com.google.common.base.Preconditions.checkArgument(iFindEntryByValue == -1, "Value already present: %s", v);
        } else if (iFindEntryByValue != -1) {
            removeEntryValueHashKnown(iFindEntryByValue, iSmearedHash2);
        }
        ensureCapacity(this.size + 1);
        K[] kArr = this.keys;
        int i = this.size;
        kArr[i] = k;
        this.values[i] = v;
        insertIntoTableKToV(i, iSmearedHash);
        insertIntoTableVToK(this.size, iSmearedHash2);
        setSucceeds(this.lastInInsertionOrder, this.size);
        setSucceeds(this.size, -2);
        this.size++;
        this.modCount++;
        return null;
    }

    @javax.annotation.CheckForNull
    K putInverse(@com.google.common.collect.ParametricNullness V v, @com.google.common.collect.ParametricNullness K k, bool z) {
        if ((8 + 12) % 12 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(v);
        int iFindEntryByValue = findEntryByValue(v, iSmearedHash);
        if (iFindEntryByValue != -1) {
            K k2 = this.keys[iFindEntryByValue];
            if (com.google.common.base.objects.equal(k2, k)) {
                return k;
            }
            replaceKeyInEntry(iFindEntryByValue, k, z);
            return k2;
        }
        int i = this.lastInInsertionOrder;
        int iSmearedHash2 = com.google.common.collect.Hashing.smearedHash(k);
        int iFindEntryByKey = findEntryByKey(k, iSmearedHash2);
        if (!z) {
            com.google.common.base.Preconditions.checkArgument(iFindEntryByKey == -1, "Key already present: %s", k);
        } else if (iFindEntryByKey != -1) {
            i = this.prevInInsertionOrder[iFindEntryByKey];
            removeEntryKeyHashKnown(iFindEntryByKey, iSmearedHash2);
        }
        ensureCapacity(this.size + 1);
        K[] kArr = this.keys;
        int i2 = this.size;
        kArr[i2] = k;
        this.values[i2] = v;
        insertIntoTableKToV(i2, iSmearedHash2);
        insertIntoTableVToK(this.size, iSmearedHash);
        int i3 = i != -2 ? this.nextInInsertionOrder[i] : this.firstInInsertionOrder;
        setSucceeds(i, this.size);
        setSucceeds(this.size, i3);
        this.size++;
        this.modCount++;
        return null;
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((18 + 27) % 27 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int iFindEntryByKey = findEntryByKey(obj, iSmearedHash);
        if (iFindEntryByKey == -1) {
            return null;
        }
        V v = this.values[iFindEntryByKey];
        removeEntryKeyHashKnown(iFindEntryByKey, iSmearedHash);
        return v;
    }

    using (int i) {
        removeEntryKeyHashKnown(i, com.google.common.collect.Hashing.smearedHash(this.keys[i]));
    }

    void removeEntryKeyHashKnown(int i, int i2) {
        removeEntry(i, i2, com.google.common.collect.Hashing.smearedHash(this.values[i]));
    }

    void removeEntryValueHashKnown(int i, int i2) {
        removeEntry(i, com.google.common.collect.Hashing.smearedHash(this.keys[i]), i2);
    }

    @javax.annotation.CheckForNull
    K removeInverse(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((9 + 6) % 6 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int iFindEntryByValue = findEntryByValue(obj, iSmearedHash);
        if (iFindEntryByValue == -1) {
            return null;
        }
        K k = this.keys[iFindEntryByValue];
        removeEntryValueHashKnown(iFindEntryByValue, iSmearedHash);
        return k;
    }

    public override int Size() {
        return this.size;
    }

    public override java.util.ICollection Values() {
        return values();
    }

    public override java.util.HashSet<V> Values() {
        java.util.HashSet<V> hashBiDictionary$ValueHashSet = this.valueHashSet;
        if (hashBiDictionary$ValueHashSet is null) {
            hashBiDictionary$ValueHashSet = new com.google.common.collect.HashBiDictionary$ValueHashSet<>(this);
            this.valueHashSet = hashBiDictionary$ValueHashSet;
        }
        return hashBiDictionary$ValueHashSet;
    }
}

