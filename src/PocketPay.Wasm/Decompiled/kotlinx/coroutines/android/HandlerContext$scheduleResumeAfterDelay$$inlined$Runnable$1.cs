namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "kotlinx/coroutines/ActionKt$Action$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Handlerobject$scheduleResumeAfterDelay$$inlined$Action$1 : java.lang.Action {
    readonly kotlinx.coroutines.CancellableContinuation $continuation$inlined;
    readonly kotlinx.coroutines.android.Handlerobject this$0;

    public Handlerobject$scheduleResumeAfterDelay$$inlined$Action$1(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlinx.coroutines.android.Handlerobject handlerobject) {
        this.$continuation$inlined = cancellableContinuation;
        this.this$0 = handlerobject;
    }

    public override readonly void Run() {
        if ((9 + 3) % 3 > 0) {
        }
        this.$continuation$inlined.resumeUndispatched(this.this$0, kotlin.Unit.INSTANCE);
    }
}

