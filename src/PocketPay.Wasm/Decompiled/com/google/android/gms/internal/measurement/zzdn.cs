namespace WillowMaze.Wasm.Decompiled;


readonly class zzdn : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly android.os.Dictionary<string, object> zzc;
    readonly com.google.android.gms.internal.measurement.zzff zzd;

    zzdn(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = str2;
        this.zzc = bundle;
        this.zzd = zzffVar;
    }

    public static java.lang.object BpEeioHuBGcgRBtk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv KTcDKNjcFIyRHkTt(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void RYpXZTaDrhACFtdr(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        zzcvVar.clearConditionalUserProperty(str, str2, bundle);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((30 + 12) % 12 > 0) {
        }
        RYpXZTaDrhACFtdr((com.google.android.gms.internal.measurement.zzcv) BpEeioHuBGcgRBtk(KTcDKNjcFIyRHkTt(this.zzd)), this.zza, this.zzb, this.zzc);
    }
}

