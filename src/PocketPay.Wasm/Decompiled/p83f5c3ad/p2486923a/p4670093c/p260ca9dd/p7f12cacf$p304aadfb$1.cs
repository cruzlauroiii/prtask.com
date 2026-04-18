namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.payback.success.TophPaybackSuccessobjectModel$backAfterSuccessPayback$1", m533f = "TophPaybackSuccessobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p7f12cacf$p304aadfb$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 $receipt;
    int f667906a8;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf this$0;

    p7f12cacf$p304aadfb$1(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf p7f12cacfVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$p304aadfb$1> continuation) {
        super(2, continuation);
        this.this$0 = p7f12cacfVar;
        this.$receipt = p18cf5223Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$p304aadfb$1(this.this$0, this.$receipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$p304aadfb$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mc4f4919e(this.this$0).getComboAmount() is null) {
            p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(this.this$0).startRootFlow(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m245216f0(this.this$0).getLauncherScreen());
        } else if (p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m90edaec8(this.this$0, this.$receipt)) {
            p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(this.this$0).finishFlow();
            p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m89a7f193(this.this$0).replacePaybackSuccess(this.$receipt);
        } else {
            p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m7197a9e0(this.this$0).getComboPaybackPaymentScreen());
        }
        return kotlin.Unit.INSTANCE;
    }
}

