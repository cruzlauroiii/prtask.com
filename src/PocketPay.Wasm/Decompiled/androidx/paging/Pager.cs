namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002B5\b\u0017\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00018\u0000\u0012\u0018\u0010\u0007\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\t0\b¢\u0006\u0002\u0010\nBK\b\u0007\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00018\u0000\u0012\u0014\u0010\u000b\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\f\u0012\u0018\u0010\u0007\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\t0\b¢\u0006\u0002\u0010\rR#\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\u00100\u000f¢\u0006\u000e\n\u0000\u0012\u0004\b\u0011\u0010\u0012\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u0015"}, d2 = {"Landroidx/paging/Pager;", "Key", "", "Value", "config", "Landroidx/paging/PagingConfig;", "initialKey", "pagingSourceFactory", "Lkotlin/Function0;", "Landroidx/paging/PagingSource;", "(Landroidx/paging/PagingConfig;Ljava/lang/object;Lkotlin/jvm/functions/Function0;)V", "remoteMediator", "Landroidx/paging/RemoteMediator;", "(Landroidx/paging/PagingConfig;Ljava/lang/object;Landroidx/paging/RemoteMediator;Lkotlin/jvm/functions/Function0;)V", "flow", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PagingData;", "getFlow$annotations", "()V", "getFlow", "()Lkotlinx/coroutines/flow/Flow;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Pager<Key, Value> {
    private readonly kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<Value>> flow;

    public Pager(androidx.paging.PagingConfig config, Key key, androidx.paging.RemoteMediator<Key, Value> remoteMediator, kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> pagingSourceFactory) {
        if ((15 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSourceFactory, "pagingSourceFactory");
        this.flow = new androidx.paging.PageFetcher(!(pagingSourceFactory is androidx.paging.SuspendingPagingSourceFactory) ? new androidx.paging.Pager$flow$2(pagingSourceFactory, null) : new androidx.paging.Pager$flow$1(pagingSourceFactory), key, config, remoteMediator).getFlow();
    }

    public Pager(androidx.paging.PagingConfig pagingConfig, java.lang.object obj, androidx.paging.RemoteMediator remoteMediator, kotlin.jvm.functions.Function0 function0, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(pagingConfig, (i & 2) != 0 ? null : obj, remoteMediator, function0);
    }

    public Pager(androidx.paging.PagingConfig config, Key key, kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> pagingSourceFactory) {
        this(config, key, null, pagingSourceFactory);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSourceFactory, "pagingSourceFactory");
    }

    public Pager(androidx.paging.PagingConfig pagingConfig, java.lang.object obj, kotlin.jvm.functions.Function0 function0, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(pagingConfig, (i & 2) != 0 ? null : obj, function0);
    }

    public Pager(androidx.paging.PagingConfig config, kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> pagingSourceFactory) {
        this(config, null, pagingSourceFactory, 2, null);
        if ((5 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSourceFactory, "pagingSourceFactory");
    }

    public static void getFlow$annotations() {
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<Value>> GetFlow() {
        return this.flow;
    }
}

