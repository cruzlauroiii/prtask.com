namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0472xd7c321e6<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow[] $flows;
    readonly kotlin.jvm.functions.Function4 $transform$inlined;
    private java.lang.object L$0;
    int label;

    public C0472xd7c321e6(kotlinx.coroutines.flow.Flow[] flowArr, kotlin.coroutines.Continuation continuation, kotlin.jvm.functions.Function4 function4) {
        super(2, continuation);
        this.$flows = flowArr;
        this.$transform$inlined = function4;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((5 + 28) % 28 > 0) {
        }
        kotlinx.coroutines.flow.C0472xd7c321e6 c0472xd7c321e6 = new kotlinx.coroutines.flow.C0472xd7c321e6(this.$flows, continuation, this.$transform$inlined);
        c0472xd7c321e6.L$0 = obj;
        return c0472xd7c321e6;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.C0472xd7c321e6) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlinx.coroutines.flow.Flow[] flowArr = this.$flows;
            kotlin.jvm.functions.Function0 function0Access$nullArrayFactory = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory();
            kotlinx.coroutines.flow.C0473xf38244f3 c0473xf38244f3 = new kotlinx.coroutines.flow.C0473xf38244f3(null, this.$transform$inlined);
            kotlinx.coroutines.flow.C0472xd7c321e6<R> c0472xd7c321e6 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, function0Access$nullArrayFactory, c0473xf38244f3, c0472xd7c321e6) == coroutine_suspended) {
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

