namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b'\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002:\u0002\u000f\u0010B\u0005¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0006H\u0096@¢\u0006\u0002\u0010\u0007J*\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\rH¦@¢\u0006\u0002\u0010\u000e¨\u0006\u0011"}, d2 = {"Landroidx/paging/RemoteMediator;", "Key", "", "Value", "()V", "initialize", "Landroidx/paging/RemoteMediator$InitializeAction;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "load", "Landroidx/paging/RemoteMediator$MediatorResult;", "loadType", "Landroidx/paging/LoadType;", "state", "Landroidx/paging/PagingState;", "(Landroidx/paging/LoadType;Landroidx/paging/PagingState;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "InitializeAction", "MediatorResult", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class RemoteMediator<Key, Value> {
    static <Key, Value> java.lang.object initialize$suspendImpl(androidx.paging.RemoteMediator<Key, Value> remoteMediator, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediator$InitializeAction> continuation) {
        return androidx.paging.RemoteMediator$InitializeAction.LAUNCH_INITIAL_REFRESH;
    }

    public java.lang.object Initialize(kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediator$InitializeAction> continuation) {
        return initialize$suspendImpl(this, continuation);
    }

    public abstract java.lang.object Load(androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediator$MediatorResult> continuation);
}

