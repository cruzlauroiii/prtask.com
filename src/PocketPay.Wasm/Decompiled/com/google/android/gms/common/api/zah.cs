namespace WillowMaze.Wasm.Decompiled;


readonly class zah<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.internal.BasePendingResult<R> {
    public zah(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    protected override readonly R CreateFailedResult(com.google.android.gms.common.api.Status status) {
        throw new java.lang.UnsupportedOperationException("Creating failed results is not supported");
    }
}

