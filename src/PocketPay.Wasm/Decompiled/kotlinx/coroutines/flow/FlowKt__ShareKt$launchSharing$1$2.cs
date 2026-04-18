namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "it", "Lkotlinx/coroutines/flow/SharingCommand;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2", m533f = "Share.kt", m534i = {}, m535l = {227}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__ShareKt$launchSharing$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.SharingCommand, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly T $initialValue;
    readonly kotlinx.coroutines.flow.MutableSharedFlow<T> $shared;
    readonly kotlinx.coroutines.flow.Flow<T> $upstream;
    java.lang.object L$0;
    int label;

    FlowKt__ShareKt$launchSharing$1$2(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.MutableSharedFlow<T> mutableSharedFlow, T t, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2> continuation) {
        super(2, continuation);
        this.$upstream = flow;
        this.$shared = mutableSharedFlow;
        this.$initialValue = t;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((5 + 12) % 12 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2 flowKt__ShareKt$launchSharing$1$2 = new kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2(this.$upstream, this.$shared, this.$initialValue, continuation);
        flowKt__ShareKt$launchSharing$1$2.L$0 = obj;
        return flowKt__ShareKt$launchSharing$1$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.SharingCommand sharingCommand, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(sharingCommand, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.SharingCommand sharingCommand, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2) create(sharingCommand, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 7) % 7 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            int i2 = kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2$WhenDictionarypings.$EnumSwitchDictionaryping$0[((kotlinx.coroutines.flow.SharingCommand) this.L$0).ordinal()];
            if (i2 == 1) {
                kotlinx.coroutines.flow.Flow<T> flow = this.$upstream;
                kotlinx.coroutines.flow.FlowCollector flowCollector = this.$shared;
                kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$2 flowKt__ShareKt$launchSharing$1$2 = this;
                this.label = 1;
                if (flow.collect(flowCollector, flowKt__ShareKt$launchSharing$1$2) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else if (i2 == 3) {
                if (this.$initialValue != kotlinx.coroutines.flow.SharedFlowKt.NO_VALUE) {
                    this.$shared.tryEmit(this.$initialValue);
                } else {
                    this.$shared.resetReplayCache();
                }
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

