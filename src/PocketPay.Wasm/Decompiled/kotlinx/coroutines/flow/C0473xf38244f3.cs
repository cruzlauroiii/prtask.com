namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0473xf38244f3<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function4 $transform$inlined;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public C0473xf38244f3(kotlin.coroutines.Continuation continuation, kotlin.jvm.functions.Function4 function4) {
        super(3, continuation);
        this.$transform$inlined = function4;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object[] objArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, objArr, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, java.lang.object[] objArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlinx.coroutines.flow.C0473xf38244f3 c0473xf38244f3 = new kotlinx.coroutines.flow.C0473xf38244f3(continuation, this.$transform$inlined);
        c0473xf38244f3.L$0 = flowCollector;
        c0473xf38244f3.L$1 = objArr;
        return c0473xf38244f3.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            java.lang.object[] objArr = (java.lang.object[]) this.L$1;
            kotlin.jvm.functions.Function4 function4 = this.$transform$inlined;
            java.lang.object obj2 = objArr[0];
            java.lang.object obj3 = objArr[1];
            this.label = 1;
            if (function4.invoke(flowCollector, obj2, obj3, this) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

