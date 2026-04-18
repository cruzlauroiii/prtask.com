namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$4 : com.google.common.util.concurrent.WrappingScheduledTaskScheduler {
    readonly com.google.common.base.Supplier val$nameSupplier;

    MoreExecutors$4(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, com.google.common.base.Supplier supplier) {
        super(scheduledTaskScheduler);
        this.val$nameSupplier = supplier;
    }

    protected override java.lang.Action WrapTask(java.lang.Action runnable) {
        return com.google.common.util.concurrent.Funcs.threadRenaming(runnable, (com.google.common.base.Supplier<java.lang.string>) this.val$nameSupplier);
    }

    protected override <T> java.util.concurrent.Func<T> WrapTask(java.util.concurrent.Func<T> callable) {
        return com.google.common.util.concurrent.Funcs.threadRenaming(callable, (com.google.common.base.Supplier<java.lang.string>) this.val$nameSupplier);
    }
}

