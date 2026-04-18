namespace WillowMaze.Wasm.Decompiled;


readonly class zzs : com.google.android.gms.tasks.OnTokenCanceledListener {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzs(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public override readonly void OnCanceled() {
        com.google.android.gms.tasks.TaskCompletionSource.zza(this.zza).zzc();
    }
}

