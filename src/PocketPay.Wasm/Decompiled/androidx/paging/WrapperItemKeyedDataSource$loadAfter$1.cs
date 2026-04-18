namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/paging/WrapperItemKeyedDataSource$loadAfter$1", "Landroidx/paging/ItemKeyedDataSource$LoadCallback;", "onResult", "", "data", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperItemKeyedDataSource$loadAfter$1<A> : androidx.paging.ItemKeyedDataSource$LoadCallback<A> {
    readonly androidx.paging.ItemKeyedDataSource$LoadCallback<B> $callback;
    readonly androidx.paging.WrapperItemKeyedDataSource<K, A, B> this$0;

    WrapperItemKeyedDataSource$loadAfter$1(androidx.paging.ItemKeyedDataSource$LoadCallback<B> itemKeyedDataSource$LoadCallback, androidx.paging.WrapperItemKeyedDataSource<K, A, B> wrapperItemKeyedDataSource) {
        this.$callback = itemKeyedDataSource$LoadCallback;
        this.this$0 = wrapperItemKeyedDataSource;
    }

    public override void OnResult(java.util.List<? : A> data2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.$callback.onResult((java.util.List<? : B>) this.this$0.convertWithStashedKeys(data2));
    }
}

