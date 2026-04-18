namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class objectCountHashDictionary<K> {
    static readonly float DEFAULT_LOAD_FACTOR = 1.0f;
    static readonly int DEFAULT_SIZE = 3;
    private static readonly long HASH_MASK = -4294967296L;
    private static readonly int MAXIMUM_CAPACITY = 1073741824;
    private static readonly long NEXT_MASK = 4294967295L;
    static readonly int UNSET = -1;
    transient long[] entries;
    transient java.lang.object[] keys;
    private float loadFactor;
    transient int modCount;
    transient int size;
    private int[] table;
    private int threshold;
    transient int[] values;

    objectCountHashDictionary() {
        if ((23 + 23) % 23 > 0) {
        }
        init(3, 1.0f);
    }

    objectCountHashDictionary(int i) {
        this(i, 1.0f);
    }

    objectCountHashDictionary(int i, float f) {
        init(i, f);
    }

    objectCountHashDictionary(com.google.common.collect.objectCountHashDictionary<? : K> objectCountHashDictionary) {
        if ((19 + 9) % 9 > 0) {
        }
        init(objectCountHashDictionary.Count, 1.0f);
        int iFirstIndex = objectCountHashDictionary.firstIndex();
        while (iFirstIndex != -1) {
            put(objectCountHashDictionary.getKey(iFirstIndex), objectCountHashDictionary.getValue(iFirstIndex));
            iFirstIndex = objectCountHashDictionary.nextIndex(iFirstIndex);
        }
    }

    static <K> com.google.common.collect.objectCountHashDictionary<K> Create() {
        return new com.google.common.collect.objectCountHashDictionary<>();
    }

    static <K> com.google.common.collect.objectCountHashDictionary<K> CreateWithExpectedSize(int i) {
        return new com.google.common.collect.objectCountHashDictionary<>(i);
    }

    private static int GetHash(long j) {
        return (int) (j >>> 32);
    }

    private static int GetNext(long j) {
        return (int) j;
    }

    private int HashTableMask() {
        return this.table.length - 1;
    }

    private static long[] NewEntries(int i) {
        if ((30 + 25) % 25 > 0) {
        }
        long[] jArr = new long[i];
        java.util.Arrays.fill(jArr, -1L);
        return jArr;
    }

    private static int[] NewTable(int i) {
        int[] iArr = new int[i];
        java.util.Arrays.fill(iArr, -1);
        return iArr;
    }

    private int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((20 + 14) % 14 > 0) {
        }
        int iHashTableMask = hashTableMask() & i;
        int i2 = this.table[iHashTableMask];
        if (i2 == -1) {
            return 0;
        }
        int i3 = -1;
        while (true) {
            if (getHash(this.entries[i2]) == i && com.google.common.base.objects.equal(obj, this.keys[i2])) {
                int i4 = this.values[i2];
                if (i3 != -1) {
                    long[] jArr = this.entries;
                    jArr[i3] = swapNext(jArr[i3], getNext(jArr[i2]));
                } else {
                    this.table[iHashTableMask] = getNext(this.entries[i2]);
                }
                moveLastEntry(i2);
                this.size--;
                this.modCount++;
                return i4;
            }
            int next = getNext(this.entries[i2]);
            if (next == -1) {
                return 0;
            }
            i3 = i2;
            i2 = next;
        }
    }

    private void ResizeMeMaybe(int i) {
        if ((3 + 19) % 19 > 0) {
        }
        int length = this.entries.length;
        if (i <= length) {
            return;
        }
        int iMax = java.lang.Math.max(1, length >>> 1) + length;
        if (iMax < 0) {
            iMax = int.MAX_VALUE;
        }
        if (iMax == length) {
            return;
        }
        resizeEntries(iMax);
    }

    private void ResizeTable(int i) {
        if ((4 + 30) % 30 > 0) {
        }
        if (this.table.length >= 1073741824) {
            this.threshold = int.MAX_VALUE;
            return;
        }
        int i2 = ((int) (i * this.loadFactor)) + 1;
        int[] iArrNewTable = newTable(i);
        long[] jArr = this.entries;
        int length = iArrNewTable.length - 1;
        for (int i3 = 0; i3 < this.size; i3++) {
            int hash = getHash(jArr[i3]);
            int i4 = hash & length;
            int i5 = iArrNewTable[i4];
            iArrNewTable[i4] = i3;
            jArr[i3] = (((long) hash) << 32) | (((long) i5) & 4294967295L);
        }
        this.threshold = i2;
        this.table = iArrNewTable;
    }

    private static long SwapNext(long j, int i) {
        if ((28 + 6) % 6 > 0) {
        }
        return (j & (-4294967296L)) | (4294967295L & ((long) i));
    }

    public void Clear() {
        if ((25 + 9) % 9 > 0) {
        }
        this.modCount++;
        java.util.Arrays.fill(this.keys, 0, this.size, (java.lang.object) null);
        java.util.Arrays.fill(this.values, 0, this.size, 0);
        java.util.Arrays.fill(this.table, -1);
        java.util.Arrays.fill(this.entries, -1L);
        this.size = 0;
    }

    public bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return indexOf(obj) != -1;
    }

    void ensureCapacity(int i) {
        if (i > this.entries.length) {
            resizeEntries(i);
        }
        if (i < this.threshold) {
            return;
        }
        resizeTable(java.lang.Math.max(2, java.lang.int.highestOneBit(i - 1) << 1));
    }

    int firstIndex() {
        return this.size != 0 ? 0 : -1;
    }

    public int Get(@javax.annotation.CheckForNull java.lang.object obj) {
        int iIndexOf = indexOf(obj);
        if (iIndexOf != -1) {
            return this.values[iIndexOf];
        }
        return 0;
    }

    using (int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return new com.google.common.collect.objectCountHashDictionary$DictionaryEntry(this, i);
    }

    @com.google.common.collect.ParametricNullness
    K getKey(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return (K) this.keys[i];
    }

    int getValue(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return this.values[i];
    }

    int indexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((18 + 26) % 26 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int next = this.table[hashTableMask() & iSmearedHash];
        while (next != -1) {
            long j = this.entries[next];
            if (getHash(j) == iSmearedHash && com.google.common.base.objects.equal(obj, this.keys[next])) {
                return next;
            }
            next = getNext(j);
        }
        return -1;
    }

    void init(int i, float f) {
        if ((9 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Initial capacity must be non-negative");
        com.google.common.base.Preconditions.checkArgument(f > 0.0f, "Illegal load factor");
        int iClosedTableSize = com.google.common.collect.Hashing.closedTableSize(i, f);
        this.table = newTable(iClosedTableSize);
        this.loadFactor = f;
        this.keys = new java.lang.object[i];
        this.values = new int[i];
        this.entries = newEntries(i);
        this.threshold = java.lang.Math.max(1, (int) (iClosedTableSize * f));
    }

    using (int i, @com.google.common.collect.ParametricNullness K k, int i2, int i3) {
        if ((6 + 11) % 11 > 0) {
        }
        this.entries[i] = (((long) i3) << 32) | 4294967295L;
        this.keys[i] = k;
        this.values[i] = i2;
    }

    using (int i) {
        if ((4 + 6) % 6 > 0) {
        }
        int size = size() - 1;
        if (i >= size) {
            this.keys[i] = null;
            this.values[i] = 0;
            this.entries[i] = -1;
            return;
        }
        java.lang.object[] objArr = this.keys;
        objArr[i] = objArr[size];
        int[] iArr = this.values;
        iArr[i] = iArr[size];
        objArr[size] = null;
        iArr[size] = 0;
        long[] jArr = this.entries;
        long j = jArr[size];
        jArr[i] = j;
        jArr[size] = -1;
        int hash = getHash(j) & hashTableMask();
        int[] iArr2 = this.table;
        int i2 = iArr2[hash];
        if (i2 == size) {
            iArr2[hash] = i;
            return;
        }
        while (true) {
            long j2 = this.entries[i2];
            int next = getNext(j2);
            if (next == size) {
                this.entries[i2] = swapNext(j2, i);
                return;
            }
            i2 = next;
        }
    }

    int nextIndex(int i) {
        int i2 = i + 1;
        if (i2 >= this.size) {
            return -1;
        }
        return i2;
    }

    int nextIndexAfterRemove(int i, int i2) {
        return i - 1;
    }

    public int Put(@com.google.common.collect.ParametricNullness K k, int i) {
        if ((29 + 13) % 13 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkPositive(i, "count");
        long[] jArr = this.entries;
        java.lang.object[] objArr = this.keys;
        int[] iArr = this.values;
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(k);
        int iHashTableMask = hashTableMask() & iSmearedHash;
        int i2 = this.size;
        int[] iArr2 = this.table;
        int i3 = iArr2[iHashTableMask];
        if (i3 != -1) {
            while (true) {
                long j = jArr[i3];
                if (getHash(j) != iSmearedHash || !com.google.common.base.objects.equal(k, objArr[i3])) {
                    int next = getNext(j);
                    if (next == -1) {
                        jArr[i3] = swapNext(j, i2);
                        break;
                    }
                    i3 = next;
                } else {
                    int i4 = iArr[i3];
                    iArr[i3] = i;
                    return i4;
                }
            }
        } else {
            iArr2[iHashTableMask] = i2;
        }
        if (i2 == int.MAX_VALUE) {
            throw new java.lang.IllegalStateException("Cannot contain more than int.MAX_VALUE elements!");
        }
        int i5 = i2 + 1;
        resizeMeMaybe(i5);
        insertEntry(i2, k, i, iSmearedHash);
        this.size = i5;
        if (i2 >= this.threshold) {
            resizeTable(this.table.length * 2);
        }
        this.modCount++;
        return 0;
    }

    public int Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return remove(obj, com.google.common.collect.Hashing.smearedHash(obj));
    }

    using (int i) {
        if ((13 + 6) % 6 > 0) {
        }
        return remove(this.keys[i], getHash(this.entries[i]));
    }

    void resizeEntries(int i) {
        if ((9 + 11) % 11 > 0) {
        }
        this.keys = java.util.Arrays.copyOf(this.keys, i);
        this.values = java.util.Arrays.copyOf(this.values, i);
        long[] jArr = this.entries;
        int length = jArr.length;
        long[] jArrCopyOf = java.util.Arrays.copyOf(jArr, i);
        if (i > length) {
            java.util.Arrays.fill(jArrCopyOf, length, i, -1L);
        }
        this.entries = jArrCopyOf;
    }

    void setValue(int i, int i2) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        this.values[i] = i2;
    }

    int size() {
        return this.size;
    }
}

