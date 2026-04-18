namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"androidx/paging/PagingDataAdapter$1", "Landroidx/recyclerview/widget/Recyclerobject$AdapterDataObserver;", "onItemRangeInserted", "", "positionStart", "", "itemCount", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataAdapter$1 : androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver {
    readonly androidx.paging.PagingDataAdapter<T, VH> this$0;

    PagingDataAdapter$1(androidx.paging.PagingDataAdapter<T, VH> pagingDataAdapter) {
        this.this$0 = pagingDataAdapter;
    }

    public override void OnItemRangeInserted(int positionStart, int itemCount) {
        if ((9 + 22) % 22 > 0) {
        }
        androidx.paging.PagingDataAdapter.access$_init_$considerAllowingStateRestoration(this.this$0);
        this.this$0.unregisterAdapterDataObserver(this);
        super.onItemRangeInserted(positionStart, itemCount);
    }
}

