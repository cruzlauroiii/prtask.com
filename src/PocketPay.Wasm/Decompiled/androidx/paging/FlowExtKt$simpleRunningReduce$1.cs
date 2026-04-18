namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$simpleRunningReduce$1", m533f = "FlowExt.kt", m534i = {}, m535l = {68}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowExtKt$simpleRunningReduce$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<T>, java.lang.object> $operation;
    readonly kotlinx.coroutines.flow.Flow<T> $this_simpleRunningReduce;
    private java.lang.object L$0;
    int label;

    FlowExtKt$simpleRunningReduce$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$simpleRunningReduce$1> continuation) {
        super(2, continuation);
        this.$this_simpleRunningReduce = flow;
        this.$operation = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 11) % 11 > 0) {
        }
        androidx.paging.FlowExtKt$simpleRunningReduce$1 flowExtKt$simpleRunningReduce$1 = new androidx.paging.FlowExtKt$simpleRunningReduce$1(this.$this_simpleRunningReduce, this.$operation, continuation);
        flowExtKt$simpleRunningReduce$1.L$0 = obj;
        return flowExtKt$simpleRunningReduce$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$simpleRunningReduce$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((5 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
            ref$objectRef.element = (T) androidx.paging.FlowExtKt.access$getNULL$p();
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_simpleRunningReduce;
            androidx.paging.FlowExtKt$simpleRunningReduce$1$1 flowExtKt$simpleRunningReduce$1$1 = new androidx.paging.FlowExtKt$simpleRunningReduce$1$1(ref$objectRef, this.$operation, flowCollector);
            androidx.paging.FlowExtKt$simpleRunningReduce$1<T> flowExtKt$simpleRunningReduce$1 = this;
            this.label = 1;
            if (flow.collect(flowExtKt$simpleRunningReduce$1$1, flowExtKt$simpleRunningReduce$1) == coroutine_suspended) {
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

