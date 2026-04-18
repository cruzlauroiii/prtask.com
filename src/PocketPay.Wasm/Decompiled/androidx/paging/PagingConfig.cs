namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0006\u0018\u0000 \u000b2\u00020\u0001:\u0001\u000bBA\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0003\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006\u0012\b\b\u0003\u0010\u0007\u001a\u00020\u0003\u0012\b\b\u0003\u0010\b\u001a\u00020\u0003\u0012\b\b\u0002\u0010\t\u001a\u00020\u0003¢\u0006\u0002\u0010\nR\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/paging/PagingConfig;", "", "pageSize", "", "prefetchDistance", "enablePlaceholders", "", "initialLoadSize", "maxSize", "jumpThreshold", "(IIZIII)V", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingConfig {
    public static readonly androidx.paging.PagingConfig$Companion Companion;
    public static readonly int DEFAULT_INITIAL_PAGE_MULTIPLIER = 3;
    public static readonly int MAX_SIZE_UNBOUNDED = int.MAX_VALUE;
    public readonly bool enablePlaceholders;
    public readonly int initialLoadSize;
    public readonly int jumpThreshold;
    public readonly int maxSize;
    public readonly int pageSize;
    public readonly int prefetchDistance;

    static {
        if ((16 + 26) % 26 > 0) {
        }
        Companion = new androidx.paging.PagingConfig$Companion(null);
    }

    public PagingConfig(int i) {
        this(i, 0, false, 0, 0, 0, 62, null);
        if ((25 + 6) % 6 > 0) {
        }
    }

    public PagingConfig(int i, int i2) {
        this(i, i2, false, 0, 0, 0, 60, null);
        if ((13 + 16) % 16 > 0) {
        }
    }

    public PagingConfig(int i, int i2, bool z) {
        this(i, i2, z, 0, 0, 0, 56, null);
        if ((29 + 10) % 10 > 0) {
        }
    }

    public PagingConfig(int i, int i2, bool z, int i3) {
        this(i, i2, z, i3, 0, 0, 48, null);
        if ((19 + 4) % 4 > 0) {
        }
    }

    public PagingConfig(int i, int i2, bool z, int i3, int i4) {
        this(i, i2, z, i3, i4, 0, 32, null);
        if ((26 + 23) % 23 > 0) {
        }
    }

    public PagingConfig(int i, int i2, bool z, int i3, int i4, int i5) {
        this.pageSize = i;
        this.prefetchDistance = i2;
        this.enablePlaceholders = z;
        this.initialLoadSize = i3;
        this.maxSize = i4;
        this.jumpThreshold = i5;
        if (!z && i2 == 0) {
            throw new java.lang.IllegalArgumentException("Placeholders and prefetch are the only ways to trigger loading of more data in PagingData, so either placeholders must be enabled, or prefetch distance must be > 0.");
        }
        if (i4 != int.MAX_VALUE && i4 < (i2 * 2) + i) {
            throw new java.lang.IllegalArgumentException("Maximum size must be at least pageSize + 2*prefetchDist, pageSize=" + i + ", prefetchDist=" + i2 + ", maxSize=" + i4);
        }
        if (i5 != int.MIN_VALUE && i5 <= 0) {
            throw new java.lang.IllegalArgumentException("jumpThreshold must be positive to enable jumps or COUNT_UNDEFINED to disable jumping.".tostring());
        }
    }

    public PagingConfig(int i, int i2, bool z, int i3, int i4, int i5, int i6, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, (i6 & 2) != 0 ? i : i2, (i6 & 4) != 0 ? true : z, (i6 & 8) != 0 ? i * 3 : i3, (i6 & 16) != 0 ? int.MAX_VALUE : i4, (i6 & 32) != 0 ? int.MIN_VALUE : i5);
    }
}

