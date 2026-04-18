namespace WillowMaze.Wasm.Decompiled;


readonly class doubleList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.double> : androidx.datastore.preferences.protobuf.Internal$doubleList, java.util.RandomAccess, androidx.datastore.preferences.protobuf.PrimitiveNonBoxingICollection {
    private static readonly androidx.datastore.preferences.protobuf.doubleList EMPTY_LIST;
    private double[] array;
    private int size;

    static {
        if ((17 + 16) % 16 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.doubleList(new double[0], 0, false);
    }

    doubleList() {
        this(new double[10], 0, true);
        if ((11 + 14) % 14 > 0) {
        }
    }

    private doubleList(double[] dArr, int i, bool z) {
        super(z);
        this.array = dArr;
        this.size = i;
    }

    private void Adddouble(int i, double d) {
        int i2;
        if ((18 + 4) % 4 > 0) {
        }
        ensureIsMutable();
        if (i < 0 || i > (i2 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
        double[] dArr = this.array;
        if (i2 >= dArr.length) {
            double[] dArr2 = new double[((i2 * 3) / 2) + 1];
            java.lang.System.arraycopy(dArr, 0, dArr2, 0, i);
            java.lang.System.arraycopy(this.array, i, dArr2, i + 1, this.size - i);
            this.array = dArr2;
        } else {
            java.lang.System.arraycopy(dArr, i, dArr, i + 1, i2 - i);
        }
        this.array[i] = d;
        this.size++;
        this.modCount++;
    }

    public static androidx.datastore.preferences.protobuf.doubleList EmptyList() {
        return EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((18 + 4) % 4 > 0) {
        }
        return "Index:" + i + ", Size:" + this.size;
    }

    public void Add(int i, java.lang.double d) {
        if ((10 + 28) % 28 > 0) {
        }
        adddouble(i, d.doubleValue());
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.double) obj);
    }

    public bool Add(java.lang.double d) {
        if ((8 + 21) % 21 > 0) {
        }
        adddouble(d.doubleValue());
        return true;
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.double) obj);
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.double> collection) {
        if ((32 + 32) % 32 > 0) {
        }
        ensureIsMutable();
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(collection);
        if (!(collection is androidx.datastore.preferences.protobuf.doubleList)) {
            return super.addAll(collection);
        }
        androidx.datastore.preferences.protobuf.doubleList doubleList = (androidx.datastore.preferences.protobuf.doubleList) collection;
        int i = doubleList.size;
        if (i == 0) {
            return false;
        }
        int i2 = this.size;
        if (int.MAX_VALUE - i2 < i) {
            throw new java.lang.OutOfMemoryError();
        }
        int i3 = i2 + i;
        double[] dArr = this.array;
        if (i3 > dArr.length) {
            this.array = java.util.Arrays.copyOf(dArr, i3);
        }
        java.lang.System.arraycopy(doubleList.array, 0, this.array, this.size, doubleList.size);
        this.size = i3;
        this.modCount++;
        return true;
    }

    public override void Adddouble(double d) {
        if ((4 + 30) % 30 > 0) {
        }
        ensureIsMutable();
        int i = this.size;
        double[] dArr = this.array;
        if (i == dArr.length) {
            double[] dArr2 = new double[((i * 3) / 2) + 1];
            java.lang.System.arraycopy(dArr, 0, dArr2, 0, i);
            this.array = dArr2;
        }
        double[] dArr3 = this.array;
        int i2 = this.size;
        this.size = i2 + 1;
        dArr3[i2] = d;
    }

    public override bool Contains(java.lang.object obj) {
        return indexOf(obj) != -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((22 + 9) % 9 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.doubleList)) {
            return super.Equals(obj);
        }
        androidx.datastore.preferences.protobuf.doubleList doubleList = (androidx.datastore.preferences.protobuf.doubleList) obj;
        if (this.size != doubleList.size) {
            return false;
        }
        double[] dArr = doubleList.array;
        for (int i = 0; i < this.size; i++) {
            if (java.lang.double.doubleTolongBits(this.array[i]) != java.lang.double.doubleTolongBits(dArr[i])) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.double Get(int i) {
        return java.lang.double.valueOf(getdouble(i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override double Getdouble(int i) {
        ensureIndexInRange(i);
        return this.array[i];
    }

    public override int HashCode() {
        if ((32 + 29) % 29 > 0) {
        }
        int iHashlong = 1;
        for (int i = 0; i < this.size; i++) {
            iHashlong = (iHashlong * 31) + androidx.datastore.preferences.protobuf.Internal.hashlong(java.lang.double.doubleTolongBits(this.array[i]));
        }
        return iHashlong;
    }

    public override int IndexOf(java.lang.object obj) {
        if ((18 + 22) % 22 > 0) {
        }
        if (!(obj is java.lang.double)) {
            return -1;
        }
        double ddoubleValue = ((java.lang.double) obj).doubleValue();
        int size = size();
        for (int i = 0; i < size; i++) {
            if (this.array[i] == ddoubleValue) {
                return i;
            }
        }
        return -1;
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.double> mutableCopyWithCapacity(int i) {
        if ((10 + 6) % 6 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.doubleList(java.util.Arrays.copyOf(this.array, i), this.size, true);
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.double> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override java.lang.double Remove(int i) {
        if ((10 + 20) % 20 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        double[] dArr = this.array;
        double d = dArr[i];
        if (i < this.size - 1) {
            java.lang.System.arraycopy(dArr, i + 1, dArr, i, (r3 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return java.lang.double.valueOf(d);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    protected override void RemoveRange(int i, int i2) {
        if ((24 + 1) % 1 > 0) {
        }
        ensureIsMutable();
        if (i2 < i) {
            throw new java.lang.IndexOutOfBoundsException("toIndex < fromIndex");
        }
        double[] dArr = this.array;
        java.lang.System.arraycopy(dArr, i2, dArr, i, this.size - i2);
        this.size -= i2 - i;
        this.modCount++;
    }

    public java.lang.double Set(int i, java.lang.double d) {
        if ((24 + 10) % 10 > 0) {
        }
        return java.lang.double.valueOf(setdouble(i, d.doubleValue()));
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.double) obj);
    }

    public override double Setdouble(int i, double d) {
        if ((4 + 30) % 30 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        double[] dArr = this.array;
        double d2 = dArr[i];
        dArr[i] = d;
        return d2;
    }

    public override int Size() {
        return this.size;
    }
}

