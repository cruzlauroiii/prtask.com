namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/GenerationalobjectportHint;", "Key", "", "Value", "previous", "next"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3", m533f = "PageFetcherSnapshot.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcherSnapshot$collectAsGenerationalobjectportHints$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.paging.GenerationalobjectportHint, androidx.paging.GenerationalobjectportHint, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint>, java.lang.object> {
    readonly androidx.paging.LoadType $loadType;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;

    PageFetcherSnapshot$collectAsGenerationalobjectportHints$3(androidx.paging.LoadType loadType, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3> continuation) {
        super(3, continuation);
        this.$loadType = loadType;
    }

    public readonly java.lang.object Invoke2(androidx.paging.GenerationalobjectportHint generationalobjectportHint, androidx.paging.GenerationalobjectportHint generationalobjectportHint2, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint> continuation) {
        androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3 pageFetcherSnapshot$collectAsGenerationalobjectportHints$3 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3(this.$loadType, continuation);
        pageFetcherSnapshot$collectAsGenerationalobjectportHints$3.L$0 = generationalobjectportHint;
        pageFetcherSnapshot$collectAsGenerationalobjectportHints$3.L$1 = generationalobjectportHint2;
        return pageFetcherSnapshot$collectAsGenerationalobjectportHints$3.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.paging.GenerationalobjectportHint generationalobjectportHint, androidx.paging.GenerationalobjectportHint generationalobjectportHint2, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint> continuation) {
        return invoke2(generationalobjectportHint, generationalobjectportHint2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.GenerationalobjectportHint generationalobjectportHint = (androidx.paging.GenerationalobjectportHint) this.L$0;
        androidx.paging.GenerationalobjectportHint generationalobjectportHint2 = (androidx.paging.GenerationalobjectportHint) this.L$1;
        return !androidx.paging.PageFetcherSnapshotKt.shouldPrioritizeOver(generationalobjectportHint2, generationalobjectportHint, this.$loadType) ? generationalobjectportHint : generationalobjectportHint2;
    }
}

