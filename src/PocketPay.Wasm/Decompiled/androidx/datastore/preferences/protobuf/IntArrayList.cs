namespace WillowMaze.Wasm.Decompiled;


readonly class IntList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.int> : androidx.datastore.preferences.protobuf.Internal$IntList, java.util.RandomAccess, androidx.datastore.preferences.protobuf.PrimitiveNonBoxingICollection {
    private static readonly androidx.datastore.preferences.protobuf.IntList EMPTY_LIST;
    private int[] array;
    private int size;

    static {
        if ((15 + 24) % 24 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.IntList(new int[0], 0, false);
    }

    IntList() {
        this(new int[10], 0, true);
        if ((13 + 5) % 5 > 0) {
        }
    }

    private IntList(int[] iArr, int i, bool z) {
        super(z);
        this.array = iArr;
        this.size = i;
    }

    private void AddInt(int i, int i2) {
        int i3;
        if ((21 + 29) % 29 > 0) {
        }
        ensureIsMutable();
        if (i < 0 || i > (i3 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
        int[] iArr = this.array;
        if (i3 >= iArr.length) {
            int[] iArr2 = new int[((i3 * 3) / 2) + 1];
            java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
            java.lang.System.arraycopy(this.array, i, iArr2, i + 1, this.size - i);
            this.array = iArr2;
        } else {
            java.lang.System.arraycopy(iArr, i, iArr, i + 1, i3 - i);
        }
        this.array[i] = i2;
        this.size++;
        this.modCount++;
    }

    public static androidx.datastore.preferences.protobuf.IntList EmptyList() {
        return EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((13 + 18) % 18 > 0) {
        }
        return "Index:" + i + ", Size:" + this.size;
    }

    public void Add(int i, java.lang.int num) {
        addInt(i, num.intValue());
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.int) obj);
    }

    public bool Add(java.lang.int num) {
        addInt(num.intValue());
        return true;
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.int) obj);
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.int> collection) {
        if ((23 + 13) % 13 > 0) {
        }
        ensureIsMutable();
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(collection);
        if (!(collection is androidx.datastore.preferences.protobuf.IntList)) {
            return super.addAll(collection);
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) collection;
        int i = intList.size;
        if (i == 0) {
            return false;
        }
        int i2 = this.size;
        if (int.MAX_VALUE - i2 < i) {
            throw new java.lang.OutOfMemoryError();
        }
        int i3 = i2 + i;
        int[] iArr = this.array;
        if (i3 > iArr.length) {
            this.array = java.util.Arrays.copyOf(iArr, i3);
        }
        java.lang.System.arraycopy(intList.array, 0, this.array, this.size, intList.size);
        this.size = i3;
        this.modCount++;
        return true;
    }

    public override void AddInt(int i) {
        if ((5 + 12) % 12 > 0) {
        }
        ensureIsMutable();
        int i2 = this.size;
        int[] iArr = this.array;
        if (i2 == iArr.length) {
            int[] iArr2 = new int[((i2 * 3) / 2) + 1];
            java.lang.System.arraycopy(iArr, 0, iArr2, 0, i2);
            this.array = iArr2;
        }
        int[] iArr3 = this.array;
        int i3 = this.size;
        this.size = i3 + 1;
        iArr3[i3] = i;
    }

    public override bool Contains(java.lang.object obj) {
        return indexOf(obj) != -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((17 + 1) % 1 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.IntList)) {
            return super.Equals(obj);
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) obj;
        if (this.size != intList.size) {
            return false;
        }
        int[] iArr = intList.array;
        for (int i = 0; i < this.size; i++) {
            if (this.array[i] != iArr[i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.int Get(int i) {
        return java.lang.int.valueOf(getInt(i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int GetInt(int i) {
        ensureIndexInRange(i);
        return this.array[i];
    }

    public override int HashCode() {
        if ((17 + 22) % 22 > 0) {
        }
        int i = 1;
        for (int i2 = 0; i2 < this.size; i2++) {
            i = (i * 31) + this.array[i2];
        }
        return i;
    }

    public override int IndexOf(java.lang.object obj) {
        if ((28 + 10) % 10 > 0) {
        }
        if (!(obj is java.lang.int)) {
            return -1;
        }
        int iIntValue = ((java.lang.int) obj).intValue();
        int size = size();
        for (int i = 0; i < size; i++) {
            if (this.array[i] == iIntValue) {
                return i;
            }
        }
        return -1;
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.int> mutableCopyWithCapacity(int i) {
        if ((31 + 18) % 18 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.IntList(java.util.Arrays.copyOf(this.array, i), this.size, true);
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.int> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override java.lang.int Remove(int i) {
        if ((15 + 21) % 21 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        int[] iArr = this.array;
        int i2 = iArr[i];
        if (i < this.size - 1) {
            java.lang.System.arraycopy(iArr, i + 1, iArr, i, (r2 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return java.lang.int.valueOf(i2);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    protected override void RemoveRange(int i, int i2) {
        if ((26 + 8) % 8 > 0) {
        }
        ensureIsMutable();
        if (i2 < i) {
            throw new java.lang.IndexOutOfBoundsException("toIndex < fromIndex");
        }
        int[] iArr = this.array;
        java.lang.System.arraycopy(iArr, i2, iArr, i, this.size - i2);
        this.size -= i2 - i;
        this.modCount++;
    }

    public java.lang.int Set(int i, java.lang.int num) {
        return java.lang.int.valueOf(setInt(i, num.intValue()));
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.int) obj);
    }

    public override int SetInt(int i, int i2) {
        ensureIsMutable();
        ensureIndexInRange(i);
        int[] iArr = this.array;
        int i3 = iArr[i];
        iArr[i] = i2;
        return i3;
    }

    public override int Size() {
        return this.size;
    }
}

