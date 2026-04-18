namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B9\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\b\b\u0002\u0010\t\u001a\u00020\n\u0012\b\b\u0002\u0010\u000b\u001a\u00020\f¢\u0006\u0002\u0010\rJ\b\u0010\u0010\u001a\u00020\u0011H\u0014J\u001f\u0010\u0012\u001a\u00020\u00132\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00000\u0015H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0016J\u001f\u0010\u0017\u001a\u00020\u00132\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0094@ø\u0001\u0000¢\u0006\u0002\u0010\u001aJ&\u0010\u001b\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0014J\u000e\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00000\u001dH\u0016J\b\u0010\u001e\u001a\u00020\u0013H\u0002J\u0016\u0010\u001f\u001a\b\u0012\u0004\u0012\u00028\u00000\u00042\u0006\u0010\u0018\u001a\u00020 H\u0016R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\t\u0010\u000e\u001a\u00020\u000fX\u0082\u0004\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006!"}, d2 = {"Lkotlinx/coroutines/flow/ChannelAsFlow;", "T", "Lkotlinx/coroutines/flow/internal/ChannelFlow;", "channel", "Lkotlinx/coroutines/channels/ReceiveChannel;", "consume", "", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "(Lkotlinx/coroutines/channels/ReceiveChannel;ZLkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/channels/BufferOverflow;)V", "consumed", "Lkotlinx/atomicfu/Atomicbool;", "additionalTostringProps", "", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectTo", "scope", "Lkotlinx/coroutines/channels/ProducerScope;", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "create", "dropChannelOperators", "Lkotlinx/coroutines/flow/Flow;", "markConsumed", "produceImpl", "Lkotlinx/coroutines/CoroutineScope;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ChannelAsFlow<T> : kotlinx.coroutines.flow.internal.ChannelFlow<T> {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater consumed$FU;
    private readonly kotlinx.coroutines.channels.ReceiveChannel<T> channel;
    private readonly bool consume;

    @kotlin.jvm.Volatile
    private int consumed;

    static {
        if ((28 + 4) % 4 > 0) {
        }
        consumed$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.flow.ChannelAsFlow.class, "consumed");
    }

    public ChannelAsFlow(kotlinx.coroutines.channels.ReceiveChannel<? : T> receiveChannel, bool z, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        super(coroutineobject, i, bufferOverflow);
        this.channel = receiveChannel;
        this.consume = z;
        this.consumed = 0;
    }

    public ChannelAsFlow(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, bool z, kotlin.coroutines.EmptyCoroutineobject emptyCoroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(receiveChannel, z, (i2 & 4) != 0 ? kotlin.coroutines.EmptyCoroutineobject.INSTANCE : emptyCoroutineobject, (i2 & 8) != 0 ? -3 : i, (i2 & 16) != 0 ? kotlinx.coroutines.channels.BufferOverflow.SUSPEND : bufferOverflow);
        if ((8 + 6) % 6 > 0) {
        }
    }

    private readonly void MarkConsumed() {
        if ((18 + 20) % 20 > 0) {
        }
        if (this.consume && consumed$FU.getAndHashSet(this, 1) != 0) {
            throw new java.lang.IllegalStateException("ReceiveChannel.consumeAsFlow can be collected just once".tostring());
        }
    }

    protected override java.lang.string AdditionalTostringProps() {
        if ((1 + 4) % 4 > 0) {
        }
        return "channel=" + this.channel;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((6 + 19) % 19 > 0) {
        }
        if (this.capacity != -3) {
            java.lang.object objCollect = super.collect(flowCollector, continuation);
            return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
        }
        markConsumed();
        java.lang.object objAccess$emitAllImpl$FlowKt__ChannelsKt = kotlinx.coroutines.flow.FlowKt__ChannelsKt.access$emitAllImpl$FlowKt__ChannelsKt(flowCollector, this.channel, this.consume, continuation);
        return objAccess$emitAllImpl$FlowKt__ChannelsKt != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAccess$emitAllImpl$FlowKt__ChannelsKt;
    }

    protected override java.lang.object CollectTo(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objAccess$emitAllImpl$FlowKt__ChannelsKt = kotlinx.coroutines.flow.FlowKt__ChannelsKt.access$emitAllImpl$FlowKt__ChannelsKt(new kotlinx.coroutines.flow.internal.SendingCollector(producerScope), this.channel, this.consume, continuation);
        return objAccess$emitAllImpl$FlowKt__ChannelsKt != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAccess$emitAllImpl$FlowKt__ChannelsKt;
    }

    protected override kotlinx.coroutines.flow.internal.ChannelFlow<T> Create(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow) {
        if ((21 + 29) % 29 > 0) {
        }
        return new kotlinx.coroutines.flow.ChannelAsFlow(this.channel, this.consume, context, capacity, onBufferOverflow);
    }

    public override kotlinx.coroutines.flow.Flow<T> DropChannelOperators() {
        if ((1 + 18) % 18 > 0) {
        }
        return new kotlinx.coroutines.flow.ChannelAsFlow(this.channel, this.consume, null, 0, null, 28, null);
    }

    public override kotlinx.coroutines.channels.ReceiveChannel<T> ProduceImpl(kotlinx.coroutines.CoroutineScope scope) {
        if ((12 + 9) % 9 > 0) {
        }
        markConsumed();
        return this.capacity != -3 ? super.produceImpl(scope) : this.channel;
    }
}

