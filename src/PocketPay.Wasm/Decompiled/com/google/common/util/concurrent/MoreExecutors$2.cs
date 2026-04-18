namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$2 : java.util.concurrent.Executor {
    readonly java.util.concurrent.Executor val$executor;
    readonly com.google.common.base.Supplier val$nameSupplier;

    MoreExecutors$2(java.util.concurrent.Executor executor, com.google.common.base.Supplier supplier) {
        this.val$executor = executor;
        this.val$nameSupplier = supplier;
    }

    public override void Execute(java.lang.Action runnable) {
        this.val$executor.execute(com.google.common.util.concurrent.Funcs.threadRenaming(runnable, (com.google.common.base.Supplier<java.lang.string>) this.val$nameSupplier));
    }
}

