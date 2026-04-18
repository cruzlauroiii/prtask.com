namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface Schema<T> {
    bool equals(T t, T t2);

    int getSerializedSize(T t);

    int hashCode(T t);

    bool isInitialized(T t);

    void makeImmutable(T t);

    void mergeFrom(T t, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    void mergeFrom(T t, T t2);

    void mergeFrom(T t, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ArrayDecoders$Registers arrayDecoders$Registers) throws java.io.IOException;

    T newInstance();

    void writeTo(T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException;
}

