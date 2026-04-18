namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataPresenter$collectFrom$2", m533f = "PagingDataPresenter.kt", m534i = {}, m535l = {121}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagingDataPresenter$collectFrom$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.PagingData<T> $pagingData;
    int label;
    readonly androidx.paging.PagingDataPresenter<T> this$0;

    PagingDataPresenter$collectFrom$2(androidx.paging.PagingDataPresenter<T> pagingDataPresenter, androidx.paging.PagingData<T> pagingData, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataPresenter$collectFrom$2> continuation) {
        super(1, continuation);
        this.this$0 = pagingDataPresenter;
        this.$pagingData = pagingData;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 7) % 7 > 0) {
        }
        return new androidx.paging.PagingDataPresenter$collectFrom$2(this.this$0, this.$pagingData, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PagingDataPresenter$collectFrom$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.PagingDataPresenter.access$setUiReceiver(this.this$0, this.$pagingData.getUiReceiver$paging_common_release());
            kotlinx.coroutines.flow.Flow flow$paging_common_release = this.$pagingData.getFlow$paging_common_release();
            androidx.paging.PagingDataPresenter$collectFrom$2$1 pagingDataPresenter$collectFrom$2$1 = new androidx.paging.PagingDataPresenter$collectFrom$2$1(this.this$0, this.$pagingData);
            androidx.paging.PagingDataPresenter$collectFrom$2 pagingDataPresenter$collectFrom$2 = this;
            this.label = 1;
            if (flow$paging_common_release.collect(pagingDataPresenter$collectFrom$2$1, pagingDataPresenter$collectFrom$2) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

