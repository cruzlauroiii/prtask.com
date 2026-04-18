namespace WillowMaze.Wasm.Decompiled;


readonly class zzdp : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdp(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = zzffVar;
    }

    public static void EaXjCMNEUingNFob(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, long j) throws android.os.RemoteException {
        zzcvVar.setUserId(str, j);
    }

    public static java.lang.object YUeiQQCHgXCuuRQm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv WVoArnOATUirhcAY(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((20 + 21) % 21 > 0) {
        }
        EaXjCMNEUingNFob((com.google.android.gms.internal.measurement.zzcv) YUeiQQCHgXCuuRQm(wVoArnOATUirhcAY(this.zzb)), this.zza, this.zzh);
    }
}

