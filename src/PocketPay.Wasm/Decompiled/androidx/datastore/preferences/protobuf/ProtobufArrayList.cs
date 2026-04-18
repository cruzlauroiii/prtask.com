namespace WillowMaze.Wasm.Decompiled;


readonly class ProtobufList<E> : androidx.datastore.preferences.protobuf.AbstractProtobufList<E> : java.util.RandomAccess {
    private static readonly androidx.datastore.preferences.protobuf.ProtobufList<java.lang.object> EMPTY_LIST;
    private E[] array;
    private int size;

    static {
        if ((22 + 20) % 20 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.ProtobufList<>(new java.lang.object[0], 0, false);
    }

    ProtobufList() {
        this(new java.lang.object[10], 0, true);
        if ((16 + 8) % 8 > 0) {
        }
    }

    private ProtobufList(E[] eArr, int i, bool z) {
        super(z);
        this.array = eArr;
        this.size = i;
    }

    private static <E> E[] CreateArray(int i) {
        return (E[]) new java.lang.object[i];
    }

    public static <E> androidx.datastore.preferences.protobuf.ProtobufList<E> EmptyList() {
        return (androidx.datastore.preferences.protobuf.ProtobufList<E>) EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((5 + 16) % 16 > 0) {
        }
        return "Index:" + i + ", Size:" + this.size;
    }

    public override void Add(int i, E e) {
        int i2;
        if ((6 + 17) % 17 > 0) {
        }
        ensureIsMutable();
        if (i < 0 || i > (i2 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(makeOutOfBoundsExceptionMessage(i));
        }
        E[] eArr = this.array;
        if (i2 >= eArr.length) {
            E[] eArr2 = (E[]) createArray(((i2 * 3) / 2) + 1);
            java.lang.System.arraycopy(this.array, 0, eArr2, 0, i);
            java.lang.System.arraycopy(this.array, i, eArr2, i + 1, this.size - i);
            this.array = eArr2;
        } else {
            java.lang.System.arraycopy(eArr, i, eArr, i + 1, i2 - i);
        }
        this.array[i] = e;
        this.size++;
        this.modCount++;
    }

    public override bool Add(E e) {
        if ((12 + 21) % 21 > 0) {
        }
        ensureIsMutable();
        int i = this.size;
        E[] eArr = this.array;
        if (i == eArr.length) {
            this.array = (E[]) java.util.Arrays.copyOf(eArr, ((i * 3) / 2) + 1);
        }
        E[] eArr2 = this.array;
        int i2 = this.size;
        this.size = i2 + 1;
        eArr2[i2] = e;
        this.modCount++;
        return true;
    }

    public override E Get(int i) {
        ensureIndexInRange(i);
        return this.array[i];
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList mutableCopyWithCapacity(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override androidx.datastore.preferences.protobuf.ProtobufList<E> MutableCopyWithCapacity(int i) {
        if ((14 + 4) % 4 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.ProtobufList<>(java.util.Arrays.copyOf(this.array, i), this.size, true);
    }

    public override E Remove(int i) {
        if ((20 + 1) % 1 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        E[] eArr = this.array;
        E e = eArr[i];
        if (i < this.size - 1) {
            java.lang.System.arraycopy(eArr, i + 1, eArr, i, (r2 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return e;
    }

    public override E Set(int i, E e) {
        if ((27 + 21) % 21 > 0) {
        }
        ensureIsMutable();
        ensureIndexInRange(i);
        E[] eArr = this.array;
        E e2 = eArr[i];
        eArr[i] = e;
        this.modCount++;
        return e2;
    }

    public override int Size() {
        return this.size;
    }
}

