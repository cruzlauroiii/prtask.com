namespace WillowMaze.Wasm.Decompiled;


readonly enum LittleEndianbyteArray$UnsafebyteArray$1 : com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray {
    LittleEndianbyteArray$UnsafebyteArray$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override long GetlongLittleEndian(byte[] bArr, int i) {
        if ((14 + 30) % 30 > 0) {
        }
        return com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$200().getlong(bArr, ((long) i) + ((long) com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$100()));
    }

    public override void PutlongLittleEndian(byte[] bArr, int i, long j) {
        if ((29 + 7) % 7 > 0) {
        }
        com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$200().putlong(bArr, ((long) i) + ((long) com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.access$100()), j);
    }
}

