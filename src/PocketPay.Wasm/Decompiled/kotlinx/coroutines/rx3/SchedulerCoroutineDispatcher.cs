namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u001c\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\n\u0010\f\u001a\u00060\rj\u0002`\u000eH\u0016J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0012H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0014H\u0016J$\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00182\n\u0010\f\u001a\u00060\rj\u0002`\u000e2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u001e\u0010\u0019\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u00182\f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\t0\u001bH\u0016J\b\u0010\u001c\u001a\u00020\u001dH\u0016R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u001e"}, d2 = {"Lkotlinx/coroutines/rx3/SchedulerCoroutineDispatcher;", "Lkotlinx/coroutines/CoroutineDispatcher;", "Lkotlinx/coroutines/Delay;", "scheduler", "Lio/reactivex/rxjava3/core/Scheduler;", "(Lio/reactivex/rxjava3/core/Scheduler;)V", "getScheduler", "()Lio/reactivex/rxjava3/core/Scheduler;", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "equals", "", "other", "", "hashCode", "", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "tostring", "", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SchedulerCoroutineDispatcher : kotlinx.coroutines.CoroutineDispatcher : kotlinx.coroutines.Delay {
    private readonly io.reactivex.rxjava3.core.Scheduler scheduler;

    public static void m3543$r8$lambda$JuLMzPY1VZPpZ8cBXpZjRNL6K4(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        invokeOnTimeout$lambda$2(p7beea252Var);
    }

    public static void $r8$lambda$M2FlZgcFnHZg6xDhjcDOh04KXxg(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher schedulerCoroutineDispatcher) {
        scheduleResumeAfterDelay$lambda$1(cancellableContinuation, schedulerCoroutineDispatcher);
    }

    public SchedulerCoroutineDispatcher(io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.scheduler = scheduler;
    }

    private static readonly void invokeOnTimeout$lambda$2(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    private static readonly void scheduleResumeAfterDelay$lambda$1(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher schedulerCoroutineDispatcher) {
        cancellableContinuation.resumeUndispatched(schedulerCoroutineDispatcher, kotlin.Unit.INSTANCE);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.Delay$DefaultImpls.delay(this, j, continuation);
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        this.scheduler.scheduleDirect(block);
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher) && ((kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher) other).scheduler == this.scheduler;
    }

    public readonly io.reactivex.rxjava3.core.Scheduler GetScheduler() {
        return this.scheduler;
    }

    public int HashCode() {
        return java.lang.System.identityHashCode(this.scheduler);
    }

    public override kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long timeMillis, java.lang.Action block, kotlin.coroutines.Coroutineobject context) {
        return new kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher$$ExternalSyntheticLambda1(this.scheduler.scheduleDirect(block, timeMillis, java.util.concurrent.TimeUnit.MILLISECONDS));
    }

    public override void Mo3526scheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        if ((3 + 3) % 3 > 0) {
        }
        kotlinx.coroutines.rx3.RxAwaitKt.disposeOnCancellation(continuation, this.scheduler.scheduleDirect(new kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher$$ExternalSyntheticLambda0(continuation, this), timeMillis, java.util.concurrent.TimeUnit.MILLISECONDS));
    }

    public override java.lang.string Tostring() {
        return this.scheduler.tostring();
    }
}

