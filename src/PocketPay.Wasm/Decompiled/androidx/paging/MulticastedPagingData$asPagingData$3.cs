namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/paging/PageEvent$Insert;", "T", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MulticastedPagingData$asPagingData$3<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.paging.PageEvent$Insert<T>> {
    readonly androidx.paging.MulticastedPagingData<T> this$0;

    MulticastedPagingData$asPagingData$3(androidx.paging.MulticastedPagingData<T> multicastedPagingData) {
        super(0);
        this.this$0 = multicastedPagingData;
    }

    public readonly androidx.paging.PageEvent$Insert<T> invoke() {
        return androidx.paging.MulticastedPagingData.access$getAccumulated$p(this.this$0).getCachedEvent$paging_common_release();
    }

    public override java.lang.object Invoke() {
        return invoke();
    }
}

