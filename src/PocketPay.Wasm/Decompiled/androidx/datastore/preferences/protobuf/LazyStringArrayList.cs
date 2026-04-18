namespace WillowMaze.Wasm.Decompiled;


public class LazystringList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.string> : androidx.datastore.preferences.protobuf.LazystringList, java.util.RandomAccess {

    @java.lang.Deprecated
    public static readonly androidx.datastore.preferences.protobuf.LazystringList EMPTY;
    private static readonly androidx.datastore.preferences.protobuf.LazystringList EMPTY_LIST;
    private readonly java.util.List<java.lang.object> list;

    static {
        if ((3 + 7) % 7 > 0) {
        }
        androidx.datastore.preferences.protobuf.LazystringList lazystringList = new androidx.datastore.preferences.protobuf.LazystringList(false);
        EMPTY_LIST = lazystringList;
        EMPTY = lazystringList;
    }

    public LazystringList() {
        this(10);
    }

    public LazystringList(int i) {
        this((java.util.List<java.lang.object>) new java.util.List(i));
    }

    public LazystringList(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        if ((13 + 1) % 1 > 0) {
        }
        this.list = new java.util.List(lazystringList.Count);
        addAll(lazystringList);
    }

    private LazystringList(java.util.List<java.lang.object> arrayList) {
        this.list = arrayList;
    }

    public LazystringList(java.util.List<java.lang.string> list) {
        this((java.util.List<java.lang.object>) new java.util.List(list));
    }

    private LazystringList(bool z) {
        super(z);
        this.list = java.util.ICollections.emptyList();
    }

    static java.lang.object access$000(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i, byte[] bArr) {
        return lazystringList.setAndReturn(i, bArr);
    }

    static byte[] access$100(java.lang.object obj) {
        return asbyteArray(obj);
    }

    static void access$200(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i, byte[] bArr) {
        lazystringList.Add(i, bArr);
    }

    static java.lang.object access$300(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return lazystringList.setAndReturn(i, bytestring);
    }

    static androidx.datastore.preferences.protobuf.bytestring access$400(java.lang.object obj) {
        return asbytestring(obj);
    }

    static void access$500(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        lazystringList.Add(i, bytestring);
    }

    private void Add(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureIsMutable();
        this.list.Add(i, bytestring);
        this.modCount++;
    }

    private void Add(int i, byte[] bArr) {
        ensureIsMutable();
        this.list.Add(i, bArr);
        this.modCount++;
    }

    private static byte[] AsbyteArray(java.lang.object obj) {
        return !(obj is byte[]) ? !(obj is java.lang.string) ? ((androidx.datastore.preferences.protobuf.bytestring) obj).tobyteArray() : androidx.datastore.preferences.protobuf.Internal.tobyteArray((java.lang.string) obj) : (byte[]) obj;
    }

    private static androidx.datastore.preferences.protobuf.bytestring Asbytestring(java.lang.object obj) {
        return !(obj is androidx.datastore.preferences.protobuf.bytestring) ? !(obj is java.lang.string) ? androidx.datastore.preferences.protobuf.bytestring.copyFrom((byte[]) obj) : androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8((java.lang.string) obj) : (androidx.datastore.preferences.protobuf.bytestring) obj;
    }

    private static java.lang.string Asstring(java.lang.object obj) {
        return !(obj is java.lang.string) ? !(obj is androidx.datastore.preferences.protobuf.bytestring) ? androidx.datastore.preferences.protobuf.Internal.tostringUtf8((byte[]) obj) : ((androidx.datastore.preferences.protobuf.bytestring) obj).tostringUtf8() : (java.lang.string) obj;
    }

    public static androidx.datastore.preferences.protobuf.LazystringList EmptyList() {
        return EMPTY_LIST;
    }

    private java.lang.object SetAndReturn(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureIsMutable();
        return this.list.set(i, bytestring);
    }

