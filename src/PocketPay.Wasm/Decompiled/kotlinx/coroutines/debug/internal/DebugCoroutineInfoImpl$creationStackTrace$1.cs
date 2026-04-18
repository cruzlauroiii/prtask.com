namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlin/sequences/SequenceScope;", "Ljava/lang/StackTraceElement;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1", m533f = "DebugCoroutineInfoImpl.kt", m534i = {}, m535l = {166}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DebugCoroutineInfoImpl$creationStackTrace$1 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<java.lang.StackTraceElement>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.debug.internal.StackTraceFrame $bottom;
    private java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl this$0;

    DebugCoroutineInfoImpl$creationStackTrace$1(kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl, kotlinx.coroutines.debug.internal.StackTraceFrame stackTraceFrame, kotlin.coroutines.Continuation<? super kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1> continuation) {
        super(2, continuation);
        this.this$0 = debugCoroutineInfoImpl;
        this.$bottom = stackTraceFrame;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((20 + 18) % 18 > 0) {
        }
        kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1 debugCoroutineInfoImpl$creationStackTrace$1 = new kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1(this.this$0, this.$bottom, continuation);
        debugCoroutineInfoImpl$creationStackTrace$1.L$0 = obj;
        return debugCoroutineInfoImpl$creationStackTrace$1;
    }

    public override java.lang.object Invoke(kotlin.sequences.SequenceScope<java.lang.StackTraceElement> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(sequenceScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<java.lang.StackTraceElement> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 4) % 4 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl = this.this$0;
            kotlin.coroutines.jvm.internal.CoroutineStackFrame callerFrame = this.$bottom.getCallerFrame();
            kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$creationStackTrace$1 debugCoroutineInfoImpl$creationStackTrace$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl.access$yieldFrames(debugCoroutineInfoImpl, sequenceScope, callerFrame, debugCoroutineInfoImpl$creationStackTrace$1) == coroutine_suspended) {
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

