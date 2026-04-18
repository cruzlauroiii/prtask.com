namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class FinalizableSoftReference<T> : java.lang.ref.SoftReference<T> : com.google.common.base.FinalizableReference {
    protected FinalizableSoftReference(@javax.annotation.CheckForNull T t, com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        super(t, finalizableReferenceQueue.queue);
        TTAFLBmyADBveaty(finalizableReferenceQueue);
    }

    public static void TTAFLBmyADBveaty(com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        finalizableReferenceQueue.cleanUp();
    }
}

