namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "kotlinx/coroutines/ActionKt$Action$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ActionC0465x222d1ab6 : java.lang.Action {
    readonly kotlinx.coroutines.CancellableContinuation $cont$inlined;

    public ActionC0465x222d1ab6(kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        this.$cont$inlined = cancellableContinuation;
    }

    public override readonly void Run() {
        kotlinx.coroutines.android.HandlerDispatcherKt.access$updateChoreographerAndPostFrameCallback(this.$cont$inlined);
    }
}

