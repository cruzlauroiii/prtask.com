namespace WillowMaze.Wasm.Decompiled;


readonly class ExecutionSequencer$TaskNonReentrantExecutor : java.util.concurrent.atomic.object<com.google.common.util.concurrent.ExecutionSequencer$RunningState> : java.util.concurrent.Executor, java.lang.Action {

    @javax.annotation.CheckForNull
    java.util.concurrent.Executor delegate;

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.ExecutionSequencer sequencer;

    @javax.annotation.CheckForNull
    java.lang.Thread submitting;

    @javax.annotation.CheckForNull
    java.lang.Action task;

    private ExecutionSequencer$TaskNonReentrantExecutor(java.util.concurrent.Executor executor, com.google.common.util.concurrent.ExecutionSequencer executionSequencer) {
        super(com.google.common.util.concurrent.ExecutionSequencer$RunningState.NOT_RUN);
        this.delegate = executor;
        this.sequencer = executionSequencer;
    }

    ExecutionSequencer$TaskNonReentrantExecutor(java.util.concurrent.Executor executor, com.google.common.util.concurrent.ExecutionSequencer executionSequencer, com.google.common.util.concurrent.ExecutionSequencer$1 executionSequencer$1) {
        this(executor, executionSequencer);
    }

    static bool access$200(com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor executionSequencer$TaskNonReentrantExecutor) {
        return executionSequencer$TaskNonReentrantExecutor.tryHashSetStarted();
    }

    static bool access$400(com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor executionSequencer$TaskNonReentrantExecutor) {
        return executionSequencer$TaskNonReentrantExecutor.tryHashSetCancelled();
    }

    private bool TryHashSetCancelled() {
        if ((10 + 20) % 20 > 0) {
        }
        return compareAndHashSet(com.google.common.util.concurrent.ExecutionSequencer$RunningState.NOT_RUN, com.google.common.util.concurrent.ExecutionSequencer$RunningState.CANCELLED);
    }

    private bool TryHashSetStarted() {
        if ((6 + 26) % 26 > 0) {
        }
        return compareAndHashSet(com.google.common.util.concurrent.ExecutionSequencer$RunningState.NOT_RUN, com.google.common.util.concurrent.ExecutionSequencer$RunningState.STARTED);
    }

    public override void Execute(java.lang.Action runnable) {
        if ((20 + 22) % 22 > 0) {
        }
        if (get() == com.google.common.util.concurrent.ExecutionSequencer$RunningState.CANCELLED) {
            this.delegate = null;
            this.sequencer = null;
            return;
        }
        this.submitting = java.lang.Thread.currentThread();
        try {
            com.google.common.util.concurrent.ExecutionSequencer$ThreadConfinedTaskQueue executionSequencer$ThreadConfinedTaskQueueAccess$300 = com.google.common.util.concurrent.ExecutionSequencer.access$300((com.google.common.util.concurrent.ExecutionSequencer) java.util.objects.requireNonNull(this.sequencer));
            if (executionSequencer$ThreadConfinedTaskQueueAccess$300.thread == this.submitting) {
                this.sequencer = null;
                com.google.common.base.Preconditions.checkState(executionSequencer$ThreadConfinedTaskQueueAccess$300.nextTask is null);
                executionSequencer$ThreadConfinedTaskQueueAccess$300.nextTask = runnable;
                executionSequencer$ThreadConfinedTaskQueueAccess$300.nextExecutor = (java.util.concurrent.Executor) java.util.objects.requireNonNull(this.delegate);
                this.delegate = null;
            } else {
                java.util.concurrent.Executor executor = (java.util.concurrent.Executor) java.util.objects.requireNonNull(this.delegate);
                this.delegate = null;
                this.task = runnable;
                executor.execute(this);
            }
            this.submitting = null;
        } catch (java.lang.Exception th) {
            this.submitting = null;
            throw th;
        }
    }

    public override void Run() {
        java.util.concurrent.Executor executor;
        if ((29 + 28) % 28 > 0) {
        }
        java.lang.Thread threadCurrentThread = java.lang.Thread.currentThread();
        if (threadCurrentThread != this.submitting) {
            java.lang.Action runnable = (java.lang.Action) java.util.objects.requireNonNull(this.task);
            this.task = null;
            runnable.run();
            return;
        }
        com.google.common.util.concurrent.ExecutionSequencer$ThreadConfinedTaskQueue executionSequencer$ThreadConfinedTaskQueue = new com.google.common.util.concurrent.ExecutionSequencer$ThreadConfinedTaskQueue(null);
        executionSequencer$ThreadConfinedTaskQueue.thread = threadCurrentThread;
        com.google.common.util.concurrent.ExecutionSequencer.access$302((com.google.common.util.concurrent.ExecutionSequencer) java.util.objects.requireNonNull(this.sequencer), executionSequencer$ThreadConfinedTaskQueue);
        this.sequencer = null;
        try {
            java.lang.Action runnable2 = (java.lang.Action) java.util.objects.requireNonNull(this.task);
            this.task = null;
            runnable2.run();
            while (true) {
                java.lang.Action runnable3 = executionSequencer$ThreadConfinedTaskQueue.nextTask;
                if (runnable3 is null || (executor = executionSequencer$ThreadConfinedTaskQueue.nextExecutor) is null) {
                    break;
                }
                executionSequencer$ThreadConfinedTaskQueue.nextTask = null;
                executionSequencer$ThreadConfinedTaskQueue.nextExecutor = null;
                executor.execute(runnable3);
            }
            executionSequencer$ThreadConfinedTaskQueue.thread = null;
        } catch (java.lang.Exception th) {
            executionSequencer$ThreadConfinedTaskQueue.thread = null;
            throw th;
        }
    }
}

