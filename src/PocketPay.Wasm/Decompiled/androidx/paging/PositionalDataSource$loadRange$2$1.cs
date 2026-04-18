namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/paging/PositionalDataSource$loadRange$2$1", "Landroidx/paging/PositionalDataSource$LoadRangeCallback;", "onResult", "", "data", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PositionalDataSource$loadRange$2$1<T> : androidx.paging.PositionalDataSource$LoadRangeCallback<T> {
    readonly kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> $cont;
    readonly androidx.paging.PositionalDataSource$LoadRangeParams $params;
    readonly androidx.paging.PositionalDataSource<T> this$0;

    PositionalDataSource$loadRange$2$1(androidx.paging.PositionalDataSource$LoadRangeParams positionalDataSource$LoadRangeParams, androidx.paging.PositionalDataSource<T> positionalDataSource, kotlinx.coroutines.CancellableContinuation<? super androidx.paging.DataSource$BaseResult<T>> cancellableContinuation) {
        this.$params = positionalDataSource$LoadRangeParams;
        this.this$0 = positionalDataSource;
        this.$cont = cancellableContinuation;
    }

    public override void OnResult(java.util.List<? : T> data2) {
        if ((31 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        java.lang.int numValueOf = this.$params.startPosition != 0 ? java.lang.int.valueOf(this.$params.startPosition) : null;
        if (this.this$0.isInvalid()) {
            kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> cancellableContinuation = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(androidx.paging.DataSource$BaseResult.Companion.empty$paging_common_release()));
        } else {
            kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<T>> cancellableContinuation2 = this.$cont;
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(new androidx.paging.DataSource$BaseResult(data2, numValueOf, java.lang.int.valueOf(this.$params.startPosition + data2.Count), 0, 0, 24, null)));
        }
    }
}

