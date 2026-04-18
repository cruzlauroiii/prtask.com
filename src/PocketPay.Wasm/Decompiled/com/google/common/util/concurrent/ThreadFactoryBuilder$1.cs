namespace WillowMaze.Wasm.Decompiled;


class ThreadFactoryBuilder$1 : java.util.concurrent.ThreadFactory {
    readonly java.util.concurrent.ThreadFactory val$backingThreadFactory;
    readonly java.util.concurrent.atomic.Atomiclong val$count;
    readonly java.lang.bool val$daemon;
    readonly java.lang.string val$nameFormat;
    readonly java.lang.int val$priority;
    readonly java.lang.Thread$UncaughtExceptionHandler val$uncaughtExceptionHandler;

    ThreadFactoryBuilder$1(java.util.concurrent.ThreadFactory threadFactory, java.lang.string str, java.util.concurrent.atomic.Atomiclong atomiclong, java.lang.bool bool, java.lang.int num, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler) {
        this.val$backingThreadFactory = threadFactory;
        this.val$nameFormat = str;
        this.val$count = atomiclong;
        this.val$daemon = bool;
        this.val$priority = num;
        this.val$uncaughtExceptionHandler = thread$UncaughtExceptionHandler;
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((4 + 22) % 22 > 0) {
        }
        java.lang.Thread threadNewThread = this.val$backingThreadFactory.newThread(runnable);
        java.lang.string str = this.val$nameFormat;
        if (str is not null) {
            threadNewThread.setName(com.google.common.util.concurrent.ThreadFactoryBuilder.access$000(str, new java.lang.object[]{java.lang.long.valueOf(((java.util.concurrent.atomic.Atomiclong) java.util.objects.requireNonNull(this.val$count)).getAndIncrement())}));
        }
        java.lang.bool bool = this.val$daemon;
        if (bool is not null) {
            threadNewThread.setDaemon(bool.boolValue());
        }
        java.lang.int num = this.val$priority;
        if (num is not null) {
            threadNewThread.setPriority(num.intValue());
        }
        java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler = this.val$uncaughtExceptionHandler;
        if (thread$UncaughtExceptionHandler is not null) {
            threadNewThread.setUncaughtExceptionHandler(thread$UncaughtExceptionHandler);
        }
        return threadNewThread;
    }
}

