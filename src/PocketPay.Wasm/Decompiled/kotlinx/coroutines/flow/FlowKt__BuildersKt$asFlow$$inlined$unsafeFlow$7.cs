namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7 : kotlinx.coroutines.flow.Flow<java.lang.int> {
    readonly int[] $this_asFlow$inlined;

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7(int[] iArr) {
        this.$this_asFlow$inlined = iArr;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<java.lang.int> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1 flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1;
        int length;
        int[] iArr;
        kotlinx.coroutines.flow.FlowCollector flowCollector2;
        int i;
        if ((26 + 13) % 13 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1) {
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1 = (kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1) continuation;
            if ((flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.label & int.MIN_VALUE) == 0) {
                flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1(this, continuation);
            } else {
                flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1(this, continuation);
        }
        java.lang.object obj = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.label;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            int[] iArr2 = this.$this_asFlow$inlined;
            iArr = iArr2;
            length = iArr2.length;
            flowCollector2 = flowCollector;
            i = 0;
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            length = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.I$1;
            int i3 = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.I$0;
            iArr = (int[]) flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.L$1;
            kotlinx.coroutines.flow.FlowCollector flowCollector3 = (kotlinx.coroutines.flow.FlowCollector) flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            flowCollector2 = flowCollector3;
            i = i3 + 1;
        }
        while (i < length) {
            java.lang.int numBoxInt = kotlin.coroutines.jvm.internal.Boxing.boxInt(iArr[i]);
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.L$0 = flowCollector2;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.L$1 = iArr;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.I$0 = i;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.I$1 = length;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1.label = 1;
            if (flowCollector2.emit(numBoxInt, flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$7$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            i++;
        }
        return kotlin.Unit.INSTANCE;
    }
}

