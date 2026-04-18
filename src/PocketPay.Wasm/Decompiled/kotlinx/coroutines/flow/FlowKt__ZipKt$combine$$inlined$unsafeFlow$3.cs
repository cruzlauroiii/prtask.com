namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__ZipKt$combine$$inlined$unsafeFlow$3<R> : kotlinx.coroutines.flow.Flow<R> {
    readonly kotlinx.coroutines.flow.Flow[] $flowArray$inlined;
    readonly kotlin.jvm.functions.Function2 $transform$inlined;

    public FlowKt__ZipKt$combine$$inlined$unsafeFlow$3(kotlinx.coroutines.flow.Flow[] flowArr, kotlin.jvm.functions.Function2 function2) {
        this.$flowArray$inlined = flowArr;
        this.$transform$inlined = function2;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((18 + 29) % 29 > 0) {
        }
        kotlinx.coroutines.flow.Flow[] flowArr = this.$flowArray$inlined;
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$1 flowKt__ZipKt$combine$6$1 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$1(this.$flowArray$inlined);
        kotlin.jvm.internal.Intrinsics.needClassReification();
        java.lang.object objCombineInternal = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, flowKt__ZipKt$combine$6$1, new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$2(this.$transform$inlined, null), continuation);
        return objCombineInternal != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCombineInternal;
    }

    public java.lang.object collect$$forInline(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        if ((2 + 18) % 18 > 0) {
        }
        new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$$inlined$unsafeFlow$3$1(this, continuation);
        kotlinx.coroutines.flow.Flow[] flowArr = this.$flowArray$inlined;
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$1 flowKt__ZipKt$combine$6$1 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$1(this.$flowArray$inlined);
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, flowKt__ZipKt$combine$6$1, new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$6$2(this.$transform$inlined, null), continuation);
        return kotlin.Unit.INSTANCE;
    }
}

