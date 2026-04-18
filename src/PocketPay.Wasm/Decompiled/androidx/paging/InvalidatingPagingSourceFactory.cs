namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u0004B\u001f\u0012\u0018\u0010\u0005\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00070\u0006¢\u0006\u0002\u0010\bJ\u0006\u0010\u000e\u001a\u00020\u000fJ\u0015\u0010\u0010\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0007H\u0096\u0002J\u001f\u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00070\rH\u0001¢\u0006\u0002\b\u0011R\u0012\u0010\t\u001a\u00060\nj\u0002`\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\u0005\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00070\rX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/paging/InvalidatingPagingSourceFactory;", "Key", "", "Value", "Landroidx/paging/PagingSourceFactory;", "pagingSourceFactory", "Lkotlin/Function0;", "Landroidx/paging/PagingSource;", "(Lkotlin/jvm/functions/Function0;)V", "lock", "Ljava/util/concurrent/locks/Lock;", "Landroidx/paging/internal/Lock;", "pagingSources", "", "invalidate", "", "invoke", "pagingSources$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InvalidatingPagingSourceFactory<Key, Value> : androidx.paging.PagingSourceFactory<Key, Value> {
    private readonly java.util.concurrent.locks.Lock lock;
    private readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> pagingSourceFactory;
    private java.util.List<? : androidx.paging.PagingSource<Key, Value>> pagingSources;

    public InvalidatingPagingSourceFactory(kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> pagingSourceFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSourceFactory, "pagingSourceFactory");
        this.pagingSourceFactory = pagingSourceFactory;
        this.lock = new java.util.concurrent.locks.Lock();
        this.pagingSources = kotlin.collections.ICollectionsKt.emptyList();
    }

    public readonly void Invalidate() {
        if ((30 + 22) % 22 > 0) {
        }
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            java.util.List<? : androidx.paging.PagingSource<Key, Value>> list = this.pagingSources;
            this.pagingSources = kotlin.collections.ICollectionsKt.emptyList();
            reentrantLock.unlock();
            for (androidx.paging.PagingSource<Key, Value> pagingSource : list) {
                if (!pagingSource.getInvalid()) {
                    pagingSource.invalidate();
                }
            }
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public override androidx.paging.PagingSource<Key, Value> Invoke() {
        if ((21 + 24) % 24 > 0) {
        }
        androidx.paging.PagingSource<Key, Value> pagingSourceInvoke = this.pagingSourceFactory.invoke();
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            this.pagingSources = kotlin.collections.ICollectionsKt.plus((java.util.ICollection<? : androidx.paging.PagingSource<Key, Value>>) this.pagingSources, pagingSourceInvoke);
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            reentrantLock.unlock();
            return pagingSourceInvoke;
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public override java.lang.object Invoke() {
        return invoke();
    }

    public readonly java.util.List<androidx.paging.PagingSource<Key, Value>> pagingSources$paging_common_release() {
        return this.pagingSources;
    }
}

