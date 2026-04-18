namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7", m533f = "Zip.kt", m534i = {}, m535l = {308}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowKt__ZipKt$combineTransform$7<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T>[] $flowArray;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;

    public FlowKt__ZipKt$combineTransform$7(kotlinx.coroutines.flow.Flow<T>[] flowArr, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T[], ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7> continuation) {
        super(2, continuation);
        this.$flowArray = flowArr;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((1 + 26) % 26 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7 flowKt__ZipKt$combineTransform$7 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7(this.$flowArray, this.$transform, continuation);
        flowKt__ZipKt$combineTransform$7.L$0 = obj;
        return flowKt__ZipKt$combineTransform$7;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlinx.coroutines.flow.Flow<T>[] flowArr = this.$flowArray;
            kotlin.jvm.internal.Intrinsics.needClassReification();
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$1 flowKt__ZipKt$combineTransform$7$1 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$1(this.$flowArray);
            kotlin.jvm.internal.Intrinsics.needClassReification();
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$2 flowKt__ZipKt$combineTransform$7$2 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$2(this.$transform, null);
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7<R> flowKt__ZipKt$combineTransform$7 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, flowKt__ZipKt$combineTransform$7$1, flowKt__ZipKt$combineTransform$7$2, flowKt__ZipKt$combineTransform$7) == coroutine_suspended) {
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
        if ((17 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
        kotlinx.coroutines.flow.Flow<T>[] flowArr = this.$flowArray;
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$1 flowKt__ZipKt$combineTransform$7$1 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$1(this.$flowArray);
        kotlin.jvm.internal.Intrinsics.needClassReification();
        kotlinx.coroutines.flow.internal.CombineKt.combineInternal(flowCollector, flowArr, flowKt__ZipKt$combineTransform$7$1, new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$7$2(this.$transform, null), this);
        return kotlin.Unit.INSTANCE;
    }
}

