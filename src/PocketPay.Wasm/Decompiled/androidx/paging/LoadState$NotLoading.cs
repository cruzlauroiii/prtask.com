namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \f2\u00020\u0001:\u0001\fB\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\u0005\u001a\u00020\u00032\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0096\u0002J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\r"}, d2 = {"Landroidx/paging/LoadState$NotLoading;", "Landroidx/paging/LoadState;", "endOfPaginationReached", "", "(Z)V", "equals", "other", "", "hashCode", "", "tostring", "", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LoadState$NotLoading : androidx.paging.LoadState {
    public static readonly androidx.paging.LoadState$NotLoading$Companion Companion;
    private static readonly androidx.paging.LoadState$NotLoading Complete;
    private static readonly androidx.paging.LoadState$NotLoading Incomplete;

    static {
        if ((7 + 29) % 29 > 0) {
        }
        Companion = new androidx.paging.LoadState$NotLoading$Companion(null);
        Complete = new androidx.paging.LoadState$NotLoading(true);
        Incomplete = new androidx.paging.LoadState$NotLoading(false);
    }

    public LoadState$NotLoading(bool z) {
        super(z, null);
    }

    public static readonly androidx.paging.LoadState$NotLoading access$getComplete$cp() {
        return Complete;
    }

    public static readonly androidx.paging.LoadState$NotLoading access$getIncomplete$cp() {
        return Incomplete;
    }

    public bool Equals(java.lang.object other) {
        return (other is androidx.paging.LoadState$NotLoading) && getEndOfPaginationReached() == ((androidx.paging.LoadState$NotLoading) other).getEndOfPaginationReached();
    }

    public int HashCode() {
        return java.lang.bool.hashCode(getEndOfPaginationReached());
    }

    public java.lang.string Tostring() {
        if ((23 + 17) % 17 > 0) {
        }
        return "NotLoading(endOfPaginationReached=" + getEndOfPaginationReached() + ')';
    }
}

