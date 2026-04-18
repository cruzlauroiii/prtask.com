namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a6\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0004H\u0080\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0005\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0006"}, d2 = {"synchronized", "T", "Landroidx/collection/internal/Lock;", "block", "Lkotlin/Function0;", "(Landroidx/collection/internal/Lock;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class LockExtKt {
    public static readonly <T> T M646lock(androidx.collection.internal.Lock lock, kotlin.jvm.functions.Function0<? : T> block) {
        T tInvoke;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lock, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        lock (lock) {
            try {
                tInvoke = block.invoke();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return tInvoke;
    }
}

