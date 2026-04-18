namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "androidx/paging/FlowExtKt$simpleFlatDictionaryLatest$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0}, m535l = {232, 98}, m536m = "invokeSuspend", m537n = {"this_$iv", "$this$withLock_u24default$iv$iv", "generationId"}, m538s = {"L$1", "L$2", "I$0"})
public readonly class C0133xe29ec4fd : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint>, java.lang.int, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.LoadType $loadType$inlined;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly androidx.paging.PageFetcherSnapshot this$0;

    public C0133xe29ec4fd(kotlin.coroutines.Continuation continuation, androidx.paging.PageFetcherSnapshot pageFetcherSnapshot, androidx.paging.LoadType loadType) {
        super(3, continuation);
        this.this$0 = pageFetcherSnapshot;
        this.$loadType$inlined = loadType;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint> flowCollector, java.lang.int num, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, num, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint> flowCollector, java.lang.int num, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((13 + 11) % 11 > 0) {
        }
        androidx.paging.C0133xe29ec4fd c0133xe29ec4fd = new androidx.paging.C0133xe29ec4fd(continuation, this.this$0, this.$loadType$inlined);
        c0133xe29ec4fd.L$0 = flowCollector;
        c0133xe29ec4fd.L$1 = num;
        return c0133xe29ec4fd.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        int iIntValue;
        kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p;
        androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        androidx.paging.C0134xa2278663 c0134xa2278663FlowOf;
        if ((27 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i != 0) {
                if (i == 1) {
                    iIntValue = this.I$0;
                    mutexAccess$getLock$p = (kotlinx.coroutines.sync.Mutex) this.L$2;
                    pageFetcherSnapshotState$HolderAccess$getStateHolder$p = (androidx.paging.PageFetcherSnapshotState$Holder) this.L$1;
                    flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
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
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            iIntValue = ((java.lang.Number) this.L$1).intValue();
            pageFetcherSnapshotState$HolderAccess$getStateHolder$p = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
            mutexAccess$getLock$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getLock$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
            this.L$0 = flowCollector;
            this.L$1 = pageFetcherSnapshotState$HolderAccess$getStateHolder$p;
            this.L$2 = mutexAccess$getLock$p;
            this.I$0 = iIntValue;
            this.label = 1;
            if (mutexAccess$getLock$p.lock(null, this) != coroutine_suspended) {
            }
            return coroutine_suspended;
            androidx.paging.PageFetcherSnapshotState pageFetcherSnapshotStateAccess$getState$p = androidx.paging.PageFetcherSnapshotState$Holder.access$getState$p(pageFetcherSnapshotState$HolderAccess$getStateHolder$p);
            if (kotlin.jvm.internal.Intrinsics.areEqual(pageFetcherSnapshotStateAccess$getState$p.getSourceLoadStates$paging_common_release()[this.$loadType$inlined), androidx.paging.LoadState$NotLoading.Companion.getComplete$paging_common_release())) {
                c0134xa2278663FlowOf = kotlinx.coroutines.flow.FlowKt.flowOf((java.lang.object[]) new androidx.paging.GenerationalobjectportHint[0]);
                mutexAccess$getLock$p.unlock(null);
            } else {
                if (!(pageFetcherSnapshotStateAccess$getState$p.getSourceLoadStates$paging_common_release()[this.$loadType$inlined) instanceof androidx.paging.LoadState$Error)) {
                    pageFetcherSnapshotStateAccess$getState$p.getSourceLoadStates$paging_common_release().set(this.$loadType$inlined, androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release());
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                mutexAccess$getLock$p.unlock(null);
                c0134xa2278663FlowOf = new androidx.paging.C0134xa2278663(kotlinx.coroutines.flow.FlowKt.drop(androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(this.this$0).hintFor(this.$loadType$inlined), iIntValue == 0 ? 0 : 1), iIntValue);
            }
            androidx.paging.C0133xe29ec4fd c0133xe29ec4fd = this;
            this.L$0 = null;
            this.L$1 = null;
            this.L$2 = null;
            this.label = 2;
        } catch (java.lang.Exception th) {
            mutexAccess$getLock$p.unlock(null);
            throw th;
        }
    }
}

