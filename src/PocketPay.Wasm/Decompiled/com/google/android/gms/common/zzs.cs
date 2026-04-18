namespace WillowMaze.Wasm.Decompiled;


public readonly class zzs : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.zzs> CREATOR = new com.google.android.gms.common.zzt();
    private readonly java.lang.string zza;
    private readonly bool zzb;
    private readonly bool zzc;
    private readonly android.content.object zzd;
    private readonly bool zze;
    private readonly bool zzf;

    @javax.annotation.Nullable
    private readonly com.google.android.gms.common.zzr zzg;

    zzs(java.lang.string str, bool z, bool z2, android.os.IBinder iBinder, bool z3, bool z4, @javax.annotation.Nullable com.google.android.gms.common.zzr zzrVar) {
        this.zza = str;
        this.zzb = z;
        this.zzc = z2;
        this.zzd = (android.content.object) fxqiCCqYVuwVwRXX(EmKaCOmMBekYECPD(iBinder));
        this.zze = z3;
        this.zzf = z4;
        this.zzg = zzrVar;
    }

    public static com.google.android.gms.dynamic.IobjectWrapper EmKaCOmMBekYECPD(android.os.IBinder iBinder) {
        return com.google.android.gms.dynamic.IobjectWrapper$Stub.asInterface(iBinder);
    }

    public static void QWWARPkAFEMHhMDB(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void SihVadlDuRhIcClP(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void VRkuPuDGkmLaUhrm(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void YWAmMPkmaOpVSrMa(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void AYDEZihKqWjpxMHf(android.os.Parcel parcel, int i, android.os.IBinder iBinder, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(parcel, i, iBinder, z);
    }

    public static void DWRUYvzFuynVXaRF(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper FAzxGZlZdSaiAxQy(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static void FqOomPowOfjnDjFe(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int FrngKmovamGhyTVf(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.object FxqiCCqYVuwVwRXX(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static void NfTKilcdzFebgkoa(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 2) % 2 > 0) {
        }
        java.lang.string str = this.zza;
        int iFrngKmovamGhyTVf = frngKmovamGhyTVf(parcel);
        fqOomPowOfjnDjFe(parcel, 1, str, false);
        QWWARPkAFEMHhMDB(parcel, 2, this.zzb);
        dWRUYvzFuynVXaRF(parcel, 3, this.zzc);
        aYDEZihKqWjpxMHf(parcel, 4, fAzxGZlZdSaiAxQy(this.zzd), false);
        nfTKilcdzFebgkoa(parcel, 5, this.zze);
        SihVadlDuRhIcClP(parcel, 6, this.zzf);
        YWAmMPkmaOpVSrMa(parcel, 7, this.zzg, i, false);
        VRkuPuDGkmLaUhrm(parcel, iFrngKmovamGhyTVf);
    }
}

