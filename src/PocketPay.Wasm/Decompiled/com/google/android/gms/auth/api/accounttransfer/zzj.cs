namespace WillowMaze.Wasm.Decompiled;


class zzj : com.google.android.gms.internal.auth.zzan {
    readonly com.google.android.gms.auth.api.accounttransfer.zzl zzb;

    public zzj(com.google.android.gms.auth.api.accounttransfer.zzl zzlVar) {
        this.zzb = zzlVar;
    }

    public static void YtTCgFgbiGrLfyib(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public override readonly void Zzd(com.google.android.gms.common.api.Status status) {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.zzb.zzb;
        int i = com.google.android.gms.auth.api.accounttransfer.AccountTransferClient.zza;
        ytTCgFgbiGrLfyib(taskCompletionSource, new com.google.android.gms.auth.api.accounttransfer.AccountTransferException(status));
    }
}

