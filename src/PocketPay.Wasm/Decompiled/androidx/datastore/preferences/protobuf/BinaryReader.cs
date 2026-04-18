namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class BinaryReader : androidx.datastore.preferences.protobuf.Reader {
    private static readonly int FIXED32_MULTIPLE_MASK = 3;
    private static readonly int FIXED64_MULTIPLE_MASK = 7;

    private BinaryReader() {
    }

    BinaryReader(androidx.datastore.preferences.protobuf.BinaryReader$1 binaryReader$1) {
        this();
    }

    public static bool LkGfeVuYOnQTvhkX(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static androidx.datastore.preferences.protobuf.BinaryReader NewInstance(java.nio.byteBuffer byteBuffer, bool z) {
        if (LkGfeVuYOnQTvhkX(byteBuffer)) {
            return new androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader(byteBuffer, z);
        }
        throw new java.lang.IllegalArgumentException("Direct buffers not yet supported");
    }

    public abstract int GetTotalbytesRead();

    public override bool ShouldDiscardUnknownFields() {
        return false;
    }
}

