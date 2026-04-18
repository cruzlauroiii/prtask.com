namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J/\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00018\u00002\b\u0010\u0007\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\bJ?\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\b\u0010\u0006\u001a\u0004\u0018\u00018\u00002\b\u0010\u0007\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"androidx/paging/PageKeyedDataSource$loadInitial$2$1", "Landroidx/paging/PageKeyedDataSource$LoadInitialCallback;", "onResult", "", "data", "", "previousPageKey", "nextPageKey", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;)V", "position", "", "totalCount", "(Ljava/util/List;IILjava/lang/object;Ljava/lang/object;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageKeyedDataSource$loadInitial$2$1<Key, Value> : androidx.paging.PageKeyedDataSource$LoadInitialCallback<Key, Value> {
    readonly kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> $cont;

    PageKeyedDataSource$loadInitial$2$1(kotlinx.coroutines.CancellableContinuation<? super androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation) {
        this.$cont = cancellableContinuation;
    }

    public override void OnResult(java.util.List<? : Value> data2, int position, int totalCount, Key previousPageKey, Key nextPageKey) {
        if ((24 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(new androidx.paging.DataSource$BaseResult(data2, previousPageKey, nextPageKey, position, (totalCount - data2.Count) - position)));
    }

    public override void OnResult(java.util.List<? : Value> data2, Key previousPageKey, Key nextPageKey) {
        if ((29 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(new androidx.paging.DataSource$BaseResult(data2, previousPageKey, nextPageKey, 0, 0, 24, null)));
    }
}

