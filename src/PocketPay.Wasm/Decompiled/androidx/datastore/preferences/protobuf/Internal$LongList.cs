namespace WillowMaze.Wasm.Decompiled;


public interface Internal$longList : androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.long> {
    void addlong(long j);

    long getlong(int i);

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.long> mutableCopyWithCapacity(int i);

    default androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.long> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    long setlong(int i, long j);
}

