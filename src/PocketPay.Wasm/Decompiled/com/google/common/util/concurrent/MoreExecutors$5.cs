namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$5 : java.util.concurrent.Executor {
    readonly java.util.concurrent.Executor val$delegate;
    readonly com.google.common.util.concurrent.AbstractTask val$future;

    MoreExecutors$5(java.util.concurrent.Executor executor, com.google.common.util.concurrent.AbstractTask abstractTask) {
        this.val$delegate = executor;
        this.val$future = abstractTask;
    }

    public override void Execute(java.lang.Action runnable) {
        try {
            this.val$delegate.execute(runnable);
        } catch (java.util.concurrent.RejectedExecutionException e) {
            this.val$future.setException(e);
        }
    }
}

