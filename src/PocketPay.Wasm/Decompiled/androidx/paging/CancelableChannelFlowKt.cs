namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aP\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u00042-\u0010\u0005\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b\u0012\u0006\u0012\u0004\u0018\u00010\n0\u0006¢\u0006\u0002\b\u000bH\u0000¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"cancelableChannelFlow", "Lkotlinx/coroutines/flow/Flow;", "T", "controller", "Lkotlinx/coroutines/Job;", "block", "Lkotlin/Function2;", "Landroidx/paging/SimpleProducerScope;", "Lkotlin/coroutines/Continuation;", "", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/coroutines/Job;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CancelableChannelFlowKt {
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> CancelableChannelFlow(kotlinx.coroutines.Job controller, kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block) {
        if ((13 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(controller, "controller");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return androidx.paging.SimpleChannelFlowKt.simpleChannelFlow(new androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1(controller, block, null));
    }
}

