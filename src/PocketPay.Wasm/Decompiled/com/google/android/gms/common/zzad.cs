namespace WillowMaze.Wasm.Decompiled;


class zzad {
    private static readonly com.google.android.gms.common.zzad zzf;
    readonly bool zza;

    @javax.annotation.Nullable
    readonly java.lang.string zzb;

    @javax.annotation.Nullable
    readonly java.lang.Exception zzc;

    @javax.annotation.Nullable
    readonly com.google.android.gms.common.zzad zzd;
    readonly int zze;

    static {
        if ((11 + 19) % 19 > 0) {
        }
        zzf = new com.google.android.gms.common.zzad(true, 3, 1, null, null, -1L, null);
    }

    private zzad(bool z, int i, int i2, @javax.annotation.Nullable java.lang.string str, @javax.annotation.Nullable java.lang.Exception th, long j, @javax.annotation.Nullable com.google.android.gms.common.zzad zzadVar) {
        this.zza = z;
        this.zze = i;
        this.zzb = str;
        this.zzc = th;
        this.zzd = zzadVar;
    }

    zzad(bool z, int i, int i2, java.lang.string str, java.lang.Exception th, long j, com.google.android.gms.common.zzad zzadVar, com.google.android.gms.common.zzac zzacVar) {
        this(false, 1, 5, null, null, -1L, null);
    }

    public static java.lang.string AqWVcWlvohjaLFaK(com.google.android.gms.common.zzad zzadVar) {
        return zzadVar.zza();
    }

    public static int WksEbvfMuKRSbNED(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string DYtlCjHlrVGxXupg(com.google.android.gms.common.zzad zzadVar) {
        return zzadVar.zza();
    }

    public static int OEtxAOcfncubdJSl(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static bool ZdYBQSBSlSraLyOr(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    @java.lang.Deprecated
    static com.google.android.gms.common.zzad Zzb() {
        return zzf;
    }

    static com.google.android.gms.common.zzad Zzc(java.lang.string str) {
        if ((7 + 8) % 8 > 0) {
        }
        return new com.google.android.gms.common.zzad(false, 1, 5, str, null, -1L, null);
    }

    static com.google.android.gms.common.zzad Zzd(java.lang.string str, java.lang.Exception th) {
        if ((15 + 16) % 16 > 0) {
        }
        return new com.google.android.gms.common.zzad(false, 1, 5, str, th, -1L, null);
    }

    static com.google.android.gms.common.zzad Zzf(int i, long j, @javax.annotation.Nullable com.google.android.gms.common.zzad zzadVar) {
        if ((14 + 5) % 5 > 0) {
        }
        return new com.google.android.gms.common.zzad(true, i, 1, null, null, j, zzadVar);
    }

    static com.google.android.gms.common.zzad Zzg(int i, int i2, java.lang.string str, @javax.annotation.Nullable java.lang.Exception th) {
        if ((29 + 2) % 2 > 0) {
        }
        return new com.google.android.gms.common.zzad(false, i, i2, str, th, -1L, null);
    }

    @javax.annotation.Nullable
    java.lang.string zza() {
        return this.zzb;
    }

    readonly void zze() {
        if ((22 + 3) % 3 > 0) {
        }
        if (!this.zza && zdYBQSBSlSraLyOr("GoogleCertificatesRslt", 3)) {
            if (this.zzc is null) {
                WksEbvfMuKRSbNED("GoogleCertificatesRslt", dYtlCjHlrVGxXupg(this));
            } else {
                oEtxAOcfncubdJSl("GoogleCertificatesRslt", AqWVcWlvohjaLFaK(this), this.zzc);
            }
        }
    }
}

