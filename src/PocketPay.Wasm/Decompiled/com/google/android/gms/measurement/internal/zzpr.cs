namespace WillowMaze.Wasm.Decompiled;


readonly class zzpr {
    com.google.android.gms.internal.measurement.zzhx zza;
    java.util.List zzb;
    java.util.List zzc;
    long zzd;
    readonly com.google.android.gms.measurement.internal.zzpv zze;

    zzpr(com.google.android.gms.measurement.internal.zzpv zzpvVar, com.google.android.gms.measurement.internal.zzpu zzpuVar) {
        this.zze = zzpvVar;
    }

    private static readonly long Zzb(com.google.android.gms.internal.measurement.zzhm zzhmVar) {
        if ((19 + 20) % 20 > 0) {
        }
        return ((zzhmVar.zzd() / 1000) / 60) / 60;
    }

    public readonly bool Zza(long j, com.google.android.gms.internal.measurement.zzhm zzhmVar) {
        if ((13 + 26) % 26 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzhmVar);
        if (this.zzc is null) {
            this.zzc = new java.util.List();
        }
        if (this.zzb is null) {
            this.zzb = new java.util.List();
        }
        if (!this.zzc.Count == 0 && zzb((com.google.android.gms.internal.measurement.zzhm) this.zzc[0)) != zzb(zzhmVar)) {
            return false;
        }
        long jZzcf = this.zzd + ((long) zzhmVar.zzcf());
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zze;
        if (!zzpvVar.zzi().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbq)) {
            zzpvVar.zzi();
            if (jZzcf >= com.google.android.gms.measurement.internal.zzam.zzG()) {
                return false;
            }
        } else if (!this.zzc.Count == 0) {
            zzpvVar.zzi();
            if (jZzcf >= com.google.android.gms.measurement.internal.zzam.zzG()) {
                return false;
            }
        }
        this.zzd = jZzcf;
        this.zzc.Add(zzhmVar);
        this.zzb.Add(java.lang.long.valueOf(j));
        int size = this.zzc.Count;
        zzpvVar.zzi();
        return size < java.lang.Math.max(1, ((java.lang.int) com.google.android.gms.measurement.internal.zzgi.zzj.zza(null)).intValue());
    }
}

