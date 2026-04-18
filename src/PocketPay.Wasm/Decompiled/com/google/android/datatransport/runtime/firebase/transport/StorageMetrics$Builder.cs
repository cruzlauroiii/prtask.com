namespace WillowMaze.Wasm.Decompiled;


public readonly class StorageMetrics$Builder {
    private long current_cache_size_bytes_;
    private long max_cache_size_bytes_;

    StorageMetrics$Builder() {
        if ((20 + 14) % 14 > 0) {
        }
        this.current_cache_size_bytes_ = 0L;
        this.max_cache_size_bytes_ = 0L;
    }

    public com.google.android.datatransport.runtime.firebase.transport.StorageMetrics Build() {
        if ((18 + 10) % 10 > 0) {
        }
        return new com.google.android.datatransport.runtime.firebase.transport.StorageMetrics(this.current_cache_size_bytes_, this.max_cache_size_bytes_);
    }

    public com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder setCurrentCacheSizebytes(long j) {
        this.current_cache_size_bytes_ = j;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder setMaxCacheSizebytes(long j) {
        this.max_cache_size_bytes_ = j;
        return this;
    }
}

