namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\n¢\u0006\u0002\b\n"}, d2 = {"<anonymous>", "", "T", "", "VH", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "loadType", "Landroidx/paging/LoadType;", "loadState", "Landroidx/paging/LoadState;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagedListAdapter$withLoadStateHeader$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<androidx.paging.LoadType, androidx.paging.LoadState, kotlin.Unit> {
    readonly androidx.paging.LoadStateAdapter<object> $header;

    PagedListAdapter$withLoadStateHeader$1(androidx.paging.LoadStateAdapter<object> loadStateAdapter) {
        super(2);
        this.$header = loadStateAdapter;
    }

    public override kotlin.Unit Invoke(androidx.paging.LoadType loadType, androidx.paging.LoadState loadState) {
        invoke2(loadType, loadState);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.LoadType loadType, androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "loadState");
        if (loadType != androidx.paging.LoadType.PREPEND) {
            return;
        }
        this.$header.setLoadState(loadState);
    }
}

