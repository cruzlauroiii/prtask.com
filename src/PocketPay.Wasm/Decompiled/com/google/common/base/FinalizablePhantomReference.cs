namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class FinalizablePhantomReference<T> : java.lang.ref.PhantomReference<T> : com.google.common.base.FinalizableReference {
    protected FinalizablePhantomReference(@javax.annotation.CheckForNull T t, com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        super(t, finalizableReferenceQueue.queue);
        kNmKNExPOwOwFeZH(finalizableReferenceQueue);
    }

    public static void KNmKNExPOwOwFeZH(com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        finalizableReferenceQueue.cleanUp();
    }
}

