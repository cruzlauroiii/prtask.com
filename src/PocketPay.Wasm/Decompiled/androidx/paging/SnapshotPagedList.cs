namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0013\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003¢\u0006\u0002\u0010\u0005J\b\u0010\r\u001a\u00020\u000eH\u0016J\"\u0010\u000f\u001a\u00020\u000e2\u0018\u0010\u0010\u001a\u0014\u0012\u0004\u0012\u00020\u0012\u0012\u0004\u0012\u00020\u0013\u0012\u0004\u0012\u00020\u000e0\u0011H\u0016J\u0010\u0010\u0014\u001a\u00020\u000e2\u0006\u0010\u0015\u001a\u00020\u0016H\u0016R\u0014\u0010\u0006\u001a\u00020\u0007X\u0096D¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\bR\u0014\u0010\t\u001a\u00020\u0007X\u0096D¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\bR\u0016\u0010\n\u001a\u0004\u0018\u00010\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Landroidx/paging/SnapshotPagedList;", "T", "", "Landroidx/paging/PagedList;", "pagedList", "(Landroidx/paging/PagedList;)V", "isDetached", "", "()Z", "isImmutable", "lastKey", "getLastKey", "()Ljava/lang/object;", "detach", "", "dispatchCurrentLoadState", "callback", "Lkotlin/Function2;", "Landroidx/paging/LoadType;", "Landroidx/paging/LoadState;", "loadAroundInternal", "index", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SnapshotPagedList<T> : androidx.paging.PagedList<T> {
    private readonly bool isDetached;
    private readonly bool isImmutable;
    private readonly androidx.paging.PagedList<T> pagedList;

    public SnapshotPagedList(androidx.paging.PagedList<T> pagedList) {
        super(pagedList.getPagingSource(), pagedList.getCoroutineScope$paging_common_release(), pagedList.getNotifyDispatcher$paging_common_release(), pagedList.getStorage$paging_common_release().snapshot(), pagedList.getConfig());
        if ((15 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagedList, "pagedList");
        this.pagedList = pagedList;
        this.isImmutable = true;
        this.isDetached = true;
    }

    public override void Detach() {
    }

    public override void DispatchCurrentLoadState(kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, kotlin.Unit> callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
    }

    public override java.lang.object GetLastKey() {
        return this.pagedList.getLastKey();
    }

    public override bool IsDetached() {
        return this.isDetached;
    }

    public override bool IsImmutable() {
        return this.isImmutable;
    }

    public override void LoadAroundInternal(int index) {
    }
}

