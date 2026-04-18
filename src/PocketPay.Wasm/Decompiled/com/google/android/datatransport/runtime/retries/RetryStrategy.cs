namespace WillowMaze.Wasm.Decompiled;


public interface RetryStrategy<TInput, TResult> {
    TInput shouldRetry(TInput tinput, TResult tresult);
}

