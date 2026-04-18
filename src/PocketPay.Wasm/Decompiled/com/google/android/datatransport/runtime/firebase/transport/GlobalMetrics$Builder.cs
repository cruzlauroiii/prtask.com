namespace WillowMaze.Wasm.Decompiled;


public readonly class GlobalMetrics$Builder {
    private com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storage_metrics_ = null;

    GlobalMetrics$Builder() {
    }

    public com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics Build() {
        return new com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics(this.storage_metrics_);
    }

    public com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder setStorageMetrics(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics) {
        this.storage_metrics_ = storageMetrics;
        return this;
    }
}

