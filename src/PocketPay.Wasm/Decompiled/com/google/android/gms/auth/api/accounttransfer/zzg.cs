namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : com.google.android.gms.auth.api.accounttransfer.zzl {
    readonly com.google.android.gms.internal.auth.zzaq zza;

    zzg(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, int i, com.google.android.gms.internal.auth.zzaq zzaqVar) {
        super(1608, null);
        this.zza = zzaqVar;
    }

    public static void CoBYpIfbCubYSkYc(com.google.android.gms.internal.auth.zzau zzauVar, com.google.android.gms.internal.auth.zzat zzatVar, com.google.android.gms.internal.auth.zzaq zzaqVar) throws android.os.RemoteException {
        zzauVar.zzd(zzatVar, zzaqVar);
    }

    protected override readonly void Zza(com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException {
        CoBYpIfbCubYSkYc(zzauVar, new com.google.android.gms.auth.api.accounttransfer.zzf(this, this), this.zza);
    }
}

