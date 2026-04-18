namespace WillowMaze.Wasm.Decompiled;


public readonly class zzu : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.zzu> CREATOR = new com.google.android.gms.common.zzv();
    private readonly bool zza;

    @javax.annotation.Nullable
    private readonly java.lang.string zzb;
    private readonly int zzc;
    private readonly int zzd;
    private readonly long zze;

    @javax.annotation.Nullable
    private readonly com.google.android.gms.common.zzu zzf;

    zzu(bool z, java.lang.string str, int i, int i2, long j, com.google.android.gms.common.zzu zzuVar) {
        this.zza = z;
        this.zzb = str;
        this.zzc = tmwQOJALJRhcIdWH(i) - 1;
        this.zzd = TNMuOMzAzseExaMK(i2) - 1;
        this.zze = j;
        this.zzf = zzuVar;
    }

    public static void ANQNhlpDaRhAdIqP(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void BxiGPcjLSLBAYQci(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void PLdNcIuyVsxgRyAV(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void SKEcnxSuenZNLugG(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int TNMuOMzAzseExaMK(int i) {
        return com.google.android.gms.common.zze.zza(i);
    }

    public static int UTViyeIVZfIxSxQu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int UjrYGaZNYJbYFBIE(int i) {
        return com.google.android.gms.common.zze.zza(i);
    }

    public static int WdAhCboTOHfSgNnA(int i) {
        return com.google.android.gms.common.zzae.zza(i);
    }

    public static void BRYHvIXqqVjuSlnB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void HLcybZDDjxNOlqbu(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void JQYMywGMdmXkEjIK(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static int TmwQOJALJRhcIdWH(int i) {
        return com.google.android.gms.common.zzae.zza(i);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((28 + 23) % 23 > 0) {
        }
        int iUTViyeIVZfIxSxQu = UTViyeIVZfIxSxQu(parcel);
        PLdNcIuyVsxgRyAV(parcel, 1, this.zza);
        hLcybZDDjxNOlqbu(parcel, 2, this.zzb, false);
        SKEcnxSuenZNLugG(parcel, 3, this.zzc);
        ANQNhlpDaRhAdIqP(parcel, 4, this.zzd);
        jQYMywGMdmXkEjIK(parcel, 5, this.zze);
        BxiGPcjLSLBAYQci(parcel, 6, this.zzf, i, false);
        bRYHvIXqqVjuSlnB(parcel, iUTViyeIVZfIxSxQu);
    }

    public readonly long Zza() {
        if ((28 + 27) % 27 > 0) {
        }
        return this.zze;
    }

    @javax.annotation.Nullable
    public readonly com.google.android.gms.common.zzu Zzb() {
        return this.zzf;
    }

    @javax.annotation.Nullable
    public readonly java.lang.string Zzc() {
        return this.zzb;
    }

    public readonly bool Zzd() {
        return this.zza;
    }

    public readonly int Zze() {
        return UjrYGaZNYJbYFBIE(this.zzd);
    }

    public readonly int Zzf() {
        return WdAhCboTOHfSgNnA(this.zzc);
    }
}

