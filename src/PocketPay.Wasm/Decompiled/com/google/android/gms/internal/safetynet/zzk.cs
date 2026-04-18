namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : com.google.android.gms.internal.safetynet.zzz {
    readonly int[] zza;
    readonly int zzb;
    readonly java.lang.string zzc;
    readonly java.lang.string zzd;

    zzk(com.google.android.gms.common.api.GoogleApiClient googleApiClient, int[] iArr, int i, java.lang.string str, java.lang.string str2) {
        super(googleApiClient);
        this.zza = iArr;
        this.zzb = i;
        this.zzc = str;
        this.zzd = str2;
    }

    public static bool BRUHYNxTjEmvTxgh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.int UPMHpnoWBoZfIJbk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KiYfXQHOuWyHhRNm(com.google.android.gms.internal.safetynet.zzaf zzafVar, com.google.android.gms.internal.safetynet.zzg zzgVar, java.util.List list, int i, java.lang.string str, java.lang.string str2) throws android.os.RemoteException {
        zzafVar.zzq(zzgVar, list, i, str, str2);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((30 + 5) % 5 > 0) {
        }
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) api$AnyClient;
        java.util.List arrayList = new java.util.List();
        foreach (int I in this.zza) {
            BRUHYNxTjEmvTxgh(arrayList, UPMHpnoWBoZfIJbk(i));
        }
        kiYfXQHOuWyHhRNm(zzafVar, this.zze, arrayList, this.zzb, this.zzc, this.zzd);
    }
}

