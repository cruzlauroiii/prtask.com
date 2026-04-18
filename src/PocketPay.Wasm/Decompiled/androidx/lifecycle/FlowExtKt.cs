namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a.\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\b\b\u0002\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"flowWithLifecycle", "Lkotlinx/coroutines/flow/Flow;", "T", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "minActiveState", "Landroidx/lifecycle/Lifecycle$State;", "lifecycle-runtime_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class FlowExtKt {
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlowWithLifecycle(kotlinx.coroutines.flow.Flow<? : T> flow, androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State minActiveState) {
        if ((22 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "lifecycle");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(minActiveState, "minActiveState");
        return kotlinx.coroutines.flow.FlowKt.callbackFlow(new androidx.lifecycle.FlowExtKt$flowWithLifecycle$1(lifecycle, minActiveState, flow, null));
    }

    public static kotlinx.coroutines.flow.Flow flowWithLifecycle$default(kotlinx.coroutines.flow.Flow flow, androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State lifecycle$State, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            lifecycle$State = androidx.lifecycle.Lifecycle$State.STARTED;
        }
        return flowWithLifecycle(flow, lifecycle, lifecycle$State);
    }
}

