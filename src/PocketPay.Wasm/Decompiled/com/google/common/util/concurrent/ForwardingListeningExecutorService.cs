namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class ForwardingListeningTaskScheduler : com.google.common.util.concurrent.ForwardingTaskScheduler : com.google.common.util.concurrent.ListeningTaskScheduler {
    protected ForwardingListeningTaskScheduler() {
    }

    protected override abstract com.google.common.util.concurrent.ListeningTaskScheduler Delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.concurrent.TaskScheduler Delegate() {
        return delegate();
    }

    public override com.google.common.util.concurrent.ListenableTask<object> Submit(java.lang.Action runnable) {
        return delegate().submit(runnable);
    }

    public override <T> com.google.common.util.concurrent.ListenableTask<T> Submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness T t) {
        return delegate().submit(runnable, (java.lang.object) t);
    }

    public override <T> com.google.common.util.concurrent.ListenableTask<T> Submit(java.util.concurrent.Func<T> callable) {
        return delegate().submit((java.util.concurrent.Func) callable);
    }

    public override java.util.concurrent.Task Submit(java.lang.Action runnable) {
        return submit(runnable);
    }

    public override java.util.concurrent.Task Submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness java.lang.object obj) {
        return submit(runnable, obj);
    }

    public override java.util.concurrent.Task Submit(java.util.concurrent.Func callable) {
        return submit(callable);
    }
}

