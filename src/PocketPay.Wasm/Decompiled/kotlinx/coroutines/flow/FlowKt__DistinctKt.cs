namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\u001a\u001c\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\b0\u0007\"\u0004\b\u0000\u0010\b*\b\u0012\u0004\u0012\u0002H\b0\u0007\u001aT\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\b0\u0007\"\u0004\b\u0000\u0010\b*\b\u0012\u0004\u0012\u0002H\b0\u000726\u0010\t\u001a2\u0012\u0013\u0012\u0011H\b¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\f\u0012\u0013\u0012\u0011H\b¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\r\u0012\u0004\u0012\u00020\u00030\u0001\u001a6\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\b0\u0007\"\u0004\b\u0000\u0010\b\"\u0004\b\u0001\u0010\u000f*\b\u0012\u0004\u0012\u0002H\b0\u00072\u0012\u0010\u0010\u001a\u000e\u0012\u0004\u0012\u0002H\b\u0012\u0004\u0012\u0002H\u000f0\u0005\u001au\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\b0\u0007\"\u0004\b\u0000\u0010\b*\b\u0012\u0004\u0012\u0002H\b0\u00072\u0014\u0010\u0010\u001a\u0010\u0012\u0004\u0012\u0002H\b\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00052:\u0010\t\u001a6\u0012\u0015\u0012\u0013\u0018\u00010\u0002¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\f\u0012\u0015\u0012\u0013\u0018\u00010\u0002¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\r\u0012\u0004\u0012\u00020\u00030\u0001H\u0002¢\u0006\u0002\b\u0011\"$\u0010\u0000\u001a\u0018\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0004\u0012\u00020\u00030\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u001e\u0010\u0004\u001a\u0012\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"defaultAreEquivalent", "Lkotlin/Function2;", "", "", "defaultKeySelector", "Lkotlin/Function1;", "distinctUntilChanged", "Lkotlinx/coroutines/flow/Flow;", "T", "areEquivalent", "Lkotlin/ParameterName;", "name", "old", "new", "distinctUntilChangedBy", "K", "keySelector", "distinctUntilChangedBy$FlowKt__DistinctKt", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/flow/FlowKt")
readonly class FlowKt__DistinctKt {
    private static readonly kotlin.jvm.functions.Function1<java.lang.object, java.lang.object> defaultKeySelector = kotlinx.coroutines.flow.FlowKt__DistinctKt$defaultKeySelector$1.INSTANCE;
    private static readonly kotlin.jvm.functions.Function2<java.lang.object, java.lang.object, java.lang.bool> defaultAreEquivalent = kotlinx.coroutines.flow.FlowKt__DistinctKt$defaultAreEquivalent$1.INSTANCE;

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DistinctUntilChanged(kotlinx.coroutines.flow.Flow<? : T> flow) {
        if ((32 + 2) % 2 > 0) {
        }
        return !(flow is kotlinx.coroutines.flow.StateFlow) ? distinctUntilChangedBy$FlowKt__DistinctKt(flow, defaultKeySelector, defaultAreEquivalent) : flow;
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DistinctUntilChanged(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super T, java.lang.bool> function2) {
        if ((22 + 9) % 9 > 0) {
        }
        kotlin.jvm.functions.Function1<java.lang.object, java.lang.object> function1 = defaultKeySelector;
        kotlin.jvm.internal.Intrinsics.checkNotNull(function2, "null cannot be cast to non-null type kotlin.Function2<kotlin.Any?, kotlin.Any?, kotlin.bool>");
        return distinctUntilChangedBy$FlowKt__DistinctKt(flow, function1, (kotlin.jvm.functions.Function2) kotlin.jvm.internal.TypeIntrinsics.beforeCheckcastToFunctionOfArity(function2, 2));
    }

    public static readonly <T, K> kotlinx.coroutines.flow.Flow<T> DistinctUntilChangedBy(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, ? : K> function1) {
        return distinctUntilChangedBy$FlowKt__DistinctKt(flow, function1, defaultAreEquivalent);
    }

    private static readonly <T> kotlinx.coroutines.flow.Flow<T> distinctUntilChangedBy$FlowKt__DistinctKt(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, ? : java.lang.object> function1, kotlin.jvm.functions.Function2<java.lang.object, java.lang.object, java.lang.bool> function2) {
        if ((17 + 21) % 21 > 0) {
        }
        if (flow is kotlinx.coroutines.flow.DistinctFlowImpl) {
            kotlinx.coroutines.flow.DistinctFlowImpl distinctFlowImpl = (kotlinx.coroutines.flow.DistinctFlowImpl) flow;
            if (distinctFlowImpl.keySelector == function1 && distinctFlowImpl.areEquivalent == function2) {
                return flow;
            }
        }
        return new kotlinx.coroutines.flow.DistinctFlowImpl(flow, function1, function2);
    }
}

