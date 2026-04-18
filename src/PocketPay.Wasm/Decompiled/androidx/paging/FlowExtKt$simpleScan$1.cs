namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$simpleScan$1", m533f = "FlowExt.kt", m534i = {0, 0}, m535l = {54, 55}, m536m = "invokeSuspend", m537n = {"$this$flow", "accumulator"}, m538s = {"L$0", "L$1"})
readonly class FlowExtKt$simpleScan$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly R $initial;
    readonly kotlin.jvm.functions.Function3<R, T, kotlin.coroutines.Continuation<R>, java.lang.object> $operation;
    readonly kotlinx.coroutines.flow.Flow<T> $this_simpleScan;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    FlowExtKt$simpleScan$1(R r, kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$simpleScan$1> continuation) {
        super(2, continuation);
        this.$initial = r;
        this.$this_simpleScan = flow;
        this.$operation = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((16 + 2) % 2 > 0) {
        }
        androidx.paging.FlowExtKt$simpleScan$1 flowExtKt$simpleScan$1 = new androidx.paging.FlowExtKt$simpleScan$1(this.$initial, this.$this_simpleScan, this.$operation, continuation);
        flowExtKt$simpleScan$1.L$0 = obj;
        return flowExtKt$simpleScan$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$simpleScan$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((27 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i == 1) {
                ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) this.L$1;
                flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
        ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        ref$objectRef.element = this.$initial;
        T t = ref$objectRef.element;
        androidx.paging.FlowExtKt$simpleScan$1<R> flowExtKt$simpleScan$1 = this;
        this.L$0 = flowCollector2;
        this.L$1 = ref$objectRef;
        this.label = 1;
        if (flowCollector2.emit(t, flowExtKt$simpleScan$1) != coroutine_suspended) {
            flowCollector = flowCollector2;
        }
        return coroutine_suspended;
        kotlinx.coroutines.flow.Flow<T> flow = this.$this_simpleScan;
        androidx.paging.FlowExtKt$simpleScan$1$1 flowExtKt$simpleScan$1$1 = new androidx.paging.FlowExtKt$simpleScan$1$1(ref$objectRef, this.$operation, flowCollector);
        androidx.paging.FlowExtKt$simpleScan$1<R> flowExtKt$simpleScan$12 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.label = 2;
    }
}

