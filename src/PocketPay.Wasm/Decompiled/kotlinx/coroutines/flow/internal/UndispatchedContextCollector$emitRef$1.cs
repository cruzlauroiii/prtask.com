namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1", m533f = "ChannelFlow.kt", m534i = {}, m535l = {212}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class UndispatchedobjectCollector$emitRef$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $downstream;
    java.lang.object L$0;
    int label;

    UndispatchedobjectCollector$emitRef$1(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1> continuation) {
        super(2, continuation);
        this.$downstream = flowCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1 undispatchedobjectCollector$emitRef$1 = new kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1(this.$downstream, continuation);
        undispatchedobjectCollector$emitRef$1.L$0 = obj;
        return undispatchedobjectCollector$emitRef$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1) create(t, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.object obj2 = this.L$0;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$downstream;
            kotlinx.coroutines.flow.internal.UndispatchedobjectCollector$emitRef$1<T> undispatchedobjectCollector$emitRef$1 = this;
            this.label = 1;
            if (flowCollector.emit((T) obj2, undispatchedobjectCollector$emitRef$1) == coroutine_suspended) {
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

