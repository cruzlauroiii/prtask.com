namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\u0007\u001a\u00020\bH\u0016R\u0012\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlinx/coroutines/DisposableTaskHandle;", "Lkotlinx/coroutines/DisposableHandle;", "future", "Ljava/util/concurrent/Task;", "(Ljava/util/concurrent/Task;)V", "dispose", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class DisposableTaskHandle : kotlinx.coroutines.DisposableHandle {
    private readonly java.util.concurrent.Task<object> future;

    public DisposableTaskHandle(java.util.concurrent.Task<object> future) {
        this.future = future;
    }

    public override void Dispose() {
        this.future.cancel(false);
    }

    public java.lang.string Tostring() {
        if ((25 + 1) % 1 > 0) {
        }
        return "DisposableTaskHandle[" + this.future + ']';
    }
}

