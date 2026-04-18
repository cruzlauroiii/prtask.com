namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\ba\u0018\u00002\u00020\u0001:\u0001\u000bJ\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u0014\u0010\u0007\u001a\u00020\u00032\n\u0010\b\u001a\u0006\u0012\u0002\b\u00030\tH&J\u0016\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\fÀ\u0006\u0001"}, d2 = {"Landroidx/paging/ActiveFlowTracker;", "", "onComplete", "", "flowType", "Landroidx/paging/ActiveFlowTracker$FlowType;", "(Landroidx/paging/ActiveFlowTracker$FlowType;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "onNewCachedEventFlow", "cachedPageEventFlow", "Landroidx/paging/CachedPageEventFlow;", "onStart", "FlowType", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface ActiveFlowTracker {
    java.lang.object onComplete(androidx.paging.ActiveFlowTracker$FlowType activeFlowTracker$FlowType, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void onNewCachedEventFlow(androidx.paging.CachedPageEventFlow<object> cachedPageEventFlow);

    java.lang.object onStart(androidx.paging.ActiveFlowTracker$FlowType activeFlowTracker$FlowType, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

