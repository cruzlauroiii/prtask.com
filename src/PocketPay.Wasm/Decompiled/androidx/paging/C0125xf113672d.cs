namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PlaceholderPaddedDiffResult;", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0125xf113672d : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult>, java.lang.object> {
    readonly androidx.paging.PagingDataEvent$Refresh<T> $this_apply;
    int label;
    readonly androidx.paging.AsyncPagingDataDiffer<T> this$0;

    C0125xf113672d(androidx.paging.PagingDataEvent$Refresh<T> pagingDataEvent$Refresh, androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer, kotlin.coroutines.Continuation<androidx.paging.C0125xf113672d> continuation) {
        super(2, continuation);
        this.$this_apply = pagingDataEvent$Refresh;
        this.this$0 = asyncPagingDataDiffer;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.C0125xf113672d(this.$this_apply, this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult> continuation) {
        return ((androidx.paging.C0125xf113672d) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return androidx.paging.PlaceholderPaddedListDiffHelperKt.computeDiff(this.$this_apply.getPreviousList(), this.$this_apply.getNewList(), androidx.paging.AsyncPagingDataDiffer.access$getDiffCallback$p(this.this$0));
    }
}

