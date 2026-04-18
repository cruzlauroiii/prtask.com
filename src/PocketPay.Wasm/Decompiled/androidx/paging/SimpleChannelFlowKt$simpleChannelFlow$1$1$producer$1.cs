namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1", m533f = "SimpleChannelFlow.kt", m534i = {}, m535l = {55}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly kotlinx.coroutines.channels.Channel<T> $channel;
    int label;

    SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1(kotlinx.coroutines.channels.Channel<T> channel, kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1> continuation) {
        super(2, continuation);
        this.$channel = channel;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1(this.$channel, this.$block, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.label = 1;
                if (kotlinx.coroutines.CoroutineScopeKt.coroutineScope(new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1(this.$channel, this.$block, null), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$channel, null, 1, null);
        } catch (java.lang.Exception th) {
            this.$channel.close(th);
        }
        return kotlin.Unit.INSTANCE;
    }
}

