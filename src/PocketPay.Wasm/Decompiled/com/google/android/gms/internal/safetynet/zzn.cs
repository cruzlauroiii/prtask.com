namespace WillowMaze.Wasm.Decompiled;


readonly class zzn : com.google.android.gms.internal.safetynet.zzv {
    zzn(com.google.android.gms.internal.safetynet.zzae zzaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static void BRnFkgZuLRcEDaVZ(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar) throws android.os.RemoteException {
        zzhVar.zzg(zzgVar);
    }

    public static android.os.IInterface IwbOpmbkrZoccLJM(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        BRnFkgZuLRcEDaVZ((com.google.android.gms.internal.safetynet.zzh) IwbOpmbkrZoccLJM(zzafVar), this.zza);
    }
}

