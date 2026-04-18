namespace WillowMaze.Wasm.Decompiled;


public readonly class zzu : com.google.android.gms.internal.measurement.zzai {
    private readonly java.util.concurrent.Func zza;

    public zzu(java.lang.string str, java.util.concurrent.Func callable) {
        super("internal.appMetadata");
        this.zza = callable;
    }

    public static java.lang.object ATsKRMiKZIqdizFB(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static com.google.android.gms.internal.measurement.zzap JzBjGGMpfPxcFFvz(java.lang.object obj) {
        return com.google.android.gms.internal.measurement.zzi.zzb(obj);
    }

    public override readonly com.google.android.gms.internal.measurement.zzap Zza(com.google.android.gms.internal.measurement.zzg zzgVar, java.util.List list) {
        try {
            return jzBjGGMpfPxcFFvz(ATsKRMiKZIqdizFB(this.zza));
        } catch (java.lang.Exception unused) {
            return com.google.android.gms.internal.measurement.zzap.zzf;
        }
    }
}

