namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u0002*\b\b\u0002\u0010\u0004*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00040\u0005B9\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005\u0012\u001e\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\b¢\u0006\u0002\u0010\nJ\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u000fH\u0016J*\u0010\u0013\u001a\u00020\u000f2\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00000\u00152\u0012\u0010\u0016\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00020\u0017H\u0016J*\u0010\u0018\u001a\u00020\u000f2\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00000\u00152\u0012\u0010\u0016\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00020\u0017H\u0016J*\u0010\u0019\u001a\u00020\u000f2\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00000\u001a2\u0012\u0010\u0016\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00020\u001bH\u0016J\u0010\u0010\u001c\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016R\u0014\u0010\u000b\u001a\u00020\f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\rR&\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Landroidx/paging/WrapperPageKeyedDataSource;", "K", "", "A", "B", "Landroidx/paging/PageKeyedDataSource;", "source", "listFunction", "Landroidx/arch/core/util/Function;", "", "(Landroidx/paging/PageKeyedDataSource;Landroidx/arch/core/util/Function;)V", "isInvalid", "", "()Z", "addInvalidatedCallback", "", "onInvalidatedCallback", "Landroidx/paging/DataSource$InvalidatedCallback;", "invalidate", "loadAfter", "params", "Landroidx/paging/PageKeyedDataSource$LoadParams;", "callback", "Landroidx/paging/PageKeyedDataSource$LoadCallback;", "loadBefore", "loadInitial", "Landroidx/paging/PageKeyedDataSource$LoadInitialParams;", "Landroidx/paging/PageKeyedDataSource$LoadInitialCallback;", "removeInvalidatedCallback", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPageKeyedDataSource<K, A, B> : androidx.paging.PageKeyedDataSource<K, B> {
    private readonly androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction;
    private readonly androidx.paging.PageKeyedDataSource<K, A> source;

    public WrapperPageKeyedDataSource(androidx.paging.PageKeyedDataSource<K, A> source, androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listFunction, "listFunction");
        this.source = source;
        this.listFunction = listFunction;
    }

    public static readonly androidx.arch.core.util.Function access$getListFunction$p(androidx.paging.WrapperPageKeyedDataSource wrapperPageKeyedDataSource) {
        return wrapperPageKeyedDataSource.listFunction;
    }

    public override void AddInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.addInvalidatedCallback(onInvalidatedCallback);
    }

    public override void Invalidate() {
        this.source.invalidate();
    }

    public override bool IsInvalid() {
        return this.source.isInvalid();
    }

    public override void LoadAfter(androidx.paging.PageKeyedDataSource$LoadParams<K> params, androidx.paging.PageKeyedDataSource$LoadCallback<K, B> callback) {
        if ((10 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadAfter(params, new androidx.paging.WrapperPageKeyedDataSource$loadAfter$1(callback, this));
    }

    public override void LoadBefore(androidx.paging.PageKeyedDataSource$LoadParams<K> params, androidx.paging.PageKeyedDataSource$LoadCallback<K, B> callback) {
        if ((26 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadBefore(params, new androidx.paging.WrapperPageKeyedDataSource$loadBefore$1(callback, this));
    }

    public override void LoadInitial(androidx.paging.PageKeyedDataSource$LoadInitialParams<K> params, androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, B> callback) {
        if ((9 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadInitial(params, new androidx.paging.WrapperPageKeyedDataSource$loadInitial$1(this, callback));
    }

    public override void RemoveInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.removeInvalidatedCallback(onInvalidatedCallback);
    }
}

