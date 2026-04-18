namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Landroidx/paging/SimpleProducerScope;", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$pageEventFlow$1", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0, 0, 1, 2, 2, 2}, m535l = {646, 168, 657}, m536m = "invokeSuspend", m537n = {"$this$cancelableChannelFlow", "it", "this_$iv", "$this$withLock_u24default$iv$iv", "$this$cancelableChannelFlow", "$this$cancelableChannelFlow", "this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$0", "L$0", "L$1", "L$2"})
readonly class PageFetcherSnapshot$pageEventFlow$1<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$pageEventFlow$1(androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshot$pageEventFlow$1> continuation) {
        super(2, continuation);
        this.this$0 = pageFetcherSnapshot;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.PageFetcherSnapshot$pageEventFlow$1 pageFetcherSnapshot$pageEventFlow$1 = new androidx.paging.PageFetcherSnapshot$pageEventFlow$1(this.this$0, continuation);
        pageFetcherSnapshot$pageEventFlow$1.L$0 = obj;
        return pageFetcherSnapshot$pageEventFlow$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcherSnapshot$pageEventFlow$1) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.SimpleProducerScope simpleProducerScope;
        androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$Holder;
        androidx.paging.SimpleProducerScope simpleProducerScope2;
        kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p;
        kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p2;
        androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$Holder2;
        androidx.paging.RemoteMediatorConnection remoteMediatorConnection;
        androidx.paging.SimpleProducerScope simpleProducerScope3;
        androidx.paging.PagingState pagingStateAccess$getPreviousPagingState$p;
        androidx.paging.LoadState loadState;
        androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
        androidx.paging.PageFetcherSnapshot$pageEventFlow$1<Value> pageFetcherSnapshot$pageEventFlow$1;
        androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot;
        androidx.paging.PageFetcherSnapshot$pageEventFlow$1<Value> pageFetcherSnapshot$pageEventFlow$12;
        if ((13 + 7) % 7 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i != 0) {
                if (i == 1) {
                    mutexAccess$getLock$p2 = (kotlinx.coroutines.sync.Mutex) this.L$3;
                    pageFetcherSnapshotState$Holder2 = (androidx.paging.PageFetcherSnapshotState$Holder) this.L$2;
                    remoteMediatorConnection = (androidx.paging.RemoteMediatorConnection) this.L$1;
                    simpleProducerScope3 = (androidx.paging.SimpleProducerScope) this.L$0;
                    kotlin.ResultKt.throwOnFailure(obj);
                } else {
                    if (i == 2) {
                        simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
                        kotlin.ResultKt.throwOnFailure(obj);
                        pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
                        mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
                        pageFetcherSnapshot$pageEventFlow$1 = this;
                        this.L$0 = simpleProducerScope;
                        this.L$1 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                        this.L$2 = mutexAccess$getLock$p;
                        this.label = 3;
                        if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshot$pageEventFlow$1) != coroutine_suspended) {
                            simpleProducerScope2 = simpleProducerScope;
                            pageFetcherSnapshotState$Holder = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                        }
                        return coroutine_suspended;
                    }
                    if (i != 3) {
                        throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                    }
                    kotlinx.coroutines.sync.Mutex mutex = (kotlinx.coroutines.sync.Mutex) this.L$2;
                    pageFetcherSnapshotState$Holder = (androidx.paging.PageFetcherSnapshotState$Holder) this.L$1;
                    simpleProducerScope2 = (androidx.paging.SimpleProducerScope) this.L$0;
                    kotlin.ResultKt.throwOnFailure(obj);
                    mutexAccess$getLock$p = mutex;
                }
                loadState = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$Holder).getSourceLoadStates$paging_common_release()[androidx.paging.LoadType.REFRESH);
                mutexAccess$getLock$p.unlock(null);
                if (!(loadState is androidx.paging.LoadState$Error)) {
                    androidx.paging.PageFetcherSnapshot.access$startConsumingHints(this.this$0, simpleProducerScope2);
                }
                return kotlin.Unit.INSTANCE;
            }
            kotlin.ResultKt.throwOnFailure(obj);
            simpleProducerScope3 = (androidx.paging.SimpleProducerScope) this.L$0;
            if (!androidx.paging.PageFetcherSnapshot.access$getPageEventChCollected$p(this.this$0).compareAndHashSet(false, true)) {
                throw new java.lang.IllegalStateException("Attempt to collect twice from pageEventFlow, which is an illegal operation. Did you forget to call Flow<PagingData<*>>.cachedIn(coroutineScope)?".tostring());
            }
            androidx.paging.SimpleProducerScope simpleProducerScope4 = simpleProducerScope3;
            kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope4, null, null, new androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2(this.this$0, simpleProducerScope3, null), 3, null);
            kotlinx.coroutines.channels.Channel channelChannel$default = kotlinx.coroutines.channels.ChannelKt.Channel$default(0, null, null, 6, null);
            kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope4, null, null, new androidx.paging.PageFetcherSnapshot$pageEventFlow$1$3(this.this$0, channelChannel$default, null), 3, null);
            kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope4, null, null, new androidx.paging.PageFetcherSnapshot$pageEventFlow$1$4(channelChannel$default, this.this$0, null), 3, null);
            remoteMediatorConnection = this.this$0.getRemoteMediatorConnection();
            if (remoteMediatorConnection is not null) {
                androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot2 = this.this$0;
                pagingStateAccess$getPreviousPagingState$p = androidx.paging.PageFetcherSnapshot.access$getPreviousPagingState$p(pageFetcherSnapshot2);
                if (pagingStateAccess$getPreviousPagingState$p is not null) {
                    remoteMediatorConnection.requestRefreshIfAllowed(pagingStateAccess$getPreviousPagingState$p);
                    pageFetcherSnapshot = this.this$0;
                    pageFetcherSnapshot$pageEventFlow$12 = this;
                    this.L$0 = simpleProducerScope3;
                    this.L$1 = null;
                    this.L$2 = null;
                    this.L$3 = null;
                    this.label = 2;
                    if (androidx.paging.PageFetcherSnapshot.access$doInitialLoad(pageFetcherSnapshot, pageFetcherSnapshot$pageEventFlow$12) != coroutine_suspended) {
                        simpleProducerScope = simpleProducerScope3;
                        pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
                        mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
                        pageFetcherSnapshot$pageEventFlow$1 = this;
                        this.L$0 = simpleProducerScope;
                        this.L$1 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                        this.L$2 = mutexAccess$getLock$p;
                        this.label = 3;
                        if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshot$pageEventFlow$1) != coroutine_suspended) {
                            simpleProducerScope2 = simpleProducerScope;
                            pageFetcherSnapshotState$Holder = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                            try {
                                loadState = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$Holder).getSourceLoadStates$paging_common_release()[androidx.paging.LoadType.REFRESH);
                                mutexAccess$getLock$p.unlock(null);
                                if (!(loadState is androidx.paging.LoadState$Error)) {
                                    androidx.paging.PageFetcherSnapshot.access$startConsumingHints(this.this$0, simpleProducerScope2);
                                }
                                return kotlin.Unit.INSTANCE;
                            } catch (java.lang.Exception th) {
                                mutexAccess$getLock$p.unlock(null);
                                throw th;
                            }
                        }
                    }
                } else {
                    androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$HolderAccess$getStateHolder$p2 = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(pageFetcherSnapshot2);
                    mutexAccess$getLock$p2 = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p2);
                    this.L$0 = simpleProducerScope3;
                    this.L$1 = remoteMediatorConnection;
                    this.L$2 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p2;
                    this.L$3 = mutexAccess$getLock$p2;
                    this.label = 1;
                    if (mutexAccess$getLock$p2.lock(null, this) != coroutine_suspended) {
                        pageFetcherSnapshotState$Holder2 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p2;
                    }
                }
            } else {
                pageFetcherSnapshot = this.this$0;
                pageFetcherSnapshot$pageEventFlow$12 = this;
                this.L$0 = simpleProducerScope3;
                this.L$1 = null;
                this.L$2 = null;
                this.L$3 = null;
                this.label = 2;
                if (androidx.paging.PageFetcherSnapshot.access$doInitialLoad(pageFetcherSnapshot, pageFetcherSnapshot$pageEventFlow$12) != coroutine_suspended) {
                    simpleProducerScope = simpleProducerScope3;
                    pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
                    mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
                    pageFetcherSnapshot$pageEventFlow$1 = this;
                    this.L$0 = simpleProducerScope;
                    this.L$1 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                    this.L$2 = mutexAccess$getLock$p;
                    this.label = 3;
                    if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshot$pageEventFlow$1) != coroutine_suspended) {
                        simpleProducerScope2 = simpleProducerScope;
                        pageFetcherSnapshotState$Holder = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                        loadState = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$Holder).getSourceLoadStates$paging_common_release()[androidx.paging.LoadType.REFRESH);
                        mutexAccess$getLock$p.unlock(null);
                        if (!(loadState is androidx.paging.LoadState$Error)) {
                            androidx.paging.PageFetcherSnapshot.access$startConsumingHints(this.this$0, simpleProducerScope2);
                        }
                        return kotlin.Unit.INSTANCE;
                    }
                }
            }
            return coroutine_suspended;
            androidx.paging.PagingState pagingStateCurrentPagingState$paging_common_release = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$Holder2).currentPagingState$paging_common_release(null);
            mutexAccess$getLock$p2.unlock(null);
            pagingStateAccess$getPreviousPagingState$p = pagingStateCurrentPagingState$paging_common_release;
            remoteMediatorConnection.requestRefreshIfAllowed(pagingStateAccess$getPreviousPagingState$p);
            pageFetcherSnapshot = this.this$0;
            pageFetcherSnapshot$pageEventFlow$12 = this;
            this.L$0 = simpleProducerScope3;
            this.L$1 = null;
            this.L$2 = null;
            this.L$3 = null;
            this.label = 2;
            if (androidx.paging.PageFetcherSnapshot.access$doInitialLoad(pageFetcherSnapshot, pageFetcherSnapshot$pageEventFlow$12) != coroutine_suspended) {
                simpleProducerScope = simpleProducerScope3;
                pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
                mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
                pageFetcherSnapshot$pageEventFlow$1 = this;
                this.L$0 = simpleProducerScope;
                this.L$1 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                this.L$2 = mutexAccess$getLock$p;
                this.label = 3;
                if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshot$pageEventFlow$1) != coroutine_suspended) {
                    simpleProducerScope2 = simpleProducerScope;
                    pageFetcherSnapshotState$Holder = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
                    loadState = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$Holder).getSourceLoadStates$paging_common_release()[androidx.paging.LoadType.REFRESH);
                    mutexAccess$getLock$p.unlock(null);
                    if (!(loadState is androidx.paging.LoadState$Error)) {
                        androidx.paging.PageFetcherSnapshot.access$startConsumingHints(this.this$0, simpleProducerScope2);
                    }
                    return kotlin.Unit.INSTANCE;
                }
            }
            return coroutine_suspended;
        } catch (java.lang.Exception th2) {
            mutexAccess$getLock$p2.unlock(null);
            throw th2;
        }
    }
}

