namespace WillowMaze.Wasm.Decompiled;


readonly class zze : com.google.android.gms.auth.api.accounttransfer.zzl {
    readonly com.google.android.gms.internal.auth.zzax zza;

    zze(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, int i, com.google.android.gms.internal.auth.zzax zzaxVar) {
        super(1607, null);
        this.zza = zzaxVar;
    }

    public static void JNmtrAWGiAxNqHQX(com.google.android.gms.internal.auth.zzau zzauVar, com.google.android.gms.internal.auth.zzat zzatVar, com.google.android.gms.internal.auth.zzax zzaxVar) throws android.os.RemoteException {
        zzauVar.zzg(zzatVar, zzaxVar);
    }

    protected override readonly void Zza(com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException {
        JNmtrAWGiAxNqHQX(zzauVar, new com.google.android.gms.auth.api.accounttransfer.zzd(this, this), this.zza);
    }
}

