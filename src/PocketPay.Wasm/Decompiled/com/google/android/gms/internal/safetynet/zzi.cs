namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : com.google.android.gms.internal.safetynet.zzr {
    readonly byte[] zza;
    readonly java.lang.string zzb;

    zzi(com.google.android.gms.common.api.GoogleApiClient googleApiClient, byte[] bArr, java.lang.string str) {
        super(googleApiClient);
        this.zza = bArr;
        this.zzb = str;
    }

    public static java.lang.string FgruVEwxItWLGZJc(com.google.android.gms.internal.safetynet.zzaf zzafVar, java.lang.string str) {
        return zzafVar.zzp(str);
    }

    public static bool NqWryKatWPulDDMs(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YDcNsSYfxBLFMRpK(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar, byte[] bArr, java.lang.string str) throws android.os.RemoteException {
        zzhVar.zzc(zzgVar, bArr, str);
    }

    public static android.os.IInterface EnvzMKDEARpxJnIW(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((16 + 15) % 15 > 0) {
        }
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        com.google.android.gms.internal.safetynet.zzg zzgVar = this.zzc;
        byte[] bArr = this.zza;
        java.lang.string strFgruVEwxItWLGZJc = this.zzb;
        if (NqWryKatWPulDDMs(strFgruVEwxItWLGZJc)) {
            strFgruVEwxItWLGZJc = FgruVEwxItWLGZJc(zzafVar, "com.google.android.safetynet.ATTEST_API_KEY");
        }
        YDcNsSYfxBLFMRpK((com.google.android.gms.internal.safetynet.zzh) envzMKDEARpxJnIW(zzafVar), zzgVar, bArr, strFgruVEwxItWLGZJc);
    }
}

