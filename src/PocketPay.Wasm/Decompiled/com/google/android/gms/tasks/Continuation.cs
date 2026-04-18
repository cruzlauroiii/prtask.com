namespace WillowMaze.Wasm.Decompiled;


public interface Continuation<TResult, TContinuationResult> {
    TContinuationResult then(com.google.android.gms.tasks.Task<TResult> task) throws java.lang.Exception;
}

