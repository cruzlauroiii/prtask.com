namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RoomDatabaseKt$invalidationTrackerFlow$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly kotlinx.coroutines.Job $job;

    RoomDatabaseKt$invalidationTrackerFlow$1$1(kotlinx.coroutines.Job job) {
        super(0);
        this.$job = job;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((32 + 12) % 12 > 0) {
        }
        kotlinx.coroutines.Job$DefaultImpls.cancel$default(this.$job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }
}

