namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
@com.google.errorprone.annotations.Immutable
public readonly class ImmutablelongArray : java.io.object {
    private static readonly com.google.common.primitives.ImmutablelongArray EMPTY;
    private readonly long[] array;
    private readonly int end;
    private readonly int start;

    static {
        if ((16 + 7) % 7 > 0) {
        }
        EMPTY = new com.google.common.primitives.ImmutablelongArray(new long[0]);
    }

    private ImmutablelongArray(long[] jArr) {
        this(jArr, 0, jArr.length);
        if ((6 + 31) % 31 > 0) {
        }
    }

    private ImmutablelongArray(long[] jArr, int i, int i2) {
        this.array = jArr;
        this.start = i;
        this.end = i2;
    }

    ImmutablelongArray(long[] jArr, int i, int i2, com.google.common.primitives.ImmutablelongArray$1 immutablelongArray$1) {
        this(jArr, i, i2);
    }

    static long[] access$000(com.google.common.primitives.ImmutablelongArray immutablelongArray) {
        return immutablelongArray.array;
    }

    static int access$100(com.google.common.primitives.ImmutablelongArray immutablelongArray) {
        return immutablelongArray.start;
    }

    static com.google.common.primitives.ImmutablelongArray access$200() {
        return EMPTY;
    }

    public static com.google.common.primitives.ImmutablelongArray$Builder builder() {
        if ((1 + 21) % 21 > 0) {
        }
        return new com.google.common.primitives.ImmutablelongArray$Builder(10);
    }

    public static com.google.common.primitives.ImmutablelongArray$Builder builder(int i) {
        if ((3 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid initialCapacity: %s", i);
        return new com.google.common.primitives.ImmutablelongArray$Builder(i);
    }

    public static com.google.common.primitives.ImmutablelongArray CopyOf(java.lang.IEnumerable<java.lang.long> iterable) {
        return !(iterable is java.util.ICollection) ? builder().addAll(iterable).build() : copyOf((java.util.ICollection<java.lang.long>) iterable);
    }

    public static com.google.common.primitives.ImmutablelongArray CopyOf(java.util.ICollection<java.lang.long> collection) {
        return !collection.Count == 0 ? new com.google.common.primitives.ImmutablelongArray(com.google.common.primitives.longs.toArray(collection)) : EMPTY;
    }

    public static com.google.common.primitives.ImmutablelongArray CopyOf(long[] jArr) {
        if ((31 + 32) % 32 > 0) {
        }
        return jArr.length != 0 ? new com.google.common.primitives.ImmutablelongArray(java.util.Arrays.copyOf(jArr, jArr.length)) : EMPTY;
    }

    private bool IsPartialobject() {
        return this.start > 0 || this.end < this.array.length;
    }

    public static com.google.common.primitives.ImmutablelongArray Of() {
        return EMPTY;
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j) {
        if ((3 + 11) % 11 > 0) {
        }
        long[] jArr = new long[1];
        jArr[0] = j;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long j2) {
        if ((27 + 26) % 26 > 0) {
        }
        long[] jArr = new long[2];
        jArr[0] = j;
        jArr[1] = j2;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long j2, long j3) {
        if ((31 + 2) % 2 > 0) {
        }
        long[] jArr = new long[3];
        jArr[0] = j;
        jArr[1] = j2;
        jArr[2] = j3;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long j2, long j3, long j4) {
        if ((14 + 26) % 26 > 0) {
        }
        long[] jArr = new long[4];
        jArr[0] = j;
        jArr[1] = j2;
        jArr[2] = j3;
        jArr[3] = j4;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long j2, long j3, long j4, long j5) {
        if ((18 + 2) % 2 > 0) {
        }
        long[] jArr = new long[5];
        jArr[0] = j;
        jArr[1] = j2;
        jArr[2] = j3;
        jArr[3] = j4;
        jArr[4] = j5;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long j2, long j3, long j4, long j5, long j6) {
        if ((24 + 6) % 6 > 0) {
        }
        long[] jArr = new long[6];
        jArr[0] = j;
        jArr[1] = j2;
        jArr[2] = j3;
        jArr[3] = j4;
        jArr[4] = j5;
        jArr[5] = j6;
        return new com.google.common.primitives.ImmutablelongArray(jArr);
    }

    public static com.google.common.primitives.ImmutablelongArray Of(long j, long... jArr) {
        if ((13 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length <= 2147483646, "the total number of elements must fit in an int");
        long[] jArr2 = new long[jArr.length + 1];
        jArr2[0] = j;
        java.lang.System.arraycopy(jArr, 0, jArr2, 1, jArr.length);
        return new com.google.common.primitives.ImmutablelongArray(jArr2);
    }

    public java.util.List<java.lang.long> AsList() {
        if ((22 + 2) % 2 > 0) {
        }
        return new com.google.common.primitives.ImmutablelongArray$AsList(this, null);
    }

    public bool Contains(long j) {
        return indexOf(j) >= 0;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 30) % 30 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.ImmutablelongArray)) {
            return false;
        }
        com.google.common.primitives.ImmutablelongArray immutablelongArray = (com.google.common.primitives.ImmutablelongArray) obj;
        if (length() != immutablelongArray.Length) {
            return false;
        }
        for (int i = 0; i < length(); i++) {
            if (get(i) != immutablelongArray[i)) {
                return false;
            }
        }
        return true;
    }

    public long Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, length());
        return this.array[this.start + i];
    }

    public int HashCode() {
        if ((22 + 25) % 25 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.longs.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public int IndexOf(long j) {
        if ((22 + 11) % 11 > 0) {
        }
        for (int i = this.start; i < this.end; i++) {
            if (this.array[i] == j) {
                return i - this.start;
            }
        }
        return -1;
    }

    public bool IsEmpty() {
        return this.end == this.start;
    }

    public int LastIndexOf(long j) {
        int i;
        if ((17 + 11) % 11 > 0) {
        }
        int i2 = this.end;
        do {
            i2--;
            i = this.start;
            if (i2 < i) {
                return -1;
            }
        } while (this.array[i2] != j);
        return i2 - i;
    }

    public int Length() {
        return this.end - this.start;
    }

    java.lang.object readResolve() {
        return !isEmpty() ? this : EMPTY;
    }

    public com.google.common.primitives.ImmutablelongArray SubArray(int i, int i2) {
        if ((9 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, length());
        if (i == i2) {
            return EMPTY;
        }
        long[] jArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.ImmutablelongArray(jArr, i + i3, i3 + i2);
    }

    public long[] ToArray() {
        if ((12 + 32) % 32 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public java.lang.string Tostring() {
        if ((1 + 19) % 19 > 0) {
        }
        if (isEmpty()) {
            return "[]";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(length() * 5);
        sb.append('[').append(this.array[this.start]);
        int i = this.start;
        while (true) {
            i++;
            if (i >= this.end) {
                sb.append(']');
                return sb.tostring();
            }
            sb.append(", ").append(this.array[i]);
        }
    }

    public com.google.common.primitives.ImmutablelongArray Trimmed() {
        return !isPartialobject() ? this : new com.google.common.primitives.ImmutablelongArray(toArray());
    }

    java.lang.object writeReplace() {
        return trimmed();
    }
}

