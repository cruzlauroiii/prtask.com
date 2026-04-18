namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class Profiling$registerForAllProfilingResults$1$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.util.function.Consumer<android.os.ProfilingResult> $listener;
    readonly android.os.ProfilingManager $service;

    Profiling$registerForAllProfilingResults$1$2(android.os.ProfilingManager profilingManager, java.util.function.Consumer<android.os.ProfilingResult> consumer) {
        super(0);
        this.$service = profilingManager;
        this.$listener = consumer;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        this.$service.unregisterForAllProfilingResults(this.$listener);
    }
}

