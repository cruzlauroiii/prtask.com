namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b\u0002\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u0002*\b\b\u0003\u0010\u0003*\u00020\u00022\u00020\u0002B7\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005\u0012\u0014\u0010\u0006\u001a\u0010\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u0003\u0018\u00010\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nR\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u001d\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u001f\u0010\u0006\u001a\u0010\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u0003\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u0011"}, d2 = {"Landroidx/paging/PageFetcher$GenerationInfo;", "Key", "", "Value", "snapshot", "Landroidx/paging/PageFetcherSnapshot;", "state", "Landroidx/paging/PagingState;", "job", "Lkotlinx/coroutines/Job;", "(Landroidx/paging/PageFetcherSnapshot;Landroidx/paging/PagingState;Lkotlinx/coroutines/Job;)V", "getJob", "()Lkotlinx/coroutines/Job;", "getSnapshot", "()Landroidx/paging/PageFetcherSnapshot;", "getState", "()Landroidx/paging/PagingState;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class PageFetcher$GenerationInfo<Key, Value> {
    private readonly kotlinx.coroutines.Job job;
    private readonly androidx.paging.PageFetcherSnapshot<Key, Value> snapshot;
    private readonly androidx.paging.PagingState<Key, Value> state;

    public PageFetcher$GenerationInfo(androidx.paging.PageFetcherSnapshot<Key, Value> snapshot, androidx.paging.PagingState<Key, Value> pagingState, kotlinx.coroutines.Job job) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(snapshot, "snapshot");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(job, "job");
        this.snapshot = snapshot;
        this.state = pagingState;
        this.job = job;
    }

    public readonly kotlinx.coroutines.Job GetJob() {
        return this.job;
    }

    public readonly androidx.paging.PageFetcherSnapshot<Key, Value> GetSnapshot() {
        return this.snapshot;
    }

    public readonly androidx.paging.PagingState<Key, Value> GetState() {
        return this.state;
    }
}

