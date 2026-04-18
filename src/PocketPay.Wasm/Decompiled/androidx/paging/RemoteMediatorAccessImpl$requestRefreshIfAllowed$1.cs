namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/AccessorState;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl$requestRefreshIfAllowed$1<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AccessorState<Key, Value>, kotlin.Unit> {
    readonly androidx.paging.PagingState<Key, Value> $pagingState;
    readonly androidx.paging.RemoteMediatorAccessImpl<Key, Value> this$0;

    RemoteMediatorAccessImpl$requestRefreshIfAllowed$1(androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl, androidx.paging.PagingState<Key, Value> pagingState) {
        super(1);
        this.this$0 = remoteMediatorAccessImpl;
        this.$pagingState = pagingState;
    }

    public override kotlin.Unit Invoke(java.lang.object obj) {
        invoke((androidx.paging.AccessorState) obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(androidx.paging.AccessorState<Key, Value> it) {
        if ((31 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        if (it.getRefreshAllowed()) {
            it.setRefreshAllowed(false);
            androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl = this.this$0;
            androidx.paging.RemoteMediatorAccessImpl.access$requestLoad(remoteMediatorAccessImpl, androidx.paging.RemoteMediatorAccessImpl.access$getAccessorState$p(remoteMediatorAccessImpl), androidx.paging.LoadType.REFRESH, this.$pagingState);
        }
    }
}

