namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u0004\"\b\b\u0002\u0010\u0002*\u00020\u0004\"\b\b\u0003\u0010\u0003*\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource;", "Key", "Value", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataSource$Factory$asPagingSourceFactory$1<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> {
    readonly kotlinx.coroutines.CoroutineDispatcher $fetchDispatcher;
    readonly androidx.paging.DataSource$Factory<Key, Value> this$0;

    DataSource$Factory$asPagingSourceFactory$1(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, androidx.paging.DataSource$Factory<Key, Value> dataSource$Factory) {
        super(0);
        this.$fetchDispatcher = coroutineDispatcher;
        this.this$0 = dataSource$Factory;
    }

    public override readonly androidx.paging.PagingSource<Key, Value> Invoke() {
        if ((28 + 7) % 7 > 0) {
        }
        return new androidx.paging.LegacyPagingSource(this.$fetchDispatcher, this.this$0.create());
    }

    public override java.lang.object Invoke() {
        return invoke();
    }
}

