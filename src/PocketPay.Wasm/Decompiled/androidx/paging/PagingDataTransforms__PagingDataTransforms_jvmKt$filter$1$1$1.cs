namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1", m533f = "PagingDataTransforms.jvm.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<T, java.lang.bool> $predicate;
    java.lang.object L$0;
    int label;

    PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1(kotlin.jvm.functions.Function1<? super T, java.lang.bool> function1, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1> continuation) {
        super(2, continuation);
        this.$predicate = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1 pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1 = new androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1(this.$predicate, continuation);
        pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1.L$0 = obj;
        return pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke2(obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1) create(t, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return this.$predicate.invoke((T) this.L$0);
    }
}

