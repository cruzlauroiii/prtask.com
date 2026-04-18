namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\n"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$$inlined$unsafeFlow$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1", "androidx/paging/PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class C0153x4f65287c<R> : kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<R>> {
    readonly java.util.concurrent.Executor $executor$inlined;
    readonly kotlinx.coroutines.flow.Flow $this_unsafeTransform$inlined;
    readonly kotlin.jvm.functions.Function1 $transform$inlined$1;

    public C0153x4f65287c(kotlinx.coroutines.flow.Flow flow, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1 function1) {
        this.$this_unsafeTransform$inlined = flow;
        this.$executor$inlined = executor;
        this.$transform$inlined$1 = function1;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        if ((12 + 15) % 15 > 0) {
        }
        java.lang.object objCollect = this.$this_unsafeTransform$inlined.collect(new androidx.paging.C0154xabcfe0a(flowCollector, this.$executor$inlined, this.$transform$inlined$1), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }
}

