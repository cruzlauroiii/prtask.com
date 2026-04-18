namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0086\b\u0018\u0000 $2\u00020\u0001:\u0001$B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003¢\u0006\u0002\u0010\u0006J\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J'\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\n2\b\u0010\u0014\u001a\u0004\u0018\u00010\u0001HÖ\u0003J&\u0010\u0015\u001a\u00020\u00162\u0018\u0010\u0017\u001a\u0014\u0012\u0004\u0012\u00020\u0019\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00160\u0018H\u0087\bø\u0001\u0000J\u0015\u0010\u001a\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u0019H\u0000¢\u0006\u0002\b\u001cJ\t\u0010\u001d\u001a\u00020\u001eHÖ\u0001J\u001d\u0010\u001f\u001a\u00020\u00002\u0006\u0010\u001b\u001a\u00020\u00192\u0006\u0010 \u001a\u00020\u0003H\u0000¢\u0006\u0002\b!J\t\u0010\"\u001a\u00020#HÖ\u0001R\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\t\u001a\u00020\n8G¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\u000bR\u0011\u0010\f\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006%"}, d2 = {"Landroidx/paging/LoadStates;", "", "refresh", "Landroidx/paging/LoadState;", "prepend", "append", "(Landroidx/paging/LoadState;Landroidx/paging/LoadState;Landroidx/paging/LoadState;)V", "getAppend", "()Landroidx/paging/LoadState;", "hasError", "", "()Z", "isIdle", "getPrepend", "getRefresh", "component1", "component2", "component3", "copy", "equals", "other", "forEach", "", "op", "Lkotlin/Function2;", "Landroidx/paging/LoadType;", "get", "loadType", "get$paging_common_release", "hashCode", "", "modifyState", "newState", "modifyState$paging_common_release", "tostring", "", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LoadStates {
    public static readonly androidx.paging.LoadStates$Companion Companion;
    private static readonly androidx.paging.LoadStates IDLE;
    private readonly androidx.paging.LoadState append;
    private readonly bool hasError;
    private readonly bool isIdle;
    private readonly androidx.paging.LoadState prepend;
    private readonly androidx.paging.LoadState refresh;

    static {
        if ((3 + 12) % 12 > 0) {
        }
        Companion = new androidx.paging.LoadStates$Companion(null);
        IDLE = new androidx.paging.LoadStates(androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release(), androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release(), androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release());
    }

    public LoadStates(androidx.paging.LoadState refresh, androidx.paging.LoadState prepend, androidx.paging.LoadState append) {
        if ((22 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(refresh, "refresh");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prepend, "prepend");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(append, "append");
        this.refresh = refresh;
        this.prepend = prepend;
        this.append = append;
        bool z = false;
        this.hasError = (refresh is androidx.paging.LoadState$Error) || (append is androidx.paging.LoadState$Error) || (prepend is androidx.paging.LoadState$Error);
        if ((refresh is androidx.paging.LoadState$NotLoading) && (append is androidx.paging.LoadState$NotLoading) && (prepend is androidx.paging.LoadState$NotLoading)) {
            z = true;
        }
        this.isIdle = z;
    }

    public static readonly androidx.paging.LoadStates access$getIDLE$cp() {
        return IDLE;
    }

    public static androidx.paging.LoadStates copy$default(androidx.paging.LoadStates loadStates, androidx.paging.LoadState loadState, androidx.paging.LoadState loadState2, androidx.paging.LoadState loadState3, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            loadState = loadStates.refresh;
        }
        if ((i & 2) != 0) {
            loadState2 = loadStates.prepend;
        }
        if ((i & 4) != 0) {
            loadState3 = loadStates.append;
        }
        return loadStates.copy(loadState, loadState2, loadState3);
    }

    public readonly androidx.paging.LoadState Component1() {
        return this.refresh;
    }

    public readonly androidx.paging.LoadState Component2() {
        return this.prepend;
    }

    public readonly androidx.paging.LoadState Component3() {
        return this.append;
    }

    public readonly androidx.paging.LoadStates Copy(androidx.paging.LoadState refresh, androidx.paging.LoadState prepend, androidx.paging.LoadState append) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(refresh, "refresh");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prepend, "prepend");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(append, "append");
        return new androidx.paging.LoadStates(refresh, prepend, append);
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 32) % 32 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.LoadStates)) {
            return false;
        }
        androidx.paging.LoadStates loadStates = (androidx.paging.LoadStates) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.refresh, loadStates.refresh) && kotlin.jvm.internal.Intrinsics.areEqual(this.prepend, loadStates.prepend) && kotlin.jvm.internal.Intrinsics.areEqual(this.append, loadStates.append);
    }

    public readonly void ForEach(kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, kotlin.Unit> op) {
        if ((4 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(op, "op");
        op.invoke(androidx.paging.LoadType.REFRESH, getRefresh());
        op.invoke(androidx.paging.LoadType.PREPEND, getPrepend());
        op.invoke(androidx.paging.LoadType.APPEND, getAppend());
    }

    public readonly androidx.paging.LoadState get$paging_common_release(androidx.paging.LoadType loadType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        int i = androidx.paging.LoadStates$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()];
        if (i == 1) {
            return this.append;
        }
        if (i == 2) {
            return this.prepend;
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return this.refresh;
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

    public readonly bool HasError() {
        return this.hasError;
    }

    public int HashCode() {
        if ((1 + 25) % 25 > 0) {
        }
        return (((this.refresh.GetHashCode() * 31) + this.prepend.GetHashCode()) * 31) + this.append.GetHashCode();
    }

    public readonly bool IsIdle() {
        return this.isIdle;
    }

    public readonly androidx.paging.LoadStates modifyState$paging_common_release(androidx.paging.LoadType loadType, androidx.paging.LoadState newState) {
        if ((27 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newState, "newState");
        int i = androidx.paging.LoadStates$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()];
        if (i == 1) {
            return copy$default(this, null, null, newState, 3, null);
        }
        if (i == 2) {
            return copy$default(this, null, newState, null, 5, null);
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return copy$default(this, newState, null, null, 6, null);
    }

    public java.lang.string Tostring() {
        if ((21 + 17) % 17 > 0) {
        }
        return "LoadStates(refresh=" + this.refresh + ", prepend=" + this.prepend + ", append=" + this.append + ')';
    }
}

