namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowSubscription$consumeFlow$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.reactive.FlowSubscription<T> this$0;

    FlowSubscription$consumeFlow$2(kotlinx.coroutines.reactive.FlowSubscription<T> flowSubscription) {
        this.this$0 = flowSubscription;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((7 + 11) % 11 > 0) {
        }
        this.this$0.subscriber.onNext(t);
        if (kotlinx.coroutines.reactive.FlowSubscription.access$getRequested$FU$p().decrementAndGet(this.this$0) > 0) {
            kotlinx.coroutines.JobKt.ensureActive(this.this$0.getCoroutineobject());
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.reactive.FlowSubscription<T> flowSubscription = this.this$0;
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.reactive.FlowSubscription.access$getProducer$FU$p().set(flowSubscription, cancellableContinuationImpl);
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }
}

