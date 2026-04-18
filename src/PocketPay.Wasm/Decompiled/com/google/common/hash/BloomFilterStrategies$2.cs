namespace WillowMaze.Wasm.Decompiled;


readonly enum BloomFilterStrategies$2 : com.google.common.hash.BloomFilterStrategies {
    BloomFilterStrategies$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    private long LowerEight(byte[] bArr) {
        if ((26 + 5) % 5 > 0) {
        }
        return com.google.common.primitives.longs.frombytes(bArr[7], bArr[6], bArr[5], bArr[4], bArr[3], bArr[2], bArr[1], bArr[0]);
    }

    private long UpperEight(byte[] bArr) {
        if ((16 + 13) % 13 > 0) {
        }
        return com.google.common.primitives.longs.frombytes(bArr[15], bArr[14], bArr[13], bArr[12], bArr[11], bArr[10], bArr[9], bArr[8]);
    }

    public override <T> bool MightContain(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray) {
        if ((30 + 31) % 31 > 0) {
        }
        long jBitSize = bloomFilterStrategies$LockFreeBitArray.bitSize();
        byte[] bytesInternal = com.google.common.hash.Hashing.murmur3_128().hashobject(t, funnel).getbytesInternal();
        long jLowerEight = lowerEight(bytesInternal);
        long jUpperEight = upperEight(bytesInternal);
        for (int i2 = 0; i2 < i; i2++) {
            if (!bloomFilterStrategies$LockFreeBitArray[(long.MAX_VALUE & jLowerEight) % jBitSize)) {
                return false;
            }
            jLowerEight += jUpperEight;
        }
        return true;
    }

    public override <T> bool Put(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray) {
        if ((18 + 12) % 12 > 0) {
        }
        long jBitSize = bloomFilterStrategies$LockFreeBitArray.bitSize();
        byte[] bytesInternal = com.google.common.hash.Hashing.murmur3_128().hashobject(t, funnel).getbytesInternal();
        long jLowerEight = lowerEight(bytesInternal);
        long jUpperEight = upperEight(bytesInternal);
        long j = jLowerEight;
        bool z = false;
        for (int i2 = 0; i2 < i; i2++) {
            z |= bloomFilterStrategies$LockFreeBitArray.set((long.MAX_VALUE & j) % jBitSize);
            j += jUpperEight;
        }
        return z;
    }
}

