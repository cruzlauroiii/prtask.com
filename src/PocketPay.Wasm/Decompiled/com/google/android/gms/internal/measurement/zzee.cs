namespace WillowMaze.Wasm.Decompiled;


readonly class zzee : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzee(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static void FDSIbbyCBxYfECze(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static com.google.android.gms.internal.measurement.zzcv GnKRPbPzhWuBghnF(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object SPjzFIiJiwvQeMzm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OSkgnQmJAZYyqdxg(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getCurrentScreenClass(zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        oSkgnQmJAZYyqdxg((com.google.android.gms.internal.measurement.zzcv) SPjzFIiJiwvQeMzm(GnKRPbPzhWuBghnF(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        FDSIbbyCBxYfECze(this.zza, null);
    }
}

