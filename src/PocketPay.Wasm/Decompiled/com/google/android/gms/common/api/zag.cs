namespace WillowMaze.Wasm.Decompiled;


readonly class zag<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.internal.BasePendingResult<R> {
    private readonly com.google.android.gms.common.api.Result zae;

    public zag(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.Result result) {
        super(googleApiClient);
        this.zae = result;
    }

    protected override readonly R CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return (R) this.zae;
    }
}

