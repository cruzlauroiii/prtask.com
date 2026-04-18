namespace WillowMaze.Wasm.Decompiled;


readonly class zzaj : com.google.android.gms.common.api.Result {
    private readonly com.google.android.gms.common.api.Status zza;

    public zzaj(com.google.android.gms.common.api.Status status) {
        this.zza = status;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

