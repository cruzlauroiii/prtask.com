namespace WillowMaze.Wasm.Decompiled;


readonly class zzec : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzec(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static java.lang.object HtiiTkbUQsKYffYS(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv KnmVRdKZJWqMKVVN(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void MvorAfIivvaYWZIE(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static void YDfYFtXLvdygwRTL(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.generateEventId(zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        yDfYFtXLvdygwRTL((com.google.android.gms.internal.measurement.zzcv) HtiiTkbUQsKYffYS(KnmVRdKZJWqMKVVN(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        MvorAfIivvaYWZIE(this.zza, null);
    }
}

