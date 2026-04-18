namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0002\u0010\u0005J\u0013\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0096\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lkotlinx/coroutines/ResumeAwaitOnCompletion;", "T", "Lkotlinx/coroutines/JobNode;", "continuation", "Lkotlinx/coroutines/CancellableContinuationImpl;", "(Lkotlinx/coroutines/CancellableContinuationImpl;)V", "invoke", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ResumeAwaitOnCompletion<T> : kotlinx.coroutines.JobNode {
    private readonly kotlinx.coroutines.CancellableContinuationImpl<T> continuation;

    public ResumeAwaitOnCompletion(kotlinx.coroutines.CancellableContinuationImpl<T> cancellableContinuationImpl) {
        this.continuation = cancellableContinuationImpl;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public override void Invoke2(java.lang.Exception cause) {
        java.lang.object state$kotlinx_coroutines_core = getJob().getState$kotlinx_coroutines_core();
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && (state$kotlinx_coroutines_core is kotlinx.coroutines.Incomplete)) {
            throw new java.lang.AssertionError();
        }
        if (state$kotlinx_coroutines_core is kotlinx.coroutines.CompletedExceptionally) {
            kotlinx.coroutines.CancellableContinuationImpl<T> cancellableContinuationImpl = this.continuation;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuationImpl.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(((kotlinx.coroutines.CompletedExceptionally) state$kotlinx_coroutines_core).cause)));
        } else {
            kotlinx.coroutines.CancellableContinuationImpl<T> cancellableContinuationImpl2 = this.continuation;
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuationImpl2.resumeWith(kotlin.Result.m948constructorimpl(kotlinx.coroutines.JobSupportKt.unboxState(state$kotlinx_coroutines_core)));
        }
    }
}

