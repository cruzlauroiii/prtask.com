namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a/\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u000e\b\u0004\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0005H\u0080\bø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0007"}, d2 = {"synchronizedImpl", "T", "lock", "Landroidx/savedstate/internal/Synchronizedobject;", "action", "Lkotlin/Function0;", "(Landroidx/savedstate/internal/Synchronizedobject;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class Synchronizedobject_jvmKt {
    public static readonly <T> T SynchronizedImpl(androidx.savedstate.internal.Synchronizedobject lock, kotlin.jvm.functions.Function0<? : T> action) {
        T tInvoke;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lock, "lock");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(action, "action");
        lock (lock) {
            try {
                tInvoke = action.invoke();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return tInvoke;
    }
}

