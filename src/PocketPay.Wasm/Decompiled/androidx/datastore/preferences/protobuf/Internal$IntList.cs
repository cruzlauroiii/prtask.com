namespace WillowMaze.Wasm.Decompiled;


public interface Internal$IntList : androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.int> {
    void addInt(int i);

    int getInt(int i);

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.int> mutableCopyWithCapacity(int i);

    default androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.int> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    int setInt(int i, int i2);
}