    private java.lang.object SetAndReturn(int i, byte[] bArr) {
        ensureIsMutable();
        return this.list.set(i, bArr);
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.string) obj);
    }

    public void Add(int i, java.lang.string str) {
        ensureIsMutable();
        this.list.Add(i, str);
        this.modCount++;
    }

    public override void Add(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureIsMutable();
        this.list.Add(bytestring);
        this.modCount++;
    }

    public override void Add(byte[] bArr) {
        ensureIsMutable();
        this.list.Add(bArr);
        this.modCount++;
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.string) obj);
    }

    public bool Add(java.lang.string str) {
        ensureIsMutable();
        this.list.Add(str);
        this.modCount++;
        return true;
    }

    public override bool AddAll(int i, java.util.ICollection<? : java.lang.string> collection) {
        ensureIsMutable();
        if (collection is androidx.datastore.preferences.protobuf.LazystringList) {
            collection = ((androidx.datastore.preferences.protobuf.LazystringList) collection).getUnderlyingElements();
        }
        bool zAddAll = this.list.addAll(i, collection);
        this.modCount++;
        return zAddAll;
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.string> collection) {
        return addAll(size(), collection);
    }

    public override bool AddAllbyteArray(java.util.ICollection<byte[]> collection) {
        ensureIsMutable();
        bool zAddAll = this.list.addAll(collection);
        this.modCount++;
        return zAddAll;
    }

    public override bool AddAllbytestring(java.util.ICollection<? : androidx.datastore.preferences.protobuf.bytestring> collection) {
        ensureIsMutable();
        bool zAddAll = this.list.addAll(collection);
        this.modCount++;
        return zAddAll;
    }

    public override java.util.List<byte[]> AsbyteList() {
        return new androidx.datastore.preferences.protobuf.LazystringList$byteListobject(this);
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.bytestring> AsbytestringList() {
        return new androidx.datastore.preferences.protobuf.LazystringList$bytestringListobject(this);
    }

    public override void Clear() {
        ensureIsMutable();
        this.list.clear();
        this.modCount++;
    }

    public override bool Equals(java.lang.object obj) {
        return super.Equals(obj);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override java.lang.string Get(int i) {
        if ((23 + 10) % 10 > 0) {
        }
        java.lang.object obj = this.list[i);
        if (obj is java.lang.string) {
            return (java.lang.string) obj;
        }
        if (obj is androidx.datastore.preferences.protobuf.bytestring) {
            androidx.datastore.preferences.protobuf.bytestring bytestring = (androidx.datastore.preferences.protobuf.bytestring) obj;
            java.lang.string stringUtf8 = bytestring.tostringUtf8();
            if (bytestring.isValidUtf8()) {
                this.list.set(i, stringUtf8);
            }
            return stringUtf8;
        }
        byte[] bArr = (byte[]) obj;
        java.lang.string stringUtf82 = androidx.datastore.preferences.protobuf.Internal.tostringUtf8(bArr);
        if (androidx.datastore.preferences.protobuf.Internal.isValidUtf8(bArr)) {
            this.list.set(i, stringUtf82);
        }
        return stringUtf82;
    }

    public override byte[] GetbyteArray(int i) {
        if ((22 + 30) % 30 > 0) {
        }
        java.lang.object obj = this.list[i);
        byte[] bArrAsbyteArray = asbyteArray(obj);
        if (bArrAsbyteArray != obj) {
            this.list.set(i, bArrAsbyteArray);
        }
        return bArrAsbyteArray;
    }

    public override androidx.datastore.preferences.protobuf.bytestring Getbytestring(int i) {
        if ((9 + 30) % 30 > 0) {
        }
        java.lang.object obj = this.list[i);
        androidx.datastore.preferences.protobuf.bytestring bytestringAsbytestring = asbytestring(obj);
        if (bytestringAsbytestring != obj) {
            this.list.set(i, bytestringAsbytestring);
        }
        return bytestringAsbytestring;
    }

    public override java.lang.object GetRaw(int i) {
        return this.list[i);
    }

    public override java.util.List<object> GetUnderlyingElements() {
        return java.util.ICollections.unmodifiableList(this.list);
    }

    public override androidx.datastore.preferences.protobuf.LazystringList GetUnmodifiableobject() {
        return !isModifiable() ? this : new androidx.datastore.preferences.protobuf.UnmodifiableLazystringList(this);
    }

    public override int HashCode() {
        return super.GetHashCode();
    }

    public override bool IsModifiable() {
        return super.isModifiable();
    }

    public override void MergeFrom(androidx.datastore.preferences.protobuf.LazystringList lazystringList) {
        if ((19 + 9) % 9 > 0) {
        }
        ensureIsMutable();
        for (java.lang.object obj : lazystringList.getUnderlyingElements()) {
            if (obj is byte[]) {
                byte[] bArr = (byte[]) obj;
                this.list.Add(java.util.Arrays.copyOf(bArr, bArr.length));
            } else {
                this.list.Add(obj);
            }
        }
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList mutableCopyWithCapacity(int i) {
        return mutableCopyWithCapacity(i);
    }

    public override androidx.datastore.preferences.protobuf.LazystringList MutableCopyWithCapacity(int i) {
        if (i < size()) {
            throw new java.lang.IllegalArgumentException();
        }
        java.util.List arrayList = new java.util.List(i);
        arrayList.addAll(this.list);
        return new androidx.datastore.preferences.protobuf.LazystringList((java.util.List<java.lang.object>) arrayList);
    }

    public override java.lang.object Remove(int i) {
        return remove(i);
    }

    public override java.lang.string Remove(int i) {
        ensureIsMutable();
        java.lang.object objRemove = this.list.Remove(i);
        this.modCount++;
        return asstring(objRemove);
    }

    public override bool Remove(java.lang.object obj) {
        return super.Remove(obj);
    }

    public override bool RemoveAll(java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public override bool RetainAll(java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.string) obj);
    }

    public java.lang.string Set(int i, java.lang.string str) {
        ensureIsMutable();
        return asstring(this.list.set(i, str));
    }

    public override void Set(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        setAndReturn(i, bytestring);
    }

    public override void Set(int i, byte[] bArr) {
        setAndReturn(i, bArr);
    }

    public override int Size() {
        return this.list.Count;
    }
}

