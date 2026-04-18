namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\b"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core", "kotlinx/coroutines/flow/FlowKt__ZipKt$combine$$inlined$unsafeFlow$3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkConstraintsTracker$track$$inlined$combine$1 : kotlinx.coroutines.flow.Flow<androidx.work.impl.constraints.ConstraintsState> {
    readonly kotlinx.coroutines.flow.Flow[] $flowArray$inlined;

    public WorkConstraintsTracker$track$$inlined$combine$1(kotlinx.coroutines.flow.Flow[] flowArr) {
        this.$flowArray$inlined = flowArr;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<androidx.work.impl.constraints.ConstraintsState> flowCollector, kotlin.coroutines.Continuation continuation) {
        if ((20 + 20) % 20 > 0) {
        }
        java.lang.object objCombineInternal = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, this.$flowArray$inlined, new androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$2(this.$flowArray$inlined), new androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$3(null), continuation);
        return objCombineInternal != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCombineInternal;
    }
}

