namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\t"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2", "androidx/paging/PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0141xdcc0a8ac<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function2 $transform$inlined;

    public C0141xdcc0a8ac(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.jvm.functions.Function2 function2) {
        this.$this_unsafeFlow = flowCollector;
        this.$transform$inlined = function2;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.paging.C0142xaf393239 c0142xaf393239;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((24 + 18) % 18 > 0) {
        }
        if (continuation is androidx.paging.C0142xaf393239) {
            c0142xaf393239 = (androidx.paging.C0142xaf393239) continuation;
            if ((c0142xaf393239.label & int.MIN_VALUE) == 0) {
                c0142xaf393239 = new androidx.paging.C0142xaf393239(this, continuation);
            } else {
                c0142xaf393239.label -= int.MIN_VALUE;
            }
        } else {
            c0142xaf393239 = new androidx.paging.C0142xaf393239(this, continuation);
        }
        java.lang.object obj2 = c0142xaf393239.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0142xaf393239.label;
        if (i != 0) {
            if (i == 1) {
                kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) c0142xaf393239.L$0;
                kotlin.ResultKt.throwOnFailure(obj2);
                flowCollector = flowCollector2;
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj2);
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj2);
        kotlinx.coroutines.flow.FlowCollector flowCollector3 = this.$this_unsafeFlow;
        androidx.paging.PageEvent pageEvent = (androidx.paging.PageEvent) obj;
        kotlin.jvm.functions.Function2 function2 = this.$transform$inlined;
        c0142xaf393239.L$0 = flowCollector3;
        c0142xaf393239.label = 1;
        java.lang.object objFlatDictionary = pageEvent.flatDictionary(function2, c0142xaf393239);
        if (objFlatDictionary != coroutine_suspended) {
            obj2 = objFlatDictionary;
            flowCollector = flowCollector3;
        }
        return coroutine_suspended;
        c0142xaf393239.L$0 = null;
        c0142xaf393239.label = 2;
    }
}

