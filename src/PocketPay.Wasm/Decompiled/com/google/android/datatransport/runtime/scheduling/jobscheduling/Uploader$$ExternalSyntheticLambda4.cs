namespace WillowMaze.Wasm.Decompiled;


public readonly class Uploader$$ExternalSyntheticLambda4 : com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore f$0;

    public Uploader$$ExternalSyntheticLambda4(com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore clientHealthMetricsStore) {
        this.f$0 = clientHealthMetricsStore;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics OnLOmBXwhVHCaoAQ(com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore clientHealthMetricsStore) {
        return clientHealthMetricsStore.loadClientMetrics();
    }

    public override readonly java.lang.object Execute() {
        return OnLOmBXwhVHCaoAQ(this.f$0);
    }
}

