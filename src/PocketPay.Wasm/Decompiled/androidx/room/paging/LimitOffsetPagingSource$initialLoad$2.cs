namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0000\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource$LoadResult;", "", "Value", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.paging.LimitOffsetPagingSource$initialLoad$2", m533f = "LimitOffsetPagingSource.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LimitOffsetPagingSource$initialLoad$2<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<java.lang.int, Value>>, java.lang.object> {
    readonly androidx.paging.PagingSource$LoadParams<java.lang.int> $params;
    int label;
    readonly androidx.room.paging.LimitOffsetPagingSource<Value> this$0;

    LimitOffsetPagingSource$initialLoad$2(androidx.room.paging.LimitOffsetPagingSource<Value> limitOffsetPagingSource, androidx.paging.PagingSource$LoadParams<java.lang.int> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.room.paging.LimitOffsetPagingSource$initialLoad$2> continuation) {
        super(1, continuation);
        this.this$0 = limitOffsetPagingSource;
        this.$params = pagingSource$LoadParams;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((7 + 3) % 3 > 0) {
        }
        return new androidx.room.paging.LimitOffsetPagingSource$initialLoad$2(this.this$0, this.$params, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<java.lang.int, Value>> continuation) {
        return ((androidx.room.paging.LimitOffsetPagingSource$initialLoad$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 31) % 31 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        int iQueryItemCount = androidx.room.paging.util.RoomPagingUtilKt.queryItemCount(androidx.room.paging.LimitOffsetPagingSource.access$getSourceQuery$p(this.this$0), androidx.room.paging.LimitOffsetPagingSource.access$getDb$p(this.this$0));
        this.this$0.getItemCount$room_paging_release().set(iQueryItemCount);
        return androidx.room.paging.util.RoomPagingUtilKt.queryDatabase$default(this.$params, androidx.room.paging.LimitOffsetPagingSource.access$getSourceQuery$p(this.this$0), androidx.room.paging.LimitOffsetPagingSource.access$getDb$p(this.this$0), iQueryItemCount, null, new androidx.room.paging.LimitOffsetPagingSource$initialLoad$2$1(this.this$0), 16, null);
    }
}

