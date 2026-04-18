namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\n¢\u0006\u0002\b\b"}, d2 = {"<anonymous>", "", "T", "", "VH", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "loadStates", "Landroidx/paging/CombinedLoadStates;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagingDataAdapter$withLoadStateFooter$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.CombinedLoadStates, kotlin.Unit> {
    readonly androidx.paging.LoadStateAdapter<object> $footer;

    PagingDataAdapter$withLoadStateFooter$1(androidx.paging.LoadStateAdapter<object> loadStateAdapter) {
        super(1);
        this.$footer = loadStateAdapter;
    }

    public override kotlin.Unit Invoke(androidx.paging.CombinedLoadStates combinedLoadStates) {
        invoke2(combinedLoadStates);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.CombinedLoadStates loadStates) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadStates, "loadStates");
        this.$footer.setLoadState(loadStates.getAppend());
    }
}

