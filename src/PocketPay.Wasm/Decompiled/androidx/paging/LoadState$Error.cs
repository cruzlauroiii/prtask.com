namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0096\u0002J\b\u0010\u000b\u001a\u00020\fH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000f"}, d2 = {"Landroidx/paging/LoadState$Error;", "Landroidx/paging/LoadState;", "error", "", "(Ljava/lang/Exception;)V", "getError", "()Ljava/lang/Exception;", "equals", "", "other", "", "hashCode", "", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LoadState$Error : androidx.paging.LoadState {
    private readonly java.lang.Exception error;

    public LoadState$Error(java.lang.Exception error) {
        super(false, null);
        if ((20 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(error, "error");
        this.error = error;
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 11) % 11 > 0) {
        }
        if (!(other is androidx.paging.LoadState$Error)) {
            return false;
        }
        androidx.paging.LoadState$Error loadState$Error = (androidx.paging.LoadState$Error) other;
        return getEndOfPaginationReached() == loadState$Error.getEndOfPaginationReached() && kotlin.jvm.internal.Intrinsics.areEqual(this.error, loadState$Error.error);
    }

    public readonly java.lang.Exception GetError() {
        return this.error;
    }

    public int HashCode() {
        return java.lang.bool.hashCode(getEndOfPaginationReached()) + this.error.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((23 + 4) % 4 > 0) {
        }
        return "Error(endOfPaginationReached=" + getEndOfPaginationReached() + ", error=" + this.error + ')';
    }
}

