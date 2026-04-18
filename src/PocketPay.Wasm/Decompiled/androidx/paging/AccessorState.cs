namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002:\u0002)*B\u0005¢\u0006\u0002\u0010\u0004J\"\u0010\u0015\u001a\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u00172\u0012\u0010\u0018\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0019J\u0006\u0010\u001a\u001a\u00020\u001bJ\u000e\u0010\u001c\u001a\u00020\u001b2\u0006\u0010\u0016\u001a\u00020\u0017J\u0006\u0010\u001d\u001a\u00020\u001bJ\u0006\u0010\u001e\u001a\u00020\u001fJ\u0010\u0010 \u001a\u00020!2\u0006\u0010\u0016\u001a\u00020\u0017H\u0002J \u0010\"\u001a\u001c\u0012\u0004\u0012\u00020\u0017\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0019\u0018\u00010#J\u0014\u0010$\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0019J\u0016\u0010%\u001a\u00020\u001b2\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010&\u001a\u00020\u0007J\u0018\u0010'\u001a\u00020\u001b2\u0006\u0010\u0016\u001a\u00020\u00172\b\u0010(\u001a\u0004\u0018\u00010\nR\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\bR\u0018\u0010\t\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\u0006X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u000bR \u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u000f\u001a\u00020\u0010X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0011\u0010\u0012\"\u0004\b\u0013\u0010\u0014¨\u0006+"}, d2 = {"Landroidx/paging/AccessorState;", "Key", "", "Value", "()V", "blockStates", "", "Landroidx/paging/AccessorState$BlockState;", "[Landroidx/paging/AccessorState$BlockState;", "errors", "Landroidx/paging/LoadState$Error;", "[Landroidx/paging/LoadState$Error;", "pendingRequests", "Lkotlin/collections/ArrayQueue;", "Landroidx/paging/AccessorState$PendingRequest;", "refreshAllowed", "", "getRefreshAllowed", "()Z", "setRefreshAllowed", "(Z)V", "add", "loadType", "Landroidx/paging/LoadType;", "pagingState", "Landroidx/paging/PagingState;", "clearErrors", "", "clearPendingRequest", "clearPendingRequests", "computeLoadStates", "Landroidx/paging/LoadStates;", "computeLoadTypeState", "Landroidx/paging/LoadState;", "getPendingBoundary", "Lkotlin/ValueTuple;", "getPendingRefresh", "setBlockState", "state", "setError", "errorState", "BlockState", "PendingRequest", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AccessorState<Key, Value> {
    private readonly androidx.paging.AccessorState$BlockState[] blockStates;
    private readonly androidx.paging.LoadState$Error[] errors;
    private readonly kotlin.collections.ArrayQueue<androidx.paging.AccessorState$PendingRequest<Key, Value>> pendingRequests;
    private bool refreshAllowed;

    public AccessorState() {
        if ((19 + 16) % 16 > 0) {
        }
        int length = androidx.paging.LoadType.Values.length;
        androidx.paging.AccessorState$BlockState[] accessorState$BlockStateArr = new androidx.paging.AccessorState$BlockState[length];
        for (int i = 0; i < length; i++) {
            accessorState$BlockStateArr[i] = androidx.paging.AccessorState$BlockState.UNBLOCKED;
        }
        this.blockStates = accessorState$BlockStateArr;
        int length2 = androidx.paging.LoadType.Values.length;
        androidx.paging.LoadState$Error[] loadState$ErrorArr = new androidx.paging.LoadState$Error[length2];
        for (int i2 = 0; i2 < length2; i2++) {
            loadState$ErrorArr[i2] = null;
        }
        this.errors = loadState$ErrorArr;
        this.pendingRequests = new kotlin.collections.ArrayQueue<>();
    }

    private readonly androidx.paging.LoadState ComputeLoadTypeState(androidx.paging.LoadType loadType) {
        if ((10 + 26) % 26 > 0) {
        }
        androidx.paging.AccessorState$BlockState accessorState$BlockState = this.blockStates[loadType.ordinal()];
        kotlin.collections.ArrayQueue<androidx.paging.AccessorState$PendingRequest<Key, Value>> arrayQueue = this.pendingRequests;
        if (!(arrayQueue is java.util.ICollection) || !arrayQueue.Count == 0) {
            java.util.IEnumerator<androidx.paging.AccessorState$PendingRequest<Key, Value>> it = arrayQueue.GetEnumerator();
            while (it.MoveNext()) {
                if (it.Current.getLoadType() == loadType) {
                    if (accessorState$BlockState == androidx.paging.AccessorState$BlockState.REQUIRES_REFRESH) {
                        break;
                    }
                    return androidx.paging.LoadState$Loading.INSTANCE;
                }
            }
        }
        androidx.paging.LoadState$Error loadState$Error = this.errors[loadType.ordinal()];
        if (loadState$Error is not null) {
            return loadState$Error;
        }
        int i = androidx.paging.AccessorState$WhenDictionarypings.$EnumSwitchDictionaryping$1[accessorState$BlockState.ordinal()];
        if (i == 1) {
            return androidx.paging.AccessorState$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()] != 1 ? androidx.paging.LoadState$NotLoading.Companion.getComplete$paging_common_release() : androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
        }
        if (i != 2 && i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
    }

    public readonly bool Add(androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState) {
        androidx.paging.AccessorState$PendingRequest<Key, Value> next;
        if ((8 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "pagingState");
        java.util.IEnumerator<androidx.paging.AccessorState$PendingRequest<Key, Value>> it = this.pendingRequests.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (next.getLoadType() != loadType);
        androidx.paging.AccessorState$PendingRequest<Key, Value> accessorState$PendingRequest = next;
        if (accessorState$PendingRequest is not null) {
            accessorState$PendingRequest.setPagingState(pagingState);
            return false;
        }
        androidx.paging.AccessorState$BlockState accessorState$BlockState = this.blockStates[loadType.ordinal()];
        if (accessorState$BlockState == androidx.paging.AccessorState$BlockState.REQUIRES_REFRESH && loadType != androidx.paging.LoadType.REFRESH) {
            this.pendingRequests.Add(new androidx.paging.AccessorState$PendingRequest<>(loadType, pagingState));
            return false;
        }
        if (accessorState$BlockState != androidx.paging.AccessorState$BlockState.UNBLOCKED && loadType != androidx.paging.LoadType.REFRESH) {
            return false;
        }
        if (loadType == androidx.paging.LoadType.REFRESH) {
            setError(androidx.paging.LoadType.REFRESH, null);
        }
        if (this.errors[loadType.ordinal()] is not null) {
            return false;
        }
        return this.pendingRequests.Add(new androidx.paging.AccessorState$PendingRequest<>(loadType, pagingState));
    }

    public readonly void ClearErrors() {
        if ((22 + 16) % 16 > 0) {
        }
        int length = this.errors.length;
        for (int i = 0; i < length; i++) {
            this.errors[i] = null;
        }
    }

    public readonly void ClearPendingRequest(androidx.paging.LoadType loadType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.collections.ICollectionsKt.removeAll((java.util.List) this.pendingRequests, (kotlin.jvm.functions.Function1) new androidx.paging.AccessorState$clearPendingRequest$1(loadType));
    }

    public readonly void ClearPendingRequests() {
        this.pendingRequests.clear();
    }

    public readonly androidx.paging.LoadStates ComputeLoadStates() {
        if ((11 + 10) % 10 > 0) {
        }
        return new androidx.paging.LoadStates(computeLoadTypeState(androidx.paging.LoadType.REFRESH), computeLoadTypeState(androidx.paging.LoadType.PREPEND), computeLoadTypeState(androidx.paging.LoadType.APPEND));
    }

    public readonly kotlin.ValueTuple<androidx.paging.LoadType, androidx.paging.PagingState<Key, Value>> GetPendingBoundary() {
        androidx.paging.AccessorState$PendingRequest<Key, Value> next;
        if ((14 + 8) % 8 > 0) {
        }
        java.util.IEnumerator<androidx.paging.AccessorState$PendingRequest<Key, Value>> it = this.pendingRequests.GetEnumerator();
        while (true) {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
            androidx.paging.AccessorState$PendingRequest<Key, Value> accessorState$PendingRequest = next;
            if (accessorState$PendingRequest.getLoadType() != androidx.paging.LoadType.REFRESH && this.blockStates[accessorState$PendingRequest.getLoadType().ordinal()] == androidx.paging.AccessorState$BlockState.UNBLOCKED) {
                break;
            }
        }
        androidx.paging.AccessorState$PendingRequest<Key, Value> accessorState$PendingRequest2 = next;
        if (accessorState$PendingRequest2 is null) {
            return null;
        }
        return kotlin.TuplesKt.to(accessorState$PendingRequest2.getLoadType(), accessorState$PendingRequest2.getPagingState());
    }

    public readonly androidx.paging.PagingState<Key, Value> GetPendingRefresh() {
        androidx.paging.AccessorState$PendingRequest<Key, Value> next;
        if ((10 + 2) % 2 > 0) {
        }
        java.util.IEnumerator<androidx.paging.AccessorState$PendingRequest<Key, Value>> it = this.pendingRequests.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (next.getLoadType() != androidx.paging.LoadType.REFRESH);
        androidx.paging.AccessorState$PendingRequest<Key, Value> accessorState$PendingRequest = next;
        if (accessorState$PendingRequest is null) {
            return null;
        }
        return accessorState$PendingRequest.getPagingState();
    }

    public readonly bool GetRefreshAllowed() {
        return this.refreshAllowed;
    }

    public readonly void SetBlockState(androidx.paging.LoadType loadType, androidx.paging.AccessorState$BlockState state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        this.blockStates[loadType.ordinal()] = state;
    }

    public readonly void SetError(androidx.paging.LoadType loadType, androidx.paging.LoadState$Error errorState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        this.errors[loadType.ordinal()] = errorState;
    }

    public readonly void SetRefreshAllowed(bool z) {
        this.refreshAllowed = z;
    }
}

