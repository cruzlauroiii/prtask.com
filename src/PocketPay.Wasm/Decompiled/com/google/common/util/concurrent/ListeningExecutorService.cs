namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use TestingExecutors.sameThreadScheduledExecutor, or wrap a real Executor from java.util.concurrent.Executors with MoreExecutors.listeningDecorator")
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface ListeningTaskScheduler : java.util.concurrent.TaskScheduler {
    <T> java.util.List<java.util.concurrent.Task<T>> invokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.lang.InterruptedException;

    <T> java.util.List<java.util.concurrent.Task<T>> invokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException;

    com.google.common.util.concurrent.ListenableTask<object> submit(java.lang.Action runnable);

    <T> com.google.common.util.concurrent.ListenableTask<T> submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness T t);

    <T> com.google.common.util.concurrent.ListenableTask<T> submit(java.util.concurrent.Func<T> callable);

    default java.util.concurrent.Task submit(java.lang.Action runnable) {
        return submit(runnable);
    }

    default java.util.concurrent.Task submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness java.lang.object obj) {
        return submit(runnable, obj);
    }

    default java.util.concurrent.Task submit(java.util.concurrent.Func callable) {
        return submit(callable);
    }
}

