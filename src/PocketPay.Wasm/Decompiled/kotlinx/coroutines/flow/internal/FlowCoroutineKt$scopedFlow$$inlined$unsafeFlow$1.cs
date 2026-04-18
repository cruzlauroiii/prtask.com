namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowCoroutineKt$scopedFlow$$inlined$unsafeFlow$1<R> : kotlinx.coroutines.flow.Flow<R> {
    readonly kotlin.jvm.functions.Function3 $block$inlined;

    public FlowCoroutineKt$scopedFlow$$inlined$unsafeFlow$1(kotlin.jvm.functions.Function3 function3) {
        this.$block$inlined = function3;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((30 + 26) % 26 > 0) {
        }
        java.lang.object objFlowScope = kotlinx.coroutines.flow.internal.FlowCoroutineKt.flowScope(new kotlinx.coroutines.flow.internal.FlowCoroutineKt$scopedFlow$1$1(this.$block$inlined, flowCollector, null), continuation);
        return objFlowScope != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objFlowScope;
    }
}

