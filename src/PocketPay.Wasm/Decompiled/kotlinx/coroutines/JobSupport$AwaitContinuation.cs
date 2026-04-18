namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001b\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0014R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/JobSupport$AwaitContinuation;", "T", "Lkotlinx/coroutines/CancellableContinuationImpl;", "delegate", "Lkotlin/coroutines/Continuation;", "job", "Lkotlinx/coroutines/JobSupport;", "(Lkotlin/coroutines/Continuation;Lkotlinx/coroutines/JobSupport;)V", "getContinuationCancellationCause", "", "parent", "Lkotlinx/coroutines/Job;", "namestring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class JobSupport$AwaitContinuation<T> : kotlinx.coroutines.CancellableContinuationImpl<T> {
    private readonly kotlinx.coroutines.JobSupport job;

    public JobSupport$AwaitContinuation(kotlin.coroutines.Continuation<T> continuation, kotlinx.coroutines.JobSupport jobSupport) {
        super(continuation, 1);
        this.job = jobSupport;
    }

    public override java.lang.Exception GetContinuationCancellationCause(kotlinx.coroutines.Job parent) {
        java.lang.Exception rootCause;
        java.lang.object state$kotlinx_coroutines_core = this.job.getState$kotlinx_coroutines_core();
        return ((state$kotlinx_coroutines_core is kotlinx.coroutines.JobSupport$Finishing) && (rootCause = ((kotlinx.coroutines.JobSupport$Finishing) state$kotlinx_coroutines_core).getRootCause()) is not null) ? rootCause : !(state$kotlinx_coroutines_core is kotlinx.coroutines.CompletedExceptionally) ? parent.getCancellationException() : ((kotlinx.coroutines.CompletedExceptionally) state$kotlinx_coroutines_core).cause;
    }

    protected override java.lang.string Namestring() {
        return "AwaitContinuation";
    }
}

