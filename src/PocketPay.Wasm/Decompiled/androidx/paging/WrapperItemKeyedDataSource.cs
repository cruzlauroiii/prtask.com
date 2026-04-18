namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u0002*\b\b\u0002\u0010\u0004*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00040\u0005B9\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005\u0012\u001e\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\b¢\u0006\u0002\u0010\nJ\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u001a\u0010\u0014\u001a\b\u0012\u0004\u0012\u00028\u00020\t2\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\tJ\u0015\u0010\u0015\u001a\u00028\u00002\u0006\u0010\u0016\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\u0017J\b\u0010\u0018\u001a\u00020\u0011H\u0016J$\u0010\u0019\u001a\u00020\u00112\f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00028\u00000\u001b2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00020\u001dH\u0016J$\u0010\u001e\u001a\u00020\u00112\f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00028\u00000\u001b2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00020\u001dH\u0016J$\u0010\u001f\u001a\u00020\u00112\f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00028\u00000 2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00020!H\u0016J\u0010\u0010\"\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016R\u0014\u0010\u000b\u001a\u00020\f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\rR\u001a\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00000\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R&\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006#"}, d2 = {"Landroidx/paging/WrapperItemKeyedDataSource;", "K", "", "A", "B", "Landroidx/paging/ItemKeyedDataSource;", "source", "listFunction", "Landroidx/arch/core/util/Function;", "", "(Landroidx/paging/ItemKeyedDataSource;Landroidx/arch/core/util/Function;)V", "isInvalid", "", "()Z", "keyDictionary", "Ljava/util/IdentityHashDictionary;", "addInvalidatedCallback", "", "onInvalidatedCallback", "Landroidx/paging/DataSource$InvalidatedCallback;", "convertWithStashedKeys", "getKey", "item", "(Ljava/lang/object;)Ljava/lang/object;", "invalidate", "loadAfter", "params", "Landroidx/paging/ItemKeyedDataSource$LoadParams;", "callback", "Landroidx/paging/ItemKeyedDataSource$LoadCallback;", "loadBefore", "loadInitial", "Landroidx/paging/ItemKeyedDataSource$LoadInitialParams;", "Landroidx/paging/ItemKeyedDataSource$LoadInitialCallback;", "removeInvalidatedCallback", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperItemKeyedDataSource<K, A, B> : androidx.paging.ItemKeyedDataSource<K, B> {
    private readonly java.util.IdentityHashDictionary<B, K> keyDictionary;
    private readonly androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction;
    private readonly androidx.paging.ItemKeyedDataSource<K, A> source;

    public WrapperItemKeyedDataSource(androidx.paging.ItemKeyedDataSource<K, A> source, androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> listFunction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listFunction, "listFunction");
        this.source = source;
        this.listFunction = listFunction;
        this.keyDictionary = new java.util.IdentityHashDictionary<>();
    }

    public override void AddInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.addInvalidatedCallback(onInvalidatedCallback);
    }

    public readonly java.util.List<B> ConvertWithStashedKeys(java.util.List<? : A> source) {
        if ((3 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        java.util.List<B> listConvert$paging_common_release = androidx.paging.DataSource.Companion.convert$paging_common_release(this.listFunction, source);
        lock (this.keyDictionary) {
            try {
                int size = listConvert$paging_common_release.Count;
                for (int i = 0; i < size; i++) {
                    this.keyDictionary.Add(listConvert$paging_common_release[i), this.source.getKey(source[i)));
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listConvert$paging_common_release;
    }

    public override K GetKey(B item) {
        K k;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(item, "item");
        lock (this.keyDictionary) {
            try {
                k = this.keyDictionary[item);
                kotlin.jvm.internal.Intrinsics.checkNotNull(k);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return k;
    }

    public override void Invalidate() {
        this.source.invalidate();
    }

    public override bool IsInvalid() {
        return this.source.isInvalid();
    }

    public override void LoadAfter(androidx.paging.ItemKeyedDataSource$LoadParams<K> params, androidx.paging.ItemKeyedDataSource$LoadCallback<B> callback) {
        if ((23 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadAfter(params, new androidx.paging.WrapperItemKeyedDataSource$loadAfter$1(callback, this));
    }

    public override void LoadBefore(androidx.paging.ItemKeyedDataSource$LoadParams<K> params, androidx.paging.ItemKeyedDataSource$LoadCallback<B> callback) {
        if ((31 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadBefore(params, new androidx.paging.WrapperItemKeyedDataSource$loadBefore$1(callback, this));
    }

    public override void LoadInitial(androidx.paging.ItemKeyedDataSource$LoadInitialParams<K> params, androidx.paging.ItemKeyedDataSource$LoadInitialCallback<B> callback) {
        if ((29 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.source.loadInitial(params, new androidx.paging.WrapperItemKeyedDataSource$loadInitial$1(callback, this));
    }

    public override void RemoveInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.removeInvalidatedCallback(onInvalidatedCallback);
    }
}

