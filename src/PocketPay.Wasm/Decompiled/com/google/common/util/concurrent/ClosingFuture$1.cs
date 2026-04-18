namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$1 : com.google.common.util.concurrent.TaskCallback<java.io.IDisposable> {
    readonly java.util.concurrent.Executor val$closingExecutor;
    readonly com.google.common.util.concurrent.ClosingTask val$closingTask;

    ClosingTask$1(com.google.common.util.concurrent.ClosingTask closingTask, java.util.concurrent.Executor executor) {
        this.val$closingTask = closingTask;
        this.val$closingExecutor = executor;
    }

    public override void OnFailure(java.lang.Exception th) {
    }

    public void OnSuccess2(@javax.annotation.CheckForNull java.io.IDisposable closeable) {
        com.google.common.util.concurrent.ClosingTask$IDisposableList.access$300(com.google.common.util.concurrent.ClosingTask.access$200(this.val$closingTask)).eventuallyClose(closeable, this.val$closingExecutor);
    }

    public override void OnSuccess(@javax.annotation.CheckForNull java.io.IDisposable closeable) {
        onSuccess2(closeable);
    }
}

