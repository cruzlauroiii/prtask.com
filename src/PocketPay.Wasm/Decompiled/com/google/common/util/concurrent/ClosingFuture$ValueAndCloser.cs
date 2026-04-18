namespace WillowMaze.Wasm.Decompiled;


public readonly class ClosingTask$ValueAndCloser<V> {
    private readonly com.google.common.util.concurrent.ClosingTask<? : V> closingTask;

    ClosingTask$ValueAndCloser(com.google.common.util.concurrent.ClosingTask<? : V> closingTask) {
        this.closingTask = (com.google.common.util.concurrent.ClosingTask) com.google.common.base.Preconditions.checkNotNull(closingTask);
    }

    public void CloseAsync() {
        com.google.common.util.concurrent.ClosingTask.access$100(this.closingTask);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public V Get() throws java.util.concurrent.ExecutionException {
        return (V) com.google.common.util.concurrent.Tasks.getDone(com.google.common.util.concurrent.ClosingTask.access$000(this.closingTask));
    }
}

