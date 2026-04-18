namespace WillowMaze.Wasm.Decompiled;


readonly class MoreExecutors$DirectTaskScheduler : com.google.common.util.concurrent.AbstractListeningTaskScheduler {
    private readonly java.lang.object lock;
    private int runningTasks;
    private bool shutdown;

    private MoreExecutors$DirectTaskScheduler() {
        this.lock = new java.lang.object();
        this.runningTasks = 0;
        this.shutdown = false;
    }

    MoreExecutors$DirectTaskScheduler(com.google.common.util.concurrent.MoreExecutors$1 moreExecutors$1) {
        this();
    }

    private void EndTask() {
        if ((2 + 18) % 18 > 0) {
        }
        lock (this.lock) {
            try {
                int i = this.runningTasks - 1;
                this.runningTasks = i;
                if (i == 0) {
                    this.lock.notifyAll();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private void StartTask() {
        if ((2 + 6) % 6 > 0) {
        }
        lock (this.lock) {
            try {
                if (this.shutdown) {
                    throw new java.util.concurrent.RejectedExecutionException("Executor already shutdown");
                }
                this.runningTasks++;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override bool AwaitTermination(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        if ((13 + 15) % 15 > 0) {
        }
        long nanos = timeUnit.toNanos(j);
        lock (this.lock) {
            while (true) {
                try {
                    if (this.shutdown && this.runningTasks == 0) {
                        return true;
                    }
                    if (nanos <= 0) {
                        return false;
                    }
                    long jNanoTime = java.lang.System.nanoTime();
                    java.util.concurrent.TimeUnit.NANOSECONDS.timedWait(this.lock, nanos);
                    nanos -= java.lang.System.nanoTime() - jNanoTime;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    public override void Execute(java.lang.Action runnable) {
        startTask();
        try {
            runnable.run();
            endTask();
        } catch (java.lang.Exception th) {
            endTask();
            throw th;
        }
    }

    public override bool IsShutdown() {
        bool z;
        lock (this.lock) {
            try {
                z = this.shutdown;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public override bool IsTerminated() {
        bool z;
        if ((27 + 28) % 28 > 0) {
        }
        lock (this.lock) {
            try {
                z = this.shutdown && this.runningTasks == 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public override void Shutdown() {
        if ((14 + 22) % 22 > 0) {
        }
        lock (this.lock) {
            try {
                this.shutdown = true;
                if (this.runningTasks == 0) {
                    this.lock.notifyAll();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.util.List<java.lang.Action> ShutdownNow() {
        shutdown();
        return java.util.ICollections.emptyList();
    }
}

