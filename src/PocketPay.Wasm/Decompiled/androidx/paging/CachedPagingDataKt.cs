namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a6\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u0006H\u0007\u001aB\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u00062\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0000¨\u0006\t"}, d2 = {"cachedIn", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PagingData;", "T", "", "scope", "Lkotlinx/coroutines/CoroutineScope;", "tracker", "Landroidx/paging/ActiveFlowTracker;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CachedPagingDataKt {
    public static readonly <T> kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<T>> CachedIn(kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<T>> flow, kotlinx.coroutines.CoroutineScope scope) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        return cachedIn(flow, scope, null);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<T>> CachedIn(kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<T>> flow, kotlinx.coroutines.CoroutineScope scope, androidx.paging.ActiveFlowTracker activeFlowTracker) {
        if ((30 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        return kotlinx.coroutines.flow.FlowKt.shareIn(kotlinx.coroutines.flow.FlowKt.onCompletion(kotlinx.coroutines.flow.FlowKt.onStart(new androidx.paging.CachedPagingDataKt$cachedIn$$inlined$map$1(androidx.paging.FlowExtKt.simpleRunningReduce(androidx.paging.FlowExtKt.simpleTransformLatest(flow, new androidx.paging.CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1(null, scope, activeFlowTracker)), new androidx.paging.CachedPagingDataKt$cachedIn$2(null))), new androidx.paging.CachedPagingDataKt$cachedIn$4(activeFlowTracker, null)), new androidx.paging.CachedPagingDataKt$cachedIn$5(activeFlowTracker, null)), scope, kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), 1);
    }

    public static kotlinx.coroutines.flow.Flow cachedIn$default(kotlinx.coroutines.flow.Flow flow, kotlinx.coroutines.CoroutineScope coroutineScope, androidx.paging.ActiveFlowTracker activeFlowTracker, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            activeFlowTracker = null;
        }
        return cachedIn(flow, coroutineScope, activeFlowTracker);
    }
}

