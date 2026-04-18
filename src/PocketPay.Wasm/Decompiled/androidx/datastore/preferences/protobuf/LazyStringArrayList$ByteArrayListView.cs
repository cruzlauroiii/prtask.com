namespace WillowMaze.Wasm.Decompiled;


class LazystringList$byteListobject : java.util.AbstractList<byte[]> : java.util.RandomAccess {
    private readonly androidx.datastore.preferences.protobuf.LazystringList list;

    LazystringList$byteListobject(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        this.list = lazystringList;
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (byte[]) obj);
    }

    public void Add(int i, byte[] bArr) {
        androidx.datastore.preferences.protobuf.LazystringList.access$200(this.list, i, bArr);
        this.modCount++;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override byte[] Get(int i) {
        return this.list.getbyteArray(i);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    public override byte[] Remove(int i) {
        java.lang.string strRemove = this.list.Remove(i);
        this.modCount++;
        return androidx.datastore.preferences.protobuf.LazystringList.access$100(strRemove);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (byte[]) obj);
    }

    public byte[] Set(int i, byte[] bArr) {
        java.lang.object objAccess$000 = androidx.datastore.preferences.protobuf.LazystringList.access$000(this.list, i, bArr);
        this.modCount++;
        return androidx.datastore.preferences.protobuf.LazystringList.access$100(objAccess$000);
    }

    public override int Size() {
        return this.list.Count;
    }
}

