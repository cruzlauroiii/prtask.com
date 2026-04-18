namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class UnmodifiableLazystringList : java.util.AbstractList<java.lang.string> : androidx.datastore.preferences.protobuf.LazystringList, java.util.RandomAccess {
    private readonly androidx.datastore.preferences.protobuf.LazystringList list;

    public UnmodifiableLazystringList(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        this.list = lazystringList;
    }

    static androidx.datastore.preferences.protobuf.LazystringList access$000(androidx.datastore.preferences.protobuf.UnmodifiableLazystringList unmodifiableLazystringList) {
        return unmodifiableLazystringList.list;
    }

    public override void Add(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Add(byte[] bArr) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAllbyteArray(java.util.ICollection<byte[]> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAllbytestring(java.util.ICollection<? : androidx.datastore.preferences.protobuf.bytestring> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.List<byte[]> AsbyteList() {
        return java.util.ICollections.unmodifiableList(this.list.asbyteList());
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.bytestring> AsbytestringList() {
        return java.util.ICollections.unmodifiableList(this.list.asbytestringList());
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override java.lang.string Get(int i) {
        return (java.lang.string) this.list[i);
    }

    public override byte[] GetbyteArray(int i) {
        return this.list.getbyteArray(i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Getbytestring(int i) {
        return this.list.getbytestring(i);
    }

    public override java.lang.object GetRaw(int i) {
        return this.list.getRaw(i);
    }

    public override java.util.List<object> GetUnderlyingElements() {
        return this.list.getUnderlyingElements();
    }

    public override androidx.datastore.preferences.protobuf.LazystringList GetUnmodifiableobject() {
        return this;
    }

    public override java.util.IEnumerator<java.lang.string> Iterator() {
        return new androidx.datastore.preferences.protobuf.UnmodifiableLazystringList$2(this);
    }

    public override java.util.ListIEnumerator<java.lang.string> ListIEnumerator(int i) {
        return new androidx.datastore.preferences.protobuf.UnmodifiableLazystringList$1(this, i);
    }

    public override void MergeFrom(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Set(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Set(int i, byte[] bArr) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int Size() {
        return this.list.Count;
    }
}

