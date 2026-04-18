namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class FinalizableWeakReference<T> : java.lang.ref.WeakReference<T> : com.google.common.base.FinalizableReference {
    protected FinalizableWeakReference(@javax.annotation.CheckForNull T t, com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        super(t, finalizableReferenceQueue.queue);
        VdZrEqmNgMBlAKUq(finalizableReferenceQueue);
    }

    public static void VdZrEqmNgMBlAKUq(com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        finalizableReferenceQueue.cleanUp();
    }
}

