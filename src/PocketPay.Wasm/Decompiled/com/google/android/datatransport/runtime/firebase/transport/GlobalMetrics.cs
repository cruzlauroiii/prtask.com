namespace WillowMaze.Wasm.Decompiled;


public readonly class GlobalMetrics {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics DEFAULT_INSTANCE = VlRTsBeKxYkxPXOn(new com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder());
    private readonly com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storage_metrics_;

    GlobalMetrics(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics) {
        this.storage_metrics_ = storageMetrics;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics GifKdwOChfwNsFzs() {
        return com.google.android.datatransport.runtime.firebase.transport.StorageMetrics.getDefaultInstance();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics VlRTsBeKxYkxPXOn(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder globalMetrics$Builder) {
        return globalMetrics$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder();
    }

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public com.google.android.datatransport.runtime.firebase.transport.StorageMetrics GetStorageMetrics() {
        com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics = this.storage_metrics_;
        return storageMetrics is not null ? storageMetrics : GifKdwOChfwNsFzs();
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "storageMetrics")
    public com.google.android.datatransport.runtime.firebase.transport.StorageMetrics GetStorageMetricsInternal() {
        return this.storage_metrics_;
    }
}

