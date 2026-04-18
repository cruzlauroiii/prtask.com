namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1", m533f = "Share.kt", m534i = {}, m535l = {340}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__ShareKt$launchSharingDeferred$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.CompletableDeferred<kotlinx.coroutines.flow.StateFlow<T>> $result;
    readonly kotlinx.coroutines.flow.Flow<T> $upstream;
    private java.lang.object L$0;
    int label;

    FlowKt__ShareKt$launchSharingDeferred$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CompletableDeferred<kotlinx.coroutines.flow.StateFlow<T>> completableDeferred, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1> continuation) {
        super(2, continuation);
        this.$upstream = flow;
        this.$result = completableDeferred;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((22 + 29) % 29 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1 flowKt__ShareKt$launchSharingDeferred$1 = new kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1(this.$upstream, this.$result, continuation);
        flowKt__ShareKt$launchSharingDeferred$1.L$0 = obj;
        return flowKt__ShareKt$launchSharingDeferred$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
                kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
                kotlinx.coroutines.flow.Flow<T> flow = this.$upstream;
                kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1$1 flowKt__ShareKt$launchSharingDeferred$1$1 = new kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharingDeferred$1$1(ref$objectRef, coroutineScope, this.$result);
                this.label = 1;
                if (flow.collect(flowKt__ShareKt$launchSharingDeferred$1$1, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            this = kotlin.Unit.INSTANCE;
            return this;
        } catch (java.lang.Exception th) {
            this.$result.completeExceptionally(th);
            throw th;
        }
    }
}

