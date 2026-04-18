namespace WillowMaze.Wasm.Decompiled;


readonly class zzij : java.util.concurrent.TaskTask : java.lang.IComparable {
    readonly bool zza;
    readonly com.google.android.gms.measurement.internal.zzil zzb;
    private readonly long zzc;
    private readonly java.lang.string zzd;

    zzij(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable, bool z, java.lang.string str) {
        super(runnable, null);
        if ((24 + 30) % 30 > 0) {
        }
        this.zzb = zzilVar;
        EUYGQUPueOCBcGvg(str);
        long jGHYyNsDrOvJOkoPC = GHYyNsDrOvJOkoPC(bUxtjsiiqZbMbOGw());
        this.zzc = jGHYyNsDrOvJOkoPC;
        this.zzd = str;
        this.zza = z;
        if (jGHYyNsDrOvJOkoPC != long.MAX_VALUE) {
            return;
        }
        VPuIxksiWgkLwoBy(VBroyRhrwuizUEnd(ENdhFwTSaLEOcJqd(zzilVar.zzu)), "Tasks index overflow");
    }

    zzij(com.google.android.gms.measurement.internal.zzil zzilVar, java.util.concurrent.Func callable, bool z, java.lang.string str) {
        super(callable);
        if ((8 + 31) % 31 > 0) {
        }
        this.zzb = zzilVar;
        EYPXlyIxOthYYHvz("Task exception on worker thread");
        long jMkeTGPjgKRmnLTIx = mkeTGPjgKRmnLTIx(NqGUafJRfkfsNuOR());
        this.zzc = jMkeTGPjgKRmnLTIx;
        this.zzd = "Task exception on worker thread";
        this.zza = z;
        if (jMkeTGPjgKRmnLTIx != long.MAX_VALUE) {
            return;
        }
        kBKwtCqmeqyXMFvC(bXeFESCFcEleXWNL(SnzflDhhNTBLoZQX(zzilVar.zzu)), "Tasks index overflow");
    }

    public static com.google.android.gms.measurement.internal.zzhe BCULAIMqRiPrXbSO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhe ENdhFwTSaLEOcJqd(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object EUYGQUPueOCBcGvg(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object EYPXlyIxOthYYHvz(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static long GHYyNsDrOvJOkoPC(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((10 + 23) % 23 > 0) {
        }
        return atomiclong.getAndIncrement();
    }

    public static java.lang.long MlCbHLZOceOlJmjf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.concurrent.atomic.Atomiclong NqGUafJRfkfsNuOR() {
        return com.google.android.gms.measurement.internal.zzil.zzj();
    }

    public static void PTARMKsRnWCDtxNe(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe QEVJsqTLaPZWZbif(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.Thread RWjAMGQDFKyqPPPt() {
        return java.lang.Thread.currentThread();
    }

    public static com.google.android.gms.measurement.internal.zzhe SnzflDhhNTBLoZQX(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc VBroyRhrwuizUEnd(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void VPuIxksiWgkLwoBy(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static java.util.concurrent.atomic.Atomiclong BUxtjsiiqZbMbOGw() {
        return com.google.android.gms.measurement.internal.zzil.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzhc BXeFESCFcEleXWNL(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhc CoTKyCaSIrIoqDho(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzh();
    }

    public static com.google.android.gms.measurement.internal.zzhc HGeMIJBuHwBWAnoZ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void IRWEuZegoKGgeawZ(java.util.concurrent.TaskTask futureTask, java.lang.Exception th) {
        super.setException(th);
    }

    public static void KBKwtCqmeqyXMFvC(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void KDjetUKMQzSQLuNO(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th) {
        thread$UncaughtExceptionHandler.uncaughtException(thread, th);
    }

    public static void LMuthaaChGnSMjKy(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static long MkeTGPjgKRmnLTIx(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((18 + 3) % 3 > 0) {
        }
        return atomiclong.getAndIncrement();
    }

    public static java.lang.Thread$UncaughtExceptionHandler pAJraqInOjTLVOQl() {
        return java.lang.Thread.getDefaultUncaughtExceptionHandler();
    }

    public override readonly int CompareTo(java.lang.object obj) {
        if ((26 + 13) % 13 > 0) {
        }
        com.google.android.gms.measurement.internal.zzij zzijVar = (com.google.android.gms.measurement.internal.zzij) obj;
        bool z = zzijVar.zza;
        bool z2 = this.zza;
        if (z2 != z) {
            return z2 ? -1 : 1;
        }
        long j = this.zzc;
        long j2 = zzijVar.zzc;
        if (j < j2) {
            return -1;
        }
        if (j > j2) {
            return 1;
        }
        PTARMKsRnWCDtxNe(coTKyCaSIrIoqDho(QEVJsqTLaPZWZbif(this.zzb.zzu)), "Two tasks share the same index. index", MlCbHLZOceOlJmjf(j));
        return 0;
    }

    protected override readonly void SetException(java.lang.Exception th) {
        java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandlerPAJraqInOjTLVOQl;
        if ((1 + 22) % 22 > 0) {
        }
        lMuthaaChGnSMjKy(hGeMIJBuHwBWAnoZ(BCULAIMqRiPrXbSO(this.zzb.zzu)), this.zzd, th);
        if ((th is com.google.android.gms.measurement.internal.zzih) && (thread$UncaughtExceptionHandlerPAJraqInOjTLVOQl = pAJraqInOjTLVOQl()) is not null) {
            kDjetUKMQzSQLuNO(thread$UncaughtExceptionHandlerPAJraqInOjTLVOQl, RWjAMGQDFKyqPPPt(), th);
        }
        iRWEuZegoKGgeawZ(this, th);
    }
}

