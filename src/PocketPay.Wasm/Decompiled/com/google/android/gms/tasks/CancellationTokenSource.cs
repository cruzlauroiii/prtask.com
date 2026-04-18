namespace WillowMaze.Wasm.Decompiled;


public class CancellationTokenSource {
    private readonly com.google.android.gms.tasks.zzb zza = new com.google.android.gms.tasks.zzb();

    public void Cancel() {
        this.zza.zza();
    }

    public com.google.android.gms.tasks.CancellationToken GetToken() {
        return this.zza;
    }
}

