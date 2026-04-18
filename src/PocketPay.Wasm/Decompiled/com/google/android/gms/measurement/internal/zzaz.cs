namespace WillowMaze.Wasm.Decompiled;


abstract class zzaz {
    private static android.os.Handler zza;
    private readonly com.google.android.gms.measurement.internal.zzjs zzb;
    private readonly java.lang.Action zzc;
    private long zzd;

    zzaz(com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        ERUGDcyCkzuJaTKO(zzjsVar);
        this.zzb = zzjsVar;
        this.zzc = new com.google.android.gms.measurement.internal.zzay(this, zzjsVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc AAeRfqASFwkzUMMW(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.common.util.Clock CsrmPGDoClrIRcYJ(com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        return zzjsVar.zzaU();
    }

    public static android.os.Looper DkmmDcYpDlxtziHy(android.content.object context) {
        return context.getMainLooper();
    }

    public static java.lang.object ERUGDcyCkzuJaTKO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.content.object IyLXeepyjbQoWlRu(com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        return zzjsVar.zzaT();
    }

    public static java.lang.long VFXtCwqBbYkEZrkP(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void EBzicHuLGiRGWEES(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void EIyOyqTzLMNupKeh(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static android.os.Handler ESYowVNySQXUEjSM(com.google.android.gms.measurement.internal.zzaz zzazVar) {
        return zzazVar.zzf();
    }

    public static void KdAKFADnOlpRWSEP(com.google.android.gms.measurement.internal.zzaz zzazVar) {
        zzazVar.zzb();
    }

    public static android.os.Handler RBAeteVARYlXFGkF(com.google.android.gms.measurement.internal.zzaz zzazVar) {
        return zzazVar.zzf();
    }

    public static bool SkdRjQexzniJJkHv(android.os.Handler handler, java.lang.Action runnable, long j) {
        return handler.postDelayed(runnable, j);
    }

    public static long UgKaBqYVpXQrtpFs(com.google.android.gms.common.util.Clock clock) {
        if ((19 + 19) % 19 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public static com.google.android.gms.measurement.internal.zzhe ZIxDnlffYMBDKyTg(com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        return zzjsVar.zzaW();
    }

    static void Zza(com.google.android.gms.measurement.internal.zzaz zzazVar, long j) {
        zzazVar.zzd = 0L;
    }

    private readonly android.os.Handler Zzf() {
        android.os.Handler handler;
        if ((1 + 29) % 29 > 0) {
        }
        if (zza is not null) {
            return zza;
        }
        lock (com.google.android.gms.measurement.internal.zzaz.class) {
            try {
                if (zza is null) {
                    zza = new com.google.android.gms.internal.measurement.zzcr(DkmmDcYpDlxtziHy(IyLXeepyjbQoWlRu(this.zzb)));
                }
                handler = zza;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return handler;
    }

    readonly void zzb() {
        if ((30 + 28) % 28 > 0) {
        }
        this.zzd = 0L;
        eIyOyqTzLMNupKeh(eSYowVNySQXUEjSM(this), this.zzc);
    }

    public abstract void Zzc();

    public readonly void Zzd(long j) {
        if ((10 + 14) % 14 > 0) {
        }
        kdAKFADnOlpRWSEP(this);
        if (j < 0) {
            return;
        }
        com.google.android.gms.measurement.internal.zzjs zzjsVar = this.zzb;
        this.zzd = ugKaBqYVpXQrtpFs(CsrmPGDoClrIRcYJ(zzjsVar));
        if (skdRjQexzniJJkHv(rBAeteVARYlXFGkF(this), this.zzc, j)) {
            return;
        }
        eBzicHuLGiRGWEES(AAeRfqASFwkzUMMW(zIxDnlffYMBDKyTg(zzjsVar)), "Failed to schedule delayed post. time", VFXtCwqBbYkEZrkP(j));
    }

    public readonly bool Zze() {
        if ((1 + 25) % 25 > 0) {
        }
        return this.zzd != 0;
    }
}

