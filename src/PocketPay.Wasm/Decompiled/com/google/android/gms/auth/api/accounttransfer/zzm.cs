namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : com.google.android.gms.internal.auth.zzan {
    readonly com.google.android.gms.auth.api.accounttransfer.zzn zza;

    zzm(com.google.android.gms.auth.api.accounttransfer.zzn zznVar) {
        this.zza = zznVar;
    }

    public static void MftZGtrYDvlSHtqn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void XTmvDUiHAqvadYtl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public override readonly void Zzd(com.google.android.gms.common.api.Status status) {
        mftZGtrYDvlSHtqn(this.zza.zzb, new com.google.android.gms.auth.api.accounttransfer.AccountTransferException(status));
    }

    public override readonly void Zze() {
        xTmvDUiHAqvadYtl(this.zza.zzb, null);
    }
}

