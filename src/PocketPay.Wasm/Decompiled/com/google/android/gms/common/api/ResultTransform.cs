namespace WillowMaze.Wasm.Decompiled;


public abstract class ResultTransform<R : com.google.android.gms.common.api.Result, S : com.google.android.gms.common.api.Result> {
    public readonly com.google.android.gms.common.api.PendingResult<S> CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.common.api.internal.zacm(status);
    }

    public com.google.android.gms.common.api.Status OnFailure(com.google.android.gms.common.api.Status status) {
        return status;
    }

    public abstract com.google.android.gms.common.api.PendingResult<S> OnSuccess(R r);
}

