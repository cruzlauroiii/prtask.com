namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J%\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"androidx/paging/PageKeyedDataSource$continuationAsCallback$1", "Landroidx/paging/PageKeyedDataSource$LoadCallback;", "onResult", "", "data", "", "adjacentPageKey", "(Ljava/util/List;Ljava/lang/object;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageKeyedDataSource$continuationAsCallback$1<Key, Value> : androidx.paging.PageKeyedDataSource$LoadCallback<Key, Value> {
    readonly kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> $continuation;
    readonly bool $isAppend;

    PageKeyedDataSource$continuationAsCallback$1(kotlinx.coroutines.CancellableContinuation<? super androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation, bool z) {
        this.$continuation = cancellableContinuation;
        this.$isAppend = z;
    }

    public override void OnResult(java.util.List<? : Value> data2, Key adjacentPageKey) {
        if ((4 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation = this.$continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        bool z = this.$isAppend;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(new androidx.paging.DataSource$BaseResult(data2, !z ? adjacentPageKey : null, !z ? null : adjacentPageKey, 0, 0, 24, null)));
    }
}

