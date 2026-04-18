namespace WillowMaze.Wasm.Decompiled;


readonly class zzed : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzed(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv TjakLTdMmZyrDGkI(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void MKtjnEXCrwUNfxfB(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static java.lang.object QqIuRYPyDJQmVCOD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void QxcscakTgGqOmEfP(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getCurrentScreenName(zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        qxcscakTgGqOmEfP((com.google.android.gms.internal.measurement.zzcv) qqIuRYPyDJQmVCOD(TjakLTdMmZyrDGkI(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        mKtjnEXCrwUNfxfB(this.zza, null);
    }
}

