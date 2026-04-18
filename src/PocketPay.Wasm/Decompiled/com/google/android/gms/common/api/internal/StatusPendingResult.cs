namespace WillowMaze.Wasm.Decompiled;


public class StatusPendingResult : com.google.android.gms.common.api.internal.BasePendingResult<com.google.android.gms.common.api.Status> {
    @java.lang.Deprecated
    public StatusPendingResult(android.os.Looper looper) {
        super(looper);
    }

    public StatusPendingResult(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return status;
    }
}

