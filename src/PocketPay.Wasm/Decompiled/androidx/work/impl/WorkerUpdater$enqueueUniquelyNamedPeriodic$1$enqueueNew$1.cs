namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.lang.string $name;
    readonly androidx.work.impl.WorkManagerImpl $this_enqueueUniquelyNamedPeriodic;
    readonly androidx.work.WorkRequest $workRequest;

    WorkerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1(androidx.work.WorkRequest workRequest, androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string str) {
        super(0);
        this.$workRequest = workRequest;
        this.$this_enqueueUniquelyNamedPeriodic = workManagerImpl;
        this.$name = str;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((20 + 22) % 22 > 0) {
        }
        androidx.work.impl.utils.EnqueueAction.enqueue(new androidx.work.impl.WorkContinuationImpl(this.$this_enqueueUniquelyNamedPeriodic, this.$name, androidx.work.ExistingWorkPolicy.KEEP, kotlin.collections.ICollectionsKt.listOf(this.$workRequest)));
    }
}

