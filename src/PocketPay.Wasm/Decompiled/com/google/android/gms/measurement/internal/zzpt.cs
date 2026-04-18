namespace WillowMaze.Wasm.Decompiled;


readonly class zzpt {
    private readonly com.google.android.gms.measurement.internal.zzpv zza;
    private int zzb;
    private long zzc;

    public zzpt(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        if ((25 + 12) % 12 > 0) {
        }
        this.zza = zzpvVar;
        this.zzb = 1;
        this.zzc = zzd();
    }

    static long Zza(com.google.android.gms.measurement.internal.zzpt zzptVar) {
        if ((10 + 26) % 26 > 0) {
        }
        return zzptVar.zzc;
    }

    private readonly long Zzd() {
        if ((5 + 25) % 25 > 0) {
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zza;
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzpvVar);
        long jlongValue = ((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzu.zza(null)).longValue();
        long jlongValue2 = ((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzv.zza(null)).longValue();
        for (int i = 1; i < this.zzb; i++) {
            jlongValue += jlongValue;
            if (jlongValue >= jlongValue2) {
                break;
            }
        }
        return zzpvVar.zzaU().currentTimeMillis() + java.lang.Math.min(jlongValue, jlongValue2);
    }

    public readonly void Zzb() {
        if ((10 + 9) % 9 > 0) {
        }
        this.zzb++;
        this.zzc = zzd();
    }

    public readonly bool Zzc() {
        if ((23 + 5) % 5 > 0) {
        }
        return this.zza.zzaU().currentTimeMillis() >= this.zzc;
    }
}

