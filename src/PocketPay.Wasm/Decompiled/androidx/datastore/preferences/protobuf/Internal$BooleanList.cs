namespace WillowMaze.Wasm.Decompiled;


public interface Internal$boolList : androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.bool> {
    void addbool(bool z);

    bool getbool(int i);

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.bool> mutableCopyWithCapacity(int i);

    default androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.bool> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    bool setbool(int i, bool z);
}

