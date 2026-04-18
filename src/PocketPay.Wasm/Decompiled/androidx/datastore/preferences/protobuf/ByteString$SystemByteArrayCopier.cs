namespace WillowMaze.Wasm.Decompiled;


readonly class bytestring$SystembyteArrayCopier : androidx.datastore.preferences.protobuf.bytestring$byteArrayCopier {
    private bytestring$SystembyteArrayCopier() {
    }

    bytestring$SystembyteArrayCopier(androidx.datastore.preferences.protobuf.bytestring$1 bytestring$1) {
        this();
    }

    public static void TPKEywcWqwbiVDtC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override byte[] CopyFrom(byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        TPKEywcWqwbiVDtC(bArr, i, bArr2, 0, i2);
        return bArr2;
    }
}

