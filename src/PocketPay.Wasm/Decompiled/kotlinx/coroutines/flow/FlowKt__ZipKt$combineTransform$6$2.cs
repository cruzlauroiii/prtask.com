namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", ""}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$6$2", m533f = "Zip.kt", m534i = {}, m535l = {251}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowKt__ZipKt$combineTransform$6$2<R, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public FlowKt__ZipKt$combineTransform$6$2(kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T[], ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$6$2> continuation) {
        super(3, continuation);
        this.$transform = function3;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, (java.lang.object[]) obj2, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, T[] tArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$6$2 flowKt__ZipKt$combineTransform$6$2 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$6$2(this.$transform, continuation);
        flowKt__ZipKt$combineTransform$6$2.L$0 = flowCollector;
        flowKt__ZipKt$combineTransform$6$2.L$1 = tArr;
        return flowKt__ZipKt$combineTransform$6$2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector<R> flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            java.lang.object[] objArr = (java.lang.object[]) this.L$1;
            kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function3 = this.$transform;
            this.L$0 = null;
            this.label = 1;
            if (function3.invoke(flowCollector, objArr, this) == coroutine_suspended) {
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

    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object obj) {
        if ((32 + 5) % 5 > 0) {
        }
        this.$transform.invoke((kotlinx.coroutines.flow.FlowCollector) this.L$0, (java.lang.object[]) this.L$1, this);
        return kotlin.Unit.INSTANCE;
    }
}

