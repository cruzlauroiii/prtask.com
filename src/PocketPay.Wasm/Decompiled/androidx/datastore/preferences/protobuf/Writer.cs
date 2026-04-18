namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface Writer {
    androidx.datastore.preferences.protobuf.Writer$FieldOrder fieldOrder();

    void writeBool(int i, bool z) throws java.io.IOException;

    void writeBoolList(int i, java.util.List<java.lang.bool> list, bool z) throws java.io.IOException;

    void writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException;

    void writebytesList(int i, java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException;

    void writedouble(int i, double d) throws java.io.IOException;

    void writedoubleList(int i, java.util.List<java.lang.double> list, bool z) throws java.io.IOException;

    @java.lang.Deprecated
    void writeEndGroup(int i) throws java.io.IOException;

    void writeEnum(int i, int i2) throws java.io.IOException;

    void writeEnumList(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeFixed32(int i, int i2) throws java.io.IOException;

    void writeFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeFixed64(int i, long j) throws java.io.IOException;

    void writeFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException;

    void writefloat(int i, float f) throws java.io.IOException;

    void writefloatList(int i, java.util.List<java.lang.float> list, bool z) throws java.io.IOException;

    @java.lang.Deprecated
    void writeGroup(int i, java.lang.object obj) throws java.io.IOException;

    @java.lang.Deprecated
    void writeGroup(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    @java.lang.Deprecated
    void writeGroupList(int i, java.util.List<object> list) throws java.io.IOException;

    @java.lang.Deprecated
    void writeGroupList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    void writeInt32(int i, int i2) throws java.io.IOException;

    void writeInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeInt64(int i, long j) throws java.io.IOException;

    void writeInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException;

    <K, V> void writeDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, java.util.Dictionary<K, V> map) throws java.io.IOException;

    void writeMessage(int i, java.lang.object obj) throws java.io.IOException;

    void writeMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    void writeMessageList(int i, java.util.List<object> list) throws java.io.IOException;

    void writeMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    void writeMessageHashSetItem(int i, java.lang.object obj) throws java.io.IOException;

    void writeSFixed32(int i, int i2) throws java.io.IOException;

    void writeSFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeSFixed64(int i, long j) throws java.io.IOException;

    void writeSFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException;

    void writeSInt32(int i, int i2) throws java.io.IOException;

    void writeSInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeSInt64(int i, long j) throws java.io.IOException;

    void writeSInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException;

    @java.lang.Deprecated
    void writeStartGroup(int i) throws java.io.IOException;

    void writestring(int i, java.lang.string str) throws java.io.IOException;

    void writestringList(int i, java.util.List<java.lang.string> list) throws java.io.IOException;

    void writeUInt32(int i, int i2) throws java.io.IOException;

    void writeUInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException;

    void writeUInt64(int i, long j) throws java.io.IOException;

    void writeUInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException;
}

