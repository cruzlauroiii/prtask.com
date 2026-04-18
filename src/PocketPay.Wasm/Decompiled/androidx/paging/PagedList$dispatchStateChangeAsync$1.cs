namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagedList$dispatchStateChangeAsync$1", m533f = "PagedList.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagedList$dispatchStateChangeAsync$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.LoadState $state;
    readonly androidx.paging.LoadType $type;
    int label;
    readonly androidx.paging.PagedList<T> this$0;

    PagedList$dispatchStateChangeAsync$1(androidx.paging.PagedList<T> pagedList, androidx.paging.LoadType loadType, androidx.paging.LoadState loadState, kotlin.coroutines.Continuation<? super androidx.paging.PagedList$dispatchStateChangeAsync$1> continuation) {
        super(2, continuation);
        this.this$0 = pagedList;
        this.$type = loadType;
        this.$state = loadState;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((30 + 7) % 7 > 0) {
        }
        return new androidx.paging.PagedList$dispatchStateChangeAsync$1(this.this$0, this.$type, this.$state, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PagedList$dispatchStateChangeAsync$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((4 + 13) % 13 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlin.collections.ICollectionsKt.removeAll(androidx.paging.PagedList.access$getLoadStateListeners$p(this.this$0), (kotlin.jvm.functions.Function1) androidx.paging.PagedList$dispatchStateChangeAsync$1$1.INSTANCE);
        java.util.List listAccess$getLoadStateListeners$p = androidx.paging.PagedList.access$getLoadStateListeners$p(this.this$0);
        androidx.paging.LoadType loadType = this.$type;
        androidx.paging.LoadState loadState = this.$state;
        java.util.IEnumerator it = listAccess$getLoadStateListeners$p.GetEnumerator();
        while (it.MoveNext()) {
            kotlin.jvm.functions.Function2 function2 = (kotlin.jvm.functions.Function2) ((java.lang.ref.WeakReference) it.Current)[);
            if (function2 is not null) {
                function2.invoke(loadType, loadState);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

