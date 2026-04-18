namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl$initSelectResult$1", m533f = "SelectOld.kt", m534i = {}, m535l = {71}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class UnbiasedSelectBuilderImpl$initSelectResult$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl<R> this$0;

    UnbiasedSelectBuilderImpl$initSelectResult$1(kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl<R> unbiasedSelectBuilderImpl, kotlin.coroutines.Continuation<? super kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl$initSelectResult$1> continuation) {
        super(2, continuation);
        this.this$0 = unbiasedSelectBuilderImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl$initSelectResult$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl$initSelectResult$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((8 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl<R> unbiasedSelectBuilderImpl = this.this$0;
                this.label = 1;
                obj = unbiasedSelectBuilderImpl.doSelect(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            this = this.this$0;
            kotlinx.coroutines.selects.SelectOldKt.access$resumeUndispatched(kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl.access$getCont$p(this), obj);
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            kotlinx.coroutines.selects.SelectOldKt.access$resumeUndispatchedWithException(kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl.access$getCont$p(this.this$0), th);
            return kotlin.Unit.INSTANCE;
        }
    }
}

