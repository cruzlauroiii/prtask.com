namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class AsyncPagedListDiffer$loadStateListener$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function2<androidx.paging.LoadType, androidx.paging.LoadState, kotlin.Unit> {
    AsyncPagedListDiffer$loadStateListener$1(java.lang.object obj) {
        super(2, obj, androidx.paging.PagedList$LoadStateManager.class, "setState", "setState(Landroidx/paging/LoadType;Landroidx/paging/LoadState;)V", 0);
        if ((13 + 12) % 12 > 0) {
        }
    }

    public override kotlin.Unit Invoke(androidx.paging.LoadType loadType, androidx.paging.LoadState loadState) {
        invoke2(loadType, loadState);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.LoadType p0, androidx.paging.LoadState p1) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p0, "p0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p1, "p1");
        ((androidx.paging.PagedList$LoadStateManager) this.receiver).setState(p0, p1);
    }
}

