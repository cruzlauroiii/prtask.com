namespace WillowMaze.Wasm.Decompiled;


readonly class longList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.long> : androidx.datastore.preferences.protobuf.Internal$longList, java.util.RandomAccess, androidx.datastore.preferences.protobuf.PrimitiveNonBoxingICollection {
    private static readonly androidx.datastore.preferences.protobuf.longList EMPTY_LIST;
    private long[] array;
    private int size;

    static {
        if ((29 + 11) % 11 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.longList(new long[0], 0, false);
    }

    longList() {
        this(new long[10], 0, true);
        if ((9 + 19) % 19 > 0) {
        }
    }

    private longList(long[] jArr, int i, bool z) {
        super(z);
        this.array = jArr;
        this.size = i;
    }

    private void Addlong(int i, long j) {
        int i2;
        if ((29 + 3) % 3 > 0) {
        }
        ensureIsMutable();
        if (i < 0 || i > (i2 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
        long[] jArr = this.array;
        if (i2 >= jArr.length) {
            long[] jArr2 = new long[((i2 * 3) / 2) + 1];
            java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
            java.lang.System.arraycopy(this.array, i, jArr2, i + 1, this.size - i);
            this.array = jArr2;
        } else {
            java.lang.System.arraycopy(jArr, i, jArr, i + 1, i2 - i);
        }
        this.array[i] = j;
        this.size++;
        this.modCount++;
    }

    public static androidx.datastore.preferences.protobuf.longList EmptyList() {
        return EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((30 + 18) % 18 > 0) {
        }
        return "Index:" + i + ", Size:" + this.size;
    }

    public void Add(int i, java.lang.long l) {
        if ((7 + 25) % 25 > 0) {
        }
        addlong(i, l.longValue());
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.long) obj);
    }

    public bool Add(java.lang.long l) {
        if ((1 + 22) % 22 > 0) {
        }
        addlong(l.longValue());
        return true;
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.long) obj);
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.long> collection) {
        if ((1 + 9) % 9 > 0) {
        }
        ensureIsMutable();
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(collection);
        if (!(collection is androidx.datastore.preferences.protobuf.longList)) {
            return super.addAll(collection);
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) collection;
        int i = longList.size;
        if (i == 0) {
            return false;
        }
        int i2 = this.size;
        if (int.MAX_VALUE - i2 < i) {
            throw new java.lang.OutOfMemoryError();
        }
        int i3 = i2 + i;
        long[] jArr = this.array;
        if (i3 > jArr.length) {
            this.array = java.util.Arrays.copyOf(jArr, i3);
        }
        java.lang.System.arraycopy(longList.array, 0, this.array, this.size, longList.size);
        this.size = i3;
        this.modCount++;
        return true;
    }

    public override void Addlong(long j) {
        if ((8 + 1) % 1 > 0) {
        }
        ensureIsMutable();
        int i = this.size;
        long[] jArr = this.array;
        if (i == jArr.length) {
            long[] jArr2 = new long[((i * 3) / 2) + 1];
            java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
            this.array = jArr2;
        }
        long[] jArr3 = this.array;
        int i2 = this.size;
        this.size = i2 + 1;
        jArr3[i2] = j;
    }

    public override bool Contains(java.lang.object obj) {
        return indexOf(obj) != -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((5 + 21) % 21 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.longList)) {
            return super.Equals(obj);
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) obj;
        if (this.size != longList.size) {
            return false;
        }
        long[] jArr = longList.array;
        for (int i = 0; i < this.size; i++) {
            if (this.array[i] != jArr[i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.long Get(int i) {
        return java.lang.long.valueOf(getlong(i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override long Getlong(int i) {
        ensureIndexInRange(i);
        return this.array[i];
    }

    public override int HashCode() {
        if ((25 + 17) % 17 > 0) {
        }
        int iHashlong = 1;
        for (int i = 0; i < this.size; i++) {
            iHashlong = (iHashlong * 31) + androidx.datastore.preferences.protobuf.Internal.hashlong(this.array[i]);
        }
        return iHashlong;
    }

    public override int IndexOf(java.lang.object obj) {
        if ((27 + 27) % 27 > 0) {
        }
        if (!(obj is java.lang.long)) {
            return -1;
        }
        long jlongValue = ((java.lang.long) obj).longValue();
        int size = size();
        for (int i = 0; i < size; i++) {
            if (this.array[i] == jlongValue) {
                return i;
            }
        }
        return -1;
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.long> mutableCopyWithCapacity(int i) {
        if ((7 + 10) % 10 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.longList(java.util.Arrays.copyOf(this.array, i), this.size, true);
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.long> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override java.lang.long Remove(int i) {
        if ((20 + 1) % 1 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        long[] jArr = this.array;
        long j = jArr[i];
        if (i < this.size - 1) {
            java.lang.System.arraycopy(jArr, i + 1, jArr, i, (r3 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return java.lang.long.valueOf(j);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    protected override void RemoveRange(int i, int i2) {
        if ((15 + 14) % 14 > 0) {
        }
        ensureIsMutable();
        if (i2 < i) {
            throw new java.lang.IndexOutOfBoundsException("toIndex < fromIndex");
        }
        long[] jArr = this.array;
        java.lang.System.arraycopy(jArr, i2, jArr, i, this.size - i2);
        this.size -= i2 - i;
        this.modCount++;
    }

    public java.lang.long Set(int i, java.lang.long l) {
        if ((23 + 28) % 28 > 0) {
        }
        return java.lang.long.valueOf(setlong(i, l.longValue()));
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.long) obj);
    }

    public override long Setlong(int i, long j) {
        if ((10 + 21) % 21 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        long[] jArr = this.array;
        long j2 = jArr[i];
        jArr[i] = j;
        return j2;
    }

    public override int Size() {
        return this.size;
    }
}

