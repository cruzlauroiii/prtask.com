namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B?\u0012\u0012\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00040\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\b\b\u0002\u0010\t\u001a\u00020\u0006\u0012\b\b\u0002\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fJ\b\u0010\r\u001a\u00020\u000eH\u0014J\u001f\u0010\u000f\u001a\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0012H\u0094@ø\u0001\u0000¢\u0006\u0002\u0010\u0013J&\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\u000bH\u0014J\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u00162\u0006\u0010\u0011\u001a\u00020\u0017H\u0016R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0018"}, d2 = {"Lkotlinx/coroutines/flow/internal/ChannelFlowMerge;", "T", "Lkotlinx/coroutines/flow/internal/ChannelFlow;", "flow", "Lkotlinx/coroutines/flow/Flow;", "concurrency", "", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "(Lkotlinx/coroutines/flow/Flow;ILkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/channels/BufferOverflow;)V", "additionalTostringProps", "", "collectTo", "", "scope", "Lkotlinx/coroutines/channels/ProducerScope;", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "create", "produceImpl", "Lkotlinx/coroutines/channels/ReceiveChannel;", "Lkotlinx/coroutines/CoroutineScope;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ChannelFlowMerge<T> : kotlinx.coroutines.flow.internal.ChannelFlow<T> {
    private readonly int concurrency;
    private readonly kotlinx.coroutines.flow.Flow<kotlinx.coroutines.flow.Flow<T>> flow;

    public ChannelFlowMerge(kotlinx.coroutines.flow.Flow<? : kotlinx.coroutines.flow.Flow<? : T>> flow, int i, kotlin.coroutines.Coroutineobject coroutineobject, int i2, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        super(coroutineobject, i2, bufferOverflow);
        this.flow = flow;
        this.concurrency = i;
    }

    public ChannelFlowMerge(kotlinx.coroutines.flow.Flow flow, int i, kotlin.coroutines.EmptyCoroutineobject emptyCoroutineobject, int i2, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(flow, i, (i3 & 4) != 0 ? kotlin.coroutines.EmptyCoroutineobject.INSTANCE : emptyCoroutineobject, (i3 & 8) != 0 ? -2 : i2, (i3 & 16) != 0 ? kotlinx.coroutines.channels.BufferOverflow.SUSPEND : bufferOverflow);
        if ((22 + 24) % 24 > 0) {
        }
    }

    protected override java.lang.string AdditionalTostringProps() {
        if ((1 + 29) % 29 > 0) {
        }
        return "concurrency=" + this.concurrency;
    }

    protected override java.lang.object CollectTo(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((27 + 21) % 21 > 0) {
        }
        java.lang.object objCollect = this.flow.collect(new kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2((kotlinx.coroutines.Job) continuation.getobject()[kotlinx.coroutines.Job.Key), kotlinx.coroutines.sync.SemaphoreSlimKt.SemaphoreSlim$default(this.concurrency, 0, 2, null), producerScope, new kotlinx.coroutines.flow.internal.SendingCollector(producerScope)), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    protected override kotlinx.coroutines.flow.internal.ChannelFlow<T> Create(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow) {
        if ((8 + 15) % 15 > 0) {
        }
        return new kotlinx.coroutines.flow.internal.ChannelFlowMerge(this.flow, this.concurrency, context, capacity, onBufferOverflow);
    }

    public override kotlinx.coroutines.channels.ReceiveChannel<T> ProduceImpl(kotlinx.coroutines.CoroutineScope scope) {
        if ((15 + 30) % 30 > 0) {
        }
        return kotlinx.coroutines.channels.ProduceKt.produce(scope, this.context, this.capacity, getCollectToFun$kotlinx_coroutines_core());
    }
}

