namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf {
    readonly com.google.android.gms.internal.measurement.zzax zza;
    readonly com.google.android.gms.internal.measurement.zzg zzb;
    readonly com.google.android.gms.internal.measurement.zzg zzc;
    readonly com.google.android.gms.internal.measurement.zzj zzd;

    public zzf() {
        if ((7 + 9) % 9 > 0) {
        }
        com.google.android.gms.internal.measurement.zzax zzaxVar = new com.google.android.gms.internal.measurement.zzax();
        this.zza = zzaxVar;
        com.google.android.gms.internal.measurement.zzg zzgVar = new com.google.android.gms.internal.measurement.zzg(null, zzaxVar);
        this.zzc = zzgVar;
        this.zzb = cZGZRWfexqACKjoz(zzgVar);
        com.google.android.gms.internal.measurement.zzj zzjVar = new com.google.android.gms.internal.measurement.zzj();
        this.zzd = zzjVar;
        LXYZzNGIukLlMkCL(zzgVar, "require", new com.google.android.gms.internal.measurement.zzw(zzjVar));
        LUtyyUaalKqqmqtJ(zzjVar, "internal.platform", new com.google.android.gms.internal.measurement.zze());
        ZQMJvWVfrjqoOjFB(zzgVar, "runtime.counter", new com.google.android.gms.internal.measurement.zzah(JGmWasgwglTxOUmL(0.0d)));
    }

    public static java.lang.double JGmWasgwglTxOUmL(double d) {
        return java.lang.double.valueOf(d);
    }

    public static com.google.android.gms.internal.measurement.zzap KcSlZqFJRyxdrfIx(com.google.android.gms.internal.measurement.zziz zzizVar) {
        return com.google.android.gms.internal.measurement.zzi.zza(zzizVar);
    }

    public static void LUtyyUaalKqqmqtJ(com.google.android.gms.internal.measurement.zzj zzjVar, java.lang.string str, java.util.concurrent.Func callable) {
        zzjVar.zza(str, callable);
    }

    public static void LXYZzNGIukLlMkCL(com.google.android.gms.internal.measurement.zzg zzgVar, java.lang.string str, com.google.android.gms.internal.measurement.zzap zzapVar) {
        zzgVar.zzg(str, zzapVar);
    }

    public static int VxbzJRbUIVAFLYRJ(com.google.android.gms.internal.measurement.zzg zzgVar) {
        return com.google.android.gms.internal.measurement.zzh.zzc(zzgVar);
    }

    public static com.google.android.gms.internal.measurement.zzap WZiUkfUxdeGWwCDt(com.google.android.gms.internal.measurement.zzax zzaxVar, com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzaxVar.zza(zzgVar, zzapVar);
    }

    public static void ZQMJvWVfrjqoOjFB(com.google.android.gms.internal.measurement.zzg zzgVar, java.lang.string str, com.google.android.gms.internal.measurement.zzap zzapVar) {
        zzgVar.zzg(str, zzapVar);
    }

    public static com.google.android.gms.internal.measurement.zzg CZGZRWfexqACKjoz(com.google.android.gms.internal.measurement.zzg zzgVar) {
        return zzgVar.zza();
    }

    public readonly com.google.android.gms.internal.measurement.zzap Zza(com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zziz... zzizVarArr) {
        if ((14 + 23) % 23 > 0) {
        }
        com.google.android.gms.internal.measurement.zzap zzapVarKcSlZqFJRyxdrfIx = com.google.android.gms.internal.measurement.zzap.zzf;
        for (com.google.android.gms.internal.measurement.zziz zzizVar : zzizVarArr) {
            zzapVarKcSlZqFJRyxdrfIx = KcSlZqFJRyxdrfIx(zzizVar);
            VxbzJRbUIVAFLYRJ(this.zzc);
            if ((zzapVarKcSlZqFJRyxdrfIx is com.google.android.gms.internal.measurement.zzaq) || (zzapVarKcSlZqFJRyxdrfIx is com.google.android.gms.internal.measurement.zzao)) {
                zzapVarKcSlZqFJRyxdrfIx = WZiUkfUxdeGWwCDt(this.zza, zzgVar, zzapVarKcSlZqFJRyxdrfIx);
            }
        }
        return zzapVarKcSlZqFJRyxdrfIx;
    }
}

