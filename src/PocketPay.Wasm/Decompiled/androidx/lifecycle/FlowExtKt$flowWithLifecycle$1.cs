namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.FlowExtKt$flowWithLifecycle$1", m533f = "FlowExt.kt", m534i = {0}, m535l = {90}, m536m = "invokeSuspend", m537n = {"$this$callbackFlow"}, m538s = {"L$0"})
readonly class FlowExtKt$flowWithLifecycle$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.lifecycle.Lifecycle $lifecycle;
    readonly androidx.lifecycle.Lifecycle$State $minActiveState;
    readonly kotlinx.coroutines.flow.Flow<T> $this_flowWithLifecycle;
    private java.lang.object L$0;
    int label;

    FlowExtKt$flowWithLifecycle$1(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State lifecycle$State, kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<? super androidx.lifecycle.FlowExtKt$flowWithLifecycle$1> continuation) {
        super(2, continuation);
        this.$lifecycle = lifecycle;
        this.$minActiveState = lifecycle$State;
        this.$this_flowWithLifecycle = flow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 8) % 8 > 0) {
        }
        androidx.lifecycle.FlowExtKt$flowWithLifecycle$1 flowExtKt$flowWithLifecycle$1 = new androidx.lifecycle.FlowExtKt$flowWithLifecycle$1(this.$lifecycle, this.$minActiveState, this.$this_flowWithLifecycle, continuation);
        flowExtKt$flowWithLifecycle$1.L$0 = obj;
        return flowExtKt$flowWithLifecycle$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.FlowExtKt$flowWithLifecycle$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ProducerScope producerScope;
        if ((32 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope2 = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            androidx.lifecycle.Lifecycle lifecycle = this.$lifecycle;
            androidx.lifecycle.Lifecycle$State lifecycle$State = this.$minActiveState;
            androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1 flowExtKt$flowWithLifecycle$1$1 = new androidx.lifecycle.FlowExtKt$flowWithLifecycle$1$1(this.$this_flowWithLifecycle, producerScope2, null);
            androidx.lifecycle.FlowExtKt$flowWithLifecycle$1<T> flowExtKt$flowWithLifecycle$1 = this;
            this.L$0 = producerScope2;
            this.label = 1;
            if (androidx.lifecycle.RepeatOnLifecycleKt.repeatOnLifecycle(lifecycle, lifecycle$State, flowExtKt$flowWithLifecycle$1$1, flowExtKt$flowWithLifecycle$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            producerScope = producerScope2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(producerScope, null, 1, null);
        return kotlin.Unit.INSTANCE;
    }
}

