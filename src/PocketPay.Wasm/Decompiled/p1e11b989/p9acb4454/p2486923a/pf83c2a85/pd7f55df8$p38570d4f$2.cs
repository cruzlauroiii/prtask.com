namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Lp1e11b989/p9acb4454/p2486923a/pf83c2a85/p8f2c2888;", "it", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.payment.ReceiptStatusDetailsPaymentInfoobjectModel$uiState$2", m533f = "ReceiptStatusDetailsPaymentInfoobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pd7f55df8$p38570d4f$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f63355afd;
    int f77ee0a1d;
    int fd304ba20;

    pd7f55df8$p38570d4f$2(kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p38570d4f$2> continuation) {
        super(3, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, th, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p38570d4f$2 pd7f55df8_p38570d4f_2 = new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p38570d4f$2(continuation);
        pd7f55df8_p38570d4f_2.L$0 = th;
        return pd7f55df8_p38570d4f_2.invokeSuspend(kotlin.Unit.INSTANCE);
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

