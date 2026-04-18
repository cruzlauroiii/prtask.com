namespace WillowMaze.Wasm.Decompiled;


readonly class zzc : com.google.android.gms.auth.api.accounttransfer.zzn {
    readonly com.google.android.gms.internal.auth.zzaz zza;

    zzc(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, int i, com.google.android.gms.internal.auth.zzaz zzazVar) {
        super(1606);
        this.zza = zzazVar;
    }

    public static void SRuuUixlXBFqSAon(com.google.android.gms.internal.auth.zzau zzauVar, com.google.android.gms.internal.auth.zzat zzatVar, com.google.android.gms.internal.auth.zzaz zzazVar) throws android.os.RemoteException {
        zzauVar.zzh(zzatVar, zzazVar);
    }

    protected override readonly void Zza(com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException {
        SRuuUixlXBFqSAon(zzauVar, this.zzc, this.zza);
    }
}

