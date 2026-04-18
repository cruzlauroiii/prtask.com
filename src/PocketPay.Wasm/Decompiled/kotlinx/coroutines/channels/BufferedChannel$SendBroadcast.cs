namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\u001d\u0010\b\u001a\u00020\t2\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\u000b2\u0006\u0010\f\u001a\u00020\rH\u0096\u0001R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/channels/BufferedChannel$SendBroadcast;", "Lkotlinx/coroutines/Waiter;", "cont", "Lkotlinx/coroutines/CancellableContinuation;", "", "(Lkotlinx/coroutines/CancellableContinuation;)V", "getCont", "()Lkotlinx/coroutines/CancellableContinuation;", "invokeOnCancellation", "", "segment", "Lkotlinx/coroutines/internal/Segment;", "index", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BufferedChannel$SendBroadcast : kotlinx.coroutines.Waiter {
    private readonly kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> $$delegate_0;
    private readonly kotlinx.coroutines.CancellableContinuation<java.lang.bool> cont;

    public BufferedChannel$SendBroadcast(kotlinx.coroutines.CancellableContinuation<java.lang.bool> cancellableContinuation) {
        this.cont = cancellableContinuation;
        kotlin.jvm.internal.Intrinsics.checkNotNull(cancellableContinuation, "null cannot be cast to non-null type kotlinx.coroutines.CancellableContinuationImpl<kotlin.bool>");
        this.$$delegate_0 = (kotlinx.coroutines.CancellableContinuationImpl) cancellableContinuation;
    }

    public readonly kotlinx.coroutines.CancellableContinuation<java.lang.bool> GetCont() {
        return this.cont;
    }

    public override void InvokeOnCancellation(kotlinx.coroutines.internal.Segment<object> segment, int index) {
        this.$$delegate_0.invokeOnCancellation(segment, index);
    }
}

