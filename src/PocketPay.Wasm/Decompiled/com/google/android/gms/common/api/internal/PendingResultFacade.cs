namespace WillowMaze.Wasm.Decompiled;


public abstract class PendingResultFacade<A : com.google.android.gms.common.api.Result, B : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.PendingResult<B> {
    public override readonly void AddStatusListener(com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        throw null;
    }

    public override readonly B Await() {
        throw null;
    }

    public override readonly B Await(long j, java.util.concurrent.TimeUnit timeUnit) {
        throw null;
    }

    public override readonly void Cancel() {
        throw null;
    }

    public override readonly bool IsCanceled() {
        throw null;
    }

    public override readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<B> resultCallback) {
        throw null;
    }

    public override readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<B> resultCallback, long j, java.util.concurrent.TimeUnit timeUnit) {
        throw null;
    }

    public readonly <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super B, ? : S> resultTransform) {
        throw null;
    }
}

