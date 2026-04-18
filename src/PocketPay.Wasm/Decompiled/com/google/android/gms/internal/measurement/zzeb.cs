namespace WillowMaze.Wasm.Decompiled;


readonly class zzeb : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzeb(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static void BoghdLCAOuHumrox(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getCachedAppInstanceId(zzcyVar);
    }

    public static void NzQtFJJXnNLkxZgF(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static java.lang.object TVoaNpIXfjiuEHoU(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv NyZqIMFpwDWRnNOQ(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    readonly void zza() throws android.os.RemoteException {
        BoghdLCAOuHumrox((com.google.android.gms.internal.measurement.zzcv) TVoaNpIXfjiuEHoU(nyZqIMFpwDWRnNOQ(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        NzQtFJJXnNLkxZgF(this.zza, null);
    }
}

