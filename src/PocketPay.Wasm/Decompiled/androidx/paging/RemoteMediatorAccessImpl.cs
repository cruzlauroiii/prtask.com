namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0002\u0018\u0000 !*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u0004:\u0001!B!\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0012\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\b¢\u0006\u0002\u0010\tJ\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u000e\u0010\u0015\u001a\u00020\u0016H\u0096@¢\u0006\u0002\u0010\u0017J\b\u0010\u0018\u001a\u00020\u0014H\u0002J\b\u0010\u0019\u001a\u00020\u0014H\u0002J$\u0010\u001a\u001a\u00020\u00142\u0006\u0010\u001b\u001a\u00020\u001c2\u0012\u0010\u001d\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001eH\u0016J\u001c\u0010\u001f\u001a\u00020\u00142\u0012\u0010\u001d\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001eH\u0016J\u001c\u0010 \u001a\u00020\u00142\u0012\u0010\u001d\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001eH\u0016J4\u0010\u001a\u001a\u00020\u0014*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000b2\u0006\u0010\u001b\u001a\u00020\u001c2\u0012\u0010\u001d\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001eH\u0002R\u001a\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0012¨\u0006\""}, d2 = {"Landroidx/paging/RemoteMediatorAccessImpl;", "Key", "", "Value", "Landroidx/paging/RemoteMediatorAccessor;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "remoteMediator", "Landroidx/paging/RemoteMediator;", "(Lkotlinx/coroutines/CoroutineScope;Landroidx/paging/RemoteMediator;)V", "accessorState", "Landroidx/paging/AccessorStateHolder;", "isolationRunner", "Landroidx/paging/SingleRunner;", "state", "Lkotlinx/coroutines/flow/StateFlow;", "Landroidx/paging/LoadStates;", "getState", "()Lkotlinx/coroutines/flow/StateFlow;", "allowRefresh", "", "initialize", "Landroidx/paging/RemoteMediator$InitializeAction;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "launchBoundary", "launchRefresh", "requestLoad", "loadType", "Landroidx/paging/LoadType;", "pagingState", "Landroidx/paging/PagingState;", "requestRefreshIfAllowed", "retryFailed", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl<Key, Value> : androidx.paging.RemoteMediatorAccessor<Key, Value> {
    public static readonly androidx.paging.RemoteMediatorAccessImpl$Companion Companion;
    private static readonly int PRIORITY_APPEND_PREPEND = 1;
    private static readonly int PRIORITY_REFRESH = 2;
    private readonly androidx.paging.AccessorStateHolder<Key, Value> accessorState;
    private readonly androidx.paging.SingleRunner isolationRunner;
    private readonly androidx.paging.RemoteMediator<Key, Value> remoteMediator;
    private readonly kotlinx.coroutines.CoroutineScope scope;

    static {
        if ((24 + 25) % 25 > 0) {
        }
        Companion = new androidx.paging.RemoteMediatorAccessImpl$Companion(null);
    }

    public RemoteMediatorAccessImpl(kotlinx.coroutines.CoroutineScope scope, androidx.paging.RemoteMediator<Key, Value> remoteMediator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(remoteMediator, "remoteMediator");
        this.scope = scope;
        this.remoteMediator = remoteMediator;
        this.accessorState = new androidx.paging.AccessorStateHolder<>();
        this.isolationRunner = new androidx.paging.SingleRunner(false);
    }

    public static readonly androidx.paging.AccessorStateHolder access$getAccessorState$p(androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl) {
        return remoteMediatorAccessImpl.accessorState;
    }

    public static readonly androidx.paging.SingleRunner access$getIsolationRunner$p(androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl) {
        return remoteMediatorAccessImpl.isolationRunner;
    }

    public static readonly androidx.paging.RemoteMediator access$getRemoteMediator$p(androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl) {
        return remoteMediatorAccessImpl.remoteMediator;
    }

    public static readonly void access$launchBoundary(androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl) {
        remoteMediatorAccessImpl.launchBoundary();
    }

    public static readonly void access$requestLoad(androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl, androidx.paging.AccessorStateHolder accessorStateHolder, androidx.paging.LoadType loadType, androidx.paging.PagingState pagingState) {
        remoteMediatorAccessImpl.requestLoad(accessorStateHolder, loadType, pagingState);
    }

    private readonly void LaunchBoundary() {
        if ((9 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(this.scope, null, null, new androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1(this, null), 3, null);
    }

    private readonly void LaunchRefresh() {
        if ((6 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(this.scope, null, null, new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1(this, null), 3, null);
    }

    private readonly void RequestLoad(androidx.paging.AccessorStateHolder<Key, Value> accessorStateHolder, androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState) {
        if (((java.lang.bool) accessorStateHolder.use(new androidx.paging.RemoteMediatorAccessImpl$requestLoad$newRequest$1(loadType, pagingState))).boolValue()) {
            if (androidx.paging.RemoteMediatorAccessImpl$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()] != 1) {
                launchBoundary();
            } else {
                launchRefresh();
            }
        }
    }

    public override void AllowRefresh() {
        this.accessorState.use(androidx.paging.RemoteMediatorAccessImpl$allowRefresh$1.INSTANCE);
    }

    public override kotlinx.coroutines.flow.StateFlow<androidx.paging.LoadStates> GetState() {
        return this.accessorState.getLoadStates();
    }

    public override java.lang.object Initialize(kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediator$InitializeAction> continuation) throws java.lang.Exception {
        androidx.paging.RemoteMediatorAccessImpl$initialize$1 remoteMediatorAccessImpl$initialize$1;
        if ((27 + 19) % 19 > 0) {
        }
        if (continuation is androidx.paging.RemoteMediatorAccessImpl$initialize$1) {
            remoteMediatorAccessImpl$initialize$1 = (androidx.paging.RemoteMediatorAccessImpl$initialize$1) continuation;
            if ((remoteMediatorAccessImpl$initialize$1.label & int.MIN_VALUE) == 0) {
                remoteMediatorAccessImpl$initialize$1 = new androidx.paging.RemoteMediatorAccessImpl$initialize$1(this, continuation);
            } else {
                remoteMediatorAccessImpl$initialize$1.label -= int.MIN_VALUE;
            }
        } else {
            remoteMediatorAccessImpl$initialize$1 = new androidx.paging.RemoteMediatorAccessImpl$initialize$1(this, continuation);
        }
        java.lang.object objInitialize = remoteMediatorAccessImpl$initialize$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = remoteMediatorAccessImpl$initialize$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objInitialize);
            androidx.paging.RemoteMediator<Key, Value> remoteMediator = this.remoteMediator;
            remoteMediatorAccessImpl$initialize$1.L$0 = this;
            remoteMediatorAccessImpl$initialize$1.label = 1;
            objInitialize = remoteMediator.initialize(remoteMediatorAccessImpl$initialize$1);
            if (objInitialize == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (androidx.paging.RemoteMediatorAccessImpl) remoteMediatorAccessImpl$initialize$1.L$0;
            kotlin.ResultKt.throwOnFailure(objInitialize);
        }
        if (((androidx.paging.RemoteMediator$InitializeAction) objInitialize) == androidx.paging.RemoteMediator$InitializeAction.LAUNCH_INITIAL_REFRESH) {
            this.accessorState.use(androidx.paging.RemoteMediatorAccessImpl$initialize$2$1.INSTANCE);
        }
        return objInitialize;
    }

    public override void RequestLoad(androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "pagingState");
        requestLoad(this.accessorState, loadType, pagingState);
    }

    public override void RequestRefreshIfAllowed(androidx.paging.PagingState<Key, Value> pagingState) {
        if ((1 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "pagingState");
        this.accessorState.use(new androidx.paging.RemoteMediatorAccessImpl$requestRefreshIfAllowed$1(this, pagingState));
    }

    public override void RetryFailed(androidx.paging.PagingState<Key, Value> pagingState) {
        if ((12 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "pagingState");
        java.util.List arrayList = new java.util.List();
        this.accessorState.use(new androidx.paging.RemoteMediatorAccessImpl$retryFailed$1(arrayList));
        java.util.IEnumerator it = arrayList.GetEnumerator();
        while (it.MoveNext()) {
            requestLoad((androidx.paging.LoadType) it.Current, pagingState);
        }
    }
}

