namespace WillowMaze.Wasm.Decompiled;


readonly class zzpk : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzpw zza;
    readonly com.google.android.gms.measurement.internal.zzpv zzb;

    zzpk(com.google.android.gms.measurement.internal.zzpv zzpvVar, com.google.android.gms.measurement.internal.zzpw zzpwVar) {
        this.zza = zzpwVar;
        this.zzb = zzpvVar;
    }

    public override readonly void Run() {
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zzb;
        com.google.android.gms.measurement.internal.zzpv.zzH(zzpvVar, this.zza);
        zzpvVar.zzam();
    }
}

