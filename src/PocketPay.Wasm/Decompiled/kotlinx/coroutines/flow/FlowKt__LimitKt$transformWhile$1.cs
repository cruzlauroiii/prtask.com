namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1", m533f = "Limit.kt", m534i = {0}, m535l = {152}, m536m = "invokeSuspend", m537n = {"collector$iv"}, m538s = {"L$0"})
readonly class FlowKt__LimitKt$transformWhile$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T> $this_transformWhile;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;

    FlowKt__LimitKt$transformWhile$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1> continuation) {
        super(2, continuation);
        this.$this_transformWhile = flow;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 9) % 9 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1 flowKt__LimitKt$transformWhile$1 = new kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1(this.$this_transformWhile, this.$transform, continuation);
        flowKt__LimitKt$transformWhile$1.L$0 = obj;
        return flowKt__LimitKt$transformWhile$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.C0470xdf1aa1b6 c0470xdf1aa1b6;
        if ((30 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_transformWhile;
            kotlinx.coroutines.flow.C0470xdf1aa1b6 c0470xdf1aa1b62 = new kotlinx.coroutines.flow.C0470xdf1aa1b6(this.$transform, flowCollector);
            try {
                this.L$0 = c0470xdf1aa1b62;
                this.label = 1;
                if (flow.collect(c0470xdf1aa1b62, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } catch (kotlinx.coroutines.flow.internal.AbortFlowException e) {
                e = e;
                c0470xdf1aa1b6 = c0470xdf1aa1b62;
                kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, c0470xdf1aa1b6);
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            c0470xdf1aa1b6 = (kotlinx.coroutines.flow.C0470xdf1aa1b6) this.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
            } catch (kotlinx.coroutines.flow.internal.AbortFlowException e2) {
                e = e2;
                kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, c0470xdf1aa1b6);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

