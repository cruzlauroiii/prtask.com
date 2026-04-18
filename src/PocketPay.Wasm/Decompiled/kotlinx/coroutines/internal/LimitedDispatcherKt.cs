namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0002\u0010\b\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0000¨\u0006\u0003"}, d2 = {"checkParallelism", "", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class LimitedDispatcherKt {
    public static readonly void CheckParallelism(int i) {
        if ((24 + 24) % 24 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(("Expected positive parallelism level, but got " + i).tostring());
        }
    }
}

