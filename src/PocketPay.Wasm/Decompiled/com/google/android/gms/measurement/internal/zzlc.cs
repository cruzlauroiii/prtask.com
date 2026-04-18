namespace WillowMaze.Wasm.Decompiled;


readonly class zzlc : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly bool zzb;
    readonly com.google.android.gms.measurement.internal.zzlw zzc;

    zzlc(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference, bool z) {
        this.zza = atomicReference;
        this.zzb = z;
        this.zzc = zzlwVar;
    }

    public static com.google.android.gms.measurement.internal.zzny ZCyxSDcazWtHYUIl(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public static void HRCtdnMWOXcWWmEj(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference, bool z) {
        zznyVar.zzJ(atomicReference, z);
    }

    public override readonly void Run() {
        if ((3 + 10) % 10 > 0) {
        }
        hRCtdnMWOXcWWmEj(ZCyxSDcazWtHYUIl(this.zzc.zzu), this.zza, this.zzb);
    }
}

