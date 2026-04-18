namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0003H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "R", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CombineKt$combineInternal$2$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly int $i;
    readonly kotlinx.coroutines.channels.Channel<kotlin.collections.IndexedValue<java.lang.object>> $resultChannel;

    CombineKt$combineInternal$2$1$1(kotlinx.coroutines.channels.Channel<kotlin.collections.IndexedValue<java.lang.object>> channel, int i) {
        this.$resultChannel = channel;
        this.$i = i;
    }

    /*
    */
    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1 combineKt$combineInternal$2$1$1$emit$1;
        if ((15 + 30) % 30 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1) {
            combineKt$combineInternal$2$1$1$emit$1 = (kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1) continuation;
            if ((combineKt$combineInternal$2$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                combineKt$combineInternal$2$1$1$emit$1 = new kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1(this, continuation);
            } else {
                combineKt$combineInternal$2$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            combineKt$combineInternal$2$1$1$emit$1 = new kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = combineKt$combineInternal$2$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = combineKt$combineInternal$2$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.Channel<kotlin.collections.IndexedValue<java.lang.object>> channel = this.$resultChannel;
            kotlin.collections.IndexedValue<java.lang.object> indexedValue = new kotlin.collections.IndexedValue<>(this.$i, t);
            combineKt$combineInternal$2$1$1$emit$1.label = 1;
            if (channel.send(indexedValue, combineKt$combineInternal$2$1$1$emit$1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        combineKt$combineInternal$2$1$1$emit$1.label = 2;
    }
}

