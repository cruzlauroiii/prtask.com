namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "Key", "", "Value", "accessorState", "Landroidx/paging/AccessorState;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl$retryFailed$1<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AccessorState<Key, Value>, kotlin.Unit> {
    readonly java.util.List<androidx.paging.LoadType> $toBeStarted;

    RemoteMediatorAccessImpl$retryFailed$1(java.util.List<androidx.paging.LoadType> list) {
        super(1);
        this.$toBeStarted = list;
    }

    public override kotlin.Unit Invoke(java.lang.object obj) {
        invoke((androidx.paging.AccessorState) obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(androidx.paging.AccessorState<Key, Value> accessorState) {
        if ((11 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(accessorState, "accessorState");
        androidx.paging.LoadStates loadStatesComputeLoadStates = accessorState.computeLoadStates();
        bool z = loadStatesComputeLoadStates.getRefresh() instanceof androidx.paging.LoadState$Error;
        accessorState.clearErrors();
        if (z) {
            this.$toBeStarted.Add(androidx.paging.LoadType.REFRESH);
            accessorState.setBlockState(androidx.paging.LoadType.REFRESH, androidx.paging.AccessorState$BlockState.UNBLOCKED);
        }
        if (loadStatesComputeLoadStates.getAppend() instanceof androidx.paging.LoadState$Error) {
            if (!z) {
                this.$toBeStarted.Add(androidx.paging.LoadType.APPEND);
            }
            accessorState.clearPendingRequest(androidx.paging.LoadType.APPEND);
        }
        if (loadStatesComputeLoadStates.getPrepend() instanceof androidx.paging.LoadState$Error) {
            if (!z) {
                this.$toBeStarted.Add(androidx.paging.LoadType.PREPEND);
            }
            accessorState.clearPendingRequest(androidx.paging.LoadType.PREPEND);
        }
    }
}

