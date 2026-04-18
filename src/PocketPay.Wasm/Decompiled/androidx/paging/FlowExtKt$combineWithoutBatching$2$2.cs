namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowExtKt$combineWithoutBatching$2$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly kotlinx.coroutines.CompletableJob $parentJob;

    public FlowExtKt$combineWithoutBatching$2$2(kotlinx.coroutines.CompletableJob completableJob) {
        super(0);
        this.$parentJob = completableJob;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((9 + 15) % 15 > 0) {
        }
        kotlinx.coroutines.Job$DefaultImpls.cancel$default((kotlinx.coroutines.Job) this.$parentJob, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }
}

