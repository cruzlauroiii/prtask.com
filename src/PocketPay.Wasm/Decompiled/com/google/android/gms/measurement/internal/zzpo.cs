namespace WillowMaze.Wasm.Decompiled;


readonly class zzpo : java.util.concurrent.Func {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly com.google.android.gms.measurement.internal.zzpv zzb;

    zzpo(com.google.android.gms.measurement.internal.zzpv zzpvVar, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = zzrVar;
        this.zzb = zzpvVar;
    }

    public override readonly java.lang.object Call() throws java.lang.Exception {
        if ((2 + 8) % 8 > 0) {
        }
        com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
        java.lang.string str = (java.lang.string) com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVar.zza);
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zzb;
        com.google.android.gms.measurement.internal.zzjx zzjxVarZzu = zzpvVar.zzu(str);
        com.google.android.gms.measurement.internal.zzjw zzjwVar = com.google.android.gms.measurement.internal.zzjw.zzb;
        if (zzjxVarZzu.zzr(zzjwVar) && com.google.android.gms.measurement.internal.zzjx.zzk(zzrVar.zzu, 100).zzr(zzjwVar)) {
            return zzpvVar.zzg(zzrVar).zzD();
        }
        zzpvVar.zzaW().zzj().zza("Analytics storage consent denied. Returning null app instance id");
        return null;
    }
}

