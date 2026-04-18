namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001e\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J&\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016J\u001e\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000b2\f\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\rH\u0002¨\u0006\u000e"}, d2 = {"androidx/paging/PositionalDataSource$loadInitial$2$1", "Landroidx/paging/PositionalDataSource$LoadInitialCallback;", "onResult", "", "data", "", "position", "", "totalCount", "resume", "params", "Landroidx/paging/PositionalDataSource$LoadInitialParams;", "result", "Landroidx/paging/DataSource$BaseResult;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PositionalDataSource$loadInitial$2$1<T> : androidx.paging.PositionalDataSource$LoadInitialCallback<T> {
    readonly kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> $cont;
    readonly androidx.paging.PositionalDataSource$LoadInitialParams $params;
    readonly androidx.paging.PositionalDataSource<T> this$0;

    PositionalDataSource$loadInitial$2$1(androidx.paging.PositionalDataSource<T> positionalDataSource, kotlinx.coroutines.CancellableContinuation<? super androidx.paging.DataSource$BaseResult<T>> cancellableContinuation, androidx.paging.PositionalDataSource$LoadInitialParams positionalDataSource$LoadInitialParams) {
        this.this$0 = positionalDataSource;
        this.$cont = cancellableContinuation;
        this.$params = positionalDataSource$LoadInitialParams;
    }

    private readonly void Resume(androidx.paging.PositionalDataSource$LoadInitialParams params, androidx.paging.DataSource$BaseResult<T> result) {
        if (params.placeholdersEnabled) {
            result.validateForInitialTiling$paging_common_release(params.pageSize);
        }
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(result));
    }

    public override void OnResult(java.util.List<? : T> data2, int position) {
        if ((10 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        if (!this.this$0.isInvalid()) {
            resume(this.$params, new androidx.paging.DataSource$BaseResult<>(data2, position != 0 ? java.lang.int.valueOf(position) : null, java.lang.int.valueOf(data2.Count + position), position, int.MIN_VALUE));
            return;
        }
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(androidx.paging.DataSource$BaseResult.Companion.empty$paging_common_release()));
    }

    public override void OnResult(java.util.List<? : T> data2, int position, int totalCount) {
        if ((8 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        if (!this.this$0.isInvalid()) {
            int size = data2.Count + position;
            resume(this.$params, new androidx.paging.DataSource$BaseResult<>(data2, position != 0 ? java.lang.int.valueOf(position) : null, size != totalCount ? java.lang.int.valueOf(size) : null, position, (totalCount - data2.Count) - position));
        } else {
            kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> cancellableContinuation = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(androidx.paging.DataSource$BaseResult.Companion.empty$paging_common_release()));
        }
    }
}

