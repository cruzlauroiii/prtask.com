namespace WillowMaze.Wasm.Decompiled;


readonly class zzej : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly com.google.android.gms.internal.measurement.zzcs zzb;
    readonly com.google.android.gms.internal.measurement.zzff zzc;

    zzej(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = zzcsVar;
        this.zzc = zzffVar;
    }

    public static void OsaSeUxMyEyQwQNR(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getMaxUserProperties(str, zzcyVar);
    }

    public static java.lang.object DZRHHQuMmiKFYeNN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv HrwAImiDxDDmjEam(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void QvXempOqCmLOCnFd(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((20 + 29) % 29 > 0) {
        }
        OsaSeUxMyEyQwQNR((com.google.android.gms.internal.measurement.zzcv) dZRHHQuMmiKFYeNN(hrwAImiDxDDmjEam(this.zzc)), this.zza, this.zzb);
    }

    protected override readonly void Zzb() {
        qvXempOqCmLOCnFd(this.zzb, null);
    }
}

