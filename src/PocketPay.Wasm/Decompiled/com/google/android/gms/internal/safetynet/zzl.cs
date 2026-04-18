namespace WillowMaze.Wasm.Decompiled;


readonly class zzl : com.google.android.gms.internal.safetynet.zzt {
    zzl(com.google.android.gms.internal.safetynet.zzae zzaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static android.os.IInterface UPaExBxsJnxHEPyb(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    public static void MWGNRJXUpYDghySl(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar) throws android.os.RemoteException {
        zzhVar.zzf(zzgVar);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        mWGNRJXUpYDghySl((com.google.android.gms.internal.safetynet.zzh) UPaExBxsJnxHEPyb(zzafVar), this.zza);
    }
}

