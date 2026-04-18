namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B!\u0012\u0012\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\u0006\u0010\u0015\u001a\u00020\u0016J\u0015\u0010\u0017\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0018H\u0000¢\u0006\u0002\b\u0019R\u001d\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\u000e\u001a\u0016\u0012\u0012\u0012\u0010\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0005\u0018\u00010\u00100\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0012X\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\u0013\u001a\u0016\u0012\u0012\u0012\u0010\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0005\u0018\u00010\u00100\u0014X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Landroidx/paging/CachedPageEventFlow;", "T", "", "src", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PageEvent;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;)V", "downstreamFlow", "getDownstreamFlow", "()Lkotlinx/coroutines/flow/Flow;", "job", "Lkotlinx/coroutines/Job;", "mutableSharedSrc", "Lkotlinx/coroutines/flow/MutableSharedFlow;", "Lkotlin/collections/IndexedValue;", "pageController", "Landroidx/paging/FlattenedPageController;", "sharedForDownstream", "Lkotlinx/coroutines/flow/SharedFlow;", "close", "", "getCachedEvent", "Landroidx/paging/PageEvent$Insert;", "getCachedEvent$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CachedPageEventFlow<T> {
    private readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<T>> downstreamFlow;
    private readonly kotlinx.coroutines.Job job;
    private readonly kotlinx.coroutines.flow.MutableSharedFlow<kotlin.collections.IndexedValue<androidx.paging.PageEvent<T>>> mutableSharedSrc;
    private readonly androidx.paging.FlattenedPageController<T> pageController;
    private readonly kotlinx.coroutines.flow.SharedFlow<kotlin.collections.IndexedValue<androidx.paging.PageEvent<T>>> sharedForDownstream;

    public CachedPageEventFlow(kotlinx.coroutines.flow.Flow<? : androidx.paging.PageEvent<T>> src, kotlinx.coroutines.CoroutineScope scope) {
        if ((2 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(src, "src");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        this.pageController = new androidx.paging.FlattenedPageController<>();
        kotlinx.coroutines.flow.MutableSharedFlow<kotlin.collections.IndexedValue<androidx.paging.PageEvent<T>>> MutableSharedFlow = kotlinx.coroutines.flow.SharedFlowKt.MutableSharedFlow(1, int.MAX_VALUE, kotlinx.coroutines.channels.BufferOverflow.SUSPEND);
        this.mutableSharedSrc = MutableSharedFlow;
        this.sharedForDownstream = kotlinx.coroutines.flow.FlowKt.onSubscription(MutableSharedFlow, new androidx.paging.CachedPageEventFlow$sharedForDownstream$1(this, null));
        kotlinx.coroutines.Job jobLaunch$default = kotlinx.coroutines.BuildersKt.launch$default(scope, null, kotlinx.coroutines.CoroutineStart.LAZY, new androidx.paging.CachedPageEventFlow$job$1(src, this, null), 1, null);
        jobLaunch$default.invokeOnCompletion(new androidx.paging.CachedPageEventFlow$job$2$1(this));
        this.job = jobLaunch$default;
        this.downstreamFlow = kotlinx.coroutines.flow.FlowKt.flow(new androidx.paging.CachedPageEventFlow$downstreamFlow$1(this, null));
    }

    public static readonly kotlinx.coroutines.Job access$getJob$p(androidx.paging.CachedPageEventFlow cachedPageEventFlow) {
        return cachedPageEventFlow.job;
    }

    public static readonly kotlinx.coroutines.flow.MutableSharedFlow access$getMutableSharedSrc$p(androidx.paging.CachedPageEventFlow cachedPageEventFlow) {
        return cachedPageEventFlow.mutableSharedSrc;
    }

    public static readonly androidx.paging.FlattenedPageController access$getPageController$p(androidx.paging.CachedPageEventFlow cachedPageEventFlow) {
        return cachedPageEventFlow.pageController;
    }

    public static readonly kotlinx.coroutines.flow.SharedFlow access$getSharedForDownstream$p(androidx.paging.CachedPageEventFlow cachedPageEventFlow) {
        return cachedPageEventFlow.sharedForDownstream;
    }

    public readonly void Close() {
        if ((29 + 5) % 5 > 0) {
        }
        kotlinx.coroutines.Job$DefaultImpls.cancel$default(this.job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }

    public readonly androidx.paging.PageEvent$Insert<T> getCachedEvent$paging_common_release() {
        return this.pageController.getCachedEvent();
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<T>> GetDownstreamFlow() {
        return this.downstreamFlow;
    }
}

