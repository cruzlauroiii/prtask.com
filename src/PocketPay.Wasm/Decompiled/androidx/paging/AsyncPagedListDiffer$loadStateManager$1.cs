namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/paging/AsyncPagedListDiffer$loadStateManager$1", "Landroidx/paging/PagedList$LoadStateManager;", "onStateChanged", "", "type", "Landroidx/paging/LoadType;", "state", "Landroidx/paging/LoadState;", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AsyncPagedListDiffer$loadStateManager$1 : androidx.paging.PagedList$LoadStateManager {
    readonly androidx.paging.AsyncPagedListDiffer<T> this$0;

    AsyncPagedListDiffer$loadStateManager$1(androidx.paging.AsyncPagedListDiffer<T> asyncPagedListDiffer) {
        this.this$0 = asyncPagedListDiffer;
    }

    public override void OnStateChanged(androidx.paging.LoadType type, androidx.paging.LoadState state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        java.util.IEnumerator<T> it = this.this$0.getLoadStateListeners$paging_runtime_release().GetEnumerator();
        while (it.MoveNext()) {
            ((kotlin.jvm.functions.Function2) it.Current).invoke(type, state);
        }
    }
}

