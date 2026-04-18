namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "isGettingItem"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$loadStateFlow$1$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class AsyncPagingDataDiffer$loadStateFlow$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.bool, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    bool Z$0;
    int label;

    AsyncPagingDataDiffer$loadStateFlow$1$1(kotlin.coroutines.Continuation<? super androidx.paging.AsyncPagingDataDiffer$loadStateFlow$1$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.AsyncPagingDataDiffer$loadStateFlow$1$1 asyncPagingDataDiffer$loadStateFlow$1$1 = new androidx.paging.AsyncPagingDataDiffer$loadStateFlow$1$1(continuation);
        asyncPagingDataDiffer$loadStateFlow$1$1.Z$0 = ((java.lang.bool) obj).boolValue();
        return asyncPagingDataDiffer$loadStateFlow$1$1;
    }

    public override java.lang.object Invoke(java.lang.bool bool, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke(bool.boolValue(), continuation);
    }

    public readonly java.lang.object Invoke(bool z, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((androidx.paging.AsyncPagingDataDiffer$loadStateFlow$1$1) create(java.lang.bool.valueOf(z), continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(!this.Z$0);
    }
}

