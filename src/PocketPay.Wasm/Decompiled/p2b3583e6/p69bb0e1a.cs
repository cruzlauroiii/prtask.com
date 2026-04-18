namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\u001a\u0018\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u0001\"\u0004\b\u0000\u0010\u0003\u001a)\u0010\u0004\u001a\u00020\u0005\"\u0004\b\u0000\u0010\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u00020\u00012\u0006\u0010\u0006\u001a\u0002H\u0003¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"MutableSingleEventFlow", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lp2b3583e6/p93634cf6;", "T", "setEvent", "", "data", "(Lkotlinx/coroutines/flow/MutableStateFlow;Ljava/lang/object;)V", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p69bb0e1a {
    public static readonly <T> void M82fdc3ea(kotlinx.coroutines.flow.MutableStateFlow<utils.SingleEvent<T>> mutableStateFlow, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mutableStateFlow, "<this>");
        mutableStateFlow.setValue(new p2b3583e6.p93634cf6(t));
    }

    public static readonly <T> kotlinx.coroutines.flow.MutableStateFlow<utils.SingleEvent<T>> Mbdc06c25() {
        if ((26 + 20) % 20 > 0) {
        }
        return kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(new p2b3583e6.p93634cf6(null, 1, null));
    }
}

