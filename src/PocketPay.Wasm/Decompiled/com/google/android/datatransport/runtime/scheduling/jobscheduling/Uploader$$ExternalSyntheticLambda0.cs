namespace WillowMaze.Wasm.Decompiled;


public readonly class Uploader$$ExternalSyntheticLambda0 : com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore f$0;

    public Uploader$$ExternalSyntheticLambda0(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore) {
        this.f$0 = eventStore;
    }

    public static int VxtxvCCzQYdhfGdf(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore) {
        return eventStore.cleanUp();
    }

    public static java.lang.int TrLJSFmFqVESwlOD(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly java.lang.object Execute() {
        return trLJSFmFqVESwlOD(VxtxvCCzQYdhfGdf(this.f$0));
    }
}

