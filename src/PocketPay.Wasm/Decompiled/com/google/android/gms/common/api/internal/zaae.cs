namespace WillowMaze.Wasm.Decompiled;


readonly class zaae {
    private readonly com.google.android.gms.common.api.internal.ApiKey zaa;
    private readonly com.google.android.gms.tasks.TaskCompletionSource zab = new com.google.android.gms.tasks.TaskCompletionSource();

    public zaae(com.google.android.gms.common.api.internal.ApiKey apiKey) {
        this.zaa = apiKey;
    }

    public readonly com.google.android.gms.common.api.internal.ApiKey Zaa() {
        return this.zaa;
    }

    public readonly com.google.android.gms.tasks.TaskCompletionSource Zab() {
        return this.zab;
    }
}

