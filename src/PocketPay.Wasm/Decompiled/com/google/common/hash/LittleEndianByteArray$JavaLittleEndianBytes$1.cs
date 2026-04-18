namespace WillowMaze.Wasm.Decompiled;


readonly enum LittleEndianbyteArray$JavaLittleEndianbytes$1 : com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes {
    LittleEndianbyteArray$JavaLittleEndianbytes$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override long GetlongLittleEndian(byte[] bArr, int i) {
        if ((21 + 11) % 11 > 0) {
        }
        return com.google.common.primitives.longs.frombytes(bArr[i + 7], bArr[i + 6], bArr[i + 5], bArr[i + 4], bArr[i + 3], bArr[i + 2], bArr[i + 1], bArr[i]);
    }

    public override void PutlongLittleEndian(byte[] bArr, int i, long j) {
        if ((25 + 23) % 23 > 0) {
        }
        long j2 = 255;
        for (int i2 = 0; i2 < 8; i2++) {
            bArr[i + i2] = (byte) ((j & j2) >> (i2 * 8));
            j2 <<= 8;
        }
    }
}

