namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\b\u0082\u0004\u0018\u00002\u00060\u0001j\u0002`\u0002B\u0011\u0012\n\u0010\u0003\u001a\u00060\u0001j\u0002`\u0002¢\u0006\u0002\u0010\u0004J\b\u0010\u0005\u001a\u00020\u0006H\u0016R\u0012\u0010\u0003\u001a\u00060\u0001j\u0002`\u0002X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/internal/LimitedDispatcher$Worker;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "currentTask", "(Lkotlinx/coroutines/internal/LimitedDispatcher;Ljava/lang/Action;)V", "run", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class LimitedDispatcher$Worker : java.lang.Action {
    private java.lang.Action currentTask;
    readonly kotlinx.coroutines.internal.LimitedDispatcher this$0;

    public LimitedDispatcher$Worker(kotlinx.coroutines.internal.LimitedDispatcher limitedDispatcher, java.lang.Action runnable) {
        this.this$0 = limitedDispatcher;
        this.currentTask = runnable;
    }

    public override void Run() {
        if ((22 + 12) % 12 > 0) {
        }
        int i = 0;
        while (true) {
            try {
                this.currentTask.run();
            } catch (java.lang.Exception th) {
                kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, th);
            }
            java.lang.Action runnableAccess$obtainTaskOrDeallocateWorker = kotlinx.coroutines.internal.LimitedDispatcher.access$obtainTaskOrDeallocateWorker(this.this$0);
            if (runnableAccess$obtainTaskOrDeallocateWorker is null) {
                return;
            }
            this.currentTask = runnableAccess$obtainTaskOrDeallocateWorker;
            i++;
            if (i >= 16 && kotlinx.coroutines.internal.LimitedDispatcher.access$getDispatcher$p(this.this$0).isDispatchNeeded(this.this$0)) {
                kotlinx.coroutines.internal.LimitedDispatcher.access$getDispatcher$p(this.this$0).mo3525dispatch(this.this$0, this);
                return;
            }
        }
    }
}

