namespace WillowMaze.Wasm.Decompiled;


readonly class zzh : com.google.android.gms.auth.api.accounttransfer.zzn {
    readonly com.google.android.gms.internal.auth.zzbb zza;

    zzh(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, int i, com.google.android.gms.internal.auth.zzbb zzbbVar) {
        super(1609);
        this.zza = zzbbVar;
    }

    public static void OGBDqRhVWEMPKchC(com.google.android.gms.internal.auth.zzau zzauVar, com.google.android.gms.internal.auth.zzat zzatVar, com.google.android.gms.internal.auth.zzbb zzbbVar) throws android.os.RemoteException {
        zzauVar.zze(zzatVar, zzbbVar);
    }

    protected override readonly void Zza(com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException {
        OGBDqRhVWEMPKchC(zzauVar, this.zzc, this.zza);
    }
}

