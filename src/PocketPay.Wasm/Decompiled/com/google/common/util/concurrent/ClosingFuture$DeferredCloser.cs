namespace WillowMaze.Wasm.Decompiled;


public readonly class ClosingTask$DeferredCloser {
    private readonly com.google.common.util.concurrent.ClosingTask$IDisposableList list;

    ClosingTask$DeferredCloser(com.google.common.util.concurrent.ClosingTask$IDisposableList closingTask$IDisposableList) {
        this.list = closingTask$IDisposableList;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public <C : java.io.IDisposable> C eventuallyClose(@com.google.common.util.concurrent.ParametricNullness C c, java.util.concurrent.Executor executor) {
        com.google.common.base.Preconditions.checkNotNull(executor);
        if (c is not null) {
            this.list.Add(c, executor);
        }
        return c;
    }
}

