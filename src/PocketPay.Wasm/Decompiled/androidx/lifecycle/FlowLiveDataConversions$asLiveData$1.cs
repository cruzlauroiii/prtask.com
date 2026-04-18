namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Landroidx/lifecycle/LiveDataScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.FlowLiveDataConversions$asLiveData$1", m533f = "FlowLiveData.kt", m534i = {}, m535l = {78}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowLiveDataConversions$asLiveData$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.lifecycle.LiveDataScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T> $this_asLiveData;
    private java.lang.object L$0;
    int label;

    FlowLiveDataConversions$asLiveData$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<? super androidx.lifecycle.FlowLiveDataConversions$asLiveData$1> continuation) {
        super(2, continuation);
        this.$this_asLiveData = flow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.lifecycle.FlowLiveDataConversions$asLiveData$1 flowLiveDataConversions$asLiveData$1 = new androidx.lifecycle.FlowLiveDataConversions$asLiveData$1(this.$this_asLiveData, continuation);
        flowLiveDataConversions$asLiveData$1.L$0 = obj;
        return flowLiveDataConversions$asLiveData$1;
    }

    public readonly java.lang.object Invoke(androidx.lifecycle.LiveDataScope<T> liveDataScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.FlowLiveDataConversions$asLiveData$1) create(liveDataScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.lifecycle.LiveDataScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.lifecycle.LiveDataScope liveDataScope = (androidx.lifecycle.LiveDataScope) this.L$0;
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_asLiveData;
            androidx.lifecycle.FlowLiveDataConversions$asLiveData$1$1 flowLiveDataConversions$asLiveData$1$1 = new androidx.lifecycle.FlowLiveDataConversions$asLiveData$1$1(liveDataScope);
            androidx.lifecycle.FlowLiveDataConversions$asLiveData$1<T> flowLiveDataConversions$asLiveData$1 = this;
            this.label = 1;
            if (flow.collect(flowLiveDataConversions$asLiveData$1$1, flowLiveDataConversions$asLiveData$1) == coroutine_suspended) {
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

