namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "it", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$1", m533f = "Share.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__ShareKt$launchSharing$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.int, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int I$0;
    int label;

    FlowKt__ShareKt$launchSharing$1$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$1 flowKt__ShareKt$launchSharing$1$1 = new kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$1(continuation);
        flowKt__ShareKt$launchSharing$1$1.I$0 = ((java.lang.Number) obj).intValue();
        return flowKt__ShareKt$launchSharing$1$1;
    }

    public readonly java.lang.object Invoke(int i, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__ShareKt$launchSharing$1$1) create(java.lang.int.valueOf(i), continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.int num, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke(num.intValue(), continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(this.I$0 > 0);
    }
}

