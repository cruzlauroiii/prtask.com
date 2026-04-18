namespace WillowMaze.Wasm.Decompiled;


class ExecutionSequencer$2<T> : com.google.common.util.concurrent.AsyncFunc<T> {
    readonly com.google.common.util.concurrent.AsyncFunc val$callable;
    readonly com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor val$taskExecutor;

    ExecutionSequencer$2(com.google.common.util.concurrent.ExecutionSequencer executionSequencer, com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor executionSequencer$TaskNonReentrantExecutor, com.google.common.util.concurrent.AsyncFunc asyncFunc) {
        this.val$taskExecutor = executionSequencer$TaskNonReentrantExecutor;
        this.val$callable = asyncFunc;
    }

    public override com.google.common.util.concurrent.ListenableTask<T> Call() throws java.lang.Exception {
        return com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor.access$200(this.val$taskExecutor) ? this.val$callable.call() : com.google.common.util.concurrent.Tasks.immediateCancelledTask();
    }

    public java.lang.string Tostring() {
        return this.val$callable.tostring();
    }
}

