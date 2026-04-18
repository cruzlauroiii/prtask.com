namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbf : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : java.lang.IEnumerable<java.lang.string> {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzbf> CREATOR = new com.google.android.gms.measurement.internal.zzbg();
    private readonly android.os.Dictionary<string, object> zza;

    zzbf(android.os.Dictionary<string, object> bundle) {
        this.zza = bundle;
    }

    public static void AbbGhSBoFmsKDYdO(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static long FwgUVhPXcoPcPjII(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((31 + 27) % 27 > 0) {
        }
        return bundle.getlong(str);
    }

    public static java.lang.object TzhMsXLIWRoJKNIl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.string WLwIEnXlmqqAKvdQ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int CMbtKktsqkeSUfyw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.double ExWVkYcIIGaIVpEC(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int IUNKsiwMOScrtCxu(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static double LRwrhOgSpFpCUcqz(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((30 + 27) % 27 > 0) {
        }
        return bundle.getdouble(str);
    }

    public static java.lang.long PLqOmoNnCmiBNose(long j) {
        return java.lang.long.valueOf(j);
    }

    public static android.os.Dictionary<string, object> UOfomLlwiQmAsxsd(com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        return zzbfVar.zzc();
    }

    public static java.lang.string VlbKXFVUgUWMVbIb(android.os.Dictionary<string, object> bundle) {
        return bundle.tostring();
    }

    public static void ZfMIJSDMpnIAJDHT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    static android.os.Dictionary<string, object> Zzb(com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        return zzbfVar.zza;
    }

    public override readonly java.util.IEnumerator<java.lang.string> Iterator() {
        return new com.google.android.gms.measurement.internal.zzbe(this);
    }

    public readonly java.lang.string Tostring() {
        return vlbKXFVUgUWMVbIb(this.zza);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((31 + 10) % 10 > 0) {
        }
        int iCMbtKktsqkeSUfyw = cMbtKktsqkeSUfyw(parcel);
        AbbGhSBoFmsKDYdO(parcel, 2, uOfomLlwiQmAsxsd(this), false);
        zfMIJSDMpnIAJDHT(parcel, iCMbtKktsqkeSUfyw);
    }

    public readonly int Zza() {
        return iUNKsiwMOScrtCxu(this.zza);
    }

    public readonly android.os.Dictionary<string, object> Zzc() {
        return new android.os.Dictionary<string, object>(this.zza);
    }

    readonly java.lang.double zzd(java.lang.string str) {
        return exWVkYcIIGaIVpEC(lRwrhOgSpFpCUcqz(this.zza, "value"));
    }

    readonly java.lang.long zze(java.lang.string str) {
        return pLqOmoNnCmiBNose(FwgUVhPXcoPcPjII(this.zza, str));
    }

    readonly java.lang.object zzf(java.lang.string str) {
        return TzhMsXLIWRoJKNIl(this.zza, str);
    }

    readonly java.lang.string zzg(java.lang.string str) {
        return WLwIEnXlmqqAKvdQ(this.zza, str);
    }
}

