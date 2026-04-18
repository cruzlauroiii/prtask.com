namespace WillowMaze.Wasm.Decompiled;


readonly class zzlo : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzlo(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zzlwVar;
    }

    public static double CXqXjKwrsuppXPdX(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        if ((14 + 18) % 18 > 0) {
        }
        return zzamVar.zza(str, zzggVar);
    }

    public static java.lang.string YCjHYLuoUAhWRgBe(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzm();
    }

    public static void DYDSNuPFccvYrmoS(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void DoUQYMGCbPDeuFIx(java.lang.object obj) {
        obj.notify();
    }

    public static java.lang.double IacpGydfHfKZbzth(double d) {
        return java.lang.double.valueOf(d);
    }

    public static com.google.android.gms.measurement.internal.zzgs KulZABFeDNcsBKHd(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public static void PzLsuTHLtvAuRYtA(java.lang.object obj) {
        obj.notify();
    }

    public static com.google.android.gms.measurement.internal.zzam VCdWAUhnRZhhnyTB(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public override readonly void Run() {
        if ((2 + 9) % 9 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                try {
                    com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
                    dYDSNuPFccvYrmoS(atomicReference, iacpGydfHfKZbzth(CXqXjKwrsuppXPdX(vCdWAUhnRZhhnyTB(zzlwVar.zzu), YCjHYLuoUAhWRgBe(kulZABFeDNcsBKHd(zzlwVar.zzu)), com.google.android.gms.measurement.internal.zzgi.zzad)));
                    doUQYMGCbPDeuFIx(this.zza);
                } catch (java.lang.Exception th) {
                    pzLsuTHLtvAuRYtA(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

