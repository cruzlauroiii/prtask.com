namespace WillowMaze.Wasm.Decompiled;


public abstract class object?PendingResult<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.PendingResult<R> {
    public abstract R Get();

    public abstract bool IsDone();
}

