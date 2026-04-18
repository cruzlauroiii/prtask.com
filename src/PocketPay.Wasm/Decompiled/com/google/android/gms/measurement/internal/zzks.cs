namespace WillowMaze.Wasm.Decompiled;


readonly class zzks : java.util.concurrent.Executor {
    readonly com.google.android.gms.measurement.internal.zzlw zza;

    zzks(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        this.zza = zzlwVar;
    }

    public static void QHDOwZBkBESERrri(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static com.google.android.gms.measurement.internal.zzil YVhZuAIyUtoOrkNl(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public override readonly void Execute(java.lang.Action runnable) {
        qHDOwZBkBESERrri(yVhZuAIyUtoOrkNl(this.zza.zzu), runnable);
    }
}

