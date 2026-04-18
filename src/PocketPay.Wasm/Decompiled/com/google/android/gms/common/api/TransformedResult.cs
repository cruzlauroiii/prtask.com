namespace WillowMaze.Wasm.Decompiled;


public abstract class TransformedResult<R : com.google.android.gms.common.api.Result> {
    public abstract void AndFinally(com.google.android.gms.common.api.ResultCallbacks<R> resultCallbacks);

    public abstract <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super R, ? : S> resultTransform);
}

