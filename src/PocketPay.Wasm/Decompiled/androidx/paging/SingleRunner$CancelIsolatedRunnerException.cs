namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"Landroidx/paging/SingleRunner$CancelIsolatedRunnerException;", "Ljava/util/concurrent/CancellationException;", "Lkotlinx/coroutines/CancellationException;", "runner", "Landroidx/paging/SingleRunner;", "(Landroidx/paging/SingleRunner;)V", "getRunner", "()Landroidx/paging/SingleRunner;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SingleRunner$CancelIsolatedRunnerException : java.util.concurrent.CancellationException {
    private readonly androidx.paging.SingleRunner runner;

    public SingleRunner$CancelIsolatedRunnerException(androidx.paging.SingleRunner runner) {
        super("Cancelled isolated runner");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runner, "runner");
        this.runner = runner;
    }

    public readonly androidx.paging.SingleRunner GetRunner() {
        return this.runner;
    }
}

