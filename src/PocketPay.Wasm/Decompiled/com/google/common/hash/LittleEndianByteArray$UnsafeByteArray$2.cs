namespace WillowMaze.Wasm.Decompiled;


readonly enum LittleEndianbyteArray$UnsafebyteArray$2 : com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray {
    LittleEndianbyteArray$UnsafebyteArray$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override long GetlongLittleEndian(byte[] bArr, int i) {
        if ((17 + 13) % 13 > 0) {
        }
        return java.lang.long.reversebytes(com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$200().getlong(bArr, ((long) i) + ((long) com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$100())));
    }

    public override void PutlongLittleEndian(byte[] bArr, int i, long j) {
        if ((14 + 1) % 1 > 0) {
        }
        com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$200().putlong(bArr, ((long) i) + ((long) com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$100()), java.lang.long.reversebytes(j));
    }
}

