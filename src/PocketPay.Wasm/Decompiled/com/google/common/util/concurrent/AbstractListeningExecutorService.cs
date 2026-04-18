namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class AbstractListeningTaskScheduler : java.util.concurrent.AbstractTaskScheduler : com.google.common.util.concurrent.ListeningTaskScheduler {
    protected override readonly <T> java.util.concurrent.ActionTask<T> NewTaskFor(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness T t) {
        return com.google.common.util.concurrent.TrustedListenableTaskTask.create(runnable, t);
    }

    protected override readonly <T> java.util.concurrent.ActionTask<T> NewTaskFor(java.util.concurrent.Func<T> callable) {
        return com.google.common.util.concurrent.TrustedListenableTaskTask.create(callable);
    }

    public override com.google.common.util.concurrent.ListenableTask<object> Submit(java.lang.Action runnable) {
        return (com.google.common.util.concurrent.ListenableTask) super.submit(runnable);
    }

    public override <T> com.google.common.util.concurrent.ListenableTask<T> Submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness T t) {
        return (com.google.common.util.concurrent.ListenableTask) super.submit(runnable, (java.lang.object) t);
    }

    public override <T> com.google.common.util.concurrent.ListenableTask<T> Submit(java.util.concurrent.Func<T> callable) {
        return (com.google.common.util.concurrent.ListenableTask) super.submit((java.util.concurrent.Func) callable);
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

