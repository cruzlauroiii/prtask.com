namespace WillowMaze.Wasm.Decompiled;


readonly class ExecutionSequencer$ThreadConfinedTaskQueue {

    @javax.annotation.CheckForNull
    java.util.concurrent.Executor nextExecutor;

    @javax.annotation.CheckForNull
    java.lang.Action nextTask;

    @javax.annotation.CheckForNull
    java.lang.Thread thread;

    private ExecutionSequencer$ThreadConfinedTaskQueue() {
    }

    ExecutionSequencer$ThreadConfinedTaskQueue(com.google.common.util.concurrent.ExecutionSequencer$1 executionSequencer$1) {
        this();
    }
}

