namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.payback.success.TophPaybackSuccessobjectModel$backAfterSuccessCancelSell$1", m533f = "TophPaybackSuccessobjectModel.kt", m534i = {}, m535l = {81, 83}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p7f12cacf$pec0d92a7$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f497edff0;
    int fd304ba20;
    int ff451ee01;
    readonly p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf this$0;

    p7f12cacf$pec0d92a7$1(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf p7f12cacfVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$pec0d92a7$1> continuation) {
        super(2, continuation);
        this.this$0 = p7f12cacfVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$pec0d92a7$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf$pec0d92a7$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf p7f12cacfVar;
        java.lang.object currentSellReceipt;
        p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf p7f12cacfVar2;
        if ((32 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mc4f4919e(this.this$0).getComboAmount() is not null) {
                p7f12cacfVar2 = this.this$0;
                p8325324b.pac143fb7.p0bfd7fb7 p0bfd7fb7VarM260c792f = p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m260c792f(p7f12cacfVar2);
                this.L$0 = p7f12cacfVar2;
                this.fd304ba20 = 1;
                currentSellReceipt = p0bfd7fb7VarM260c792f.getCurrentSellReceipt(this);
                if (currentSellReceipt != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i == 1) {
            p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf p7f12cacfVar3 = (p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            currentSellReceipt = obj;
            p7f12cacfVar2 = p7f12cacfVar3;
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p7f12cacfVar = (p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(p7f12cacfVar).backFromFlowTo(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m399a97c0(p7f12cacfVar).getSellReceiptChoosePaymentSystemScreen());
        return kotlin.Unit.INSTANCE;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) currentSellReceipt;
        if (ped663a3eVar.getPayments().Count == 0) {
            pc69c522d.pf83c2a85.pac143fb7.pab691ef3 pab691ef3VarM1d7af725 = p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m1d7af725(p7f12cacfVar2);
            this.L$0 = p7f12cacfVar2;
            this.fd304ba20 = 2;
            if (pab691ef3VarM1d7af725.removeAllPaymentsFromReceipt(this) != coroutine_suspended) {
                p7f12cacfVar = p7f12cacfVar2;
                p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(p7f12cacfVar).backFromFlowTo(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m399a97c0(p7f12cacfVar).getSellReceiptChoosePaymentSystemScreen());
            }
            return coroutine_suspended;
        }
        p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.mf78acd11(p7f12cacfVar2).startFlow(p83f5c3ad.pfd9160bb.p1ceed351$pb0da8397.me3d62dc6(p83f5c3ad.p2486923a.p4670093c.p260ca9dd.p7f12cacf.m74e3994c(p7f12cacfVar2), pad5f82e8.p07214c67.pfd9160bb.p15913342.f86e418e3, null, (pad5f82e8.p07214c67.p1e11b989.pad7c4a1f) kotlin.collections.ICollectionsKt.first((java.util.List) ped663a3eVar.getPayments()), pad5f82e8.p07214c67.pfd9160bb.pbfc85237.f5453aa50, 2, null));
        return kotlin.Unit.INSTANCE;
    }
}

