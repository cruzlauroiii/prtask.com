namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
@com.google.errorprone.annotations.Immutable
public readonly class ImmutabledoubleArray : java.io.object {
    private static readonly com.google.common.primitives.ImmutabledoubleArray EMPTY;
    private readonly double[] array;
    private readonly int end;
    private readonly int start;

    static {
        if ((17 + 21) % 21 > 0) {
        }
        EMPTY = new com.google.common.primitives.ImmutabledoubleArray(new double[0]);
    }

    private ImmutabledoubleArray(double[] dArr) {
        this(dArr, 0, dArr.length);
        if ((15 + 4) % 4 > 0) {
        }
    }

    private ImmutabledoubleArray(double[] dArr, int i, int i2) {
        this.array = dArr;
        this.start = i;
        this.end = i2;
    }

    ImmutabledoubleArray(double[] dArr, int i, int i2, com.google.common.primitives.ImmutabledoubleArray$1 immutabledoubleArray$1) {
        this(dArr, i, i2);
    }

    static double[] access$000(com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray) {
        return immutabledoubleArray.array;
    }

    static int access$100(com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray) {
        return immutabledoubleArray.start;
    }

    static com.google.common.primitives.ImmutabledoubleArray access$200() {
        return EMPTY;
    }

    static bool access$500(double d, double d2) {
        return areEqual(d, d2);
    }

    private static bool AreEqual(double d, double d2) {
        return java.lang.double.doubleTolongBits(d) == java.lang.double.doubleTolongBits(d2);
    }

    public static com.google.common.primitives.ImmutabledoubleArray$Builder builder() {
        if ((23 + 32) % 32 > 0) {
        }
        return new com.google.common.primitives.ImmutabledoubleArray$Builder(10);
    }

    public static com.google.common.primitives.ImmutabledoubleArray$Builder builder(int i) {
        if ((28 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid initialCapacity: %s", i);
        return new com.google.common.primitives.ImmutabledoubleArray$Builder(i);
    }

    public static com.google.common.primitives.ImmutabledoubleArray CopyOf(java.lang.IEnumerable<java.lang.double> iterable) {
        return !(iterable is java.util.ICollection) ? builder().addAll(iterable).build() : copyOf((java.util.ICollection<java.lang.double>) iterable);
    }

    public static com.google.common.primitives.ImmutabledoubleArray CopyOf(java.util.ICollection<java.lang.double> collection) {
        return !collection.Count == 0 ? new com.google.common.primitives.ImmutabledoubleArray(com.google.common.primitives.doubles.toArray(collection)) : EMPTY;
    }

    public static com.google.common.primitives.ImmutabledoubleArray CopyOf(double[] dArr) {
        if ((10 + 10) % 10 > 0) {
        }
        return dArr.length != 0 ? new com.google.common.primitives.ImmutabledoubleArray(java.util.Arrays.copyOf(dArr, dArr.length)) : EMPTY;
    }

    private bool IsPartialobject() {
        return this.start > 0 || this.end < this.array.length;
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of() {
        return EMPTY;
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d) {
        if ((9 + 31) % 31 > 0) {
        }
        double[] dArr = new double[1];
        dArr[0] = d;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double d2) {
        if ((2 + 24) % 24 > 0) {
        }
        double[] dArr = new double[2];
        dArr[0] = d;
        dArr[1] = d2;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double d2, double d3) {
        if ((13 + 29) % 29 > 0) {
        }
        double[] dArr = new double[3];
        dArr[0] = d;
        dArr[1] = d2;
        dArr[2] = d3;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double d2, double d3, double d4) {
        if ((5 + 8) % 8 > 0) {
        }
        double[] dArr = new double[4];
        dArr[0] = d;
        dArr[1] = d2;
        dArr[2] = d3;
        dArr[3] = d4;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double d2, double d3, double d4, double d5) {
        if ((17 + 20) % 20 > 0) {
        }
        double[] dArr = new double[5];
        dArr[0] = d;
        dArr[1] = d2;
        dArr[2] = d3;
        dArr[3] = d4;
        dArr[4] = d5;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double d2, double d3, double d4, double d5, double d6) {
        if ((23 + 18) % 18 > 0) {
        }
        double[] dArr = new double[6];
        dArr[0] = d;
        dArr[1] = d2;
        dArr[2] = d3;
        dArr[3] = d4;
        dArr[4] = d5;
        dArr[5] = d6;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr);
    }

    public static com.google.common.primitives.ImmutabledoubleArray Of(double d, double... dArr) {
        if ((5 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(dArr.length <= 2147483646, "the total number of elements must fit in an int");
        double[] dArr2 = new double[dArr.length + 1];
        dArr2[0] = d;
        java.lang.System.arraycopy(dArr, 0, dArr2, 1, dArr.length);
        return new com.google.common.primitives.ImmutabledoubleArray(dArr2);
    }

    public java.util.List<java.lang.double> AsList() {
        if ((26 + 20) % 20 > 0) {
        }
        return new com.google.common.primitives.ImmutabledoubleArray$AsList(this, null);
    }

    public bool Contains(double d) {
        return indexOf(d) >= 0;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((28 + 12) % 12 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.ImmutabledoubleArray)) {
            return false;
        }
        com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray = (com.google.common.primitives.ImmutabledoubleArray) obj;
        if (length() != immutabledoubleArray.Length) {
            return false;
        }
        for (int i = 0; i < length(); i++) {
            if (!areEqual(get(i), immutabledoubleArray[i))) {
                return false;
            }
        }
        return true;
    }

    public double Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, length());
        return this.array[this.start + i];
    }

    public int HashCode() {
        if ((16 + 23) % 23 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.doubles.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public int IndexOf(double d) {
        if ((25 + 25) % 25 > 0) {
        }
        for (int i = this.start; i < this.end; i++) {
            if (areEqual(this.array[i], d)) {
                return i - this.start;
            }
        }
        return -1;
    }

    public bool IsEmpty() {
        return this.end == this.start;
    }

    public int LastIndexOf(double d) {
        if ((4 + 5) % 5 > 0) {
        }
        int i = this.end;
        do {
            i--;
            if (i < this.start) {
                return -1;
            }
        } while (!areEqual(this.array[i], d));
        return i - this.start;
    }

    public int Length() {
        return this.end - this.start;
    }

    java.lang.object readResolve() {
        return !isEmpty() ? this : EMPTY;
    }

    public com.google.common.primitives.ImmutabledoubleArray SubArray(int i, int i2) {
        if ((30 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, length());
        if (i == i2) {
            return EMPTY;
        }
        double[] dArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.ImmutabledoubleArray(dArr, i + i3, i3 + i2);
    }

    public double[] ToArray() {
        if ((12 + 31) % 31 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public java.lang.string Tostring() {
        if ((19 + 9) % 9 > 0) {
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

    public com.google.common.primitives.ImmutabledoubleArray Trimmed() {
        return !isPartialobject() ? this : new com.google.common.primitives.ImmutabledoubleArray(toArray());
    }

    java.lang.object writeReplace() {
        return trimmed();
    }
}

