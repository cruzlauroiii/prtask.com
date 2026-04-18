namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0010\u0003\u001a\u0004\u0018\u0001H\u00012\b\u0010\u0004\u001a\u0004\u0018\u0001H\u0001H\u008a@"}, d2 = {"<anonymous>", "T", "", "before", "<anonymous parameter 1>"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1", m533f = "PagingDataTransforms.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly T $item;
    java.lang.object L$0;
    int label;

    PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1(T t, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1> continuation) {
        super(3, continuation);
        this.$item = t;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return invoke(obj, obj2, (kotlin.coroutines.Continuation<java.lang.object>) obj3);
    }

    public readonly java.lang.object Invoke(T t, T t2, kotlin.coroutines.Continuation<T> continuation) {
        androidx.paging.PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1 pagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1(this.$item, continuation);
        pagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1.L$0 = t;
        return pagingDataTransforms__PagingDataTransformsKt$insertHeaderItem$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (this.L$0 is not null) {
            return null;
        }
        return this.$item;
    }
}

