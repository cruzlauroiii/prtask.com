namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/paging/WrapperPositionalDataSource$loadRange$1", "Landroidx/paging/PositionalDataSource$LoadRangeCallback;", "onResult", "", "data", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPositionalDataSource$loadRange$1<A> : androidx.paging.PositionalDataSource$LoadRangeCallback<A> {
    readonly androidx.paging.PositionalDataSource$LoadRangeCallback<B> $callback;
    readonly androidx.paging.WrapperPositionalDataSource<A, B> this$0;

    WrapperPositionalDataSource$loadRange$1(androidx.paging.PositionalDataSource$LoadRangeCallback<B> positionalDataSource$LoadRangeCallback, androidx.paging.WrapperPositionalDataSource<A, B> wrapperPositionalDataSource) {
        this.$callback = positionalDataSource$LoadRangeCallback;
        this.this$0 = wrapperPositionalDataSource;
    }

    public override void OnResult(java.util.List<? : A> data2) {
        if ((5 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.$callback.onResult((java.util.List<? : B>) androidx.paging.DataSource.Companion.convert$paging_common_release(this.this$0.getListFunction(), data2));
    }
}

