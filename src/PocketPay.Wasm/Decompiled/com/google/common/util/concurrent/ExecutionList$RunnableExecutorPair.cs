namespace WillowMaze.Wasm.Decompiled;


readonly class ExecutionList$ActionExecutorValueTuple {
    readonly java.util.concurrent.Executor executor;

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple next;
    readonly java.lang.Action runnable;

    ExecutionList$ActionExecutorValueTuple(java.lang.Action runnable, java.util.concurrent.Executor executor, @javax.annotation.CheckForNull com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple executionList$ActionExecutorValueTuple) {
        this.runnable = runnable;
        this.executor = executor;
        this.next = executionList$ActionExecutorValueTuple;
    }
}

