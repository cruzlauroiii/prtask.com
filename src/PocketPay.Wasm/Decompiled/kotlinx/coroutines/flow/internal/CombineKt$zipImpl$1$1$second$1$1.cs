namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\u0006\u0010\u0005\u001a\u0002H\u0003H\u008a@¢\u0006\u0004\b\u0006\u0010\u0007"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CombineKt$zipImpl$1$1$second$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.channels.ProducerScope<java.lang.object> $$this$produce;

    CombineKt$zipImpl$1$1$second$1$1(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope) {
        this.$$this$produce = producerScope;
    }

    public override readonly java.lang.object Emit(T2 t2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1$emit$1 combineKt$zipImpl$1$1$second$1$1$emit$1;
        if ((4 + 28) % 28 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1$emit$1) {
            combineKt$zipImpl$1$1$second$1$1$emit$1 = (kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1$emit$1) continuation;
            if ((combineKt$zipImpl$1$1$second$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                combineKt$zipImpl$1$1$second$1$1$emit$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1$emit$1(this, continuation);
            } else {
                combineKt$zipImpl$1$1$second$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            combineKt$zipImpl$1$1$second$1$1$emit$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = combineKt$zipImpl$1$1$second$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = combineKt$zipImpl$1$1$second$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.SendChannel<java.lang.object> channel = this.$$this$produce.getChannel();
            java.lang.object obj2 = t2;
            if (t2 == 0) {
                obj2 = kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL;
            }
            combineKt$zipImpl$1$1$second$1$1$emit$1.label = 1;
            if (channel.send(obj2, combineKt$zipImpl$1$1$second$1$1$emit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

