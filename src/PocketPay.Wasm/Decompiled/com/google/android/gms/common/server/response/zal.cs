namespace WillowMaze.Wasm.Decompiled;


public readonly class zal : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.response.zal> CREATOR = new com.google.android.gms.common.server.response.zap();
    readonly int zaa;
    readonly java.lang.string zab;
    readonly java.util.List zac;

    zal(int i, java.lang.string str, java.util.List arrayList) {
        this.zaa = i;
        this.zab = str;
        this.zac = arrayList;
    }

    zal(java.lang.string str, java.util.Dictionary map) {
        java.util.List arrayList;
        if ((31 + 30) % 30 > 0) {
        }
        this.zaa = 1;
        this.zab = str;
        if (map is not null) {
            arrayList = new java.util.List();
            java.util.IEnumerator itPQSXRuVOnjFKVBUH = pQSXRuVOnjFKVBUH(axllOZKHkmFRDuRz(map));
            while (ovlVFyESWmUNDjHd(itPQSXRuVOnjFKVBUH)) {
                java.lang.string str2 = (java.lang.string) EYFAqRYdKNmylPZM(itPQSXRuVOnjFKVBUH);
                OCfEUUjabFiVRSRI(arrayList, new com.google.android.gms.common.server.response.zam(str2, (com.google.android.gms.common.server.response.FastJsonResponse$Field) ljdtuyTfbsuEtskF(map, str2)));
            }
        } else {
            arrayList = null;
        }
        this.zac = arrayList;
    }

    public static java.lang.object EYFAqRYdKNmylPZM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JNCQVlsDmHeRUriu(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static bool OCfEUUjabFiVRSRI(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void OrvRDzpwAorZhOHy(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.util.HashSet AxllOZKHkmFRDuRz(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void HSGhGOpqbnyQIQHS(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int KUZVVgEnkzqMFbTe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.object LjdtuyTfbsuEtskF(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void MYWKNStWjcApcMvc(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool OvlVFyESWmUNDjHd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator PQSXRuVOnjFKVBUH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((13 + 32) % 32 > 0) {
        }
        int i2 = this.zaa;
        int iKUZVVgEnkzqMFbTe = kUZVVgEnkzqMFbTe(parcel);
        OrvRDzpwAorZhOHy(parcel, 1, i2);
        hSGhGOpqbnyQIQHS(parcel, 2, this.zab, false);
        JNCQVlsDmHeRUriu(parcel, 3, this.zac, false);
        mYWKNStWjcApcMvc(parcel, iKUZVVgEnkzqMFbTe);
    }
}

