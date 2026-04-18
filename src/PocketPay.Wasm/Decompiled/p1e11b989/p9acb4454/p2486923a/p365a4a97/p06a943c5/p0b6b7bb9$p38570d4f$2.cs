namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p06a943c5/pf5c8ce31;", "it", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.positions.search.ReceiptStatusDetailsPositionsSearchobjectModel$uiState$2", m533f = "ReceiptStatusDetailsPositionsSearchobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p0b6b7bb9$p38570d4f$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f3f50d0c8;
    int fade51b3e;
    int fd304ba20;

    p0b6b7bb9$p38570d4f$2(kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$2> continuation) {
        super(3, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, th, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$2 p0b6b7bb9_p38570d4f_2 = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$2(continuation);
        p0b6b7bb9_p38570d4f_2.L$0 = th;
        return p0b6b7bb9_p38570d4f_2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException((java.lang.Exception) this.L$0);
        return kotlin.Unit.INSTANCE;
    }
}

