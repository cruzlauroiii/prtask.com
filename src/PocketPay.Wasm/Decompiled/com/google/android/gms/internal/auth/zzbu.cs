namespace WillowMaze.Wasm.Decompiled;


readonly class zzbu : com.google.android.gms.auth.api.proxy.ProxyApi$ProxyResult {
    private readonly com.google.android.gms.common.api.Status zza;
    private com.google.android.gms.auth.api.proxy.ProxyResponse zzb;

    public zzbu(com.google.android.gms.auth.api.proxy.ProxyResponse proxyResponse) {
        this.zzb = proxyResponse;
        this.zza = com.google.android.gms.common.api.Status.RESULT_SUCCESS;
    }

    public zzbu(com.google.android.gms.common.api.Status status) {
        this.zza = status;
    }

    public override readonly com.google.android.gms.auth.api.proxy.ProxyResponse GetResponse() {
        return this.zzb;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

