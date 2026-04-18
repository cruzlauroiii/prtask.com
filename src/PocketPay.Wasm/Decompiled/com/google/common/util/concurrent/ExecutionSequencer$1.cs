namespace WillowMaze.Wasm.Decompiled;


class ExecutionSequencer$1<T> : com.google.common.util.concurrent.AsyncFunc<T> {
    readonly java.util.concurrent.Func val$callable;

    ExecutionSequencer$1(com.google.common.util.concurrent.ExecutionSequencer executionSequencer, java.util.concurrent.Func callable) {
        this.val$callable = callable;
    }

    public override com.google.common.util.concurrent.ListenableTask<T> Call() throws java.lang.Exception {
        return com.google.common.util.concurrent.Tasks.immediateTask(this.val$callable.call());
    }

    public java.lang.string Tostring() {
        return this.val$callable.tostring();
    }
}

