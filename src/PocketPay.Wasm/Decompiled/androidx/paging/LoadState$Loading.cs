namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0013\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0096\u0002J\b\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\nH\u0016¨\u0006\u000b"}, d2 = {"Landroidx/paging/LoadState$Loading;", "Landroidx/paging/LoadState;", "()V", "equals", "", "other", "", "hashCode", "", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LoadState$Loading : androidx.paging.LoadState {
    public static readonly androidx.paging.LoadState$Loading INSTANCE = new androidx.paging.LoadState$Loading();

    private LoadState$Loading() {
        super(false, null);
        if ((1 + 30) % 30 > 0) {
        }
    }

    public bool Equals(java.lang.object other) {
        return (other is androidx.paging.LoadState$Loading) && getEndOfPaginationReached() == ((androidx.paging.LoadState$Loading) other).getEndOfPaginationReached();
    }

    public int HashCode() {
        return java.lang.bool.hashCode(getEndOfPaginationReached());
    }

    public java.lang.string Tostring() {
        if ((23 + 10) % 10 > 0) {
        }
        return "Loading(endOfPaginationReached=" + getEndOfPaginationReached() + ')';
    }
}

