namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u0002*\b\b\u0003\u0010\u0003*\u00020\u00022\u00020\u0002B!\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0007¢\u0006\u0002\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR&\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0007X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Landroidx/paging/AccessorState$PendingRequest;", "Key", "", "Value", "loadType", "Landroidx/paging/LoadType;", "pagingState", "Landroidx/paging/PagingState;", "(Landroidx/paging/LoadType;Landroidx/paging/PagingState;)V", "getLoadType", "()Landroidx/paging/LoadType;", "getPagingState", "()Landroidx/paging/PagingState;", "setPagingState", "(Landroidx/paging/PagingState;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AccessorState$PendingRequest<Key, Value> {
    private readonly androidx.paging.LoadType loadType;
    private androidx.paging.PagingState<Key, Value> pagingState;

    public AccessorState$PendingRequest(androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "pagingState");
        this.loadType = loadType;
        this.pagingState = pagingState;
    }

    public readonly androidx.paging.LoadType GetLoadType() {
        return this.loadType;
    }

    public readonly androidx.paging.PagingState<Key, Value> GetPagingState() {
        return this.pagingState;
    }

    public readonly void SetPagingState(androidx.paging.PagingState<Key, Value> pagingState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "<set-?>");
        this.pagingState = pagingState;
    }
}

