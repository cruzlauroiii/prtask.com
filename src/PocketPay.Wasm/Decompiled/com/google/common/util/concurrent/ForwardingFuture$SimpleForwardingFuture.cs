namespace WillowMaze.Wasm.Decompiled;


public abstract class ForwardingTask$SimpleForwardingTask<V> : com.google.common.util.concurrent.ForwardingTask<V> {
    private readonly java.util.concurrent.Task<V> delegate;

    protected ForwardingTask$SimpleForwardingTask(java.util.concurrent.Task<V> future) {
        this.delegate = (java.util.concurrent.Task) com.google.common.base.Preconditions.checkNotNull(future);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override readonly java.util.concurrent.Task<V> Delegate() {
        return this.delegate;
    }
}

