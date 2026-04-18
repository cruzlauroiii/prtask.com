namespace WillowMaze.Wasm.Decompiled;


readonly class zzel : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzel(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static java.lang.object AHkTthIPsZQaepZZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv HtvKdypNlhuHRfRX(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void ZqPSGTsnoOyMnDMW(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static void TcRhQxttcwOymeeS(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getSessionId(zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        tcRhQxttcwOymeeS((com.google.android.gms.internal.measurement.zzcv) AHkTthIPsZQaepZZ(HtvKdypNlhuHRfRX(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        ZqPSGTsnoOyMnDMW(this.zza, null);
    }
}

