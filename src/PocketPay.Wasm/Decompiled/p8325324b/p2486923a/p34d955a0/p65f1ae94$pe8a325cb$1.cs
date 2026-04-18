namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.states.SendSellReceiptErrorobjectModel$backToChoosePaymentSystem$1", m533f = "SendSellReceiptErrorobjectModel.kt", m534i = {}, m535l = {52}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p65f1ae94$pe8a325cb$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f17b3d260;
    int f205c9b4f;
    int f470edbc6;
    int f5e6ca4e7;
    int fd304ba20;
    readonly p8325324b.p2486923a.p34d955a0.p65f1ae94 this$0;

    p65f1ae94$pe8a325cb$1(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p34d955a0.p65f1ae94$pe8a325cb$1> continuation) {
        super(2, continuation);
        this.this$0 = p65f1ae94Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p34d955a0.p65f1ae94$pe8a325cb$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p34d955a0.p65f1ae94$pe8a325cb$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 21) % 21 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            pc69c522d.pf83c2a85.pac143fb7.pab691ef3 pab691ef3VarM1d7af725 = p8325324b.p2486923a.p34d955a0.p65f1ae94.m1d7af725(this.this$0);
            p8325324b.p2486923a.p34d955a0.p65f1ae94$pe8a325cb$1 p65f1ae94_pe8a325cb_1 = this;
            this.fd304ba20 = 1;
            if (pab691ef3VarM1d7af725.removeAllPaymentsFromReceipt(p65f1ae94_pe8a325cb_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p8325324b.p2486923a.p34d955a0.p65f1ae94.m399a97c0(this.this$0).backToSellChoosePaySystem();
        return kotlin.Unit.INSTANCE;
    }
}

