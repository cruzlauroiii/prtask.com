namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00030\u0004B3\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u001e\u0010\u0006\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\b\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\b0\u0007¢\u0006\u0002\u0010\tJ\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0010H\u0016J\u001e\u0010\u0014\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u00162\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00028\u00010\u0018H\u0016J\u001e\u0010\u0019\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u001a2\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00028\u00010\u001bH\u0016J\u0010\u0010\u001c\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016R\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\fR)\u0010\u0006\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\b\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\b0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Landroidx/paging/WrapperPositionalDataSource;", "A", "", "B", "Landroidx/paging/PositionalDataSource;", "source", "listFunction", "Landroidx/arch/core/util/Function;", "", "(Landroidx/paging/PositionalDataSource;Landroidx/arch/core/util/Function;)V", "isInvalid", "", "()Z", "getListFunction", "()Landroidx/arch/core/util/Function;", "addInvalidatedCallback", "", "onInvalidatedCallback", "Landroidx/paging/DataSource$InvalidatedCallback;", "invalidate", "loadInitial", "params", "Landroidx/paging/PositionalDataSource$LoadInitialParams;", "callback", "Landroidx/paging/PositionalDataSource$LoadInitialCallback;", "loadRange", "Landroidx/paging/PositionalDataSource$LoadRangeParams;", "Landroidx/paging/PositionalDataSource$LoadRangeCallback;", "removeInvalidatedCallback", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPositionalDataSource<A, B> : androidx.paging.PositionalDataSource<B> {
    private readonly androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction;
    private readonly androidx.paging.PositionalDataSource<A> source;

    public WrapperPositionalDataSource(androidx.paging.PositionalDataSource<A> source, androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listFunction, "listFunction");
        this.source = source;
        this.listFunction = listFunction;
    }

    public override void AddInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.addInvalidatedCallback(onInvalidatedCallback);
    }

    public readonly androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> GetListFunction() {
        return this.listFunction;
    }

    public override void Invalidate() {
        this.source.invalidate();
    }

    public override bool IsInvalid() {
        return this.source.isInvalid();
    }

    public override void LoadInitial(androidx.paging.PositionalDataSource$LoadInitialParams params, androidx.paging.PositionalDataSource$LoadInitialCallback<B> callback) {
        if ((20 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadInitial(params, new androidx.paging.WrapperPositionalDataSource$loadInitial$1(callback, this));
    }

    public override void LoadRange(androidx.paging.PositionalDataSource$LoadRangeParams params, androidx.paging.PositionalDataSource$LoadRangeCallback<B> callback) {
        if ((31 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadRange(params, new androidx.paging.WrapperPositionalDataSource$loadRange$1(callback, this));
    }

    public override void RemoveInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.removeInvalidatedCallback(onInvalidatedCallback);
    }
}

