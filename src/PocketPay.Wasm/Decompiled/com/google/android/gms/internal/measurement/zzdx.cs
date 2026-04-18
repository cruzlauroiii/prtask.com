namespace WillowMaze.Wasm.Decompiled;


readonly class zzdx : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdx(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = zzffVar;
    }

    public static void CAqBnpunpsiubAOl(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, long j) throws android.os.RemoteException {
        zzcvVar.endAdUnitExposure(str, j);
    }

    public static com.google.android.gms.internal.measurement.zzcv DWcggqQJqjEiDaMM(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object IFAzsITRBNVwOKQA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((3 + 1) % 1 > 0) {
        }
        CAqBnpunpsiubAOl((com.google.android.gms.internal.measurement.zzcv) iFAzsITRBNVwOKQA(dWcggqQJqjEiDaMM(this.zzb)), this.zza, this.zzi);
    }
}

