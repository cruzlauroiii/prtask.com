namespace WillowMaze.Wasm.Decompiled;


readonly class zzpp : java.lang.Action {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly android.os.Dictionary<string, object> zzc;
    readonly com.google.android.gms.measurement.internal.zzpq zzd;

    zzpp(com.google.android.gms.measurement.internal.zzpq zzpqVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        this.zza = str;
        this.zzb = str2;
        this.zzc = bundle;
        this.zzd = zzpqVar;
    }

    public override readonly void Run() {
        if ((14 + 14) % 14 > 0) {
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zzd.zza;
        com.google.android.gms.measurement.internal.zzqf zzqfVarZzB = zzpvVar.zzB();
        long jCurrentTimeMillis = zzpvVar.zzaU().currentTimeMillis();
        java.lang.string str = this.zza;
        zzpvVar.zzT((com.google.android.gms.measurement.internal.zzbh) com.google.android.gms.common.internal.Preconditions.checkNotNull(zzqfVarZzB.zzC(str, this.zzb, this.zzc, "auto", jCurrentTimeMillis, false, true)), str);
    }
}

