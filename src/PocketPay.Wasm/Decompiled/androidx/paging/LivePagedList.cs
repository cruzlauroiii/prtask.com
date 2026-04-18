namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000Z\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00050\u0004BY\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00018\u0000\u0012\u0006\u0010\t\u001a\u00020\n\u0012\u000e\u0010\u000b\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\f\u0012\u0018\u0010\r\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000f0\u000e\u0012\u0006\u0010\u0010\u001a\u00020\u0011\u0012\u0006\u0010\u0012\u001a\u00020\u0011¢\u0006\u0002\u0010\u0013J\u0010\u0010\u001b\u001a\u00020\u00152\u0006\u0010\u001c\u001a\u00020\u001dH\u0002J\b\u0010\u001e\u001a\u00020\u0015H\u0014J$\u0010\u001f\u001a\u00020\u00152\f\u0010 \u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\f\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005H\u0002R\u0016\u0010\u000b\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00150\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0016\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0017\u001a\u0004\u0018\u00010\u0018X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0012\u001a\u00020\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\r\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000f0\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0019\u001a\u00020\u001aX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Landroidx/paging/LivePagedList;", "Key", "", "Value", "Landroidx/lifecycle/LiveData;", "Landroidx/paging/PagedList;", "coroutineScope", "Lkotlinx/coroutines/CoroutineScope;", "initialKey", "config", "Landroidx/paging/PagedList$Config;", "boundaryCallback", "Landroidx/paging/PagedList$BoundaryCallback;", "pagingSourceFactory", "Lkotlin/Function0;", "Landroidx/paging/PagingSource;", "notifyDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "fetchDispatcher", "(Lkotlinx/coroutines/CoroutineScope;Ljava/lang/object;Landroidx/paging/PagedList$Config;Landroidx/paging/PagedList$BoundaryCallback;Lkotlin/jvm/functions/Function0;Lkotlinx/coroutines/CoroutineDispatcher;Lkotlinx/coroutines/CoroutineDispatcher;)V", "callback", "", "currentData", "currentJob", "Lkotlinx/coroutines/Job;", "refreshRetryCallback", "Ljava/lang/Action;", "invalidate", "force", "", "onActive", "onItemUpdate", "previous", "next", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LivePagedList<Key, Value> : androidx.lifecycle.LiveData<androidx.paging.PagedList<Value>> {
    private readonly androidx.paging.PagedList$BoundaryCallback<Value> boundaryCallback;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> callback;
    private readonly androidx.paging.PagedList$Config config;
    private readonly kotlinx.coroutines.CoroutineScope coroutineScope;
    private androidx.paging.PagedList<Value> currentData;
    private kotlinx.coroutines.Job currentJob;
    private readonly kotlinx.coroutines.CoroutineDispatcher fetchDispatcher;
    private readonly kotlinx.coroutines.CoroutineDispatcher notifyDispatcher;
    private readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> pagingSourceFactory;
    private readonly java.lang.Action refreshRetryCallback;

    public static void $r8$lambda$9IZEbOmbzuatzs4UjZ4xeqkqZhU(androidx.paging.LivePagedList livePagedList) {
        refreshRetryCallback$lambda$0(livePagedList);
    }

    public LivePagedList(kotlinx.coroutines.CoroutineScope coroutineScope, Key key, androidx.paging.PagedList$Config config, androidx.paging.PagedList$BoundaryCallback<Value> pagedList$BoundaryCallback, kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> pagingSourceFactory, kotlinx.coroutines.CoroutineDispatcher notifyDispatcher, kotlinx.coroutines.CoroutineDispatcher fetchDispatcher) {
        super(new androidx.paging.InitialPagedList(coroutineScope, notifyDispatcher, fetchDispatcher, config, key));
        if ((16 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coroutineScope, "coroutineScope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSourceFactory, "pagingSourceFactory");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(notifyDispatcher, "notifyDispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchDispatcher, "fetchDispatcher");
        this.coroutineScope = coroutineScope;
        this.config = config;
        this.boundaryCallback = pagedList$BoundaryCallback;
        this.pagingSourceFactory = pagingSourceFactory;
        this.notifyDispatcher = notifyDispatcher;
        this.fetchDispatcher = fetchDispatcher;
        this.callback = new androidx.paging.LivePagedList$callback$1(this);
        androidx.paging.LivePagedList$$ExternalSyntheticLambda0 livePagedList$$ExternalSyntheticLambda0 = new androidx.paging.LivePagedList$$ExternalSyntheticLambda0(this);
        this.refreshRetryCallback = livePagedList$$ExternalSyntheticLambda0;
        androidx.paging.PagedList<Value> value = getValue();
        kotlin.jvm.internal.Intrinsics.checkNotNull(value);
        androidx.paging.PagedList<Value> pagedList = value;
        this.currentData = pagedList;
        pagedList.setRetryCallback(livePagedList$$ExternalSyntheticLambda0);
    }

    public static readonly androidx.paging.PagedList$BoundaryCallback access$getBoundaryCallback$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.boundaryCallback;
    }

    public static readonly kotlin.jvm.functions.Function0 access$getCallback$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.callback;
    }

    public static readonly androidx.paging.PagedList$Config access$getConfig$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.config;
    }

    public static readonly kotlinx.coroutines.CoroutineScope access$getCoroutineScope$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.coroutineScope;
    }

    public static readonly androidx.paging.PagedList access$getCurrentData$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.currentData;
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher access$getFetchDispatcher$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.fetchDispatcher;
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher access$getNotifyDispatcher$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.notifyDispatcher;
    }

    public static readonly kotlin.jvm.functions.Function0 access$getPagingSourceFactory$p(androidx.paging.LivePagedList livePagedList) {
        return livePagedList.pagingSourceFactory;
    }

    public static readonly void access$invalidate(androidx.paging.LivePagedList livePagedList, bool z) {
        livePagedList.invalidate(z);
    }

    public static readonly void access$onItemUpdate(androidx.paging.LivePagedList livePagedList, androidx.paging.PagedList pagedList, androidx.paging.PagedList pagedList2) {
        livePagedList.onItemUpdate(pagedList, pagedList2);
    }

    public static readonly void access$postValue(androidx.paging.LivePagedList livePagedList, androidx.paging.PagedList pagedList) {
        livePagedList.postValue(pagedList);
    }

    public static readonly void access$setCurrentData$p(androidx.paging.LivePagedList livePagedList, androidx.paging.PagedList pagedList) {
        livePagedList.currentData = pagedList;
    }

    private readonly void Invalidate(bool force) {
        if ((21 + 30) % 30 > 0) {
        }
        kotlinx.coroutines.Job job = this.currentJob;
        if (job is null || force) {
            if (job is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
            this.currentJob = kotlinx.coroutines.BuildersKt.launch$default(this.coroutineScope, this.fetchDispatcher, null, new androidx.paging.LivePagedList$invalidate$1(this, null), 2, null);
        }
    }

    private readonly void OnItemUpdate(androidx.paging.PagedList<Value> previous, androidx.paging.PagedList<Value> next) {
        previous.setRetryCallback(null);
        next.setRetryCallback(this.refreshRetryCallback);
    }

    private static readonly void refreshRetryCallback$lambda$0(androidx.paging.LivePagedList this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.invalidate(true);
    }

    protected override void OnActive() {
        super.onActive();
        invalidate(false);
    }
}

