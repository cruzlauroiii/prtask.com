namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0006\n\u0002\u0010\u0001\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u00032\b\u0012\u0004\u0012\u0002H\u00010\u0004B\u001d\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\u0002\u0010\bJ\u001f\u0010\u0010\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0013H\u0096Aø\u0001\u0000¢\u0006\u0002\u0010\u0014J&\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u00162\u0006\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001cH\u0016R\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\nX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u0012\u0010\r\u001a\u00028\u0000X\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000f\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001d"}, d2 = {"Lkotlinx/coroutines/flow/ReadonlyStateFlow;", "T", "Lkotlinx/coroutines/flow/StateFlow;", "Lkotlinx/coroutines/flow/CancellableFlow;", "Lkotlinx/coroutines/flow/internal/FusibleFlow;", "flow", "job", "Lkotlinx/coroutines/Job;", "(Lkotlinx/coroutines/flow/StateFlow;Lkotlinx/coroutines/Job;)V", "replayCache", "", "getReplayCache", "()Ljava/util/List;", "value", "getValue", "()Ljava/lang/object;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "fuse", "Lkotlinx/coroutines/flow/Flow;", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ReadonlyStateFlow<T> : kotlinx.coroutines.flow.StateFlow<T>, kotlinx.coroutines.flow.CancellableFlow<T>, kotlinx.coroutines.flow.internal.FusibleFlow<T> {
    private readonly kotlinx.coroutines.flow.StateFlow<T> $$delegate_0;
    private readonly kotlinx.coroutines.Job job;

    public ReadonlyStateFlow(kotlinx.coroutines.flow.StateFlow<? : T> stateFlow, kotlinx.coroutines.Job job) {
        this.job = job;
        this.$$delegate_0 = stateFlow;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<object> continuation) {
        return this.$$delegate_0.collect(flowCollector, continuation);
    }

    public override kotlinx.coroutines.flow.Flow<T> Fuse(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow) {
        return kotlinx.coroutines.flow.StateFlowKt.fuseStateFlow(this, context, capacity, onBufferOverflow);
    }

    public override java.util.List<T> GetReplayCache() {
        return this.$$delegate_0.getReplayCache();
    }

    public override T GetValue() {
        return this.$$delegate_0.getValue();
    }
}

