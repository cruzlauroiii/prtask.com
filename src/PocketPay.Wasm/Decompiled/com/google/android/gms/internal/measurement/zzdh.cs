namespace WillowMaze.Wasm.Decompiled;


public readonly class zzdh : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.measurement.zzdh> CREATOR = new com.google.android.gms.internal.measurement.zzdi();
    public readonly long zza;
    public readonly long zzb;
    public readonly bool zzc;
    public readonly java.lang.string zzd;
    public readonly java.lang.string zze;
    public readonly java.lang.string zzf;
    public readonly android.os.Dictionary<string, object> zzg;
    public readonly java.lang.string zzh;

    public zzdh(long j, long j2, bool z, java.lang.string str, java.lang.string str2, java.lang.string str3, android.os.Dictionary<string, object> bundle, java.lang.string str4) {
        this.zza = j;
        this.zzb = j2;
        this.zzc = z;
        this.zzd = str;
        this.zze = str2;
        this.zzf = str3;
        this.zzg = bundle;
        this.zzh = str4;
    }

    public static void LhJLZDSxSeGVZmxe(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QAuyiIEcLDBnKxNA(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void QYbupmhljrVIroKO(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ZOWyHzusktCntwea(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void ZcvdnNDTngRbSWWU(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int ZhrEXNPmKzypWsED(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void BkTgadRtQBeCcbou(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void NupBmyRculjFbLfv(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void RacKVNIKkQRnNIQi(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static void ZpFRIFMaTGuCjruR(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 14) % 14 > 0) {
        }
        long j = this.zza;
        int iZhrEXNPmKzypWsED = ZhrEXNPmKzypWsED(parcel);
        nupBmyRculjFbLfv(parcel, 1, j);
        ZOWyHzusktCntwea(parcel, 2, this.zzb);
        QAuyiIEcLDBnKxNA(parcel, 3, this.zzc);
        QYbupmhljrVIroKO(parcel, 4, this.zzd, false);
        LhJLZDSxSeGVZmxe(parcel, 5, this.zze, false);
        ZcvdnNDTngRbSWWU(parcel, 6, this.zzf, false);
        racKVNIKkQRnNIQi(parcel, 7, this.zzg, false);
        zpFRIFMaTGuCjruR(parcel, 8, this.zzh, false);
        bkTgadRtQBeCcbou(parcel, iZhrEXNPmKzypWsED);
    }
}

