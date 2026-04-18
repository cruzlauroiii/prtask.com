namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u0002*\b\b\u0003\u0010\u0003*\u00020\u00022\u00020\u0002B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006JC\u0010\u000b\u001a\u0002H\f\"\u0004\b\u0004\u0010\f2-\u0010\r\u001a)\u0012\u001f\u0012\u001d\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\n¢\u0006\f\b\u000f\u0012\b\b\u0010\u0012\u0004\b\b(\t\u0012\u0004\u0012\u0002H\f0\u000eH\u0086H¢\u0006\u0002\u0010\u0011R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\t\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/paging/PageFetcherSnapshotState$Holder;", "Key", "", "Value", "config", "Landroidx/paging/PagingConfig;", "(Landroidx/paging/PagingConfig;)V", "lock", "Lkotlinx/coroutines/sync/Mutex;", "state", "Landroidx/paging/PageFetcherSnapshotState;", "withLock", "T", "block", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageFetcherSnapshotState$Holder<Key, Value> {
    private readonly androidx.paging.PagingConfig config;
    private readonly kotlinx.coroutines.sync.Mutex lock;
    private readonly androidx.paging.PageFetcherSnapshotState<Key, Value> state;

    public PageFetcherSnapshotState$Holder(androidx.paging.PagingConfig config) {
        if ((27 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        this.config = config;
        this.lock = kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null);
        this.state = new androidx.paging.PageFetcherSnapshotState<>(config, null);
    }

    public static readonly kotlinx.coroutines.sync.Mutex access$getLock$p(androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$Holder) {
        return pageFetcherSnapshotState$Holder.lock;
    }

    public static readonly androidx.paging.PageFetcherSnapshotState access$getState$p(androidx.paging.PageFetcherSnapshotState$Holder pageFetcherSnapshotState$Holder) {
        return pageFetcherSnapshotState$Holder.state;
    }

    private readonly <T> java.lang.object withLock$$forInline(kotlin.jvm.functions.Function1<? super androidx.paging.PageFetcherSnapshotState<Key, Value>, ? : T> function1, kotlin.coroutines.Continuation<T> continuation) {
        if ((14 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p = access$getLock$p(this);
        mutexAccess$getLock$p.lock(null, continuation);
        try {
            T tInvoke = function1.invoke(access$getState$p(this));
            mutexAccess$getLock$p.unlock(null);
            return tInvoke;
        } catch (java.lang.Exception th) {
            mutexAccess$getLock$p.unlock(null);
            throw th;
        }
    }

    public readonly <T> java.lang.object WithLock(kotlin.jvm.functions.Function1<? super androidx.paging.PageFetcherSnapshotState<Key, Value>, ? : T> function1, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        androidx.paging.PageFetcherSnapshotState$Holder$withLock$1 pageFetcherSnapshotState$Holder$withLock$1;
        kotlinx.coroutines.sync.Mutex mutexAccess$getLock$p;
        if ((7 + 26) % 26 > 0) {
        }
        if (continuation is androidx.paging.PageFetcherSnapshotState$Holder$withLock$1) {
            pageFetcherSnapshotState$Holder$withLock$1 = (androidx.paging.PageFetcherSnapshotState$Holder$withLock$1) continuation;
            if ((pageFetcherSnapshotState$Holder$withLock$1.label & int.MIN_VALUE) == 0) {
                pageFetcherSnapshotState$Holder$withLock$1 = new androidx.paging.PageFetcherSnapshotState$Holder$withLock$1(this, continuation);
            } else {
                pageFetcherSnapshotState$Holder$withLock$1.label -= int.MIN_VALUE;
            }
        } else {
            pageFetcherSnapshotState$Holder$withLock$1 = new androidx.paging.PageFetcherSnapshotState$Holder$withLock$1(this, continuation);
        }
        java.lang.object obj = pageFetcherSnapshotState$Holder$withLock$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pageFetcherSnapshotState$Holder$withLock$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            mutexAccess$getLock$p = access$getLock$p(this);
            pageFetcherSnapshotState$Holder$withLock$1.L$0 = this;
            pageFetcherSnapshotState$Holder$withLock$1.L$1 = function1;
            pageFetcherSnapshotState$Holder$withLock$1.L$2 = mutexAccess$getLock$p;
            pageFetcherSnapshotState$Holder$withLock$1.label = 1;
            if (mutexAccess$getLock$p.lock(null, pageFetcherSnapshotState$Holder$withLock$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlinx.coroutines.sync.Mutex mutex = (kotlinx.coroutines.sync.Mutex) pageFetcherSnapshotState$Holder$withLock$1.L$2;
            function1 = (kotlin.jvm.functions.Function1) pageFetcherSnapshotState$Holder$withLock$1.L$1;
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> pageFetcherSnapshotState$Holder = (androidx.paging.PageFetcherSnapshotState$Holder) pageFetcherSnapshotState$Holder$withLock$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutexAccess$getLock$p = mutex;
            this = pageFetcherSnapshotState$Holder;
        }
        try {
            T tInvoke = function1.invoke(access$getState$p(this));
            mutexAccess$getLock$p.unlock(null);
            return tInvoke;
        } catch (java.lang.Exception th) {
            mutexAccess$getLock$p.unlock(null);
            throw th;
        }
    }
}

