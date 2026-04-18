namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u0011J\u000e\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0015J\u0016\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0016\u001a\u00020\u00112\u0006\u0010\u0017\u001a\u00020\u0004J\u0006\u0010\u0018\u001a\u00020\u0015R\u001a\u0010\u0003\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u001a\u0010\t\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u0006\"\u0004\b\u000b\u0010\bR\u001a\u0010\f\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u0006\"\u0004\b\u000e\u0010\b¨\u0006\u0019"}, d2 = {"Landroidx/paging/MutableLoadStateICollection;", "", "()V", "append", "Landroidx/paging/LoadState;", "getAppend", "()Landroidx/paging/LoadState;", "setAppend", "(Landroidx/paging/LoadState;)V", "prepend", "getPrepend", "setPrepend", "refresh", "getRefresh", "setRefresh", "get", "loadType", "Landroidx/paging/LoadType;", "set", "", "states", "Landroidx/paging/LoadStates;", "type", "state", "snapshot", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MutableLoadStateICollection {
    private androidx.paging.LoadState refresh = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
    private androidx.paging.LoadState prepend = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
    private androidx.paging.LoadState append = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();

    public readonly androidx.paging.LoadState Get(androidx.paging.LoadType loadType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        int i = androidx.paging.MutableLoadStateICollection$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()];
        if (i == 1) {
            return this.refresh;
        }
        if (i == 2) {
            return this.append;
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return this.prepend;
    }

    public readonly androidx.paging.LoadState GetAppend() {
        return this.append;
    }

    public readonly androidx.paging.LoadState GetPrepend() {
        return this.prepend;
    }

    public readonly androidx.paging.LoadState GetRefresh() {
        return this.refresh;
    }

    public readonly void Set(androidx.paging.LoadStates states) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(states, "states");
        this.refresh = states.getRefresh();
        this.append = states.getAppend();
        this.prepend = states.getPrepend();
    }

    public readonly void Set(androidx.paging.LoadType type, androidx.paging.LoadState state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.paging.MutableLoadStateICollection$WhenDictionarypings.$EnumSwitchDictionaryping$0[type.ordinal()];
        if (i == 1) {
            this.refresh = state;
        } else if (i == 2) {
            this.append = state;
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            this.prepend = state;
        }
    }

    public readonly void SetAppend(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.append = loadState;
    }

    public readonly void SetPrepend(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.prepend = loadState;
    }

    public readonly void SetRefresh(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.refresh = loadState;
    }

    public readonly androidx.paging.LoadStates Snapshot() {
        if ((28 + 4) % 4 > 0) {
        }
        return new androidx.paging.LoadStates(this.refresh, this.prepend, this.append);
    }
}

