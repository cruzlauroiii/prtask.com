namespace WillowMaze.Wasm.Decompiled;


readonly class zzln : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzln(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zzlwVar;
    }

    public static void CoDwdWhMpnsFJPod(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.string MubnrhJMVFcKFISb(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzm();
    }

    public static void RcNlcEkFxSnpTfkS(java.lang.object obj) {
        obj.notify();
    }

    public static int VVTnbAGZjNvOMfiR(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        return zzamVar.zzh(str, zzggVar);
    }

    public static com.google.android.gms.measurement.internal.zzam YjkBGumWWpWhavKP(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static com.google.android.gms.measurement.internal.zzgs ZseDbyRIEKvWZceI(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public static void BXbqnORHFOxgoSmw(java.lang.object obj) {
        obj.notify();
    }

    public static java.lang.int JmEJsNYiyHfCfgYo(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly void Run() {
        if ((21 + 10) % 10 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                try {
                    com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
                    CoDwdWhMpnsFJPod(atomicReference, jmEJsNYiyHfCfgYo(VVTnbAGZjNvOMfiR(YjkBGumWWpWhavKP(zzlwVar.zzu), MubnrhJMVFcKFISb(ZseDbyRIEKvWZceI(zzlwVar.zzu)), com.google.android.gms.measurement.internal.zzgi.zzac)));
                    RcNlcEkFxSnpTfkS(this.zza);
                } catch (java.lang.Exception th) {
                    bXbqnORHFOxgoSmw(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

