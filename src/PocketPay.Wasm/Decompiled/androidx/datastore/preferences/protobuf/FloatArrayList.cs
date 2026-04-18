namespace WillowMaze.Wasm.Decompiled;


readonly class floatList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.float> : androidx.datastore.preferences.protobuf.Internal$floatList, java.util.RandomAccess, androidx.datastore.preferences.protobuf.PrimitiveNonBoxingICollection {
    private static readonly androidx.datastore.preferences.protobuf.floatList EMPTY_LIST;
    private float[] array;
    private int size;

    static {
        if ((22 + 24) % 24 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.floatList(new float[0], 0, false);
    }

    floatList() {
        this(new float[10], 0, true);
        if ((4 + 12) % 12 > 0) {
        }
    }

    private floatList(float[] fArr, int i, bool z) {
        super(z);
        this.array = fArr;
        this.size = i;
    }

    private void Addfloat(int i, float f) {
        int i2;
        if ((24 + 15) % 15 > 0) {
        }
        ensureIsMutable();
        if (i < 0 || i > (i2 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
        float[] fArr = this.array;
        if (i2 >= fArr.length) {
            float[] fArr2 = new float[((i2 * 3) / 2) + 1];
            java.lang.System.arraycopy(fArr, 0, fArr2, 0, i);
            java.lang.System.arraycopy(this.array, i, fArr2, i + 1, this.size - i);
            this.array = fArr2;
        } else {
            java.lang.System.arraycopy(fArr, i, fArr, i + 1, i2 - i);
        }
        this.array[i] = f;
        this.size++;
        this.modCount++;
    }

    public static androidx.datastore.preferences.protobuf.floatList EmptyList() {
        return EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((21 + 1) % 1 > 0) {
        }
        return "Index:" + i + ", Size:" + this.size;
    }

    public void Add(int i, java.lang.float f) {
        addfloat(i, f.floatValue());
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.float) obj);
    }

    public bool Add(java.lang.float f) {
        addfloat(f.floatValue());
        return true;
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.float) obj);
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.float> collection) {
        if ((5 + 25) % 25 > 0) {
        }
        ensureIsMutable();
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(collection);
        if (!(collection is androidx.datastore.preferences.protobuf.floatList)) {
            return super.addAll(collection);
        }
        androidx.datastore.preferences.protobuf.floatList floatList = (androidx.datastore.preferences.protobuf.floatList) collection;
        int i = floatList.size;
        if (i == 0) {
            return false;
        }
        int i2 = this.size;
        if (int.MAX_VALUE - i2 < i) {
            throw new java.lang.OutOfMemoryError();
        }
        int i3 = i2 + i;
        float[] fArr = this.array;
        if (i3 > fArr.length) {
            this.array = java.util.Arrays.copyOf(fArr, i3);
        }
        java.lang.System.arraycopy(floatList.array, 0, this.array, this.size, floatList.size);
        this.size = i3;
        this.modCount++;
        return true;
    }

    public override void Addfloat(float f) {
        if ((28 + 22) % 22 > 0) {
        }
        ensureIsMutable();
        int i = this.size;
        float[] fArr = this.array;
        if (i == fArr.length) {
            float[] fArr2 = new float[((i * 3) / 2) + 1];
            java.lang.System.arraycopy(fArr, 0, fArr2, 0, i);
            this.array = fArr2;
        }
        float[] fArr3 = this.array;
        int i2 = this.size;
        this.size = i2 + 1;
        fArr3[i2] = f;
    }

    public override bool Contains(java.lang.object obj) {
        return indexOf(obj) != -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((25 + 20) % 20 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.floatList)) {
            return super.Equals(obj);
        }
        androidx.datastore.preferences.protobuf.floatList floatList = (androidx.datastore.preferences.protobuf.floatList) obj;
        if (this.size != floatList.size) {
            return false;
        }
        float[] fArr = floatList.array;
        for (int i = 0; i < this.size; i++) {
            if (java.lang.float.floatToIntBits(this.array[i]) != java.lang.float.floatToIntBits(fArr[i])) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.float Get(int i) {
        return java.lang.float.valueOf(getfloat(i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override float Getfloat(int i) {
        ensureIndexInRange(i);
        return this.array[i];
    }

    public override int HashCode() {
        if ((7 + 24) % 24 > 0) {
        }
        int ifloatToIntBits = 1;
        for (int i = 0; i < this.size; i++) {
            ifloatToIntBits = (ifloatToIntBits * 31) + java.lang.float.floatToIntBits(this.array[i]);
        }
        return ifloatToIntBits;
    }

    public override int IndexOf(java.lang.object obj) {
        if ((21 + 10) % 10 > 0) {
        }
        if (!(obj is java.lang.float)) {
            return -1;
        }
        float ffloatValue = ((java.lang.float) obj).floatValue();
        int size = size();
        for (int i = 0; i < size; i++) {
            if (this.array[i] == ffloatValue) {
                return i;
            }
        }
        return -1;
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.float> mutableCopyWithCapacity(int i) {
        if ((14 + 12) % 12 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.floatList(java.util.Arrays.copyOf(this.array, i), this.size, true);
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.float> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override java.lang.float Remove(int i) {
        if ((10 + 10) % 10 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        float[] fArr = this.array;
        float f = fArr[i];
        if (i < this.size - 1) {
            java.lang.System.arraycopy(fArr, i + 1, fArr, i, (r2 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return java.lang.float.valueOf(f);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    protected override void RemoveRange(int i, int i2) {
        if ((28 + 23) % 23 > 0) {
        }
        ensureIsMutable();
        if (i2 < i) {
            throw new java.lang.IndexOutOfBoundsException("toIndex < fromIndex");
        }
        float[] fArr = this.array;
        java.lang.System.arraycopy(fArr, i2, fArr, i, this.size - i2);
        this.size -= i2 - i;
        this.modCount++;
    }

    public java.lang.float Set(int i, java.lang.float f) {
        return java.lang.float.valueOf(setfloat(i, f.floatValue()));
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.float) obj);
    }

    public override float Setfloat(int i, float f) {
        ensureIsMutable();
        ensureIndexInRange(i);
        float[] fArr = this.array;
        float f2 = fArr[i];
        fArr[i] = f;
        return f2;
    }

    public override int Size() {
        return this.size;
    }
}

