namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J%\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"androidx/paging/WrapperPageKeyedDataSource$loadAfter$1", "Landroidx/paging/PageKeyedDataSource$LoadCallback;", "onResult", "", "data", "", "adjacentPageKey", "(Ljava/util/List;Ljava/lang/object;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPageKeyedDataSource$loadAfter$1<A, K> : androidx.paging.PageKeyedDataSource$LoadCallback<K, A> {
    readonly androidx.paging.PageKeyedDataSource$LoadCallback<K, B> $callback;
    readonly androidx.paging.WrapperPageKeyedDataSource<K, A, B> this$0;

    WrapperPageKeyedDataSource$loadAfter$1(androidx.paging.PageKeyedDataSource$LoadCallback<K, B> pageKeyedDataSource$LoadCallback, androidx.paging.WrapperPageKeyedDataSource<K, A, B> wrapperPageKeyedDataSource) {
        this.$callback = pageKeyedDataSource$LoadCallback;
        this.this$0 = wrapperPageKeyedDataSource;
    }

    public override void OnResult(java.util.List<? : A> data2, K adjacentPageKey) {
        if ((29 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.$callback.onResult((java.util.List<? : B>) androidx.paging.DataSource.Companion.convert$paging_common_release(androidx.paging.WrapperPageKeyedDataSource.access$getListFunction$p(this.this$0), data2), adjacentPageKey);
    }
}

