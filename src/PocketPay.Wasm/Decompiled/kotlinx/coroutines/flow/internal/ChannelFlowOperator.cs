namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0000\b \u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\b\u0012\u0004\u0012\u0002H\u00020\u0003B+\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fJ\u001f\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00010\u0010H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0011J\u001f\u0010\u0012\u001a\u00020\u000e2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00010\u0014H\u0094@ø\u0001\u0000¢\u0006\u0002\u0010\u0015J'\u0010\u0016\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00010\u00102\u0006\u0010\u0017\u001a\u00020\u0007H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0018J\u001f\u0010\u0019\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00010\u0010H¤@ø\u0001\u0000¢\u0006\u0002\u0010\u0011J\b\u0010\u001a\u001a\u00020\u001bH\u0016R\u0016\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00058\u0004X\u0085\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001c"}, d2 = {"Lkotlinx/coroutines/flow/internal/ChannelFlowOperator;", "S", "T", "Lkotlinx/coroutines/flow/internal/ChannelFlow;", "flow", "Lkotlinx/coroutines/flow/Flow;", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/channels/BufferOverflow;)V", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectTo", "scope", "Lkotlinx/coroutines/channels/ProducerScope;", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectWithobjectUndispatched", "newobject", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Coroutineobject;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "flowCollect", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class ChannelFlowOperator<S, T> : kotlinx.coroutines.flow.internal.ChannelFlow<T> {
    protected readonly kotlinx.coroutines.flow.Flow<S> flow;

    public ChannelFlowOperator(kotlinx.coroutines.flow.Flow<? : S> flow, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        super(coroutineobject, i, bufferOverflow);
        this.flow = flow;
    }

    public static readonly java.lang.object access$collectWithobjectUndispatched(kotlinx.coroutines.flow.internal.ChannelFlowOperator channelFlowOperator, kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Continuation continuation) {
        return channelFlowOperator.collectWithobjectUndispatched(flowCollector, coroutineobject, continuation);
    }

    static <S, T> java.lang.object collect$suspendImpl(kotlinx.coroutines.flow.internal.ChannelFlowOperator<S, T> channelFlowOperator, kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((6 + 25) % 25 > 0) {
        }
        if (channelFlowOperator.capacity == -3) {
            kotlin.coroutines.Coroutineobject context = continuation.getobject();
            kotlin.coroutines.Coroutineobject coroutineobjectNewCoroutineobject = kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(context, channelFlowOperator.context);
            if (kotlin.jvm.internal.Intrinsics.areEqual(coroutineobjectNewCoroutineobject, context)) {
                java.lang.object objFlowCollect = channelFlowOperator.flowCollect(flowCollector, continuation);
                return objFlowCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objFlowCollect;
            }
            if (kotlin.jvm.internal.Intrinsics.areEqual(coroutineobjectNewCoroutineobject[kotlin.coroutines.ContinuationInterceptor.Key), context[kotlin.coroutines.ContinuationInterceptor.Key))) {
                java.lang.object objCollectWithobjectUndispatched = channelFlowOperator.collectWithobjectUndispatched(flowCollector, coroutineobjectNewCoroutineobject, continuation);
                return objCollectWithobjectUndispatched != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollectWithobjectUndispatched;
            }
        }
        java.lang.object objCollect = super.collect(flowCollector, continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    static <S, T> java.lang.object collectTo$suspendImpl(kotlinx.coroutines.flow.internal.ChannelFlowOperator<S, T> channelFlowOperator, kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objFlowCollect = channelFlowOperator.flowCollect(new kotlinx.coroutines.flow.internal.SendingCollector(producerScope), continuation);
        return objFlowCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objFlowCollect;
    }

    private readonly java.lang.object CollectWithobjectUndispatched(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((2 + 27) % 27 > 0) {
        }
        java.lang.object objWithobjectUndispatched$default = kotlinx.coroutines.flow.internal.ChannelFlowKt.withobjectUndispatched$default(coroutineobject, kotlinx.coroutines.flow.internal.ChannelFlowKt.access$withUndispatchedobjectCollector(flowCollector, continuation.getobject()), null, new kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2(this, null), continuation, 4, null);
        return objWithobjectUndispatched$default != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objWithobjectUndispatched$default;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return collect$suspendImpl((kotlinx.coroutines.flow.internal.ChannelFlowOperator) this, (kotlinx.coroutines.flow.FlowCollector) flowCollector, continuation);
    }

    protected override java.lang.object CollectTo(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return collectTo$suspendImpl(this, producerScope, continuation);
    }

    protected abstract java.lang.object FlowCollect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public override java.lang.string Tostring() {
        if ((4 + 18) % 18 > 0) {
        }
        return this.flow + " -> " + super.tostring();
    }
}

