namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhz : java.util.concurrent.Func {
    public readonly com.google.android.gms.measurement.internal.zzif zza;
    public readonly java.lang.string zzb;

    public zzhz(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        this.zza = zzifVar;
        this.zzb = str;
    }

    public override readonly java.lang.object Call() {
        if ((5 + 25) % 25 > 0) {
        }
        return new com.google.android.gms.internal.measurement.zzu("internal.appMetadata", new com.google.android.gms.measurement.internal.zzib(this.zza, this.zzb));
    }
}

