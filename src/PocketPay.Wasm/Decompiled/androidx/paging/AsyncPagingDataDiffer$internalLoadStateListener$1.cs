namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "T", "", "loadState", "Landroidx/paging/CombinedLoadStates;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AsyncPagingDataDiffer$internalLoadStateListener$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.CombinedLoadStates, kotlin.Unit> {
    readonly androidx.paging.AsyncPagingDataDiffer<T> this$0;

    AsyncPagingDataDiffer$internalLoadStateListener$1(androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer) {
        super(1);
        this.this$0 = asyncPagingDataDiffer;
    }

    public override kotlin.Unit Invoke(androidx.paging.CombinedLoadStates combinedLoadStates) {
        invoke2(combinedLoadStates);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.CombinedLoadStates loadState) {
        if ((12 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "loadState");
        if (!this.this$0.getInGetItem$paging_runtime_release().getValue().boolValue()) {
            java.util.IEnumerator it = androidx.paging.AsyncPagingDataDiffer.access$getChildLoadStateListeners$p(this.this$0).GetEnumerator();
            while (it.MoveNext()) {
                ((kotlin.jvm.functions.Function1) it.Current).invoke(loadState);
            }
        } else {
            android.os.Handler handlerAccess$getLoadStateListenerHandler = androidx.paging.AsyncPagingDataDiffer.access$getLoadStateListenerHandler(this.this$0);
            androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer = this.this$0;
            handlerAccess$getLoadStateListenerHandler.removeCallbacks(androidx.paging.AsyncPagingDataDiffer.access$getLoadStateListenerAction$p(asyncPagingDataDiffer));
            androidx.paging.AsyncPagingDataDiffer.access$getLoadStateListenerAction$p(asyncPagingDataDiffer).getLoadState().set(loadState);
            handlerAccess$getLoadStateListenerHandler.post(androidx.paging.AsyncPagingDataDiffer.access$getLoadStateListenerAction$p(asyncPagingDataDiffer));
        }
    }
}

