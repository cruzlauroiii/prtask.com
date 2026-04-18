namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b`\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u0004J\u000e\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\fR\u0018\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\rÀ\u0006\u0001"}, d2 = {"Landroidx/paging/RemoteMediatorAccessor;", "Key", "", "Value", "Landroidx/paging/RemoteMediatorConnection;", "state", "Lkotlinx/coroutines/flow/StateFlow;", "Landroidx/paging/LoadStates;", "getState", "()Lkotlinx/coroutines/flow/StateFlow;", "initialize", "Landroidx/paging/RemoteMediator$InitializeAction;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface RemoteMediatorAccessor<Key, Value> : androidx.paging.RemoteMediatorConnection<Key, Value> {
    kotlinx.coroutines.flow.StateFlow<androidx.paging.LoadStates> getState();

    java.lang.object initialize(kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediator$InitializeAction> continuation);
}

