namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u00020\u00040\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/channels/ProducerScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1", m533f = "Delay.kt", m534i = {}, m535l = {210}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__DelayKt$debounceInternal$1$values$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<java.lang.object>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T> $this_debounceInternal;
    private java.lang.object L$0;
    int label;

    FlowKt__DelayKt$debounceInternal$1$values$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1> continuation) {
        super(2, continuation);
        this.$this_debounceInternal = flow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1 flowKt__DelayKt$debounceInternal$1$values$1 = new kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1(this.$this_debounceInternal, continuation);
        flowKt__DelayKt$debounceInternal$1$values$1.L$0 = obj;
        return flowKt__DelayKt$debounceInternal$1$values$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2((kotlinx.coroutines.channels.ProducerScope<java.lang.object>) producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((31 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_debounceInternal;
            kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1$1 flowKt__DelayKt$debounceInternal$1$values$1$1 = new kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1$1(producerScope);
            kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$values$1 flowKt__DelayKt$debounceInternal$1$values$1 = this;
            this.label = 1;
            if (flow.collect(flowKt__DelayKt$debounceInternal$1$values$1$1, flowKt__DelayKt$debounceInternal$1$values$1) == coroutine_suspended) {
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

