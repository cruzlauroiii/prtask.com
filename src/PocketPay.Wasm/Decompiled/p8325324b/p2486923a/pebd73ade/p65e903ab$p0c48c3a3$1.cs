namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.choose.SellReceiptChoosePaySystemobjectModel$getCurrentSellReceiptData$1", m533f = "SellReceiptChoosePaySystemobjectModel.kt", m534i = {}, m535l = {91}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p65e903ab$p0c48c3a3$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f05cba247;
    int fd304ba20;
    readonly p8325324b.p2486923a.pebd73ade.p65e903ab this$0;

    p65e903ab$p0c48c3a3$1(p8325324b.p2486923a.pebd73ade.p65e903ab p65e903abVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.pebd73ade.p65e903ab$p0c48c3a3$1> continuation) {
        super(2, continuation);
        this.this$0 = p65e903abVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.pebd73ade.p65e903ab$p0c48c3a3$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.pebd73ade.p65e903ab$p0c48c3a3$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object currentSellReceipt;
        if ((16 + 4) % 4 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p8325324b.p2486923a.pebd73ade.p65e903ab.mc5961be3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                currentSellReceipt = p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).getCurrentSellReceipt(this);
                if (currentSellReceipt == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                currentSellReceipt = obj;
            }
            p8325324b.p2486923a.pebd73ade.p65e903ab p65e903abVar = this.this$0;
            pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVarM1c1e012b = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) currentSellReceipt;
            if (p8325324b.p2486923a.pebd73ade.p65e903ab.m97bc466a(p65e903abVar) is not null) {
                pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVarM97bc466a = p8325324b.p2486923a.pebd73ade.p65e903ab.m97bc466a(p65e903abVar);
                java.lang.string clientEmail = ped663a3eVarM97bc466a is not null ? ped663a3eVarM97bc466a.getClientEmail() : null;
                pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVarM97bc466a2 = p8325324b.p2486923a.pebd73ade.p65e903ab.m97bc466a(p65e903abVar);
                ped663a3eVarM1c1e012b = pad5f82e8.p07214c67.p1e11b989.ped663a3e.m1c1e012b(ped663a3eVarM1c1e012b, null, null, null, null, null, clientEmail, ped663a3eVarM97bc466a2 is not null ? ped663a3eVarM97bc466a2.getClientPhone() : null, null, null, false, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, null, 67108767, null);
            }
            p8325324b.p2486923a.pebd73ade.p65e903ab.m983972f2(this.this$0, ped663a3eVarM1c1e012b);
            p8325324b.p2486923a.pebd73ade.p65e903ab.mc5961be3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(ped663a3eVarM1c1e012b));
        } catch (java.lang.Exception e) {
            p8325324b.p2486923a.pebd73ade.p65e903ab.mc5961be3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

