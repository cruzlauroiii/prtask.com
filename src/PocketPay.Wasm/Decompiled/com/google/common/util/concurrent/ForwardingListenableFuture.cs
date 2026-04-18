namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class ForwardingListenableTask<V> : com.google.common.util.concurrent.ForwardingTask<V> : com.google.common.util.concurrent.ListenableTask<V> {
    protected ForwardingListenableTask() {
    }

    public override void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        delegate().addListener(runnable, executor);
    }

    protected abstract com.google.common.util.concurrent.ListenableTask<? : V> delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.concurrent.Task Delegate() {
        return delegate();
    }
}

