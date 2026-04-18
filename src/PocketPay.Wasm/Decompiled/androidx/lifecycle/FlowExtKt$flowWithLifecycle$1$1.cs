namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1", m533f = "FlowExt.kt", m534i = {}, m535l = {90}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowExtKt$flowWithLifecycle$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ProducerScope<T> $$this$callbackFlow;
    readonly kotlinx.coroutines.flow.Flow<T> $this_flowWithLifecycle;
    int label;

    FlowExtKt$flowWithLifecycle$1$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<? super androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1> continuation) {
        super(2, continuation);
        this.$this_flowWithLifecycle = flow;
        this.$$this$callbackFlow = producerScope;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1(this.$this_flowWithLifecycle, this.$$this$callbackFlow, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_flowWithLifecycle;
            androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1$1 flowExtKt$flowWithLifecycle$1$1$1 = new androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1$1(this.$$this$callbackFlow);
            androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1 flowExtKt$flowWithLifecycle$1$1 = this;
            this.label = 1;
            if (flow.collect(flowExtKt$flowWithLifecycle$1$1$1, flowExtKt$flowWithLifecycle$1$1) == coroutine_suspended) {
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

