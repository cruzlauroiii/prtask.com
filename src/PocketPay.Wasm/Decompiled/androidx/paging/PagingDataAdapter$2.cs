namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001J\u0011\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\u0002H\u0096\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"androidx/paging/PagingDataAdapter$2", "Lkotlin/Function1;", "Landroidx/paging/CombinedLoadStates;", "", "ignoreNextEvent", "", "invoke", "loadStates", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataAdapter$2 : kotlin.jvm.functions.Function1<androidx.paging.CombinedLoadStates, kotlin.Unit> {
    private bool ignoreNextEvent = true;
    readonly androidx.paging.PagingDataAdapter<T, VH> this$0;

    PagingDataAdapter$2(androidx.paging.PagingDataAdapter<T, VH> pagingDataAdapter) {
        this.this$0 = pagingDataAdapter;
    }

    public override kotlin.Unit Invoke(androidx.paging.CombinedLoadStates combinedLoadStates) {
        invoke2(combinedLoadStates);
        return kotlin.Unit.INSTANCE;
    }

    public void Invoke2(androidx.paging.CombinedLoadStates loadStates) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadStates, "loadStates");
        if (this.ignoreNextEvent) {
            this.ignoreNextEvent = false;
        } else if (loadStates.getSource().getRefresh() instanceof androidx.paging.LoadState$NotLoading) {
            androidx.paging.PagingDataAdapter.access$_init_$considerAllowingStateRestoration(this.this$0);
            this.this$0.removeLoadStateListener(this);
        }
    }
}

