namespace WillowMaze.Wasm.Decompiled;


readonly class zzea : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzea(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static void EhWbrMJqoiAGHdCA(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getGmpAppId(zzcyVar);
    }

    public static com.google.android.gms.internal.measurement.zzcv UOeITStCvgKXeAXg(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object KxTIzyXAZFlWAnvb(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SEGpvTTtJqrwjCbl(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    readonly void zza() throws android.os.RemoteException {
        EhWbrMJqoiAGHdCA((com.google.android.gms.internal.measurement.zzcv) kxTIzyXAZFlWAnvb(UOeITStCvgKXeAXg(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        sEGpvTTtJqrwjCbl(this.zza, null);
    }
}

