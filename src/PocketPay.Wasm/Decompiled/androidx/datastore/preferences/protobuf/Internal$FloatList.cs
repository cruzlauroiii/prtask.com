namespace WillowMaze.Wasm.Decompiled;


public interface Internal$floatList : androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.float> {
    void addfloat(float f);

    float getfloat(int i);

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.float> mutableCopyWithCapacity(int i);

    default androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.float> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    float setfloat(int i, float f);
}

