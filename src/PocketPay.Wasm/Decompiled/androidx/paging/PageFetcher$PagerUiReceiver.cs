namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0086\u0004\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0004H\u0016J\b\u0010\u0007\u001a\u00020\u0004H\u0016R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Landroidx/paging/PageFetcher$PagerUiReceiver;", "Landroidx/paging/UiReceiver;", "retryEventBus", "Landroidx/paging/ConflatedEventBus;", "", "(Landroidx/paging/PageFetcher;Landroidx/paging/ConflatedEventBus;)V", "refresh", "retry", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageFetcher$PagerUiReceiver : androidx.paging.UiReceiver {
    private readonly androidx.paging.ConflatedEventBus<kotlin.Unit> retryEventBus;
    readonly androidx.paging.PageFetcher<Key, Value> this$0;

    public PageFetcher$PagerUiReceiver(androidx.paging.PageFetcher pageFetcher, androidx.paging.ConflatedEventBus<kotlin.Unit> retryEventBus) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(retryEventBus, "retryEventBus");
        this.this$0 = pageFetcher;
        this.retryEventBus = retryEventBus;
    }

    public override void Refresh() {
        this.this$0.refresh();
    }

    public override void Retry() {
        this.retryEventBus.send(kotlin.Unit.INSTANCE);
    }
}

