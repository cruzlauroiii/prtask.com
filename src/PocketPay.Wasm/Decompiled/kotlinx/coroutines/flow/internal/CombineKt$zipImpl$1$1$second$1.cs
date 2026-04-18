namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\b\u0012\u0004\u0012\u00020\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Lkotlinx/coroutines/channels/ProducerScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1", m533f = "Combine.kt", m534i = {}, m535l = {89}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CombineKt$zipImpl$1$1$second$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<java.lang.object>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T2> $flow2;
    private java.lang.object L$0;
    int label;

    CombineKt$zipImpl$1$1$second$1(kotlinx.coroutines.flow.Flow<? : T2> flow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1> continuation) {
        super(2, continuation);
        this.$flow2 = flow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1 combineKt$zipImpl$1$1$second$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1(this.$flow2, continuation);
        combineKt$zipImpl$1$1$second$1.L$0 = obj;
        return combineKt$zipImpl$1$1$second$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2((kotlinx.coroutines.channels.ProducerScope<java.lang.object>) producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlinx.coroutines.flow.Flow<T2> flow = this.$flow2;
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1 combineKt$zipImpl$1$1$second$1$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1$1(producerScope);
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1 combineKt$zipImpl$1$1$second$1 = this;
            this.label = 1;
            if (flow.collect(combineKt$zipImpl$1$1$second$1$1, combineKt$zipImpl$1$1$second$1) == coroutine_suspended) {
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

