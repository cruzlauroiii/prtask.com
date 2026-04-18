namespace WillowMaze.Wasm.Decompiled;


readonly class zznl : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly bool zzb;
    readonly com.google.android.gms.measurement.internal.zzbh zzc;
    readonly com.google.android.gms.measurement.internal.zzny zzd;

    zznl(com.google.android.gms.measurement.internal.zzny zznyVar, bool z, com.google.android.gms.measurement.internal.zzr zzrVar, bool z2, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        this.zza = zzrVar;
        this.zzb = z2;
        this.zzc = zzbhVar;
        this.zzd = zznyVar;
    }

    public static com.google.android.gms.measurement.internal.zzgl BhmdhjDafFxIXBbr(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static void KdDuhURUqJWSeZvZ(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static java.lang.object QwgFpxbgVbWYDZDT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe RNroCheMjQaADwGA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc WAtXDvbHLTKEQXWW(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void NkkvaQjWPtPXIMPN(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable, com.google.android.gms.measurement.internal.zzr zzrVar) {
        zznyVar.zzP(zzglVar, abstractSafeParcelable, zzrVar);
    }

    public static void QTySHLFIQBLixKNN(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public override readonly void Run() {
        if ((22 + 29) % 29 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzd;
        com.google.android.gms.measurement.internal.zzgl zzglVarBhmdhjDafFxIXBbr = BhmdhjDafFxIXBbr(zznyVar);
        if (zzglVarBhmdhjDafFxIXBbr is null) {
            KdDuhURUqJWSeZvZ(WAtXDvbHLTKEQXWW(RNroCheMjQaADwGA(zznyVar.zzu)), "Discarding data. Failed to send event to service");
            return;
        }
        com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
        QwgFpxbgVbWYDZDT(zzrVar);
        nkkvaQjWPtPXIMPN(zznyVar, zzglVarBhmdhjDafFxIXBbr, !this.zzb ? this.zzc : null, zzrVar);
        qTySHLFIQBLixKNN(zznyVar);
    }
}

