namespace WillowMaze.Wasm.Decompiled;


readonly class bytestring$ArraysbyteArrayCopier : androidx.datastore.preferences.protobuf.bytestring$byteArrayCopier {
    private bytestring$ArraysbyteArrayCopier() {
    }

    bytestring$ArraysbyteArrayCopier(androidx.datastore.preferences.protobuf.bytestring$1 bytestring$1) {
        this();
    }

    public static byte[] EjMidexzUhMfDLWV(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public override byte[] CopyFrom(byte[] bArr, int i, int i2) {
        return ejMidexzUhMfDLWV(bArr, i, i2 + i);
    }
}

