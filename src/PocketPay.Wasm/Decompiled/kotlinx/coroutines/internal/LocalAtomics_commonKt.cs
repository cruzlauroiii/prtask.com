namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\".\u0010\u0000\u001a\u00020\u0001*\u00060\u0002j\u0002`\u00032\u0006\u0010\u0000\u001a\u00020\u00018À\u0002@À\u0002X\u0080\u000e¢\u0006\f\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"value", "", "Ljava/util/concurrent/atomic/Atomicint;", "Lkotlinx/coroutines/internal/LocalAtomicInt;", "getValue", "(Ljava/util/concurrent/atomic/Atomicint;)I", "setValue", "(Ljava/util/concurrent/atomic/Atomicint;I)V", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class LocalAtomics_commonKt {
    public static readonly int GetValue(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static readonly void SetValue(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.set(i);
    }
}

