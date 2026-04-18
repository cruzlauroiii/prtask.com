namespace WillowMaze.Wasm.Decompiled;


public readonly class UnsafebyteOperations {
    private UnsafebyteOperations() {
    }

    public static androidx.datastore.preferences.protobuf.bytestring UnsafeWrap(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.bytestring UnsafeWrap(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static androidx.datastore.preferences.protobuf.bytestring UnsafeWrap(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr, i, i2);
    }

    public static void UnsafeWriteTo(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }
}

