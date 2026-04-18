namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractScheduledService$TaskAsCancellable : com.google.common.util.concurrent.AbstractScheduledService$Cancellable {
    private readonly java.util.concurrent.Task<object> delegate;

    AbstractScheduledService$TaskAsCancellable(java.util.concurrent.Task<object> future) {
        this.delegate = future;
    }

    public override void Cancel(bool z) {
        this.delegate.cancel(z);
    }

    public override bool IsCancelled() {
        return this.delegate.isCancelled();
    }
}

