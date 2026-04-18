namespace WillowMaze.Wasm.Decompiled;


public abstract class PendingResult<R : com.google.android.gms.common.api.Result> {
    public void AddStatusListener(com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract R Await();

    public abstract R Await(long j, java.util.concurrent.TimeUnit timeUnit);

    public abstract void Cancel();

    public abstract bool IsCanceled();

    public abstract void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> resultCallback);

    public abstract void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> resultCallback, long j, java.util.concurrent.TimeUnit timeUnit);

    public <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super R, ? : S> resultTransform) {
        throw new java.lang.UnsupportedOperationException();
    }
}

