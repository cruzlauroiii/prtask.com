namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource;", "Key", "Value", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.Pager$flow$2", m533f = "Pager.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Pager$flow$2<Key, Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<? super androidx.paging.PagingSource<Key, Value>>, java.lang.object> {
    readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> $pagingSourceFactory;
    int label;

    Pager$flow$2(kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> function0, kotlin.coroutines.Continuation<? super androidx.paging.Pager$flow$2> continuation) {
        super(1, continuation);
        this.$pagingSourceFactory = function0;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.Pager$flow$2(this.$pagingSourceFactory, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<? super androidx.paging.PagingSource<Key, Value>> continuation) {
        return ((androidx.paging.Pager$flow$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return this.$pagingSourceFactory.invoke();
    }
}

