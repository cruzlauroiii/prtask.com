namespace WillowMaze.Wasm.Decompiled;


readonly class zzek : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzek(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = zzffVar;
    }

    public static java.lang.object BdKFuogHKauANItF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv MJWflmAKMqpVrgRd(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void QhETLJqpLUOUxhZR(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static void SKteZBpXronXsbPd(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getAppInstanceId(zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        sKteZBpXronXsbPd((com.google.android.gms.internal.measurement.zzcv) BdKFuogHKauANItF(MJWflmAKMqpVrgRd(this.zzb)), this.zza);
    }

    protected override readonly void Zzb() {
        qhETLJqpLUOUxhZR(this.zza, null);
    }
}

