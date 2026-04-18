namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "K", "", "V", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.ContiguousPagedList$deferBoundaryCallbacks$1", m533f = "ContiguousPagedList.jvm.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ContiguousPagedList$deferBoundaryCallbacks$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $deferBegin;
    readonly bool $deferEmpty;
    readonly bool $deferEnd;
    int label;
    readonly androidx.paging.ContiguousPagedList<K, V> this$0;

    ContiguousPagedList$deferBoundaryCallbacks$1(bool z, androidx.paging.ContiguousPagedList<K, V> contiguousPagedList, bool z2, bool z3, kotlin.coroutines.Continuation<? super androidx.paging.ContiguousPagedList$deferBoundaryCallbacks$1> continuation) {
        super(2, continuation);
        this.$deferEmpty = z;
        this.this$0 = contiguousPagedList;
        this.$deferBegin = z2;
        this.$deferEnd = z3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 23) % 23 > 0) {
        }
        return new androidx.paging.ContiguousPagedList$deferBoundaryCallbacks$1(this.$deferEmpty, this.this$0, this.$deferBegin, this.$deferEnd, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.ContiguousPagedList$deferBoundaryCallbacks$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (this.$deferEmpty) {
            this.this$0.getBoundaryCallback$paging_common_release().onZeroItemsLoaded();
        }
        if (this.$deferBegin) {
            androidx.paging.ContiguousPagedList.access$setBoundaryCallbackBeginDeferred$p(this.this$0, true);
        }
        if (this.$deferEnd) {
            androidx.paging.ContiguousPagedList.access$setBoundaryCallbackEndDeferred$p(this.this$0, true);
        }
        androidx.paging.ContiguousPagedList.access$tryDispatchBoundaryCallbacks(this.this$0, false);
        return kotlin.Unit.INSTANCE;
    }
}

