namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\t"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$$inlined$unsafeFlow$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1 : kotlinx.coroutines.flow.Flow<pd2a57dc1.p2486923a.p9c70933a.p74c9efb4> {
    readonly kotlinx.coroutines.flow.Flow $this_unsafeTransform$inlined;

    public pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1(kotlinx.coroutines.flow.Flow flow) {
        this.$this_unsafeTransform$inlined = flow;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<pd2a57dc1.p2486923a.p9c70933a.p74c9efb4> flowCollector, kotlin.coroutines.Continuation continuation) {
        java.lang.object objCollect = this.$this_unsafeTransform$inlined.collect(new pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2(flowCollector), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }
}

