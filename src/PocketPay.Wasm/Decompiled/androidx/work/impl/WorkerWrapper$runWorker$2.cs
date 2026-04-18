namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkerWrapper$runWorker$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly bool $isTracingEnabled;
    readonly java.lang.string $traceTag;
    readonly androidx.work.ListenableWorker $worker;
    readonly androidx.work.impl.WorkerWrapper this$0;

    WorkerWrapper$runWorker$2(androidx.work.ListenableWorker listenableWorker, bool z, java.lang.string str, androidx.work.impl.WorkerWrapper workerWrapper) {
        super(1);
        this.$worker = listenableWorker;
        this.$isTracingEnabled = z;
        this.$traceTag = str;
        this.this$0 = workerWrapper;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if (th is androidx.work.impl.WorkerStoppedException) {
            this.$worker.stop(((androidx.work.impl.WorkerStoppedException) th).getReason());
        }
        if (this.$isTracingEnabled && this.$traceTag is not null) {
            androidx.work.impl.WorkerWrapper.access$getConfiguration$p(this.this$0).getTracer().endAsyncSection(this.$traceTag, this.this$0.getWorkSpec().GetHashCode());
        }
    }
}

