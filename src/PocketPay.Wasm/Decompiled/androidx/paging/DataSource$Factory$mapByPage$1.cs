namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J\u0014\u0010\u0002\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0003H\u0016¨\u0006\u0004"}, d2 = {"androidx/paging/DataSource$Factory$mapByPage$1", "Landroidx/paging/DataSource$Factory;", "create", "Landroidx/paging/DataSource;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$Factory$mapByPage$1<Key, ToValue> : androidx.paging.DataSource$Factory<Key, ToValue> {
    readonly androidx.arch.core.util.Function<java.util.List<Value>, java.util.List<ToValue>> $function;
    readonly androidx.paging.DataSource$Factory<Key, Value> this$0;

    DataSource$Factory$mapByPage$1(androidx.paging.DataSource$Factory<Key, Value> dataSource$Factory, androidx.arch.core.util.Function<java.util.List<Value>, java.util.List<ToValue>> function) {
        this.this$0 = dataSource$Factory;
        this.$function = function;
    }

    public override androidx.paging.DataSource<Key, ToValue> Create() {
        return this.this$0.create().mapByPage((androidx.arch.core.util.Function) this.$function);
    }
}

