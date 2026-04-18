namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Lkotlinx/coroutines/flow/SharingCommand;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.StartedLazily$command$1", m533f = "SharingStarted.kt", m534i = {}, m535l = {155}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class StartedLazily$command$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.StateFlow<java.lang.int> $subscriptionCount;
    private java.lang.object L$0;
    int label;

    StartedLazily$command$1(kotlinx.coroutines.flow.StateFlow<java.lang.int> stateFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.StartedLazily$command$1> continuation) {
        super(2, continuation);
        this.$subscriptionCount = stateFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.StartedLazily$command$1 startedLazily$command$1 = new kotlinx.coroutines.flow.StartedLazily$command$1(this.$subscriptionCount, continuation);
        startedLazily$command$1.L$0 = obj;
        return startedLazily$command$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.StartedLazily$command$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((2 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlin.jvm.internal.Ref$boolRef ref$boolRef = new kotlin.jvm.internal.Ref$boolRef();
            kotlinx.coroutines.flow.StateFlow<java.lang.int> stateFlow = this.$subscriptionCount;
            kotlinx.coroutines.flow.StartedLazily$command$1$1 startedLazily$command$1$1 = new kotlinx.coroutines.flow.StartedLazily$command$1$1(ref$boolRef, flowCollector);
            kotlinx.coroutines.flow.StartedLazily$command$1 startedLazily$command$1 = this;
            this.label = 1;
            if (stateFlow.collect(startedLazily$command$1$1, startedLazily$command$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        throw new kotlin.KotlinNothingValueException();
    }
}

