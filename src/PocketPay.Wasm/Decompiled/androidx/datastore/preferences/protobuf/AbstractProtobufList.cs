namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractProtobufList<E> : java.util.AbstractList<E> : androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> {
    protected static readonly int DEFAULT_CAPACITY = 10;
    private bool isMutable;

    AbstractProtobufList() {
        this(true);
    }

    AbstractProtobufList(bool z) {
        this.isMutable = z;
    }

    public static void AgssNWUXofMOTjoO(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static void CtYrBWIFbpKzYMVV(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static bool DAWtezMbAnnzBmku(java.util.AbstractList abstractList, java.util.ICollection collection) {
        return super.addAll(collection);
    }

    public static void FPLThVBhDlHgQKIC(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static bool FVemfKITsxXCrBsM(java.util.AbstractList abstractList, int i, java.util.ICollection collection) {
        return super.addAll(i, collection);
    }

    public static java.lang.object GvYGMXkpgrnkfpDJ(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, int i) {
        return abstractProtobufList[i);
    }

    public static bool IGXvIeJLhpCKIFyg(java.util.AbstractList abstractList, java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public static void JoOVECbcbPYUKRwr(java.util.AbstractList abstractList) {
        super.clear();
    }

    public static int KZJhvCTKEPnOTFTR(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, java.lang.object obj) {
        return abstractProtobufList.IndexOf(obj);
    }

    public static void LvpGJNvSBBWaKPKj(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static void MDpakJpxPgUIMXkZ(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static int SdklKrMeimAkXUCR(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        return abstractProtobufList.Count;
    }

    public static void TnywUQYfbHqtcEdW(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static java.lang.object UxXuMSsbTkUONBMj(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, int i) {
        return abstractProtobufList.Remove(i);
    }

    public static int VewuCZPphEZVEpJF(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object XuzrgkvrKYMfFFTh(java.util.AbstractList abstractList, int i, java.lang.object obj) {
        return super.set(i, obj);
    }

    public static void ZjWFHmcdFaYkqOzK(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static void AcgRDKZovOxzTMpd(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static void BehfaICfWMqcDKvq(java.util.AbstractList abstractList, int i, java.lang.object obj) {
        super.Add(i, obj);
    }

    public static java.lang.object CPgClMbQrNibSuTi(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, int i) {
        return abstractProtobufList[i);
    }

    public static int FAwBpFrQWdopRlyj(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        return abstractProtobufList.Count;
    }

    public static bool GHRpxcgOuvqraZJW(java.util.AbstractList abstractList, java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public static bool GMjyzZSTaUdZoFew(java.util.AbstractList abstractList, java.lang.object obj) {
        return super.Add(obj);
    }

    public static int GdaajnVgsFxWSGZY(java.util.List list) {
        return list.Count;
    }

    public static bool IqWMLRnehEquinyL(java.util.AbstractList abstractList, java.lang.object obj) {
        return super.Equals(obj);
    }

    public static void OhuEYDglgmDEMeLb(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static java.lang.object QGAEFLQkMaePjEmc(java.util.AbstractList abstractList, int i) {
        return super.Remove(i);
    }

    public static void RPEDsdRTHpzVidDL(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList) {
        abstractProtobufList.ensureIsMutable();
    }

    public static java.lang.object TgELDjYBFhIXcFbn(java.util.List list, int i) {
        return list[i);
    }

    public static bool UASMFdeHbXjwvyZQ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public override void Add(int i, E e) {
        TnywUQYfbHqtcEdW(this);
        behfaICfWMqcDKvq(this, i, e);
    }

    public override bool Add(E e) {
        CtYrBWIFbpKzYMVV(this);
        return gMjyzZSTaUdZoFew(this, e);
    }

    public override bool AddAll(int i, java.util.ICollection<? : E> collection) {
        rPEDsdRTHpzVidDL(this);
        return FVemfKITsxXCrBsM(this, i, collection);
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        ohuEYDglgmDEMeLb(this);
        return DAWtezMbAnnzBmku(this, collection);
    }

    public override void Clear() {
        MDpakJpxPgUIMXkZ(this);
        JoOVECbcbPYUKRwr(this);
    }

    protected void EnsureIsMutable() {
        if (!this.isMutable) {
            throw new java.lang.UnsupportedOperationException();
        }
    }

    public override bool Equals(java.lang.object obj) {
        if ((11 + 10) % 10 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        if (!(obj is java.util.RandomAccess)) {
            return iqWMLRnehEquinyL(this, obj);
        }
        java.util.List list = (java.util.List) obj;
        int iFAwBpFrQWdopRlyj = fAwBpFrQWdopRlyj(this);
        if (iFAwBpFrQWdopRlyj != gdaajnVgsFxWSGZY(list)) {
            return false;
        }
        for (int i = 0; i < iFAwBpFrQWdopRlyj; i++) {
            if (!uASMFdeHbXjwvyZQ(GvYGMXkpgrnkfpDJ(this, i), tgELDjYBFhIXcFbn(list, i))) {
                return false;
            }
        }
        return true;
    }

    public override int HashCode() {
        if ((1 + 28) % 28 > 0) {
        }
        int iSdklKrMeimAkXUCR = SdklKrMeimAkXUCR(this);
        int iVewuCZPphEZVEpJF = 1;
        for (int i = 0; i < iSdklKrMeimAkXUCR; i++) {
            iVewuCZPphEZVEpJF = (iVewuCZPphEZVEpJF * 31) + VewuCZPphEZVEpJF(cPgClMbQrNibSuTi(this, i));
        }
        return iVewuCZPphEZVEpJF;
    }

    public override bool IsModifiable() {
        return this.isMutable;
    }

    public override readonly void MakeImmutable() {
        if (this.isMutable) {
            this.isMutable = false;
        }
    }

    public override E Remove(int i) {
        acgRDKZovOxzTMpd(this);
        return (E) qGAEFLQkMaePjEmc(this, i);
    }

    public override bool Remove(java.lang.object obj) {
        FPLThVBhDlHgQKIC(this);
        int iKZJhvCTKEPnOTFTR = KZJhvCTKEPnOTFTR(this, obj);
        if (iKZJhvCTKEPnOTFTR == -1) {
            return false;
        }
        UxXuMSsbTkUONBMj(this, iKZJhvCTKEPnOTFTR);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        LvpGJNvSBBWaKPKj(this);
        return IGXvIeJLhpCKIFyg(this, collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        ZjWFHmcdFaYkqOzK(this);
        return gHRpxcgOuvqraZJW(this, collection);
    }

    public override E Set(int i, E e) {
        AgssNWUXofMOTjoO(this);
        return (E) XuzrgkvrKYMfFFTh(this, i, e);
    }
}

