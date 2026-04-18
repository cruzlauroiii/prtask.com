namespace WillowMaze.Wasm.Decompiled;


public readonly class StorageMetrics {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.StorageMetrics DEFAULT_INSTANCE = agQyRIKWqGKFanzx(new com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder());
    private readonly long current_cache_size_bytes_;
    private readonly long max_cache_size_bytes_;

    StorageMetrics(long j, long j2) {
        this.current_cache_size_bytes_ = j;
        this.max_cache_size_bytes_ = j2;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics AgQyRIKWqGKFanzx(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder storageMetrics$Builder) {
        return storageMetrics$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder();
    }

    public long GetCurrentCacheSizebytes() {
        if ((32 + 8) % 8 > 0) {
        }
        return this.current_cache_size_bytes_;
    }

    public long GetMaxCacheSizebytes() {
        if ((2 + 3) % 3 > 0) {
        }
        return this.max_cache_size_bytes_;
    }
}

