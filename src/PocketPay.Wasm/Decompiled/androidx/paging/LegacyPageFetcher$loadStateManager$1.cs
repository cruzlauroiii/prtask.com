namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/paging/LegacyPageFetcher$loadStateManager$1", "Landroidx/paging/PagedList$LoadStateManager;", "onStateChanged", "", "type", "Landroidx/paging/LoadType;", "state", "Landroidx/paging/LoadState;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LegacyPageFetcher$loadStateManager$1 : androidx.paging.PagedList$LoadStateManager {
    readonly androidx.paging.LegacyPageFetcher<K, V> this$0;

    LegacyPageFetcher$loadStateManager$1(androidx.paging.LegacyPageFetcher<K, V> legacyPageFetcher) {
        this.this$0 = legacyPageFetcher;
    }

    public override void OnStateChanged(androidx.paging.LoadType type, androidx.paging.LoadState state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        this.this$0.getPageConsumer().onStateChanged(type, state);
    }
}

