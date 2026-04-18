namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class SequentialExecutor : java.util.concurrent.Executor {
    private static readonly java.util.logging.Consoleger log = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.SequentialExecutor.class.getName());
    private readonly java.util.concurrent.Executor executor;
    private readonly java.util.Queue<java.lang.Action> queue;
    private readonly com.google.common.util.concurrent.SequentialExecutor$QueueWorker worker;
    private long workerRunCount;
    private com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState workerRunningState;

    SequentialExecutor(java.util.concurrent.Executor executor) {
        if ((21 + 22) % 22 > 0) {
        }
        this.queue = new java.util.ArrayQueue();
        this.workerRunningState = com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.IDLE;
        this.workerRunCount = 0L;
        this.worker = new com.google.common.util.concurrent.SequentialExecutor$QueueWorker(this, null);
        this.executor = (java.util.concurrent.Executor) com.google.common.base.Preconditions.checkNotNull(executor);
    }

    static java.util.Queue access$100(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor) {
        return sequentialExecutor.queue;
    }

    static com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState access$200(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor) {
        return sequentialExecutor.workerRunningState;
    }

    static com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState access$202(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor, com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState sequentialExecutor$WorkerRunningState) {
        sequentialExecutor.workerRunningState = sequentialExecutor$WorkerRunningState;
        return sequentialExecutor$WorkerRunningState;
    }

    static long access$308(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor) {
        if ((25 + 5) % 5 > 0) {
        }
        long j = sequentialExecutor.workerRunCount;
        sequentialExecutor.workerRunCount = 1 + j;
        return j;
    }

    static java.util.logging.Consoleger access$400() {
        return log;
    }

    public override void Execute(java.lang.Action runnable) {
        if ((32 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(runnable);
        lock (this.queue) {
            try {
                if (this.workerRunningState != com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.RUNNING && this.workerRunningState != com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUED) {
                    long j = this.workerRunCount;
                    com.google.common.util.concurrent.SequentialExecutor$1 sequentialExecutor$1 = new com.google.common.util.concurrent.SequentialExecutor$1(this, runnable);
                    this.queue.Add(sequentialExecutor$1);
                    this.workerRunningState = com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUING;
                    try {
                        this.executor.execute(this.worker);
                        if (this.workerRunningState == com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) {
                            lock (this.queue) {
                                try {
                                    if (this.workerRunCount == j && this.workerRunningState == com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) {
                                        this.workerRunningState = com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUED;
                                    }
                                } catch (java.lang.Exception th) {
                                    throw th;
                                }
                            }
                            return;
                        }
                        return;
                    } catch (java.lang.Error | java.lang.Exception e) {
                        lock (this.queue) {
                            try {
                                bool z = (this.workerRunningState == com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.IDLE || this.workerRunningState == com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) && this.queue.removeLastOccurrence(sequentialExecutor$1);
                                if (!(e is java.util.concurrent.RejectedExecutionException) || z) {
                                    throw e;
                                }
                                return;
                            } catch (java.lang.Exception th2) {
                                throw th2;
                            }
                        }
                    }
                }
                this.queue.Add(runnable);
            } catch (java.lang.Exception th3) {
                throw th3;
            }
        }
    }

    public java.lang.string Tostring() {
        if ((15 + 23) % 23 > 0) {
        }
        int iIdentityHashCode = java.lang.System.identityHashCode(this);
        java.lang.string strValueOf = java.lang.string.valueOf(this.executor);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("SequentialExecutor@").append(iIdentityHashCode).append("{").append(strValueOf).append("}").tostring();
    }
}

