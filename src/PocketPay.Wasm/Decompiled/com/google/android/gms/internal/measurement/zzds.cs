namespace WillowMaze.Wasm.Decompiled;


readonly class zzds : com.google.android.gms.internal.measurement.zzeu {
    readonly android.os.Dictionary<string, object> zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzds(com.google.android.gms.internal.measurement.zzff zzffVar, android.os.Dictionary<string, object> bundle) {
        super(zzffVar, true);
        this.zza = bundle;
        this.zzb = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv YoRqhxONvNYoUlMI(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object DpGfCQpbacRCqXCZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void INYWsJEZtNUiIekP(com.google.android.gms.internal.measurement.zzcv zzcvVar, android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException {
        zzcvVar.setConsentThirdParty(bundle, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((28 + 31) % 31 > 0) {
        }
        iNYWsJEZtNUiIekP((com.google.android.gms.internal.measurement.zzcv) dpGfCQpbacRCqXCZ(YoRqhxONvNYoUlMI(this.zzb)), this.zza, this.zzh);
    }
}

