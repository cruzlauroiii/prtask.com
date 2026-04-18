namespace WillowMaze.Wasm.Decompiled;


readonly class zzoe : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzpv zza;
    readonly java.lang.Action zzb;

    zzoe(com.google.android.gms.measurement.internal.zzog zzogVar, com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.Action runnable) {
        this.zza = zzpvVar;
        this.zzb = runnable;
    }

    public override readonly void Run() {
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zza;
        zzpvVar.zzL();
        zzpvVar.zzK(this.zzb);
        zzpvVar.zzat();
    }
}

