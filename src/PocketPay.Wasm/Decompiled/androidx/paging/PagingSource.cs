namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b&\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002:\u0002\"#B\u0005¢\u0006\u0002\u0010\u0004J#\u0010\u0015\u001a\u0004\u0018\u00018\u00002\u0012\u0010\u0016\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0017H&¢\u0006\u0002\u0010\u0018J\u0006\u0010\u0019\u001a\u00020\u0010J(\u0010\u001a\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001b2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00000\u001dH¦@¢\u0006\u0002\u0010\u001eJ\u0014\u0010\u001f\u001a\u00020\u00102\f\u0010 \u001a\b\u0012\u0004\u0012\u00020\u00100\u000fJ\u0014\u0010!\u001a\u00020\u00102\f\u0010 \u001a\b\u0012\u0004\u0012\u00020\u00100\u000fR\u0011\u0010\u0005\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR\u0014\u0010\t\u001a\u00020\n8AX\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u001a\u0010\r\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00100\u000f0\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\bR\u0014\u0010\u0013\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\b¨\u0006$"}, d2 = {"Landroidx/paging/PagingSource;", "Key", "", "Value", "()V", "invalid", "", "getInvalid", "()Z", "invalidateCallbackCount", "", "getInvalidateCallbackCount$paging_common_release", "()I", "invalidateCallbackTracker", "Landroidx/paging/InvalidateCallbackTracker;", "Lkotlin/Function0;", "", "jumpingSupported", "getJumpingSupported", "keyReuseSupported", "getKeyReuseSupported", "getRefreshKey", "state", "Landroidx/paging/PagingState;", "(Landroidx/paging/PagingState;)Ljava/lang/object;", "invalidate", "load", "Landroidx/paging/PagingSource$LoadResult;", "params", "Landroidx/paging/PagingSource$LoadParams;", "(Landroidx/paging/PagingSource$LoadParams;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerInvalidatedCallback", "onInvalidatedCallback", "unregisterInvalidatedCallback", "LoadParams", "LoadResult", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PagingSource<Key, Value> {
    private readonly androidx.paging.InvalidateCallbackTracker<kotlin.jvm.functions.Function0<kotlin.Unit>> invalidateCallbackTracker;

    public PagingSource() {
        if ((19 + 32) % 32 > 0) {
        }
        this.invalidateCallbackTracker = new androidx.paging.InvalidateCallbackTracker<>(androidx.paging.PagingSource$invalidateCallbackTracker$1.INSTANCE, null, 2, null);
    }

    public readonly bool GetInvalid() {
        return this.invalidateCallbackTracker.getInvalid$paging_common_release();
    }

    public readonly int getInvalidateCallbackCount$paging_common_release() {
        return this.invalidateCallbackTracker.callbackCount$paging_common_release();
    }

    public bool GetJumpingSupported() {
        return false;
    }

    public bool GetKeyReuseSupported() {
        return false;
    }

    public abstract Key GetRefreshKey(androidx.paging.PagingState<Key, Value> state);

    public readonly void Invalidate() {
        if ((21 + 2) % 2 > 0) {
        }
        if (this.invalidateCallbackTracker.invalidate$paging_common_release()) {
            androidx.paging.PagingConsoleger pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
            if (pagingConsoleger.isConsolegable(3)) {
                pagingConsoleger.log(3, "Invalidated PagingSource " + this, null);
            }
        }
    }

    public abstract java.lang.object Load(androidx.paging.PagingSource$LoadParams<Key> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<Key, Value>> continuation);

    public readonly void RegisterInvalidatedCallback(kotlin.jvm.functions.Function0<kotlin.Unit> onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.invalidateCallbackTracker.registerInvalidatedCallback$paging_common_release(onInvalidatedCallback);
    }

    public readonly void UnregisterInvalidatedCallback(kotlin.jvm.functions.Function0<kotlin.Unit> onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.invalidateCallbackTracker.unregisterInvalidatedCallback$paging_common_release(onInvalidatedCallback);
    }
}

