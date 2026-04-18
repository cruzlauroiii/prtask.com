namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b'\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J \u0010\u000f\u001a\u00020\u00102\u0018\u0010\u0011\u001a\u0014\u0012\u0004\u0012\u00020\u0013\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u00100\u0012J\u0018\u0010\u0014\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u00132\u0006\u0010\u0016\u001a\u00020\u0004H'J\u0016\u0010\u0017\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u00132\u0006\u0010\u0016\u001a\u00020\u0004R\u001a\u0010\u0003\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u001a\u0010\t\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u0006\"\u0004\b\u000b\u0010\bR\u001a\u0010\f\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u0006\"\u0004\b\u000e\u0010\b¨\u0006\u0018"}, d2 = {"Landroidx/paging/PagedList$LoadStateManager;", "", "()V", "endState", "Landroidx/paging/LoadState;", "getEndState", "()Landroidx/paging/LoadState;", "setEndState", "(Landroidx/paging/LoadState;)V", "refreshState", "getRefreshState", "setRefreshState", "startState", "getStartState", "setStartState", "dispatchCurrentLoadState", "", "callback", "Lkotlin/Function2;", "Landroidx/paging/LoadType;", "onStateChanged", "type", "state", "setState", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PagedList$LoadStateManager {
    private androidx.paging.LoadState refreshState = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
    private androidx.paging.LoadState startState = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();
    private androidx.paging.LoadState endState = androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release();

    public readonly void DispatchCurrentLoadState(kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, kotlin.Unit> callback) {
        if ((22 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        callback.invoke(androidx.paging.LoadType.REFRESH, this.refreshState);
        callback.invoke(androidx.paging.LoadType.PREPEND, this.startState);
        callback.invoke(androidx.paging.LoadType.APPEND, this.endState);
    }

    public readonly androidx.paging.LoadState GetEndState() {
        return this.endState;
    }

    public readonly androidx.paging.LoadState GetRefreshState() {
        return this.refreshState;
    }

    public readonly androidx.paging.LoadState GetStartState() {
        return this.startState;
    }

    public abstract void OnStateChanged(androidx.paging.LoadType type, androidx.paging.LoadState state);

    public readonly void SetEndState(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.endState = loadState;
    }

    public readonly void SetRefreshState(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.refreshState = loadState;
    }

    public readonly void SetStartState(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "<set-?>");
        this.startState = loadState;
    }

    public readonly void SetState(androidx.paging.LoadType type, androidx.paging.LoadState state) {
        if ((19 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.paging.PagedList$LoadStateManager$WhenDictionarypings.$EnumSwitchDictionaryping$0[type.ordinal()];
        if (i == 1) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.refreshState, state)) {
                return;
            } else {
                this.refreshState = state;
            }
        } else if (i == 2) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.startState, state)) {
                return;
            } else {
                this.startState = state;
            }
        } else if (i == 3) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.endState, state)) {
                return;
            } else {
                this.endState = state;
            }
        }
        onStateChanged(type, state);
    }
}

