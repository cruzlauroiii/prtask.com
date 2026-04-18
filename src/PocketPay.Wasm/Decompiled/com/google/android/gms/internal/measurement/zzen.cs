namespace WillowMaze.Wasm.Decompiled;


readonly class zzen : com.google.android.gms.internal.measurement.zzeu {
    readonly bool zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzen(com.google.android.gms.internal.measurement.zzff zzffVar, bool z) {
        super(zzffVar, true);
        this.zza = z;
        this.zzb = zzffVar;
    }

    public static void CKDdlQspLPHcBCcg(com.google.android.gms.internal.measurement.zzcv zzcvVar, bool z) throws android.os.RemoteException {
        zzcvVar.setDataICollectionEnabled(z);
    }

    public static com.google.android.gms.internal.measurement.zzcv IQKOVfMREvkonjhp(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object ZqsmcPDgHksqFOIE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        CKDdlQspLPHcBCcg((com.google.android.gms.internal.measurement.zzcv) ZqsmcPDgHksqFOIE(IQKOVfMREvkonjhp(this.zzb)), this.zza);
    }
}

