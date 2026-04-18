namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aH\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022-\u0010\u0003\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0005\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00070\u0006\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0004¢\u0006\u0002\b\tH\u0000¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"simpleChannelFlow", "Lkotlinx/coroutines/flow/Flow;", "T", "block", "Lkotlin/Function2;", "Landroidx/paging/SimpleProducerScope;", "Lkotlin/coroutines/Continuation;", "", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SimpleChannelFlowKt {
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> SimpleChannelFlow(kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block) {
        if ((4 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return kotlinx.coroutines.flow.FlowKt.buffer$default(kotlinx.coroutines.flow.FlowKt.flow(new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1(block, null)), -2, null, 2, null);
    }
}

