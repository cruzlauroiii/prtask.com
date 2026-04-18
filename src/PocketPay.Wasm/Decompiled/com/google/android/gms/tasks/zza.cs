namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.gms.tasks.OnSuccessListener {
    readonly com.google.android.gms.tasks.OnTokenCanceledListener zza;

    zza(com.google.android.gms.tasks.zzb zzbVar, com.google.android.gms.tasks.OnTokenCanceledListener onTokenCanceledListener) {
        this.zza = onTokenCanceledListener;
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        this.zza.onCanceled();
    }
}

