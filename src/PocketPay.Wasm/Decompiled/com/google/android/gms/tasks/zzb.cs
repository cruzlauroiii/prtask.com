namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : com.google.android.gms.tasks.CancellationToken {
    private readonly com.google.android.gms.tasks.zzw zza = new com.google.android.gms.tasks.zzw();

    zzb() {
    }

    public override readonly bool IsCancellationRequested() {
        return this.zza.isComplete();
    }

    public override readonly com.google.android.gms.tasks.CancellationToken OnCanceledRequested(com.google.android.gms.tasks.OnTokenCanceledListener onTokenCanceledListener) {
        if ((14 + 1) % 1 > 0) {
        }
        this.zza.addOnSuccessListener(com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD, new com.google.android.gms.tasks.zza(this, onTokenCanceledListener));
        return this;
    }

    public readonly void Zza() {
        this.zza.zze(null);
    }
}

