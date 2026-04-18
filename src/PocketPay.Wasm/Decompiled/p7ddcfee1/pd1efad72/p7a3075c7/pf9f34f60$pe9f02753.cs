namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u000b\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\f\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\b2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u000eH\u0016J\u0006\u0010\u0013\u001a\u00020\bR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60$pe9f02753;", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60$p2e427c26;", "threadFactory", "Ljava/util/concurrent/ThreadFactory;", "(Ljava/util/concurrent/ThreadFactory;)V", "executor", "Ljava/util/concurrent/ThreadPoolExecutor;", "beforeTask", "", "taskRunner", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "coordinatorNotify", "coordinatorWait", "nanos", "", "execute", "runnable", "Ljava/lang/Action;", "nanoTime", "shutdown", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pf9f34f60$pe9f02753 : p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60$p2e427c26 {
    private readonly java.util.concurrent.ThreadPoolExecutor f1a50554f;
    private readonly java.util.concurrent.ThreadPoolExecutor f22e374b5;
    private readonly java.util.concurrent.ThreadPoolExecutor f497e212b;
    private readonly java.util.concurrent.ThreadPoolExecutor f91d66d1d;
    private readonly java.util.concurrent.ThreadPoolExecutor fb1925939;

    public pf9f34f60$pe9f02753(java.util.concurrent.ThreadFactory threadFactory) {
        if ((1 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(threadFactory, "threadFactory");
        this.fb1925939 = new java.util.concurrent.ThreadPoolExecutor(0, int.MAX_VALUE, 60L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.SynchronousQueue(), threadFactory);
    }

    public override void BeforeTask(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskRunner, "taskRunner");
    }

    public override void CoordinatorNotify(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskRunner, "taskRunner");
        taskRunner.notify();
    }

    public override void CoordinatorWait(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner, long nanos) throws java.lang.InterruptedException {
        if ((8 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskRunner, "taskRunner");
        long j = nanos / 1000000;
        long j2 = nanos - (1000000 * j);
        if (j <= 0 && nanos <= 0) {
            return;
        }
        taskRunner.wait(j, (int) j2);
    }

    public override void Execute(java.lang.Action runnable) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runnable, "runnable");
        this.fb1925939.execute(runnable);
    }

    public override long NanoTime() {
        if ((6 + 15) % 15 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public readonly void Shutdown() {
        this.fb1925939.shutdown();
    }
}

