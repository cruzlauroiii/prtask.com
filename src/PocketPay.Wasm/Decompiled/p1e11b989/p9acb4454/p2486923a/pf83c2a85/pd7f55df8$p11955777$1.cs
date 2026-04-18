namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.payment.ReceiptStatusDetailsPaymentInfoobjectModel$getReceiptStatusDetailsPayment$1", m533f = "ReceiptStatusDetailsPaymentInfoobjectModel.kt", m534i = {}, m535l = {62}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pd7f55df8$p11955777$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f31c6b185;
    int fd304ba20;
    readonly p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 this$0;

    pd7f55df8$p11955777$1(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1> continuation) {
        super(2, continuation);
        this.this$0 = pd7f55df8Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((2 + 1) % 1 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8.m2c5466f4(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(true));
            kotlinx.coroutines.flow.Flow<pad5f82e8.p07214c67.p1e11b989.p9ded6185> receiptByUuid = p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8.m34b8edf3(this.this$0).getReceiptByUuid(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8.m316b9c6e(this.this$0));
            p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1$1 pd7f55df8_p11955777_1_1 = new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1$1(this.this$0);
            p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1 pd7f55df8_p11955777_1 = this;
            this.fd304ba20 = 1;
            if (receiptByUuid.collect(pd7f55df8_p11955777_1_1, pd7f55df8_p11955777_1) == coroutine_suspended) {
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

