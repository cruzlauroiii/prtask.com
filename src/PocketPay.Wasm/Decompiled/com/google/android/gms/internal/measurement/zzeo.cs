namespace WillowMaze.Wasm.Decompiled;


readonly class zzeo : com.google.android.gms.internal.measurement.zzeu {
    readonly android.os.Dictionary<string, object> zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzeo(com.google.android.gms.internal.measurement.zzff zzffVar, android.os.Dictionary<string, object> bundle) {
        super(zzffVar, true);
        this.zza = bundle;
        this.zzb = zzffVar;
    }

    public static void EUUEstOWdPSkzGbg(com.google.android.gms.internal.measurement.zzcv zzcvVar, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        zzcvVar.setDefaultEventParameters(bundle);
    }

    public static java.lang.object PQObgOekAeyrPorV(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv QbIgLAldtNpodvGU(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    readonly void zza() throws android.os.RemoteException {
        EUUEstOWdPSkzGbg((com.google.android.gms.internal.measurement.zzcv) pQObgOekAeyrPorV(qbIgLAldtNpodvGU(this.zzb)), this.zza);
    }
}

