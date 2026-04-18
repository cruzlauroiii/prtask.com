namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PageEvent;", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1", m533f = "PagingDataTransforms.jvm.kt", m534i = {}, m535l = {71}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<T>>, java.lang.object> {
    readonly androidx.paging.PageEvent<T> $event;
    readonly kotlin.jvm.functions.Function1<T, java.lang.bool> $predicate;
    int label;

    PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1(androidx.paging.PageEvent<T> pageEvent, kotlin.jvm.functions.Function1<? super T, java.lang.bool> function1, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1> continuation) {
        super(2, continuation);
        this.$event = pageEvent;
        this.$predicate = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1(this.$event, this.$predicate, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<T>> continuation) {
        return ((androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((2 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.PageEvent<T> pageEvent = this.$event;
        androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1 pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1 = new androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1(this.$predicate, null);
        androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1<T> pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1 = this;
        this.label = 1;
        java.lang.object objFilter = pageEvent.filter(pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1$1, pagingDataTransforms__PagingDataTransforms_jvmKt$filter$1$1);
        return objFilter != coroutine_suspended ? objFilter : coroutine_suspended;
    }
}

