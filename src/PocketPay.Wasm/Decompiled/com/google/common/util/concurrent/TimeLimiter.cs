namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use FakeTimeLimiter")
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface TimeLimiter {
    <T> T callUninterruptiblyWithTimeout(java.util.concurrent.Func<T> callable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.util.concurrent.TimeoutException;

    <T> T callWithTimeout(java.util.concurrent.Func<T> callable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException;

    <T> T newProxy(T t, java.lang.Class<T> cls, long j, java.util.concurrent.TimeUnit timeUnit);

    void runUninterruptiblyWithTimeout(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException;

    void runWithTimeout(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException, java.util.concurrent.TimeoutException;
}

