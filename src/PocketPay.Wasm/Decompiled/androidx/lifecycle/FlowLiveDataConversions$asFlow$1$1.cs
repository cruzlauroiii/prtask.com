namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.FlowLiveDataConversions$asFlow$1$1", m533f = "FlowLiveData.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowLiveDataConversions$asFlow$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.lifecycle.Observer<T> $observer;
    readonly androidx.lifecycle.LiveData<T> $this_asFlow;
    int label;

    FlowLiveDataConversions$asFlow$1$1(androidx.lifecycle.LiveData<T> liveData, androidx.lifecycle.Observer<T> observer, kotlin.coroutines.Continuation<? super androidx.lifecycle.FlowLiveDataConversions$asFlow$1$1> continuation) {
        super(2, continuation);
        this.$this_asFlow = liveData;
        this.$observer = observer;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.FlowLiveDataConversions$asFlow$1$1(this.$this_asFlow, this.$observer, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.FlowLiveDataConversions$asFlow$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        this.$this_asFlow.observeForever(this.$observer);
        return kotlin.Unit.INSTANCE;
    }
}

