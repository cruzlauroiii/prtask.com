namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : com.google.android.gms.internal.safetynet.zzt {
    zzm(com.google.android.gms.internal.safetynet.zzae zzaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static android.os.IInterface AjBsdSVohlCyjnEs(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    public static void XULbUSmQbAJqDUaK(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar) throws android.os.RemoteException {
        zzhVar.zzd(zzgVar);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        XULbUSmQbAJqDUaK((com.google.android.gms.internal.safetynet.zzh) AjBsdSVohlCyjnEs(zzafVar), this.zza);
    }
}

