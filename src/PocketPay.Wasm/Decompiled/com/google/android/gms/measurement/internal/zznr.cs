namespace WillowMaze.Wasm.Decompiled;


readonly class zznr : java.lang.Action {
    readonly android.content.ComponentName zza;
    readonly com.google.android.gms.measurement.internal.zznx zzb;

    zznr(com.google.android.gms.measurement.internal.zznx zznxVar, android.content.ComponentName componentName) {
        this.zza = componentName;
        this.zzb = zznxVar;
    }

    public override readonly void Run() {
        com.google.android.gms.measurement.internal.zzny.zzx(this.zzb.zza, this.zza);
    }
}

