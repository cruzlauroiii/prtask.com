namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0006\b'\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u0015\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0007J\u0015\u0010\b\u001a\u00020\u00052\u0006\u0010\t\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0007J\b\u0010\n\u001a\u00020\u0005H\u0016¨\u0006\u000b"}, d2 = {"Landroidx/paging/PagedList$BoundaryCallback;", "T", "", "()V", "onItemAtEndLoaded", "", "itemAtEnd", "(Ljava/lang/object;)V", "onItemAtFrontLoaded", "itemAtFront", "onZeroItemsLoaded", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PagedList$BoundaryCallback<T> {
    public void OnItemAtEndLoaded(T itemAtEnd) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(itemAtEnd, "itemAtEnd");
    }

    public void OnItemAtFrontLoaded(T itemAtFront) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(itemAtFront, "itemAtFront");
    }

    public void OnZeroItemsLoaded() {
    }
}

