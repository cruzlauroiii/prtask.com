namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "Key", "", "Value", "generationalHint", "Landroidx/paging/GenerationalobjectportHint;", "emit", "(Landroidx/paging/GenerationalobjectportHint;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PageFetcherSnapshot$collectAsGenerationalobjectportHints$4<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.paging.LoadType $loadType;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$collectAsGenerationalobjectportHints$4(androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, androidx.paging.LoadType loadType) {
        this.this$0 = pageFetcherSnapshot;
        this.$loadType = loadType;
    }

    public readonly java.lang.object Emit(androidx.paging.GenerationalobjectportHint generationalobjectportHint, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objAccess$doLoad = androidx.paging.PageFetcherSnapshot.access$doLoad(this.this$0, this.$loadType, generationalobjectportHint, continuation);
        return objAccess$doLoad != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAccess$doLoad;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((androidx.paging.GenerationalobjectportHint) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }
}

