namespace WillowMaze.Wasm.Decompiled;


class LazystringList$bytestringListobject : java.util.AbstractList<androidx.datastore.preferences.protobuf.bytestring> : java.util.RandomAccess {
    private readonly androidx.datastore.preferences.protobuf.LazystringList list;

    LazystringList$bytestringListobject(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        this.list = lazystringList;
    }

    public void Add(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        androidx.datastore.preferences.protobuf.LazystringList.access$500(this.list, i, bytestring);
        this.modCount++;
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (androidx.datastore.preferences.protobuf.bytestring) obj);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Get(int i) {
        return this.list.getbytestring(i);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Remove(int i) {
        java.lang.string strRemove = this.list.Remove(i);
        this.modCount++;
        return androidx.datastore.preferences.protobuf.LazystringList.access$400(strRemove);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    public androidx.datastore.preferences.protobuf.bytestring Set(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        java.lang.object objAccess$300 = androidx.datastore.preferences.protobuf.LazystringList.access$300(this.list, i, bytestring);
        this.modCount++;
        return androidx.datastore.preferences.protobuf.LazystringList.access$400(objAccess$300);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (androidx.datastore.preferences.protobuf.bytestring) obj);
    }

    public override int Size() {
        return this.list.Count;
    }
}

