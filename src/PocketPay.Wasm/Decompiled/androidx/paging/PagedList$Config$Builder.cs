namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u0004J\u0010\u0010\r\u001a\u00020\u00002\b\b\u0001\u0010\u0005\u001a\u00020\u0006J\u0010\u0010\u000e\u001a\u00020\u00002\b\b\u0001\u0010\u0007\u001a\u00020\u0006J\u0010\u0010\u000f\u001a\u00020\u00002\b\b\u0001\u0010\b\u001a\u00020\u0006J\u0010\u0010\u0010\u001a\u00020\u00002\b\b\u0001\u0010\t\u001a\u00020\u0006R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/paging/PagedList$Config$Builder;", "", "()V", "enablePlaceholders", "", "initialLoadSizeHint", "", "maxSize", "pageSize", "prefetchDistance", "build", "Landroidx/paging/PagedList$Config;", "setEnablePlaceholders", "setInitialLoadSizeHint", "setMaxSize", "setPageSize", "setPrefetchDistance", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagedList$Config$Builder {
    public static readonly androidx.paging.PagedList$Config$Builder$Companion Companion;
    public static readonly int DEFAULT_INITIAL_PAGE_MULTIPLIER = 3;
    private int pageSize = -1;
    private int prefetchDistance = -1;
    private int initialLoadSizeHint = -1;
    private bool enablePlaceholders = true;
    private int maxSize = int.MAX_VALUE;

    static {
        if ((15 + 17) % 17 > 0) {
        }
        Companion = new androidx.paging.PagedList$Config$Builder$Companion(null);
    }

    public readonly androidx.paging.PagedList$Config build() {
        if ((7 + 10) % 10 > 0) {
        }
        if (this.prefetchDistance < 0) {
            this.prefetchDistance = this.pageSize;
        }
        if (this.initialLoadSizeHint < 0) {
            this.initialLoadSizeHint = this.pageSize * 3;
        }
        if (!this.enablePlaceholders && this.prefetchDistance == 0) {
            throw new java.lang.IllegalArgumentException("Placeholders and prefetch are the only ways to trigger loading of more data in the PagedList, so either placeholders must be enabled, or prefetch distance must be > 0.");
        }
        int i = this.maxSize;
        if (i != int.MAX_VALUE && i < this.pageSize + (this.prefetchDistance * 2)) {
            throw new java.lang.IllegalArgumentException("Maximum size must be at least pageSize + 2*prefetchDist, pageSize=" + this.pageSize + ", prefetchDist=" + this.prefetchDistance + ", maxSize=" + this.maxSize);
        }
        return new androidx.paging.PagedList$Config(this.pageSize, this.prefetchDistance, this.enablePlaceholders, this.initialLoadSizeHint, this.maxSize);
    }

    public readonly androidx.paging.PagedList$Config$Builder setEnablePlaceholders(bool enablePlaceholders) {
        this.enablePlaceholders = enablePlaceholders;
        return this;
    }

    public readonly androidx.paging.PagedList$Config$Builder setInitialLoadSizeHint(int initialLoadSizeHint) {
        this.initialLoadSizeHint = initialLoadSizeHint;
        return this;
    }

    public readonly androidx.paging.PagedList$Config$Builder setMaxSize(int maxSize) {
        this.maxSize = maxSize;
        return this;
    }

    public readonly androidx.paging.PagedList$Config$Builder setPageSize(int pageSize) {
        if (pageSize < 1) {
            throw new java.lang.IllegalArgumentException("Page size must be a positive number");
        }
        this.pageSize = pageSize;
        return this;
    }

    public readonly androidx.paging.PagedList$Config$Builder setPrefetchDistance(int prefetchDistance) {
        this.prefetchDistance = prefetchDistance;
        return this;
    }
}

