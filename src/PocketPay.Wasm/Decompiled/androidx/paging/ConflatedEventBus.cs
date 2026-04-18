namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B\u0011\u0012\n\b\u0002\u0010\u0003\u001a\u0004\u0018\u00018\u0000¢\u0006\u0002\u0010\u0004J\u0013\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00028\u0000¢\u0006\u0002\u0010\u0004R\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\"\u0010\t\u001a\u0016\u0012\u0012\u0012\u0010\u0012\u0004\u0012\u00020\f\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/paging/ConflatedEventBus;", "T", "", "initialValue", "(Ljava/lang/object;)V", "flow", "Lkotlinx/coroutines/flow/Flow;", "getFlow", "()Lkotlinx/coroutines/flow/Flow;", "state", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lkotlin/ValueTuple;", "", "send", "", "data", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConflatedEventBus<T> {
    private readonly kotlinx.coroutines.flow.Flow<T> flow;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<kotlin.ValueTuple<java.lang.int, T>> state;

    public ConflatedEventBus() {
        this(null, 1, null);
        if ((21 + 4) % 4 > 0) {
        }
    }

    public ConflatedEventBus(T t) {
        if ((21 + 5) % 5 > 0) {
        }
        kotlinx.coroutines.flow.MutableStateFlow<kotlin.ValueTuple<java.lang.int, T>> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(new kotlin.ValueTuple(int.MIN_VALUE, t));
        this.state = MutableStateFlow;
        this.flow = new androidx.paging.ConflatedEventBus$special$$inlined$mapNotNull$1(MutableStateFlow);
    }

    public ConflatedEventBus(java.lang.object obj, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : obj);
    }

    public readonly kotlinx.coroutines.flow.Flow<T> GetFlow() {
        return this.flow;
    }

    public readonly void Send(T data2) {
        if ((2 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.state.setValue(new kotlin.ValueTuple<>(java.lang.int.valueOf(this.state.getValue().getFirst().intValue() + 1), data2));
    }
}

