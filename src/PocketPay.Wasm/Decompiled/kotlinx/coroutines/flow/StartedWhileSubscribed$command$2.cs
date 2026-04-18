namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "it", "Lkotlinx/coroutines/flow/SharingCommand;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.StartedWhileSubscribed$command$2", m533f = "SharingStarted.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class StartedWhileSubscribed$command$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.SharingCommand, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    java.lang.object L$0;
    int label;

    StartedWhileSubscribed$command$2(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.StartedWhileSubscribed$command$2> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.StartedWhileSubscribed$command$2 startedWhileSubscribed$command$2 = new kotlinx.coroutines.flow.StartedWhileSubscribed$command$2(continuation);
        startedWhileSubscribed$command$2.L$0 = obj;
        return startedWhileSubscribed$command$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.SharingCommand sharingCommand, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke2(sharingCommand, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.SharingCommand sharingCommand, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((kotlinx.coroutines.flow.StartedWhileSubscribed$command$2) create(sharingCommand, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(((kotlinx.coroutines.flow.SharingCommand) this.L$0) != kotlinx.coroutines.flow.SharingCommand.START);
    }
}

