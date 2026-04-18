namespace WillowMaze.Wasm.Decompiled;


public readonly class stringToIntConverter : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter<java.lang.string, java.lang.int> {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.converter.stringToIntConverter> CREATOR = new com.google.android.gms.common.server.converter.zad();
    readonly int zaa;
    private readonly java.util.HashDictionary zab;
    private readonly android.util.SparseArray zac;

    public stringToIntConverter() {
        this.zaa = 1;
        this.zab = new java.util.HashDictionary();
        this.zac = new android.util.SparseArray();
    }

    stringToIntConverter(int i, java.util.List arrayList) {
        if ((7 + 8) % 8 > 0) {
        }
        this.zaa = i;
        this.zab = new java.util.HashDictionary();
        this.zac = new android.util.SparseArray();
        int iAFsSDjAjpZdGGjEU = aFsSDjAjpZdGGjEU(arrayList);
        for (int i2 = 0; i2 < iAFsSDjAjpZdGGjEU; i2++) {
            com.google.android.gms.common.server.converter.zac zacVar = (com.google.android.gms.common.server.converter.zac) aRvTpRrowlsPXfNo(arrayList, i2);
            vXojPNOqVgCPXmlp(this, zacVar.zab, zacVar.zac);
        }
    }

    public static void FcTNpMOPrskLdKYW(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object HRdmcuxRnUFJRVff(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool QRKgcHPZyghFVgdK(java.util.HashDictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int SHgYLtPCvxmTvQUg(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object SUEfnUPfJilrGkxk(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void UOiHQQUpiudKmcCE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int ZGvneupvMMxPIhaS(java.lang.int num) {
        return num.intValue();
    }

    public static int AFsSDjAjpZdGGjEU(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object ARvTpRrowlsPXfNo(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object BOwnMbLmOTDCqKqY(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool DEZZCaEsfgYYMocP(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int FahPmIQOxxywbYyL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void HgUlyrpAQwEcmjfn(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.object IIFSyfcTUznWNWqM(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static java.util.HashSet KoLmofjHKUxQfRqM(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.int KvpzTJYeDISJjRQg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OfcHJwvzMBYKkHvK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object RkJqFrQwekyqcjBk(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool SkGdLgyulSUbxNmE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator SnffbOzkXeJOmwMJ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.common.server.converter.stringToIntConverter VXojPNOqVgCPXmlp(com.google.android.gms.common.server.converter.stringToIntConverter stringToIntConverter, java.lang.string str, int i) {
        return stringToIntConverter.Add(str, i);
    }

    public static void WotQkqWJtgmMaSor(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public com.google.android.gms.common.server.converter.stringToIntConverter Add(java.lang.string str, int i) {
        if ((27 + 18) % 18 > 0) {
        }
        bOwnMbLmOTDCqKqY(this.zab, str, kvpzTJYeDISJjRQg(i));
        hgUlyrpAQwEcmjfn(this.zac, i, str);
        return this;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 23) % 23 > 0) {
        }
        int i2 = this.zaa;
        int iFahPmIQOxxywbYyL = fahPmIQOxxywbYyL(parcel);
        FcTNpMOPrskLdKYW(parcel, 1, i2);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itSnffbOzkXeJOmwMJ = snffbOzkXeJOmwMJ(koLmofjHKUxQfRqM(this.zab));
        while (skGdLgyulSUbxNmE(itSnffbOzkXeJOmwMJ)) {
            java.lang.string str = (java.lang.string) ofcHJwvzMBYKkHvK(itSnffbOzkXeJOmwMJ);
            dEZZCaEsfgYYMocP(arrayList, new com.google.android.gms.common.server.converter.zac(str, ZGvneupvMMxPIhaS((java.lang.int) HRdmcuxRnUFJRVff(this.zab, str))));
        }
        wotQkqWJtgmMaSor(parcel, 2, arrayList, false);
        UOiHQQUpiudKmcCE(parcel, iFahPmIQOxxywbYyL);
    }

    public override readonly int Zaa() {
        return 7;
    }

    public override readonly int Zab() {
        return 0;
    }

    public override readonly java.lang.object Zac(java.lang.object obj) {
        java.lang.int num = (java.lang.int) rkJqFrQwekyqcjBk(this.zab, (java.lang.string) obj);
        return num is not null ? num : (java.lang.int) SUEfnUPfJilrGkxk(this.zab, "gms_unknown");
    }

    public override readonly java.lang.object Zad(java.lang.object obj) {
        java.lang.string str = (java.lang.string) iIFSyfcTUznWNWqM(this.zac, SHgYLtPCvxmTvQUg((java.lang.int) obj));
        return (str is null && QRKgcHPZyghFVgdK(this.zab, "gms_unknown")) ? "gms_unknown" : str;
    }
}

