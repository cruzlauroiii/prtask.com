namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\u0001\n\u0002\b\u0003\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002BE\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012-\u0010\u0004\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0005¢\u0006\u0002\b\nø\u0001\u0000¢\u0006\u0002\u0010\u000bJ\u001f\u0010\u0011\u001a\u00020\u00122\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0014R:\u0010\u0004\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0005¢\u0006\u0002\b\nX\u0082\u0004ø\u0001\u0000¢\u0006\u0004\n\u0002\u0010\fR\u0018\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u000eX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0015"}, d2 = {"Lkotlinx/coroutines/flow/SubscribedSharedFlow;", "T", "Lkotlinx/coroutines/flow/SharedFlow;", "sharedFlow", "action", "Lkotlin/Function2;", "Lkotlinx/coroutines/flow/FlowCollector;", "Lkotlin/coroutines/Continuation;", "", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/coroutines/flow/SharedFlow;Lkotlin/jvm/functions/Function2;)V", "Lkotlin/jvm/functions/Function2;", "replayCache", "", "getReplayCache", "()Ljava/util/List;", "collect", "", "collector", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SubscribedSharedFlow<T> : kotlinx.coroutines.flow.SharedFlow<T> {
    private readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> action;
    private readonly kotlinx.coroutines.flow.SharedFlow<T> sharedFlow;

    public SubscribedSharedFlow(kotlinx.coroutines.flow.SharedFlow<? : T> sharedFlow, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        this.sharedFlow = sharedFlow;
        this.action = function2;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<object> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1 subscribedSharedFlow$collect$1;
        if ((23 + 12) % 12 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1) {
            subscribedSharedFlow$collect$1 = (kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1) continuation;
            if ((subscribedSharedFlow$collect$1.label & int.MIN_VALUE) == 0) {
                subscribedSharedFlow$collect$1 = new kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1(this, continuation);
            } else {
                subscribedSharedFlow$collect$1.label -= int.MIN_VALUE;
            }
        } else {
            subscribedSharedFlow$collect$1 = new kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1(this, continuation);
        }
        java.lang.object obj = subscribedSharedFlow$collect$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = subscribedSharedFlow$collect$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.SharedFlow<T> sharedFlow = this.sharedFlow;
            kotlinx.coroutines.flow.SubscribedFlowCollector subscribedFlowCollector = new kotlinx.coroutines.flow.SubscribedFlowCollector(flowCollector, this.action);
            subscribedSharedFlow$collect$1.label = 1;
            if (sharedFlow.collect(subscribedFlowCollector, subscribedSharedFlow$collect$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        throw new kotlin.KotlinNothingValueException();
    }

    public override java.util.List<T> GetReplayCache() {
        return this.sharedFlow.getReplayCache();
    }
}

