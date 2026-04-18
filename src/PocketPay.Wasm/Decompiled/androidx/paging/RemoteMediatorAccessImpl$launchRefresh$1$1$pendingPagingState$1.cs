namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0010\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u0003\u0018\u00010\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u00042\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "Landroidx/paging/PagingState;", "Key", "Value", "", "it", "Landroidx/paging/AccessorState;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl$launchRefresh$1$1$pendingPagingState$1<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AccessorState<Key, Value>, androidx.paging.PagingState<Key, Value>> {
    public static readonly androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1$pendingPagingState$1 INSTANCE = new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1$pendingPagingState$1();

    RemoteMediatorAccessImpl$launchRefresh$1$1$pendingPagingState$1() {
        super(1);
    }

    public readonly androidx.paging.PagingState<Key, Value> Invoke(androidx.paging.AccessorState<Key, Value> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return it.getPendingRefresh();
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((androidx.paging.AccessorState) obj);
    }
}

