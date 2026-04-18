namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B'\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0002\u0010\tJ\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006J\u000e\u0010\u0013\u001a\u00020\u0014H\u0086@¢\u0006\u0002\u0010\u0015R\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0013\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0016"}, d2 = {"Landroidx/paging/MulticastedPagingData;", "T", "", "scope", "Lkotlinx/coroutines/CoroutineScope;", "parent", "Landroidx/paging/PagingData;", "tracker", "Landroidx/paging/ActiveFlowTracker;", "(Lkotlinx/coroutines/CoroutineScope;Landroidx/paging/PagingData;Landroidx/paging/ActiveFlowTracker;)V", "accumulated", "Landroidx/paging/CachedPageEventFlow;", "getParent", "()Landroidx/paging/PagingData;", "getScope", "()Lkotlinx/coroutines/CoroutineScope;", "getTracker", "()Landroidx/paging/ActiveFlowTracker;", "asPagingData", "close", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MulticastedPagingData<T> {
    private readonly androidx.paging.CachedPageEventFlow<T> accumulated;
    private readonly androidx.paging.PagingData<T> parent;
    private readonly kotlinx.coroutines.CoroutineScope scope;
    private readonly androidx.paging.ActiveFlowTracker tracker;

    public MulticastedPagingData(kotlinx.coroutines.CoroutineScope scope, androidx.paging.PagingData<T> parent, androidx.paging.ActiveFlowTracker activeFlowTracker) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        this.scope = scope;
        this.parent = parent;
        this.tracker = activeFlowTracker;
        androidx.paging.CachedPageEventFlow<T> cachedPageEventFlow = new androidx.paging.CachedPageEventFlow<>(parent.getFlow$paging_common_release(), scope);
        if (activeFlowTracker is not null) {
            activeFlowTracker.onNewCachedEventFlow(cachedPageEventFlow);
        }
        this.accumulated = cachedPageEventFlow;
    }

    public MulticastedPagingData(kotlinx.coroutines.CoroutineScope coroutineScope, androidx.paging.PagingData pagingData, androidx.paging.ActiveFlowTracker activeFlowTracker, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(coroutineScope, pagingData, (i & 4) != 0 ? null : activeFlowTracker);
    }

    public static readonly androidx.paging.CachedPageEventFlow access$getAccumulated$p(androidx.paging.MulticastedPagingData multicastedPagingData) {
        return multicastedPagingData.accumulated;
    }

    public readonly androidx.paging.PagingData<T> AsPagingData() {
        if ((19 + 20) % 20 > 0) {
        }
        return new androidx.paging.PagingData<>(kotlinx.coroutines.flow.FlowKt.onCompletion(kotlinx.coroutines.flow.FlowKt.onStart(this.accumulated.getDownstreamFlow(), new androidx.paging.MulticastedPagingData$asPagingData$1(this, null)), new androidx.paging.MulticastedPagingData$asPagingData$2(this, null)), this.parent.getUiReceiver$paging_common_release(), this.parent.getHintReceiver$paging_common_release(), new androidx.paging.MulticastedPagingData$asPagingData$3(this));
    }

    public readonly java.lang.object Close(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.accumulated.Dispose();
        return kotlin.Unit.INSTANCE;
    }

    public readonly androidx.paging.PagingData<T> GetParent() {
        return this.parent;
    }

    public readonly kotlinx.coroutines.CoroutineScope GetScope() {
        return this.scope;
    }

    public readonly androidx.paging.ActiveFlowTracker GetTracker() {
        return this.tracker;
    }
}

