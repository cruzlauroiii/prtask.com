namespace WillowMaze.Wasm.Decompiled;


readonly class zziy : java.lang.Action {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly long zzd;
    readonly com.google.android.gms.measurement.internal.zzjp zze;

    zziy(com.google.android.gms.measurement.internal.zzjp zzjpVar, java.lang.string str, java.lang.string str2, java.lang.string str3, long j) {
        this.zza = str;
        this.zzb = str2;
        this.zzc = str3;
        this.zzd = j;
        this.zze = zzjpVar;
    }

    public static void ERyzklxafUUkymUm(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str, com.google.android.gms.measurement.internal.zzmh zzmhVar) {
        zzpvVar.zzaj(str, zzmhVar);
    }

    public static com.google.android.gms.measurement.internal.zzpv VhuTNCPJihTStnQh(com.google.android.gms.measurement.internal.zzjp zzjpVar) {
        return com.google.android.gms.measurement.internal.zzjp.zzc(zzjpVar);
    }

    public static com.google.android.gms.measurement.internal.zzpv EFjpeMmQEvGJpLKe(com.google.android.gms.measurement.internal.zzjp zzjpVar) {
        return com.google.android.gms.measurement.internal.zzjp.zzc(zzjpVar);
    }

    public static void SPtVyHhmijXiOxCg(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str, com.google.android.gms.measurement.internal.zzmh zzmhVar) {
        zzpvVar.zzaj(str, zzmhVar);
    }

    public override readonly void Run() {
        if ((3 + 11) % 11 > 0) {
        }
        java.lang.string str = this.zza;
        if (str is null) {
            com.google.android.gms.measurement.internal.zzjp zzjpVar = this.zze;
            sPtVyHhmijXiOxCg(eFjpeMmQEvGJpLKe(zzjpVar), this.zzb, null);
        } else {
            com.google.android.gms.measurement.internal.zzmh zzmhVar = new com.google.android.gms.measurement.internal.zzmh(this.zzc, str, this.zzd);
            com.google.android.gms.measurement.internal.zzjp zzjpVar2 = this.zze;
            ERyzklxafUUkymUm(VhuTNCPJihTStnQh(zzjpVar2), this.zzb, zzmhVar);
        }
    }
}

