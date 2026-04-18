namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DebugProbesImpl$startWeakRefCleanerThread$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    public static readonly kotlinx.coroutines.debug.internal.DebugProbesImpl$startWeakRefCleanerThread$1 INSTANCE = new kotlinx.coroutines.debug.internal.DebugProbesImpl$startWeakRefCleanerThread$1();

    DebugProbesImpl$startWeakRefCleanerThread$1() {
        super(0);
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        kotlinx.coroutines.debug.internal.DebugProbesImpl.access$getCallerInfoCache$p().runWeakRefQueueCleaningLoopUntilInterrupted();
    }
}

