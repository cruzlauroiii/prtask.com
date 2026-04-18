namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface Reader {
    public static readonly int READ_DONE = int.MAX_VALUE;
    public static readonly int TAG_UNKNOWN = 0;

    int getFieldNumber() throws java.io.IOException;

    int getTag();

    <T> void mergeGroupField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    <T> void mergeMessageField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    bool readBool() throws java.io.IOException;

    void readBoolList(java.util.List<java.lang.bool> list) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.bytestring readbytes() throws java.io.IOException;

    void readbytesList(java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException;

    double readdouble() throws java.io.IOException;

    void readdoubleList(java.util.List<java.lang.double> list) throws java.io.IOException;

    int readEnum() throws java.io.IOException;

    void readEnumList(java.util.List<java.lang.int> list) throws java.io.IOException;

    int readFixed32() throws java.io.IOException;

    void readFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException;

    long readFixed64() throws java.io.IOException;

    void readFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException;

    float readfloat() throws java.io.IOException;

    void readfloatList(java.util.List<java.lang.float> list) throws java.io.IOException;

    @java.lang.Deprecated
    <T> T readGroup(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    @java.lang.Deprecated
    <T> T readGroupBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    @java.lang.Deprecated
    <T> void readGroupList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    @java.lang.Deprecated
    <T> void readGroupList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    int readInt32() throws java.io.IOException;

    void readInt32List(java.util.List<java.lang.int> list) throws java.io.IOException;

    long readInt64() throws java.io.IOException;

    void readInt64List(java.util.List<java.lang.long> list) throws java.io.IOException;

    <K, V> void readDictionary(java.util.Dictionary<K, V> map, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    <T> T readMessage(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    <T> T readMessageBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    <T> void readMessageList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    <T> void readMessageList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    int readSFixed32() throws java.io.IOException;

    void readSFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException;

    long readSFixed64() throws java.io.IOException;

    void readSFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException;

    int readSInt32() throws java.io.IOException;

    void readSInt32List(java.util.List<java.lang.int> list) throws java.io.IOException;

    long readSInt64() throws java.io.IOException;

    void readSInt64List(java.util.List<java.lang.long> list) throws java.io.IOException;

    java.lang.string readstring() throws java.io.IOException;

    void readstringList(java.util.List<java.lang.string> list) throws java.io.IOException;

    void readstringListRequireUtf8(java.util.List<java.lang.string> list) throws java.io.IOException;

    java.lang.string readstringRequireUtf8() throws java.io.IOException;

    int readUInt32() throws java.io.IOException;

    void readUInt32List(java.util.List<java.lang.int> list) throws java.io.IOException;

    long readUInt64() throws java.io.IOException;

    void readUInt64List(java.util.List<java.lang.long> list) throws java.io.IOException;

    bool shouldDiscardUnknownFields();

    bool skipField() throws java.io.IOException;
}

