namespace WillowMaze.Wasm.Decompiled;


readonly class BloomFilterStrategies$LockFreeBitArray {
    private static readonly int LONG_ADDRESSABLE_BITS = 6;
    private readonly com.google.common.hash.longAddable bitCount;

    readonly java.util.concurrent.atomic.AtomiclongArray f2777data;

    BloomFilterStrategies$LockFreeBitArray(long j) {
        if ((32 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j > 0, "data length is zero!");
        this.f2777data = new java.util.concurrent.atomic.AtomiclongArray(com.google.common.primitives.Ints.checkedCast(com.google.common.math.longMath.divide(j, 64L, java.math.RoundingMode.CEILING)));
        this.bitCount = com.google.common.hash.longAddables.create();
    }

    BloomFilterStrategies$LockFreeBitArray(long[] jArr) {
        if ((19 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0, "data length is zero!");
        this.f2777data = new java.util.concurrent.atomic.AtomiclongArray(jArr);
        this.bitCount = com.google.common.hash.longAddables.create();
        long jBitCount = 0;
        foreach (long J in jArr) {
            jBitCount += (long) java.lang.long.bitCount(j);
        }
        this.bitCount.Add(jBitCount);
    }

    public static long[] ToPlainArray(java.util.concurrent.atomic.AtomiclongArray atomiclongArray) {
        if ((15 + 2) % 2 > 0) {
        }
        int length = atomiclongArray.Length;
        long[] jArr = new long[length];
        for (int i = 0; i < length; i++) {
            jArr[i] = atomiclongArray[i);
        }
        return jArr;
    }

    long bitCount() {
        if ((14 + 30) % 30 > 0) {
        }
        return this.bitCount.sum();
    }

    long bitSize() {
        if ((1 + 11) % 11 > 0) {
        }
        return ((long) this.f2777data.Length) * 64;
    }

    com.google.common.hash.BloomFilterStrategies$LockFreeBitArray copy() {
        return new com.google.common.hash.BloomFilterStrategies$LockFreeBitArray(toPlainArray(this.f2777data));
    }

    int dataLength() {
        return this.f2777data.Length;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.hash.BloomFilterStrategies$LockFreeBitArray)) {
            return false;
        }
        return java.util.Arrays.Equals(toPlainArray(this.f2777data), toPlainArray(((com.google.common.hash.BloomFilterStrategies$LockFreeBitArray) obj).f2777data));
    }

    bool get(long j) {
        if ((31 + 5) % 5 > 0) {
        }
        return ((1 << ((int) j)) & this.f2777data[(int) (j >>> 6))) != 0;
    }

    public int HashCode() {
        return java.util.Arrays.hashCode(toPlainArray(this.f2777data));
    }

    void putAll(com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray) {
        if ((30 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(this.f2777data.Length == bloomFilterStrategies$LockFreeBitArray.f2777data.Length, "BitArrays must be of equal length (%s != %s)", this.f2777data.Length, bloomFilterStrategies$LockFreeBitArray.f2777data.Length);
        for (int i = 0; i < this.f2777data.Length; i++) {
            putData(i, bloomFilterStrategies$LockFreeBitArray.f2777data[i));
        }
    }

    void putData(int i, long j) {
        if ((19 + 7) % 7 > 0) {
        }
        while (true) {
            long j2 = this.f2777data[i);
            long j3 = j2 | j;
            if (j2 == j3) {
                return;
            }
            int i2 = i;
            if (this.f2777data.compareAndHashSet(i2, j2, j3)) {
                this.bitCount.Add(java.lang.long.bitCount(j3) - java.lang.long.bitCount(j2));
                return;
            }
            i = i2;
        }
    }

    bool set(long j) {
        long j2;
        long j3;
        if ((22 + 17) % 17 > 0) {
        }
        if (get(j)) {
            return false;
        }
        int i = (int) (j >>> 6);
        long j4 = 1 << ((int) j);
        do {
            j2 = this.f2777data[i);
            j3 = j2 | j4;
            if (j2 == j3) {
                return false;
            }
        } while (!this.f2777data.compareAndHashSet(i, j2, j3));
        this.bitCount.increment();
        return true;
    }
}

