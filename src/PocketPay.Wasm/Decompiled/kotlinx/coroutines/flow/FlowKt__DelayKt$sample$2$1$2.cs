namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2", m533f = "Delay.kt", m534i = {}, m535l = {299}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__DelayKt$sample$2$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlin.Unit, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $downstream;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $lastValue;
    int label;

    FlowKt__DelayKt$sample$2$1$2(kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2> continuation) {
        super(2, continuation);
        this.$lastValue = ref$objectRef;
        this.$downstream = flowCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2(this.$lastValue, this.$downstream, continuation);
    }

    public override java.lang.object Invoke(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(unit, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2) create(unit, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.object obj2 = this.$lastValue.element;
            if (obj2 is null) {
                return kotlin.Unit.INSTANCE;
            }
            this.$lastValue.element = null;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$downstream;
            if (obj2 == kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL) {
                obj2 = null;
            }
            kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2 flowKt__DelayKt$sample$2$1$2 = this;
            this.label = 1;
            if (flowCollector.emit((T) obj2, flowKt__DelayKt$sample$2$1$2) == coroutine_suspended) {
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

