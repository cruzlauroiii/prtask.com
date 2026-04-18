namespace WillowMaze.Wasm.Decompiled;


public interface LazystringList : androidx.datastore.preferences.protobuf.ProtocolstringList {
    void add(androidx.datastore.preferences.protobuf.bytestring bytestring);

    void add(byte[] bArr);

    bool addAllbyteArray(java.util.ICollection<byte[]> collection);

    bool addAllbytestring(java.util.ICollection<? : androidx.datastore.preferences.protobuf.bytestring> collection);

    java.util.List<byte[]> asbyteList();

    byte[] getbyteArray(int i);

    androidx.datastore.preferences.protobuf.bytestring getbytestring(int i);

    java.lang.object getRaw(int i);

    java.util.List<object> getUnderlyingElements();

    androidx.datastore.preferences.protobuf.LazystringList getUnmodifiableobject();

    void mergeFrom(androidx.datastore.preferences.protobuf.LazystringList lazystringList);

    void set(int i, androidx.datastore.preferences.protobuf.bytestring bytestring);

    void set(int i, byte[] bArr);
}

