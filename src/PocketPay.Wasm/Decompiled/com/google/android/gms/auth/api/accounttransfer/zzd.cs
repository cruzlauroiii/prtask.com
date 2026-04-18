namespace WillowMaze.Wasm.Decompiled;


readonly class zzd : com.google.android.gms.auth.api.accounttransfer.zzj {
    readonly com.google.android.gms.auth.api.accounttransfer.zze zza;

    zzd(com.google.android.gms.auth.api.accounttransfer.zze zzeVar, com.google.android.gms.auth.api.accounttransfer.zzl zzlVar) {
        super(zzlVar);
        this.zza = zzeVar;
    }

    public static void LCDeRIDFdkIqgOSJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public override readonly void Zzb(byte[] bArr) {
        LCDeRIDFdkIqgOSJ(this.zza.zzb, bArr);
    }
}

