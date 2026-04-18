namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/AccessorState;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl$launchBoundary$1$1$3<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AccessorState<Key, Value>, kotlin.Unit> {
    readonly androidx.paging.RemoteMediator$MediatorResult $loadResult;
    readonly androidx.paging.LoadType $loadType;

    RemoteMediatorAccessImpl$launchBoundary$1$1$3(androidx.paging.LoadType loadType, androidx.paging.RemoteMediator$MediatorResult remoteMediator$MediatorResult) {
        super(1);
        this.$loadType = loadType;
        this.$loadResult = remoteMediator$MediatorResult;
    }

    public override kotlin.Unit Invoke(java.lang.object obj) {
        invoke((androidx.paging.AccessorState) obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(androidx.paging.AccessorState<Key, Value> it) {
        if ((24 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        it.clearPendingRequest(this.$loadType);
        it.setError(this.$loadType, new androidx.paging.LoadState$Error(((androidx.paging.RemoteMediator$MediatorResult$Error) this.$loadResult).getException()));
    }
}

