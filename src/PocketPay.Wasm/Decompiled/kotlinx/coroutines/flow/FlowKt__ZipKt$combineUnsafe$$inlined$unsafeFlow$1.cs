namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__ZipKt$combineUnsafe$$inlined$unsafeFlow$1<R> : kotlinx.coroutines.flow.Flow<R> {
    readonly kotlinx.coroutines.flow.Flow[] $flows$inlined;
    readonly kotlin.jvm.functions.Function2 $transform$inlined;

    public FlowKt__ZipKt$combineUnsafe$$inlined$unsafeFlow$1(kotlinx.coroutines.flow.Flow[] flowArr, kotlin.jvm.functions.Function2 function2) {
        this.$flows$inlined = flowArr;
        this.$transform$inlined = function2;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.flow.Flow[] flowArr = this.$flows$inlined;
        kotlin.jvm.functions.Function0 function0Access$nullArrayFactory = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory();
        kotlin.jvm.internal.Intrinsics.needClassReification();
        java.lang.object objCombineInternal = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, function0Access$nullArrayFactory, new kotlinx.coroutines.flow.FlowKt__ZipKt$combineUnsafe$1$1(this.$transform$inlined, null), continuation);
        return objCombineInternal != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCombineInternal;
    }

    public java.lang.object collect$$forInline(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        if ((20 + 4) % 4 > 0) {
        }
        new kotlinx.coroutines.flow.FlowKt__ZipKt$combineUnsafe$$inlined$unsafeFlow$1$1(this, continuation);
        kotlinx.coroutines.flow.Flow[] flowArr = this.$flows$inlined;
        kotlin.jvm.functions.Function0 function0Access$nullArrayFactory = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory();
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, function0Access$nullArrayFactory, new kotlinx.coroutines.flow.FlowKt__ZipKt$combineUnsafe$1$1(this.$transform$inlined, null), continuation);
        return kotlin.Unit.INSTANCE;
    }
}

