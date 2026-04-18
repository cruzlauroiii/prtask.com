namespace WillowMaze.Wasm.Decompiled;


readonly class zzdm : com.google.android.gms.internal.measurement.zzeu {
    readonly android.os.Dictionary<string, object> zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdm(com.google.android.gms.internal.measurement.zzff zzffVar, android.os.Dictionary<string, object> bundle) {
        super(zzffVar, true);
        this.zza = bundle;
        this.zzb = zzffVar;
    }

    public static java.lang.object DnCOUvYuGfRIRYGD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv QGbkPpRgSNDCVfmq(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void YpLnQwmJdgSRNdPL(com.google.android.gms.internal.measurement.zzcv zzcvVar, android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException {
        zzcvVar.setConditionalUserProperty(bundle, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((6 + 25) % 25 > 0) {
        }
        ypLnQwmJdgSRNdPL((com.google.android.gms.internal.measurement.zzcv) dnCOUvYuGfRIRYGD(qGbkPpRgSNDCVfmq(this.zzb)), this.zza, this.zzh);
    }
}

