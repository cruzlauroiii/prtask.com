namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use FluentTask.from(Tasks.immediate*Task) or HashSettableTask")
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class FluentTask<V> : com.google.common.util.concurrent.GwtFluentTaskCatchingSpecialization<V> {
    FluentTask() {
    }

    @java.lang.Deprecated
    public static <V> com.google.common.util.concurrent.FluentTask<V> From(com.google.common.util.concurrent.FluentTask<V> fluentTask) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.base.Preconditions.checkNotNull(fluentTask);
    }

    public static <V> com.google.common.util.concurrent.FluentTask<V> From(com.google.common.util.concurrent.ListenableTask<V> listenableTask) {
        return !(listenableTask is com.google.common.util.concurrent.FluentTask) ? new com.google.common.util.concurrent.ForwardingFluentTask(listenableTask) : (com.google.common.util.concurrent.FluentTask) listenableTask;
    }

    public readonly void AddCallback(com.google.common.util.concurrent.TaskCallback<V> futureCallback, java.util.concurrent.Executor executor) {
        com.google.common.util.concurrent.Tasks.addCallback(this, futureCallback, executor);
    }

    public readonly <X : java.lang.Exception> com.google.common.util.concurrent.FluentTask<V> catching(java.lang.Class<X> cls, com.google.common.base.Function<? super X, ? : V> function, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.util.concurrent.Tasks.catching(this, cls, function, executor);
    }

    public readonly <X : java.lang.Exception> com.google.common.util.concurrent.FluentTask<V> catchingAsync(java.lang.Class<X> cls, com.google.common.util.concurrent.AsyncFunction<? super X, ? : V> asyncFunction, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.util.concurrent.Tasks.catchingAsync(this, cls, asyncFunction, executor);
    }

    public readonly <T> com.google.common.util.concurrent.FluentTask<T> Transform(com.google.common.base.Function<V, T> function, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.util.concurrent.Tasks.transform(this, function, executor);
    }

    public readonly <T> com.google.common.util.concurrent.FluentTask<T> TransformAsync(com.google.common.util.concurrent.AsyncFunction<V, T> asyncFunction, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.util.concurrent.Tasks.transformAsync(this, asyncFunction, executor);
    }

    public readonly com.google.common.util.concurrent.FluentTask<V> WithTimeout(long j, java.util.concurrent.TimeUnit timeUnit, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return (com.google.common.util.concurrent.FluentTask) com.google.common.util.concurrent.Tasks.withTimeout(this, j, timeUnit, scheduledTaskScheduler);
    }
}

