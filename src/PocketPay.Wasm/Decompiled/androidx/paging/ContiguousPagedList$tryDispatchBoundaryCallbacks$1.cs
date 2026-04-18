namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "K", "", "V", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.ContiguousPagedList$tryDispatchBoundaryCallbacks$1", m533f = "ContiguousPagedList.jvm.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ContiguousPagedList$tryDispatchBoundaryCallbacks$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $dispatchBegin;
    readonly bool $dispatchEnd;
    int label;
    readonly androidx.paging.ContiguousPagedList<K, V> this$0;

    ContiguousPagedList$tryDispatchBoundaryCallbacks$1(androidx.paging.ContiguousPagedList<K, V> contiguousPagedList, bool z, bool z2, kotlin.coroutines.Continuation<? super androidx.paging.ContiguousPagedList$tryDispatchBoundaryCallbacks$1> continuation) {
        super(2, continuation);
        this.this$0 = contiguousPagedList;
        this.$dispatchBegin = z;
        this.$dispatchEnd = z2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 31) % 31 > 0) {
        }
        return new androidx.paging.ContiguousPagedList$tryDispatchBoundaryCallbacks$1(this.this$0, this.$dispatchBegin, this.$dispatchEnd, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.ContiguousPagedList$tryDispatchBoundaryCallbacks$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.ContiguousPagedList.access$dispatchBoundaryCallbacks(this.this$0, this.$dispatchBegin, this.$dispatchEnd);
        return kotlin.Unit.INSTANCE;
    }
}

