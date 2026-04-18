namespace WillowMaze.Wasm.Decompiled;


readonly class zzll : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzll(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zzlwVar;
    }

    public static void DdIFIFCqyVvYIKEn(java.lang.object obj) {
        obj.notify();
    }

    public static void LjNeSbMUWZpiAAXE(java.lang.object obj) {
        obj.notify();
    }

    public static com.google.android.gms.measurement.internal.zzam MYLIzmgWgugWNQYb(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void SHYakVHdIZZeXzDh(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.string FcIowfqpPTjrVVxK(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzm();
    }

    public static java.lang.string PTwsItHhUwcrAhLV(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        return zzamVar.zzr(str, zzggVar);
    }

    public static com.google.android.gms.measurement.internal.zzgs PkiIIkHGGauraKwL(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public override readonly void Run() {
        if ((2 + 20) % 20 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                try {
                    com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
                    SHYakVHdIZZeXzDh(atomicReference, pTwsItHhUwcrAhLV(MYLIzmgWgugWNQYb(zzlwVar.zzu), fcIowfqpPTjrVVxK(pkiIIkHGGauraKwL(zzlwVar.zzu)), com.google.android.gms.measurement.internal.zzgi.zzaa));
                    LjNeSbMUWZpiAAXE(this.zza);
                } catch (java.lang.Exception th) {
                    DdIFIFCqyVvYIKEn(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

