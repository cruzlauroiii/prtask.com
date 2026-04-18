namespace WillowMaze.Wasm.Decompiled;


readonly class zzeq : com.google.android.gms.internal.measurement.zzeu {
    readonly android.content.object zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzeq(com.google.android.gms.internal.measurement.zzff zzffVar, android.content.object intent) {
        super(zzffVar, true);
        this.zza = intent;
        this.zzb = zzffVar;
    }

    public static java.lang.object CwVZzhrhYQwLXLLL(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void MemnPuuYxXEMcmFe(com.google.android.gms.internal.measurement.zzcv zzcvVar, android.content.object intent) throws android.os.RemoteException {
        zzcvVar.setSgtmDebugInfo(intent);
    }

    public static com.google.android.gms.internal.measurement.zzcv EzPHAzuyYsuYSsFG(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    readonly void zza() throws android.os.RemoteException {
        MemnPuuYxXEMcmFe((com.google.android.gms.internal.measurement.zzcv) CwVZzhrhYQwLXLLL(ezPHAzuyYsuYSsFG(this.zzb)), this.zza);
    }
}

