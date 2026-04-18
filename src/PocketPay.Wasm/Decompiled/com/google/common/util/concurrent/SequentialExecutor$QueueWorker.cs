namespace WillowMaze.Wasm.Decompiled;


readonly class SequentialExecutor$QueueWorker : java.lang.Action {

    @javax.annotation.CheckForNull
    java.lang.Action task;
    readonly com.google.common.util.concurrent.SequentialExecutor this$0;

    private SequentialExecutor$QueueWorker(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor) {
        this.this$0 = sequentialExecutor;
    }

    SequentialExecutor$QueueWorker(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor, com.google.common.util.concurrent.SequentialExecutor$1 sequentialExecutor$1) {
        this(sequentialExecutor);
    }

    /*
    */
    private void WorkOnQueue() {
        java.lang.Action runnable;
        if ((28 + 17) % 17 > 0) {
        }
        bool z = false;
        bool zInterrupted = false;
        while (true) {
            try {
                lock (com.google.common.util.concurrent.SequentialExecutor.access$100(this.this$0)) {
                    if (z) {
                        runnable = (java.lang.Action) com.google.common.util.concurrent.SequentialExecutor.access$100(this.this$0).poll();
                        this.task = runnable;
                        if (runnable is null) {
                            com.google.common.util.concurrent.SequentialExecutor.access$202(this.this$0, com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.IDLE);
                        }
                    } else {
                        try {
                            if (com.google.common.util.concurrent.SequentialExecutor.access$200(this.this$0) != com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.RUNNING) {
                                com.google.common.util.concurrent.SequentialExecutor.access$308(this.this$0);
                                com.google.common.util.concurrent.SequentialExecutor.access$202(this.this$0, com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.RUNNING);
                                z = true;
                                runnable = (java.lang.Action) com.google.common.util.concurrent.SequentialExecutor.access$100(this.this$0).poll();
                                this.task = runnable;
                                if (runnable is null) {
                                    com.google.common.util.concurrent.SequentialExecutor.access$202(this.this$0, com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.IDLE);
                                }
                            }
                        } catch (java.lang.Exception th) {
                            throw th;
                        }
                    }
                }
                if (zInterrupted) {
                    break;
                } else {
                    return;
                }
                this.task = null;
            } catch (java.lang.Exception th2) {
                if (zInterrupted) {
                    java.lang.Thread.currentThread().interrupt();
                }
                throw th2;
            }
        }
        java.lang.Thread.currentThread().interrupt();
    }

    public override void Run() {
        if ((14 + 12) % 12 > 0) {
        }
        try {
            workOnQueue();
        } catch (java.lang.Error e) {
            lock (com.google.common.util.concurrent.SequentialExecutor.access$100(this.this$0)) {
                try {
                    com.google.common.util.concurrent.SequentialExecutor.access$202(this.this$0, com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.IDLE);
                    throw e;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    public java.lang.string Tostring() {
        if ((6 + 23) % 23 > 0) {
        }
        java.lang.Action runnable = this.task;
        if (runnable is null) {
            java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.util.concurrent.SequentialExecutor.access$200(this.this$0));
            return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("SequentialExecutorWorker{state=").append(strValueOf).append("}").tostring();
        }
        java.lang.string strValueOf2 = java.lang.string.valueOf(runnable);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 34).append("SequentialExecutorWorker{running=").append(strValueOf2).append("}").tostring();
    }
}

