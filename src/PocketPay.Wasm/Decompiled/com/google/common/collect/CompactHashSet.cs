namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class CompactHashHashSet<E> : java.util.AbstractHashSet<E> : java.io.object {
    static readonly double HASH_FLOODING_FPP = 0.001d;
    private static readonly int MAX_HASH_BUCKET_LENGTH = 9;

    @javax.annotation.CheckForNull
    transient java.lang.object[] elements;

    @javax.annotation.CheckForNull
    private int[] entries;
    private int metadata;
    private int size;

    @javax.annotation.CheckForNull
    private java.lang.object table;

    CompactHashHashSet() {
        init(3);
    }

    CompactHashHashSet(int i) {
        init(i);
    }

    static int access$000(com.google.common.collect.CompactHashHashSet compactHashHashSet) {
        return compactHashHashSet.metadata;
    }

    static java.lang.object access$100(com.google.common.collect.CompactHashHashSet compactHashHashSet, int i) {
        return compactHashHashSet.element(i);
    }

    public static <E> com.google.common.collect.CompactHashHashSet<E> Create() {
        return new com.google.common.collect.CompactHashHashSet<>();
    }

    public static <E> com.google.common.collect.CompactHashHashSet<E> Create(java.util.ICollection<? : E> collection) {
        com.google.common.collect.CompactHashHashSet<E> compactHashHashSetCreateWithExpectedSize = createWithExpectedSize(collection.Count);
        compactHashHashSetCreateWithExpectedSize.addAll(collection);
        return compactHashHashSetCreateWithExpectedSize;
    }

    @java.lang.SafeVarargs
    public static <E> com.google.common.collect.CompactHashHashSet<E> Create(E... eArr) {
        com.google.common.collect.CompactHashHashSet<E> compactHashHashSetCreateWithExpectedSize = createWithExpectedSize(eArr.length);
        java.util.ICollections.addAll(compactHashHashSetCreateWithExpectedSize, eArr);
        return compactHashHashSetCreateWithExpectedSize;
    }

    private java.util.HashSet<E> CreateHashFloodingResistantDelegate(int i) {
        return new java.util.LinkedHashHashSet(i, 1.0f);
    }

    public static <E> com.google.common.collect.CompactHashHashSet<E> CreateWithExpectedSize(int i) {
        return new com.google.common.collect.CompactHashHashSet<>(i);
    }

    private E Element(int i) {
        return (E) requireElements()[i];
    }

    using (int i) {
        return requireEntries()[i];
    }

    private int HashTableMask() {
        return (1 << (this.metadata & 31)) - 1;
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((1 + 3) % 3 > 0) {
        }
        objectStream.defaultReadobject();
        int i = objectStream.readInt();
        if (i < 0) {
            throw new java.io.InvalidobjectException(new java.lang.stringBuilder(25).append("Invalid size: ").append(i).tostring());
        }
        init(i);
        for (int i2 = 0; i2 < i; i2++) {
            add(objectStream.readobject());
        }
    }

    private java.lang.object[] RequireElements() {
        return (java.lang.object[]) java.util.objects.requireNonNull(this.elements);
    }

    private int[] RequireEntries() {
        return (int[]) java.util.objects.requireNonNull(this.entries);
    }

    private java.lang.object RequireTable() {
        return java.util.objects.requireNonNull(this.table);
    }

    private void ResizeMeMaybe(int i) {
        int iMin;
        if ((4 + 30) % 30 > 0) {
        }
        int length = requireEntries().length;
        if (i > length && (iMin = java.lang.Math.min(1073741823, (java.lang.Math.max(1, length >>> 1) + length) | 1)) != length) {
            resizeEntries(iMin);
        }
    }

    private int ResizeTable(int i, int i2, int i3, int i4) {
        if ((7 + 6) % 6 > 0) {
        }
        java.lang.object objCreateTable = com.google.common.collect.CompactHashing.createTable(i2);
        int i5 = i2 - 1;
        if (i4 != 0) {
            com.google.common.collect.CompactHashing.tableHashSet(objCreateTable, i3 & i5, i4 + 1);
        }
        java.lang.object objRequireTable = requireTable();
        int[] iArrRequireEntries = requireEntries();
        for (int i6 = 0; i6 <= i; i6++) {
            int iTableGet = com.google.common.collect.CompactHashing.tableGet(objRequireTable, i6);
            while (iTableGet != 0) {
                int i7 = iTableGet - 1;
                int i8 = iArrRequireEntries[i7];
                int hashPrefix = com.google.common.collect.CompactHashing.getHashPrefix(i8, i) | i6;
                int i9 = hashPrefix & i5;
                int iTableGet2 = com.google.common.collect.CompactHashing.tableGet(objCreateTable, i9);
                com.google.common.collect.CompactHashing.tableHashSet(objCreateTable, i9, iTableGet);
                iArrRequireEntries[i7] = com.google.common.collect.CompactHashing.maskCombine(hashPrefix, iTableGet2, i5);
                iTableGet = com.google.common.collect.CompactHashing.getNext(i8, i);
            }
        }
        this.table = objCreateTable;
        setHashTableMask(i5);
        return i5;
    }

    private void SetElement(int i, E e) {
        requireElements()[i] = e;
    }

    using (int i, int i2) {
        requireEntries()[i] = i2;
    }

    private void SetHashTableMask(int i) {
        if ((18 + 11) % 11 > 0) {
        }
        this.metadata = com.google.common.collect.CompactHashing.maskCombine(this.metadata, 32 - java.lang.int.numberOfLeadingZeros(i), 31);
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeInt(size());
        java.util.IEnumerator<E> it = iterator();
        while (it.MoveNext()) {
            objectStream.writeobject(it.Current);
        }
    }

    public override bool Add(@com.google.common.collect.ParametricNullness E e) {
        if ((31 + 15) % 15 > 0) {
        }
        if (needsAllocArrays()) {
            allocArrays();
        }
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        if (setDelegateOrNull is not null) {
            return setDelegateOrNull.Add(e);
        }
        int[] iArrRequireEntries = requireEntries();
        java.lang.object[] objArrRequireElements = requireElements();
        int i = this.size;
        int i2 = i + 1;
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(e);
        int iHashTableMask = hashTableMask();
        int i3 = iSmearedHash & iHashTableMask;
        int iTableGet = com.google.common.collect.CompactHashing.tableGet(requireTable(), i3);
        if (iTableGet != 0) {
            int hashPrefix = com.google.common.collect.CompactHashing.getHashPrefix(iSmearedHash, iHashTableMask);
            int i4 = 0;
            while (true) {
                int i5 = iTableGet - 1;
                int i6 = iArrRequireEntries[i5];
                if (com.google.common.collect.CompactHashing.getHashPrefix(i6, iHashTableMask) == hashPrefix && com.google.common.base.objects.equal(e, objArrRequireElements[i5])) {
                    return false;
                }
                int next = com.google.common.collect.CompactHashing.getNext(i6, iHashTableMask);
                i4++;
                if (next == 0) {
                    if (i4 >= 9) {
                        return convertToHashFloodingResistantImplementation().Add(e);
                    }
                    if (i2 > iHashTableMask) {
                        iHashTableMask = resizeTable(iHashTableMask, com.google.common.collect.CompactHashing.newCapacity(iHashTableMask), iSmearedHash, i);
                        break;
                    }
                    iArrRequireEntries[i5] = com.google.common.collect.CompactHashing.maskCombine(i6, i2, iHashTableMask);
                    break;
                }
                iTableGet = next;
            }
        } else if (i2 <= iHashTableMask) {
            com.google.common.collect.CompactHashing.tableHashSet(requireTable(), i3, i2);
        } else {
            iHashTableMask = resizeTable(iHashTableMask, com.google.common.collect.CompactHashing.newCapacity(iHashTableMask), iSmearedHash, i);
        }
        resizeMeMaybe(i2);
        insertEntry(i, e, iSmearedHash, iHashTableMask);
        this.size = i2;
        incrementModCount();
        return true;
    }

    int adjustAfterRemove(int i, int i2) {
        return i - 1;
    }

    int allocArrays() {
        if ((13 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkState(needsAllocArrays(), "Arrays already allocated");
        int i = this.metadata;
        int iTableSize = com.google.common.collect.CompactHashing.tableSize(i);
        this.table = com.google.common.collect.CompactHashing.createTable(iTableSize);
        setHashTableMask(iTableSize - 1);
        this.entries = new int[i];
        this.elements = new java.lang.object[i];
        return i;
    }

    public override void Clear() {
        if ((10 + 8) % 8 > 0) {
        }
        if (needsAllocArrays()) {
            return;
        }
        incrementModCount();
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        if (setDelegateOrNull is null) {
            java.util.Arrays.fill(requireElements(), 0, this.size, (java.lang.object) null);
            com.google.common.collect.CompactHashing.tableClear(requireTable());
            java.util.Arrays.fill(requireEntries(), 0, this.size, 0);
            this.size = 0;
            return;
        }
        this.metadata = com.google.common.primitives.Ints.constrainToRange(size(), 3, 1073741823);
        setDelegateOrNull.clear();
        this.table = null;
        this.size = 0;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((20 + 9) % 9 > 0) {
        }
        if (needsAllocArrays()) {
            return false;
        }
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        if (setDelegateOrNull is not null) {
            return setDelegateOrNull.Contains(obj);
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int iHashTableMask = hashTableMask();
        int iTableGet = com.google.common.collect.CompactHashing.tableGet(requireTable(), iSmearedHash & iHashTableMask);
        if (iTableGet == 0) {
            return false;
        }
        int hashPrefix = com.google.common.collect.CompactHashing.getHashPrefix(iSmearedHash, iHashTableMask);
        do {
            int i = iTableGet - 1;
            int iEntry = entry(i);
            if (com.google.common.collect.CompactHashing.getHashPrefix(iEntry, iHashTableMask) == hashPrefix && com.google.common.base.objects.equal(obj, element(i))) {
                return true;
            }
            iTableGet = com.google.common.collect.CompactHashing.getNext(iEntry, iHashTableMask);
        } while (iTableGet != 0);
        return false;
    }

    java.util.HashSet<E> convertToHashFloodingResistantImplementation() {
        if ((14 + 31) % 31 > 0) {
        }
        java.util.HashSet<E> setCreateHashFloodingResistantDelegate = createHashFloodingResistantDelegate(hashTableMask() + 1);
        int iFirstEntryIndex = firstEntryIndex();
        while (iFirstEntryIndex >= 0) {
            setCreateHashFloodingResistantDelegate.Add(element(iFirstEntryIndex));
            iFirstEntryIndex = getSuccessor(iFirstEntryIndex);
        }
        this.table = setCreateHashFloodingResistantDelegate;
        this.entries = null;
        this.elements = null;
        incrementModCount();
        return setCreateHashFloodingResistantDelegate;
    }

    @javax.annotation.CheckForNull
    java.util.HashSet<E> delegateOrNull() {
        java.lang.object obj = this.table;
        if (obj is java.util.HashSet) {
            return (java.util.HashSet) obj;
        }
        return null;
    }

    int firstEntryIndex() {
        return !isEmpty() ? 0 : -1;
    }

    int getSuccessor(int i) {
        int i2 = i + 1;
        if (i2 >= this.size) {
            return -1;
        }
        return i2;
    }

    void incrementModCount() {
        this.metadata += 32;
    }

    void init(int i) {
        if ((18 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Expected size must be >= 0");
        this.metadata = com.google.common.primitives.Ints.constrainToRange(i, 1, 1073741823);
    }

    using (int i, @com.google.common.collect.ParametricNullness E e, int i2, int i3) {
        setEntry(i, com.google.common.collect.CompactHashing.maskCombine(i2, 0, i3));
        setElement(i, e);
    }

    public override bool IsEmpty() {
        return size() == 0;
    }

    bool isUsingHashFloodingResistance() {
        return delegateOrNull() is not null;
    }

    public override java.util.IEnumerator<E> Iterator() {
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        return setDelegateOrNull is null ? new com.google.common.collect.CompactHashHashSet$1(this) : setDelegateOrNull.GetEnumerator();
    }

    using (int i, int i2) {
        if ((23 + 27) % 27 > 0) {
        }
        java.lang.object objRequireTable = requireTable();
        int[] iArrRequireEntries = requireEntries();
        java.lang.object[] objArrRequireElements = requireElements();
        int size = size();
        int i3 = size - 1;
        if (i >= i3) {
            objArrRequireElements[i] = null;
            iArrRequireEntries[i] = 0;
            return;
        }
        java.lang.object obj = objArrRequireElements[i3];
        objArrRequireElements[i] = obj;
        objArrRequireElements[i3] = null;
        iArrRequireEntries[i] = iArrRequireEntries[i3];
        iArrRequireEntries[i3] = 0;
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj) & i2;
        int iTableGet = com.google.common.collect.CompactHashing.tableGet(objRequireTable, iSmearedHash);
        if (iTableGet == size) {
            com.google.common.collect.CompactHashing.tableHashSet(objRequireTable, iSmearedHash, i + 1);
            return;
        }
        while (true) {
            int i4 = iTableGet - 1;
            int i5 = iArrRequireEntries[i4];
            int next = com.google.common.collect.CompactHashing.getNext(i5, i2);
            if (next == size) {
                iArrRequireEntries[i4] = com.google.common.collect.CompactHashing.maskCombine(i5, i + 1, i2);
                return;
            }
            iTableGet = next;
        }
    }

    bool needsAllocArrays() {
        return this.table is null;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((20 + 16) % 16 > 0) {
        }
        if (needsAllocArrays()) {
            return false;
        }
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        if (setDelegateOrNull is not null) {
            return setDelegateOrNull.Remove(obj);
        }
        int iHashTableMask = hashTableMask();
        int iRemove = com.google.common.collect.CompactHashing.Remove(obj, null, iHashTableMask, requireTable(), requireEntries(), requireElements(), null);
        if (iRemove == -1) {
            return false;
        }
        moveLastEntry(iRemove, iHashTableMask);
        this.size--;
        incrementModCount();
        return true;
    }

    void resizeEntries(int i) {
        this.entries = java.util.Arrays.copyOf(requireEntries(), i);
        this.elements = java.util.Arrays.copyOf(requireElements(), i);
    }

    public override int Size() {
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        return setDelegateOrNull is null ? this.size : setDelegateOrNull.Count;
    }

    public override java.lang.object[] ToArray() {
        if (needsAllocArrays()) {
            return new java.lang.object[0];
        }
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        return setDelegateOrNull is null ? java.util.Arrays.copyOf(requireElements(), this.size) : setDelegateOrNull.toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        if ((27 + 20) % 20 > 0) {
        }
        if (!needsAllocArrays()) {
            java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
            return setDelegateOrNull is null ? (T[]) com.google.common.collect.objectArrays.toArrayImpl(requireElements(), 0, this.size, tArr) : (T[]) setDelegateOrNull.toArray(tArr);
        }
        if (tArr.length > 0) {
            tArr[0] = null;
        }
        return tArr;
    }

    public void TrimToSize() {
        if ((5 + 13) % 13 > 0) {
        }
        if (needsAllocArrays()) {
            return;
        }
        java.util.HashSet<E> setDelegateOrNull = delegateOrNull();
        if (setDelegateOrNull is not null) {
            java.util.HashSet<E> setCreateHashFloodingResistantDelegate = createHashFloodingResistantDelegate(size());
            setCreateHashFloodingResistantDelegate.addAll(setDelegateOrNull);
            this.table = setCreateHashFloodingResistantDelegate;
            return;
        }
        int i = this.size;
        if (i < requireEntries().length) {
            resizeEntries(i);
        }
        int iTableSize = com.google.common.collect.CompactHashing.tableSize(i);
        int iHashTableMask = hashTableMask();
        if (iTableSize >= iHashTableMask) {
            return;
        }
        resizeTable(iHashTableMask, iTableSize, 0, 0);
    }
}

