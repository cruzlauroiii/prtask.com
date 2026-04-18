namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1", m533f = "RemoteMediatorAccessor.kt", m534i = {}, m535l = {321}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteMediatorAccessImpl$launchRefresh$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.internal.Ref$boolRef $launchAppendPrepend;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly androidx.paging.RemoteMediatorAccessImpl<Key, Value> this$0;

    RemoteMediatorAccessImpl$launchRefresh$1$1(androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl, kotlin.jvm.internal.Ref$boolRef ref$boolRef, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1> continuation) {
        super(1, continuation);
        this.this$0 = remoteMediatorAccessImpl;
        this.$launchAppendPrepend = ref$boolRef;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 11) % 11 > 0) {
        }
        return new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1(this.this$0, this.$launchAppendPrepend, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl;
        kotlin.jvm.internal.Ref$boolRef ref$boolRef;
        bool zboolValue;
        if ((18 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.PagingState pagingState = (androidx.paging.PagingState) androidx.paging.RemoteMediatorAccessImpl.access$getAccessorState$p(this.this$0).use(androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1$pendingPagingState$1.INSTANCE);
            if (pagingState is not null) {
                androidx.paging.RemoteMediatorAccessImpl remoteMediatorAccessImpl2 = this.this$0;
                kotlin.jvm.internal.Ref$boolRef ref$boolRef2 = this.$launchAppendPrepend;
                androidx.paging.RemoteMediator remoteMediatorAccess$getRemoteMediator$p = androidx.paging.RemoteMediatorAccessImpl.access$getRemoteMediator$p(remoteMediatorAccessImpl2);
                androidx.paging.LoadType loadType = androidx.paging.LoadType.REFRESH;
                this.L$0 = remoteMediatorAccessImpl2;
                this.L$1 = ref$boolRef2;
                this.label = 1;
                obj = remoteMediatorAccess$getRemoteMediator$p.load(loadType, pagingState, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
                remoteMediatorAccessImpl = remoteMediatorAccessImpl2;
                ref$boolRef = ref$boolRef2;
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        ref$boolRef = (kotlin.jvm.internal.Ref$boolRef) this.L$1;
        remoteMediatorAccessImpl = (androidx.paging.RemoteMediatorAccessImpl) this.L$0;
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.RemoteMediator$MediatorResult remoteMediator$MediatorResult = (androidx.paging.RemoteMediator$MediatorResult) obj;
        if (remoteMediator$MediatorResult is androidx.paging.RemoteMediator$MediatorResult$Success) {
            zboolValue = ((java.lang.bool) androidx.paging.RemoteMediatorAccessImpl.access$getAccessorState$p(remoteMediatorAccessImpl).use(new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1$1$1(remoteMediator$MediatorResult))).boolValue();
        } else {
            if (!(remoteMediator$MediatorResult is androidx.paging.RemoteMediator$MediatorResult$Error)) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            zboolValue = ((java.lang.bool) androidx.paging.RemoteMediatorAccessImpl.access$getAccessorState$p(remoteMediatorAccessImpl).use(new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1$1$2(remoteMediator$MediatorResult))).boolValue();
        }
        ref$boolRef.element = zboolValue;
        return kotlin.Unit.INSTANCE;
    }
}

