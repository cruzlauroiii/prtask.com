namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a:\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00060\u0002j\u0002`\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0005H\u0080\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0006\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0007"}, d2 = {"withLock", "T", "Ljava/util/concurrent/locks/Lock;", "Landroidx/paging/internal/Lock;", "block", "Lkotlin/Function0;", "(Ljava/util/concurrent/locks/Lock;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class AtomicsKt {
    public static readonly <T> T WithLock(java.util.concurrent.locks.Lock reentrantLock, kotlin.jvm.functions.Function0<? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reentrantLock, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        try {
            reentrantLock.lock();
            T tInvoke = block.invoke();
            reentrantLock.unlock();
            return tInvoke;
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }
}

