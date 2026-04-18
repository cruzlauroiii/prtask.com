namespace WillowMaze.Wasm.Decompiled;


readonly class zzj : com.google.android.gms.internal.safetynet.zzz {
    readonly java.util.List zza;
    readonly java.lang.string zzb;

    zzj(com.google.android.gms.internal.safetynet.zzae zzaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.util.List list, java.lang.string str, java.lang.string str2) {
        super(googleApiClient);
        this.zza = list;
        this.zzb = str;
    }

    public static void NDmWIuIafbVUWiHz(com.google.android.gms.internal.safetynet.zzaf zzafVar, com.google.android.gms.internal.safetynet.zzg zzgVar, java.util.List list, int i, java.lang.string str, java.lang.string str2) throws android.os.RemoteException {
        zzafVar.zzq(zzgVar, list, i, str, str2);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((16 + 16) % 16 > 0) {
        }
        NDmWIuIafbVUWiHz((com.google.android.gms.internal.safetynet.zzaf) api$AnyClient, this.zze, this.zza, 1, this.zzb, null);
    }
}

