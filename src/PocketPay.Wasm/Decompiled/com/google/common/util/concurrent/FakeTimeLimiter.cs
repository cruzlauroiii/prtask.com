namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class FakeTimeLimiter : com.google.common.util.concurrent.TimeLimiter {
    @com.google.common.util.concurrent.ParametricNullness
    public override <T> T CallUninterruptiblyWithTimeout(java.util.concurrent.Func<T> callable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException {
        return (T) callWithTimeout(callable, j, timeUnit);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override <T> T CallWithTimeout(java.util.concurrent.Func<T> callable, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException {
        com.google.common.base.Preconditions.checkNotNull(callable);
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        try {
            return callable.call();
        } catch (java.lang.Error e) {
            throw new com.google.common.util.concurrent.ExecutionError(e);
        } catch (java.lang.Exception e2) {
            throw new com.google.common.util.concurrent.UncheckedExecutionException(e2);
        } catch (java.lang.Exception e3) {
            throw new java.util.concurrent.ExecutionException(e3);
        } catch (java.lang.Exception th) {
            throw new java.util.concurrent.ExecutionException(th);
        }
    }

    public override <T> T NewProxy(T t, java.lang.Class<T> cls, long j, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.base.Preconditions.checkNotNull(t);
        com.google.common.base.Preconditions.checkNotNull(cls);
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        return t;
    }

    public override void RunUninterruptiblyWithTimeout(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        runWithTimeout(runnable, j, timeUnit);
    }

    public override void RunWithTimeout(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.base.Preconditions.checkNotNull(runnable);
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        try {
            runnable.run();
        } catch (java.lang.Error e) {
            throw new com.google.common.util.concurrent.ExecutionError(e);
        } catch (java.lang.Exception e2) {
            throw new com.google.common.util.concurrent.UncheckedExecutionException(e2);
        } catch (java.lang.Exception th) {
            throw new com.google.common.util.concurrent.UncheckedExecutionException(th);
        }
    }
}

