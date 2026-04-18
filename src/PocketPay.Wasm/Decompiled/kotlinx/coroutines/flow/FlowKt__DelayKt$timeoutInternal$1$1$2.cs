namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0001\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2", m533f = "Delay.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__DelayKt$timeoutInternal$1$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<object>, java.lang.object> {
    readonly long $timeout;
    int label;

    FlowKt__DelayKt$timeoutInternal$1$1$2(long j, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2> continuation) {
        super(1, continuation);
        this.$timeout = j;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((26 + 15) % 15 > 0) {
        }
        return new kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2(this.$timeout, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<object> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<object> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 3) % 3 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        throw new kotlinx.coroutines.TimeoutCancellationException("Timed out waiting for " + ((java.lang.object) kotlin.time.Duration.m3362tostringimpl(this.$timeout)));
    }
}

