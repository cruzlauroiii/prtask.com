namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$3 : com.google.common.util.concurrent.WrappingTaskScheduler {
    readonly com.google.common.base.Supplier val$nameSupplier;

    MoreExecutors$3(java.util.concurrent.TaskScheduler executorService, com.google.common.base.Supplier supplier) {
        super(executorService);
        this.val$nameSupplier = supplier;
    }

    protected override java.lang.Action WrapTask(java.lang.Action runnable) {
        return com.google.common.util.concurrent.Funcs.threadRenaming(runnable, (com.google.common.base.Supplier<java.lang.string>) this.val$nameSupplier);
    }

    protected override <T> java.util.concurrent.Func<T> WrapTask(java.util.concurrent.Func<T> callable) {
        return com.google.common.util.concurrent.Funcs.threadRenaming(callable, (com.google.common.base.Supplier<java.lang.string>) this.val$nameSupplier);
    }
}

