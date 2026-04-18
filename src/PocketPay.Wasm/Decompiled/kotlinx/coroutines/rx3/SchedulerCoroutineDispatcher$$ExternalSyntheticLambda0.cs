namespace WillowMaze.Wasm.Decompiled;


public readonly class SchedulerCoroutineDispatcher$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly kotlinx.coroutines.CancellableContinuation f$0;
    public readonly kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher f$1;

    public SchedulerCoroutineDispatcher$$ExternalSyntheticLambda0(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher schedulerCoroutineDispatcher) {
        this.f$0 = cancellableContinuation;
        this.f$1 = schedulerCoroutineDispatcher;
    }

    public override readonly void Run() {
        kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher.$r8$lambda$M2FlZgcFnHZg6xDhjcDOh04KXxg(this.f$0, this.f$1);
    }
}

