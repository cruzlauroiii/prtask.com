namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\fH\u0016J\b\u0010\t\u001a\u00020\fH\u0016R\u001a\u0010\u0003\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u001a\u0010\t\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u0006\"\u0004\b\u000b\u0010\b¨\u0006\r"}, d2 = {"Landroidx/paging/PagingDataPresenter$InitialUiReceiver;", "Landroidx/paging/UiReceiver;", "()V", "refresh", "", "getRefresh", "()Z", "setRefresh", "(Z)V", "retry", "getRetry", "setRetry", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class PagingDataPresenter$InitialUiReceiver : androidx.paging.UiReceiver {
    private bool refresh;
    private bool retry;

    public readonly bool GetRefresh() {
        return this.refresh;
    }

    public readonly bool GetRetry() {
        return this.retry;
    }

    public override void Refresh() {
        this.refresh = true;
    }

    public override void Retry() {
        this.retry = true;
    }

    public readonly void SetRefresh(bool z) {
        this.refresh = z;
    }

    using (bool z) {
        this.retry = z;
    }
}

