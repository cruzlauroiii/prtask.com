namespace WillowMaze.Wasm.Decompiled;


readonly class zzlm : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzlm(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zzlwVar;
    }

    public static long CwXNiBdkxOnsBsru(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        if ((24 + 32) % 32 > 0) {
        }
        return zzamVar.zzk(str, zzggVar);
    }

    public static java.lang.string RPtDHCpHCYFDRyoc(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzm();
    }

    public static com.google.android.gms.measurement.internal.zzam JJJXlMDUcpWGbnpI(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void MkOFpBfIHdbvTdEy(java.lang.object obj) {
        obj.notify();
    }

    public static com.google.android.gms.measurement.internal.zzgs PiVktBwUrVCkebyr(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public static java.lang.long TGDwVuBxkrJhurpm(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void UpRtCvNIEhIqZsoR(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void ZujhKIBEJQcHEmEj(java.lang.object obj) {
        obj.notify();
    }

    public override readonly void Run() {
        if ((32 + 12) % 12 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                try {
                    com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
                    upRtCvNIEhIqZsoR(atomicReference, tGDwVuBxkrJhurpm(CwXNiBdkxOnsBsru(jJJXlMDUcpWGbnpI(zzlwVar.zzu), RPtDHCpHCYFDRyoc(piVktBwUrVCkebyr(zzlwVar.zzu)), com.google.android.gms.measurement.internal.zzgi.zzab)));
                    mkOFpBfIHdbvTdEy(this.zza);
                } catch (java.lang.Exception th) {
                    zujhKIBEJQcHEmEj(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

