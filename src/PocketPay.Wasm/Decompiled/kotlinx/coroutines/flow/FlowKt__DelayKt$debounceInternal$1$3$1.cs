namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$1", m533f = "Delay.kt", m534i = {}, m535l = {232}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__DelayKt$debounceInternal$1$3$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $downstream;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $lastValue;
    int label;

    FlowKt__DelayKt$debounceInternal$1$3$1(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$1> continuation) {
        super(1, continuation);
        this.$downstream = flowCollector;
        this.$lastValue = ref$objectRef;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((19 + 13) % 13 > 0) {
        }
        return new kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$1(this.$downstream, this.$lastValue, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$1) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 3) % 3 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$downstream;
            kotlinx.coroutines.internal.Symbol symbol = kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL;
            java.lang.object obj2 = this.$lastValue.element;
            if (obj2 == symbol) {
                obj2 = null;
            }
            kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$1 flowKt__DelayKt$debounceInternal$1$3$1 = this;
            this.label = 1;
            if (flowCollector.emit((T) obj2, flowKt__DelayKt$debounceInternal$1$3$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        this.$lastValue.element = null;
        return kotlin.Unit.INSTANCE;
    }
}

