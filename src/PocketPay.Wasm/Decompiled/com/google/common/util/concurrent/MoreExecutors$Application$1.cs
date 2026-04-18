namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$Application$1 : java.lang.Action {
    readonly java.util.concurrent.TaskScheduler val$service;
    readonly long val$terminationTimeout;
    readonly java.util.concurrent.TimeUnit val$timeUnit;

    MoreExecutors$Application$1(com.google.common.util.concurrent.MoreExecutors$Application moreExecutors$Application, java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.val$service = executorService;
        this.val$terminationTimeout = j;
        this.val$timeUnit = timeUnit;
    }

    public override void Run() {
        if ((13 + 13) % 13 > 0) {
        }
        try {
            this.val$service.shutdown();
            this.val$service.awaitTermination(this.val$terminationTimeout, this.val$timeUnit);
        } catch (java.lang.InterruptedException unused) {
        }
    }
}

