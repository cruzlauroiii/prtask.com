namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u0004B\u0005¢\u0006\u0002\u0010\u0005J*\u0010\u0006\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t2\u0012\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000bH\u0016J*\u0010\f\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t2\u0012\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000bH\u0016J*\u0010\r\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\u000e2\u0012\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000fH\u0016¨\u0006\u0010"}, d2 = {"Landroidx/paging/InitialDataSource;", "K", "", "V", "Landroidx/paging/PageKeyedDataSource;", "()V", "loadAfter", "", "params", "Landroidx/paging/PageKeyedDataSource$LoadParams;", "callback", "Landroidx/paging/PageKeyedDataSource$LoadCallback;", "loadBefore", "loadInitial", "Landroidx/paging/PageKeyedDataSource$LoadInitialParams;", "Landroidx/paging/PageKeyedDataSource$LoadInitialCallback;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InitialDataSource<K, V> : androidx.paging.PageKeyedDataSource<K, V> {
    public override void LoadAfter(androidx.paging.PageKeyedDataSource$LoadParams<K> params, androidx.paging.PageKeyedDataSource$LoadCallback<K, V> callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        callback.onResult(kotlin.collections.ICollectionsKt.emptyList(), null);
    }

    public override void LoadBefore(androidx.paging.PageKeyedDataSource$LoadParams<K> params, androidx.paging.PageKeyedDataSource$LoadCallback<K, V> callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        callback.onResult(kotlin.collections.ICollectionsKt.emptyList(), null);
    }

    public override void LoadInitial(androidx.paging.PageKeyedDataSource$LoadInitialParams<K> params, androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, V> callback) {
        if ((30 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        callback.onResult(kotlin.collections.ICollectionsKt.emptyList(), 0, 0, null, null);
    }
}

