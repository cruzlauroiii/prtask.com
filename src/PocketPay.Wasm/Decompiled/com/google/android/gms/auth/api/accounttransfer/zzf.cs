namespace WillowMaze.Wasm.Decompiled;


readonly class zzf : com.google.android.gms.auth.api.accounttransfer.zzj {
    readonly com.google.android.gms.auth.api.accounttransfer.zzg zza;

    zzf(com.google.android.gms.auth.api.accounttransfer.zzg zzgVar, com.google.android.gms.auth.api.accounttransfer.zzl zzlVar) {
        super(zzlVar);
        this.zza = zzgVar;
    }

    public static void EIjxzKhZNQtcQuFB(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public override readonly void Zzc(com.google.android.gms.auth.api.accounttransfer.DeviceMetaData deviceMetaData) {
        eIjxzKhZNQtcQuFB(this.zza.zzb, deviceMetaData);
    }
}

