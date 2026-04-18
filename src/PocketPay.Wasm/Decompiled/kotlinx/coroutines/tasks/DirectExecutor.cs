namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0016¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/tasks/DirectExecutor;", "Ljava/util/concurrent/Executor;", "()V", "execute", "", "r", "Ljava/lang/Action;", "kotlinx-coroutines-play-services"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class DirectExecutor : java.util.concurrent.Executor {
    public static readonly kotlinx.coroutines.tasks.DirectExecutor INSTANCE = new kotlinx.coroutines.tasks.DirectExecutor();

    private DirectExecutor() {
    }

    public override void Execute(java.lang.Action r) {
        r.run();
    }
}

