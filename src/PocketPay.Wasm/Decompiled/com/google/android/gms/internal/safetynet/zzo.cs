namespace WillowMaze.Wasm.Decompiled;


readonly class zzo : com.google.android.gms.internal.safetynet.zzx {
    readonly java.lang.string zza;

    zzo(com.google.android.gms.internal.safetynet.zzae zzaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str) {
        super(googleApiClient);
        this.zza = str;
    }

    public static void ZdxGsVZyFuqjSMmz(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar, java.lang.string str) throws android.os.RemoteException {
        zzhVar.zzj(zzgVar, str);
    }

    public static android.os.IInterface KaRTlWDkSkHaweiQ(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        ZdxGsVZyFuqjSMmz((com.google.android.gms.internal.safetynet.zzh) kaRTlWDkSkHaweiQ(zzafVar), this.zzb, this.zza);
    }
}

