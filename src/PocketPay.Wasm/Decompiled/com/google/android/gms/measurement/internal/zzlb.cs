namespace WillowMaze.Wasm.Decompiled;


readonly class zzlb : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzlb(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zzlwVar;
    }

    public static com.google.android.gms.measurement.internal.zzgs CutdiacGkRZkKhLM(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public static void FUFUdvjZWednYWxT(java.lang.object obj) {
        obj.notify();
    }

    public static void FrjpvhsPipgvqasA(java.lang.object obj) {
        obj.notify();
    }

    public static bool AzdnLUJaQxaxeZhH(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        return zzamVar.zzx(str, zzggVar);
    }

    public static java.lang.string CyDziUmzRNNSWwLg(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzm();
    }

    public static java.lang.bool KzmxQDvcFXEMEpOk(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static com.google.android.gms.measurement.internal.zzam PmqPwdVmotkieUua(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void QxdjNqMuFZdXsstP(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public override readonly void Run() {
        if ((6 + 24) % 24 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                try {
                    com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
                    qxdjNqMuFZdXsstP(atomicReference, kzmxQDvcFXEMEpOk(azdnLUJaQxaxeZhH(pmqPwdVmotkieUua(zzlwVar.zzu), cyDziUmzRNNSWwLg(CutdiacGkRZkKhLM(zzlwVar.zzu)), com.google.android.gms.measurement.internal.zzgi.zzZ)));
                    FrjpvhsPipgvqasA(this.zza);
                } catch (java.lang.Exception th) {
                    FUFUdvjZWednYWxT(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

