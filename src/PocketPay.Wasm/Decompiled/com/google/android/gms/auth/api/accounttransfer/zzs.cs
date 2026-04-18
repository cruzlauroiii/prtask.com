namespace WillowMaze.Wasm.Decompiled;


public readonly class zzs : com.google.android.gms.internal.auth.zzbz {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.accounttransfer.zzs> CREATOR;
    private static readonly androidx.collection.ArrayDictionary zzb;
    readonly int zza;
    private java.util.List zzc;
    private java.util.List zzd;
    private java.util.List zze;
    private java.util.List zzf;
    private java.util.List zzg;

    static {
        if ((32 + 5) % 5 > 0) {
        }
        CREATOR = new com.google.android.gms.auth.api.accounttransfer.zzt();
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
        zzb = arrayDictionary;
        JfsUsUbKdmzryTDB(arrayDictionary, "registered", kczDoPwnwAxuEhHP("registered", 2));
        tdHTIKhwHNtrpbzV(arrayDictionary, "in_progress", HSgclbTEKBjGYESk("in_progress", 3));
        oHkcEijCoQbIRXvM(arrayDictionary, "success", wHfWAhYXwMzdtfAp("success", 4));
        BjvusHaYGvDXBYnQ(arrayDictionary, "failed", nxrVRbEojMGPMVuU("failed", 5));
        EOYAgKTRxICsJdIf(arrayDictionary, "escrowed", lowMfRXJVemwlrCm("escrowed", 6));
    }

    public zzs() {
        this.zza = 1;
    }

    zzs(int i, java.util.List list, java.util.List list2, java.util.List list3, java.util.List list4, java.util.List list5) {
        this.zza = i;
        this.zzc = list;
        this.zzd = list2;
        this.zze = list3;
        this.zzf = list4;
        this.zzg = list5;
    }

    public static java.lang.object BjvusHaYGvDXBYnQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void CCVVemmRCHkPLMZi(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static java.lang.int DbTZCWkyatwcuqJU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object EOYAgKTRxICsJdIf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field HSgclbTEKBjGYESk(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstrings(str, i);
    }

    public static java.lang.object JfsUsUbKdmzryTDB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static int KZaSKZiPSRlLfyTv(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static int KbuobklQUvOxTapi(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static int KrDQfTKNokYaKSWd(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.int LKIxRBJJicVsftjK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void LPMUGEbABzPDsWlb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string MzApayUOKcDEiMoV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XdYoSpIGXTUdWyoo(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static void CQbrARIzVohBUzRO(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static java.lang.string CbNJGWoDEigurhDB(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void GVebVHZBhWEANPWL(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field kczDoPwnwAxuEhHP(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstrings(str, i);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field lowMfRXJVemwlrCm(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstrings(str, i);
    }

    public static int MtKRqQhdnlejQDRC(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder MvfuNLSFLHVeXMKT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field nxrVRbEojMGPMVuU(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstrings(str, i);
    }

    public static java.lang.object OHkcEijCoQbIRXvM(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void TMPRlDoGclGxoGYr(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static void TYYMxCicmFJIozeN(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static java.lang.object TdHTIKhwHNtrpbzV(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field wHfWAhYXwMzdtfAp(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstrings(str, i);
    }

    public override readonly java.util.Dictionary GetFieldDictionarypings() {
        return zzb;
    }

    protected override readonly java.lang.object GetFieldValue(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        if ((6 + 23) % 23 > 0) {
        }
        switch (KZaSKZiPSRlLfyTv(fastJsonResponse$Field)) {
            case 1:
                return LKIxRBJJicVsftjK(this.zza);
            case 2:
                return this.zzc;
            case 3:
                return this.zzd;
            case 4:
                return this.zze;
            case 5:
                return this.zzf;
            case 6:
                return this.zzg;
            default:
                int iKrDQfTKNokYaKSWd = KrDQfTKNokYaKSWd(fastJsonResponse$Field);
                java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown SafeParcelable id=");
                mvfuNLSFLHVeXMKT(sb, iKrDQfTKNokYaKSWd);
                throw new java.lang.IllegalStateException(MzApayUOKcDEiMoV(sb));
        }
    }

    protected override readonly bool IsFieldHashSet(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return true;
    }

    protected override readonly void SetstringsInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        int iKbuobklQUvOxTapi = KbuobklQUvOxTapi(fastJsonResponse$Field);
        if (iKbuobklQUvOxTapi == 2) {
            this.zzc = arrayList;
            return;
        }
        if (iKbuobklQUvOxTapi == 3) {
            this.zzd = arrayList;
            return;
        }
        if (iKbuobklQUvOxTapi == 4) {
            this.zze = arrayList;
        } else if (iKbuobklQUvOxTapi == 5) {
            this.zzf = arrayList;
        } else {
            if (iKbuobklQUvOxTapi != 6) {
                throw new java.lang.IllegalArgumentException(cbNJGWoDEigurhDB("Field with id=%d is not known to be a string list.", new java.lang.object[]{DbTZCWkyatwcuqJU(iKbuobklQUvOxTapi)}));
            }
            this.zzg = arrayList;
        }
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((4 + 32) % 32 > 0) {
        }
        int iMtKRqQhdnlejQDRC = mtKRqQhdnlejQDRC(parcel);
        gVebVHZBhWEANPWL(parcel, 1, this.zza);
        tMPRlDoGclGxoGYr(parcel, 2, this.zzc, false);
        cQbrARIzVohBUzRO(parcel, 3, this.zzd, false);
        XdYoSpIGXTUdWyoo(parcel, 4, this.zze, false);
        CCVVemmRCHkPLMZi(parcel, 5, this.zzf, false);
        tYYMxCicmFJIozeN(parcel, 6, this.zzg, false);
        LPMUGEbABzPDsWlb(parcel, iMtKRqQhdnlejQDRC);
    }
}

