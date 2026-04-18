namespace WillowMaze.Wasm.Decompiled;


public abstract class ForwardingListenableTask$SimpleForwardingListenableTask<V> : com.google.common.util.concurrent.ForwardingListenableTask<V> {
    private readonly com.google.common.util.concurrent.ListenableTask<V> delegate;

    protected ForwardingListenableTask$SimpleForwardingListenableTask(com.google.common.util.concurrent.ListenableTask<V> listenableTask) {
        this.delegate = (com.google.common.util.concurrent.ListenableTask) com.google.common.base.Preconditions.checkNotNull(listenableTask);
    }

    protected override readonly com.google.common.util.concurrent.ListenableTask<V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.concurrent.Task Delegate() {
        return delegate();
    }
}

