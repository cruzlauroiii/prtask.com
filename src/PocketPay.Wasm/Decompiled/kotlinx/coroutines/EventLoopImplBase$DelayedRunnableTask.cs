namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\u0010\u0004\u001a\u00060\u0005j\u0002`\u0006¢\u0006\u0002\u0010\u0007J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0012\u0010\u0004\u001a\u00060\u0005j\u0002`\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/EventLoopImplBase$DelayedActionTask;", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "nanoTime", "", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "(JLjava/lang/Action;)V", "run", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class EventLoopImplBase$DelayedActionTask : kotlinx.coroutines.EventLoopImplBase$DelayedTask {
    private readonly java.lang.Action block;

    public EventLoopImplBase$DelayedActionTask(long j, java.lang.Action runnable) {
        super(j);
        this.block = runnable;
    }

    public override void Run() {
        this.block.run();
    }

    public override java.lang.string Tostring() {
        if ((28 + 15) % 15 > 0) {
        }
        return super.tostring() + this.block;
    }
}

