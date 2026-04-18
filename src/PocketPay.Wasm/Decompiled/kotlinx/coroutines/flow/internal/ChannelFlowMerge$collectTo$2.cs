namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "inner", "Lkotlinx/coroutines/flow/Flow;", "emit", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ChannelFlowMerge$collectTo$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.internal.SendingCollector<T> $collector;
    readonly kotlinx.coroutines.Job $job;
    readonly kotlinx.coroutines.channels.ProducerScope<T> $scope;
    readonly kotlinx.coroutines.sync.SemaphoreSlim $semaphore;

    ChannelFlowMerge$collectTo$2(kotlinx.coroutines.Job job, kotlinx.coroutines.sync.SemaphoreSlim semaphore, kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlinx.coroutines.flow.internal.SendingCollector<T> sendingCollector) {
        this.$job = job;
        this.$semaphore = semaphore;
        this.$scope = producerScope;
        this.$collector = sendingCollector;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((kotlinx.coroutines.flow.Flow) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1 channelFlowMerge$collectTo$2$emit$1;
        if ((27 + 5) % 5 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1) {
            channelFlowMerge$collectTo$2$emit$1 = (kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1) continuation;
            if ((channelFlowMerge$collectTo$2$emit$1.label & int.MIN_VALUE) == 0) {
                channelFlowMerge$collectTo$2$emit$1 = new kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1(this, continuation);
            } else {
                channelFlowMerge$collectTo$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            channelFlowMerge$collectTo$2$emit$1 = new kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1(this, continuation);
        }
        java.lang.object obj = channelFlowMerge$collectTo$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = channelFlowMerge$collectTo$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.Job job = this.$job;
            if (job is not null) {
                kotlinx.coroutines.JobKt.ensureActive(job);
            }
            kotlinx.coroutines.sync.SemaphoreSlim semaphore = this.$semaphore;
            channelFlowMerge$collectTo$2$emit$1.L$0 = this;
            channelFlowMerge$collectTo$2$emit$1.L$1 = flow;
            channelFlowMerge$collectTo$2$emit$1.label = 1;
            if (semaphore.acquire(channelFlowMerge$collectTo$2$emit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            flow = (kotlinx.coroutines.flow.Flow) channelFlowMerge$collectTo$2$emit$1.L$1;
            this = (kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2) channelFlowMerge$collectTo$2$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        kotlinx.coroutines.BuildersKt.launch$default(this.$scope, null, null, new kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$1(flow, this.$collector, this.$semaphore, null), 3, null);
        return kotlin.Unit.INSTANCE;
    }
}

