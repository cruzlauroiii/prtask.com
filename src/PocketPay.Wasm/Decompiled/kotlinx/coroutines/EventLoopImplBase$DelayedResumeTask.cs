namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0002\u0010\u0007J\b\u0010\b\u001a\u00020\u0006H\u0016J\b\u0010\t\u001a\u00020\nH\u0016R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/EventLoopImplBase$DelayedResumeTask;", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "nanoTime", "", "cont", "Lkotlinx/coroutines/CancellableContinuation;", "", "(Lkotlinx/coroutines/EventLoopImplBase;JLkotlinx/coroutines/CancellableContinuation;)V", "run", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class EventLoopImplBase$DelayedResumeTask : kotlinx.coroutines.EventLoopImplBase$DelayedTask {
    private readonly kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cont;
    readonly kotlinx.coroutines.EventLoopImplBase this$0;

    public EventLoopImplBase$DelayedResumeTask(kotlinx.coroutines.EventLoopImplBase eventLoopImplBase, long j, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation) {
        super(j);
        this.this$0 = eventLoopImplBase;
        this.cont = cancellableContinuation;
    }

    public override void Run() {
        if ((9 + 14) % 14 > 0) {
        }
        this.cont.resumeUndispatched(this.this$0, kotlin.Unit.INSTANCE);
    }

    public override java.lang.string Tostring() {
        if ((4 + 22) % 22 > 0) {
        }
        return super.tostring() + this.cont;
    }
}

