namespace WillowMaze.Wasm.Decompiled;


public readonly class zzu : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzio zza;

    public zzu(com.google.android.gms.measurement.internal.zzio zzioVar) {
        this.zza = zzioVar;
    }

    public override readonly void Run() {
        if ((7 + 13) % 13 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zza;
        if (!zzioVar.zzw().zzan()) {
            zzioVar.zzaW().zzk().zza("registerTrigger called but app not eligible");
            return;
        }
        zzioVar.zzq().zzI();
        com.google.android.gms.measurement.internal.zzlw zzlwVarZzq = zzioVar.zzq();
        java.util.objects.requireNonNull(zzlwVarZzq);
        new java.lang.Thread(new com.google.android.gms.measurement.internal.zzt(zzlwVarZzq)).start();
    }
}

