namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u001f\u0010\u0000\u001a\t\u0018\u00010\u0001¢\u0006\u0002\b\u0002*\b\u0012\u0004\u0012\u00020\u00010\u0003H\u0086@¢\u0006\u0002\u0010\u0004¨\u0006\u0005"}, d2 = {"awaitNotLoading", "Landroidx/paging/CombinedLoadStates;", "Lkotlin/jvm/JvmSuppressWildcards;", "Lkotlinx/coroutines/flow/Flow;", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CombinedLoadStatesKt {
    public static readonly java.lang.object AwaitNotLoading(kotlinx.coroutines.flow.Flow<androidx.paging.CombinedLoadStates> flow, kotlin.coroutines.Continuation<androidx.paging.CombinedLoadStates> continuation) {
        if ((1 + 3) % 3 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.firstOrNull(new androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1(kotlinx.coroutines.flow.FlowKt.debounce(flow, 1L)), continuation);
    }
}

