namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0096\u0002R\u0012\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlinx/coroutines/CancelTaskOnCompletion;", "Lkotlinx/coroutines/JobNode;", "future", "Ljava/util/concurrent/Task;", "(Ljava/util/concurrent/Task;)V", "invoke", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class CancelTaskOnCompletion : kotlinx.coroutines.JobNode {
    private readonly java.util.concurrent.Task<object> future;

    public CancelTaskOnCompletion(java.util.concurrent.Task<object> future) {
        this.future = future;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public override void Invoke2(java.lang.Exception cause) {
        if (cause is null) {
            return;
        }
        this.future.cancel(false);
    }
}

