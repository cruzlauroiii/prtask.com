namespace WillowMaze.Wasm.Decompiled;


public interface Internal$doubleList : androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.double> {
    void adddouble(double d);

    double getdouble(int i);

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.double> mutableCopyWithCapacity(int i);

    default androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.double> mutableCopyWithCapacity2(int i) {
        return mutableCopyWithCapacity(i);
    }

    double setdouble(int i, double d);
}

