namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzp(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public override readonly void Zzc(com.google.android.gms.common.api.Status status) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, this.zza);
    }
}

