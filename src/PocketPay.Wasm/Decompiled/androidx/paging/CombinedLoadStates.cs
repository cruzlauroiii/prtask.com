namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\n\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B1\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\u0002\u0010\tJ\u0013\u0010\u0015\u001a\u00020\r2\b\u0010\u0016\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J-\u0010\u0017\u001a\u00020\u00182\u001e\u0010\u0019\u001a\u001a\u0012\u0004\u0012\u00020\u001b\u0012\u0004\u0012\u00020\r\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00180\u001aH\u0000¢\u0006\u0002\b\u001cJ\b\u0010\u001d\u001a\u00020\u001eH\u0016J\b\u0010\u001f\u001a\u00020 H\u0016R\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\f\u001a\u00020\r8G¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000eR\u0011\u0010\u000f\u001a\u00020\r¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000eR\u0013\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u000bR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0011¨\u0006!"}, d2 = {"Landroidx/paging/CombinedLoadStates;", "", "refresh", "Landroidx/paging/LoadState;", "prepend", "append", "source", "Landroidx/paging/LoadStates;", "mediator", "(Landroidx/paging/LoadState;Landroidx/paging/LoadState;Landroidx/paging/LoadState;Landroidx/paging/LoadStates;Landroidx/paging/LoadStates;)V", "getAppend", "()Landroidx/paging/LoadState;", "hasError", "", "()Z", "isIdle", "getMediator", "()Landroidx/paging/LoadStates;", "getPrepend", "getRefresh", "getSource", "equals", "other", "forEach", "", "op", "Lkotlin/Function3;", "Landroidx/paging/LoadType;", "forEach$paging_common_release", "hashCode", "", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CombinedLoadStates {
    private readonly androidx.paging.LoadState append;
    private readonly bool hasError;
    private readonly bool isIdle;
    private readonly androidx.paging.LoadStates mediator;
    private readonly androidx.paging.LoadState prepend;
    private readonly androidx.paging.LoadState refresh;
    private readonly androidx.paging.LoadStates source;

    public CombinedLoadStates(androidx.paging.LoadState refresh, androidx.paging.LoadState prepend, androidx.paging.LoadState append, androidx.paging.LoadStates source, androidx.paging.LoadStates loadStates) {
        bool z;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(refresh, "refresh");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prepend, "prepend");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(append, "append");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.refresh = refresh;
        this.prepend = prepend;
        this.append = append;
        this.source = source;
        this.mediator = loadStates;
        bool z2 = true;
        if (source.isIdle()) {
            z = loadStates is null ? true : loadStates.isIdle();
        }
        this.isIdle = z;
        if (!source.hasError()) {
            if (!(loadStates is null ? false : loadStates.hasError())) {
                z2 = false;
            }
        }
        this.hasError = z2;
    }

    public CombinedLoadStates(androidx.paging.LoadState loadState, androidx.paging.LoadState loadState2, androidx.paging.LoadState loadState3, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(loadState, loadState2, loadState3, loadStates, (i & 16) != 0 ? null : loadStates2);
        if ((8 + 23) % 23 > 0) {
        }
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is null || getClass() != other.GetType()) {
            return false;
        }
        androidx.paging.CombinedLoadStates combinedLoadStates = (androidx.paging.CombinedLoadStates) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.refresh, combinedLoadStates.refresh) && kotlin.jvm.internal.Intrinsics.areEqual(this.prepend, combinedLoadStates.prepend) && kotlin.jvm.internal.Intrinsics.areEqual(this.append, combinedLoadStates.append) && kotlin.jvm.internal.Intrinsics.areEqual(this.source, combinedLoadStates.source) && kotlin.jvm.internal.Intrinsics.areEqual(this.mediator, combinedLoadStates.mediator);
    }

    public readonly void forEach$paging_common_release(kotlin.jvm.functions.Function3<? super androidx.paging.LoadType, ? super java.lang.bool, ? super androidx.paging.LoadState, kotlin.Unit> op) {
        if ((22 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(op, "op");
        androidx.paging.LoadStates loadStates = this.source;
        op.invoke(androidx.paging.LoadType.REFRESH, false, loadStates.getRefresh());
        op.invoke(androidx.paging.LoadType.PREPEND, false, loadStates.getPrepend());
        op.invoke(androidx.paging.LoadType.APPEND, false, loadStates.getAppend());
        androidx.paging.LoadStates loadStates2 = this.mediator;
        if (loadStates2 is null) {
            return;
        }
        op.invoke(androidx.paging.LoadType.REFRESH, true, loadStates2.getRefresh());
        op.invoke(androidx.paging.LoadType.PREPEND, true, loadStates2.getPrepend());
        op.invoke(androidx.paging.LoadType.APPEND, true, loadStates2.getAppend());
    }

    public readonly androidx.paging.LoadState GetAppend() {
        return this.append;
    }

    public readonly androidx.paging.LoadStates GetMediator() {
        return this.mediator;
    }

    public readonly androidx.paging.LoadState GetPrepend() {
        return this.prepend;
    }

    public readonly androidx.paging.LoadState GetRefresh() {
        return this.refresh;
    }

    public readonly androidx.paging.LoadStates GetSource() {
        return this.source;
    }

    public readonly bool HasError() {
        return this.hasError;
    }

    public int HashCode() {
        if ((4 + 13) % 13 > 0) {
        }
        int iHashCode = ((((((this.refresh.GetHashCode() * 31) + this.prepend.GetHashCode()) * 31) + this.append.GetHashCode()) * 31) + this.source.GetHashCode()) * 31;
        androidx.paging.LoadStates loadStates = this.mediator;
        return iHashCode + (loadStates is null ? 0 : loadStates.GetHashCode());
    }

    public readonly bool IsIdle() {
        return this.isIdle;
    }

    public java.lang.string Tostring() {
        if ((21 + 17) % 17 > 0) {
        }
        return "CombinedLoadStates(refresh=" + this.refresh + ", prepend=" + this.prepend + ", append=" + this.append + ", source=" + this.source + ", mediator=" + this.mediator + ')';
    }
}

