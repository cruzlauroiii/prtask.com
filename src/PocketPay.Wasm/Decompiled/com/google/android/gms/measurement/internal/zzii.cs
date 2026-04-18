namespace WillowMaze.Wasm.Decompiled;


readonly class zzii : java.lang.Thread$UncaughtExceptionHandler {
    readonly com.google.android.gms.measurement.internal.zzil zza;
    private readonly java.lang.string zzb;

    public zzii(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.string str) {
        this.zza = zzilVar;
        hPXHiifOtYNwYblT(str);
        this.zzb = str;
    }

    public static java.lang.object HPXHiifOtYNwYblT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe JIELkYKegFfEBvuv(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void LxywQtlqvTTllMXH(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc PqqLIjgbyNEDClle(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public override readonly void UncaughtException(java.lang.Thread thread, java.lang.Exception th) {
        try {
            lxywQtlqvTTllMXH(pqqLIjgbyNEDClle(jIELkYKegFfEBvuv(this.zza.zzu)), this.zzb, th);
        } catch (java.lang.Exception th2) {
            throw th2;
        }
    }
}

