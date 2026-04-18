namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "value"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$simpleTransformLatest$1$1", m533f = "FlowExt.kt", m534i = {}, m535l = {89}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowExtKt$simpleTransformLatest$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.ChannelFlowCollector<R> $collector;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    java.lang.object L$0;
    int label;

    FlowExtKt$simpleTransformLatest$1$1(kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, androidx.paging.ChannelFlowCollector<R> channelFlowCollector, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$simpleTransformLatest$1$1> continuation) {
        super(2, continuation);
        this.$transform = function3;
        this.$collector = channelFlowCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((10 + 20) % 20 > 0) {
        }
        androidx.paging.FlowExtKt$simpleTransformLatest$1$1 flowExtKt$simpleTransformLatest$1$1 = new androidx.paging.FlowExtKt$simpleTransformLatest$1$1(this.$transform, this.$collector, continuation);
        flowExtKt$simpleTransformLatest$1$1.L$0 = obj;
        return flowExtKt$simpleTransformLatest$1$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$simpleTransformLatest$1$1) create(t, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((9 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.object obj2 = this.L$0;
            kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function3 = this.$transform;
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$collector;
            this.label = 1;
            if (function3.invoke(flowCollector, obj2, this) == coroutine_suspended) {
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

