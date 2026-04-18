namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$startConsumingHints$2", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0}, m535l = {646, 233}, m536m = "invokeSuspend", m537n = {"this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1"})
readonly class PageFetcherSnapshot$startConsumingHints$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$startConsumingHints$2(androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshot$startConsumingHints$2> continuation) {
        super(2, continuation);
        this.this$0 = pageFetcherSnapshot;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.PageFetcherSnapshot$startConsumingHints$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcherSnapshot$startConsumingHints$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.PageFetcherSnapshot pageFetcherSnapshot;
        androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
        kotlinx.coroutines.sync.Mutex mutex;
        if ((22 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i != 0) {
                if (i == 1) {
                    pageFetcherSnapshot = (androidx.paging.PageFetcherSnapshot) this.L$2;
                    mutex = (kotlinx.coroutines.sync.Mutex) this.L$1;
                    pageFetcherSnapshotState$HolderAccess$getStateHolder$p = (androidx.paging.PageFetcherSnapshotState$Holder) this.L$0;
                    kotlin.ResultKt.throwOnFailure(obj);
                } else {
                    if (i != 2) {
                        throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                    }
                    kotlin.ResultKt.throwOnFailure(obj);
                }
                return kotlin.Unit.INSTANCE;
            }
            kotlin.ResultKt.throwOnFailure(obj);
            pageFetcherSnapshot = this.this$0;
            pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(pageFetcherSnapshot);
            kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
            androidx.paging.PageFetcherSnapshot$startConsumingHints$2 pageFetcherSnapshot$startConsumingHints$2 = this;
            this.L$0 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
            this.L$1 = mutexAccess$getLock$p;
            this.L$2 = pageFetcherSnapshot;
            this.label = 1;
            if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshot$startConsumingHints$2) != coroutine_suspended) {
                mutex = mutexAccess$getLock$p;
            }
            return coroutine_suspended;
            kotlinx.coroutines.flow.Flow<java.lang.int> flowConsumePrependGenerationIdAsFlow = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p).consumePrependGenerationIdAsFlow();
            mutex.unlock(null);
            androidx.paging.LoadType loadType = androidx.paging.LoadType.PREPEND;
            androidx.paging.PageFetcherSnapshot$startConsumingHints$2 pageFetcherSnapshot$startConsumingHints$22 = this;
            this.L$0 = null;
            this.L$1 = null;
            this.L$2 = null;
            this.label = 2;
        } catch (java.lang.Exception th) {
            mutex.unlock(null);
            throw th;
        }
    }
}

