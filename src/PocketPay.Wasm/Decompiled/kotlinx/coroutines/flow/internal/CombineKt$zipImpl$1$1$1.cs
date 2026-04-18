namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CombineKt$zipImpl$1$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.CompletableJob $collectJob;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $this_unsafeFlow;

    CombineKt$zipImpl$1$1$1(kotlinx.coroutines.CompletableJob completableJob, kotlinx.coroutines.flow.FlowCollector<R> flowCollector) {
        super(1);
        this.$collectJob = completableJob;
        this.$this_unsafeFlow = flowCollector;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if (this.$collectJob.isActive()) {
            this.$collectJob.cancel((java.util.concurrent.CancellationException) new kotlinx.coroutines.flow.internal.AbortFlowException(this.$this_unsafeFlow));
        }
    }
}

