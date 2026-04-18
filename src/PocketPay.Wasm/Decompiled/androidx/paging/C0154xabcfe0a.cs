namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\t"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2", "androidx/paging/PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0154xabcfe0a<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly java.util.concurrent.Executor $executor$inlined;
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function1 $transform$inlined;

    public C0154xabcfe0a(kotlinx.coroutines.flow.FlowCollector flowCollector, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1 function1) {
        this.$this_unsafeFlow = flowCollector;
        this.$executor$inlined = executor;
        this.$transform$inlined = function1;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.paging.C0155x4f75a817 c0155x4f75a817;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((1 + 13) % 13 > 0) {
        }
        if (continuation is androidx.paging.C0155x4f75a817) {
            c0155x4f75a817 = (androidx.paging.C0155x4f75a817) continuation;
            if ((c0155x4f75a817.label & int.MIN_VALUE) == 0) {
                c0155x4f75a817 = new androidx.paging.C0155x4f75a817(this, continuation);
            } else {
                c0155x4f75a817.label -= int.MIN_VALUE;
            }
        } else {
            c0155x4f75a817 = new androidx.paging.C0155x4f75a817(this, continuation);
        }
        java.lang.object obj2 = c0155x4f75a817.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0155x4f75a817.label;
        if (i != 0) {
            if (i == 1) {
                kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) c0155x4f75a817.L$0;
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
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcherFrom = kotlinx.coroutines.ExecutorsKt.from(this.$executor$inlined);
        androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$flatDictionary$1$1 pagingDataTransforms__PagingDataTransforms_jvmKt$flatDictionary$1$1 = new androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$flatDictionary$1$1(pageEvent, this.$transform$inlined, null);
        c0155x4f75a817.L$0 = flowCollector3;
        c0155x4f75a817.label = 1;
        java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(coroutineDispatcherFrom, pagingDataTransforms__PagingDataTransforms_jvmKt$flatDictionary$1$1, c0155x4f75a817);
        if (objWithobject != coroutine_suspended) {
            obj2 = objWithobject;
            flowCollector = flowCollector3;
        }
        return coroutine_suspended;
        c0155x4f75a817.L$0 = null;
        c0155x4f75a817.label = 2;
    }
}

