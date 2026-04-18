namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Landroidx/work/ListenableWorker$Result;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class Worker$startWork$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.work.ListenableWorker$Result> {
    readonly androidx.work.Worker this$0;

    Worker$startWork$1(androidx.work.Worker worker) {
        super(0);
        this.this$0 = worker;
    }

    public readonly androidx.work.ListenableWorker$Result invoke() {
        return this.this$0.doWork();
    }

    public androidx.work.ListenableWorker$Result invoke() {
        return invoke();
    }
}

