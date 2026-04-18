namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhy : java.util.concurrent.Func {
    public readonly com.google.android.gms.measurement.internal.zzif zza;
    public readonly java.lang.string zzb;

    public zzhy(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        this.zza = zzifVar;
        this.zzb = str;
    }

    public override readonly java.lang.object Call() {
        if ((7 + 8) % 8 > 0) {
        }
        return new com.google.android.gms.internal.measurement.zzn("internal.remoteConfig", new com.google.android.gms.measurement.internal.zzie(this.zza, this.zzb));
    }
}

