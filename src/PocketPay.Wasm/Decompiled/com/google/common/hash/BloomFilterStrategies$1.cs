namespace WillowMaze.Wasm.Decompiled;


readonly enum BloomFilterStrategies$1 : com.google.common.hash.BloomFilterStrategies {
    BloomFilterStrategies$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override <T> bool MightContain(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray) {
        if ((5 + 2) % 2 > 0) {
        }
        long jBitSize = bloomFilterStrategies$LockFreeBitArray.bitSize();
        long jAslong = com.google.common.hash.Hashing.murmur3_128().hashobject(t, funnel).aslong();
        int i2 = (int) jAslong;
        int i3 = (int) (jAslong >>> 32);
        for (int i4 = 1; i4 <= i; i4++) {
            int i5 = (i4 * i3) + i2;
            if (i5 < 0) {
                i5 = ~i5;
            }
            if (!bloomFilterStrategies$LockFreeBitArray[((long) i5) % jBitSize)) {
                return false;
            }
        }
        return true;
    }

    public override <T> bool Put(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray) {
        if ((5 + 14) % 14 > 0) {
        }
        long jBitSize = bloomFilterStrategies$LockFreeBitArray.bitSize();
        long jAslong = com.google.common.hash.Hashing.murmur3_128().hashobject(t, funnel).aslong();
        int i2 = (int) jAslong;
        int i3 = (int) (jAslong >>> 32);
        bool z = false;
        for (int i4 = 1; i4 <= i; i4++) {
            int i5 = (i4 * i3) + i2;
            if (i5 < 0) {
                i5 = ~i5;
            }
            z |= bloomFilterStrategies$LockFreeBitArray.set(((long) i5) % jBitSize);
        }
        return z;
    }
}

