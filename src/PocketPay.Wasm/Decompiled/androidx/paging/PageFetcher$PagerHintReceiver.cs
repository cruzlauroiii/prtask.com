namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0004\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u0002*\b\b\u0003\u0010\u0003*\u00020\u00022\u00020\u0004B\u0019\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016R\"\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u00068\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Landroidx/paging/PageFetcher$PagerHintReceiver;", "Key", "", "Value", "Landroidx/paging/HintReceiver;", "pageFetcherSnapshot", "Landroidx/paging/PageFetcherSnapshot;", "(Landroidx/paging/PageFetcher;Landroidx/paging/PageFetcherSnapshot;)V", "getPageFetcherSnapshot$paging_common_release", "()Landroidx/paging/PageFetcherSnapshot;", "accessHint", "", "viewportHint", "Landroidx/paging/objectportHint;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageFetcher$PagerHintReceiver<Key, Value> : androidx.paging.HintReceiver {
    private readonly androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot;
    readonly androidx.paging.PageFetcher<Key, Value> this$0;

    public PageFetcher$PagerHintReceiver(androidx.paging.PageFetcher pageFetcher, androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pageFetcherSnapshot, "pageFetcherSnapshot");
        this.this$0 = pageFetcher;
        this.pageFetcherSnapshot = pageFetcherSnapshot;
    }

    public override void AccessHint(androidx.paging.objectportHint viewportHint) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewportHint, "viewportHint");
        this.pageFetcherSnapshot.accessHint(viewportHint);
    }

    public readonly androidx.paging.PageFetcherSnapshot<Key, Value> getPageFetcherSnapshot$paging_common_release() {
        return this.pageFetcherSnapshot;
    }
}

