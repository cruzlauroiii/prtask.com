namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.zzb> CREATOR = new com.google.android.gms.location.zzc();
    private readonly long zza;
    private readonly bool zzb;
    private readonly android.os.WorkSource zzc;
    private readonly java.lang.string zzd;
    private readonly int[] zze;
    private readonly bool zzf;
    private readonly java.lang.string zzg;
    private readonly long zzh;
    private java.lang.string zzi;

    zzb(long j, bool z, android.os.WorkSource workSource, java.lang.string str, int[] iArr, bool z2, java.lang.string str2, long j2, java.lang.string str3) {
        this.zza = j;
        this.zzb = z;
        this.zzc = workSource;
        this.zzd = str;
        this.zze = iArr;
        this.zzf = z2;
        this.zzg = str2;
        this.zzh = j2;
        this.zzi = str3;
    }

    public static void MftRPGaXJHluVtHO(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void NaZHHbjRFmSgdaJg(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void StPFSYbgjxbRzxUg(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void VXUADrngahGXBlcx(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void JrxwoNZUPOvTxhFH(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object PGeoiEOOjEQolWpc(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void PsvShpzyqjRfZvzU(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QCERNBuTcFKNfhZo(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QsAVcNqWSBNFJZLc(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int RvtLPOXdMgYtBQYH(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void XEngtsfCWOuDPcoU(android.os.Parcel parcel, int i, int[] iArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIntArray(parcel, i, iArr, z);
    }

    public static void YfgleouMGWCupJIX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 26) % 26 > 0) {
        }
        pGeoiEOOjEQolWpc(parcel);
        int iRvtLPOXdMgYtBQYH = rvtLPOXdMgYtBQYH(parcel);
        VXUADrngahGXBlcx(parcel, 1, this.zza);
        jrxwoNZUPOvTxhFH(parcel, 2, this.zzb);
        StPFSYbgjxbRzxUg(parcel, 3, this.zzc, i, false);
        qsAVcNqWSBNFJZLc(parcel, 4, this.zzd, false);
        xEngtsfCWOuDPcoU(parcel, 5, this.zze, false);
        NaZHHbjRFmSgdaJg(parcel, 6, this.zzf);
        psvShpzyqjRfZvzU(parcel, 7, this.zzg, false);
        MftRPGaXJHluVtHO(parcel, 8, this.zzh);
        qCERNBuTcFKNfhZo(parcel, 9, this.zzi, false);
        yfgleouMGWCupJIX(parcel, iRvtLPOXdMgYtBQYH);
    }

    public readonly com.google.android.gms.location.zzb Zza(java.lang.string str) {
        this.zzi = str;
        return this;
    }
}

