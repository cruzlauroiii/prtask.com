namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.error.SendPaybackReceiptErrorobjectModel$backToChoosePaymentSystem$1", m533f = "SendPaybackReceiptErrorobjectModel.kt", m534i = {}, m535l = {51}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p4ca91289$pe8a325cb$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int fd0cec1f2;
    int fd304ba20;
    readonly p4670093c.p2486923a.pcb5e100e.p4ca91289 this$0;

    p4ca91289$pe8a325cb$1(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.pcb5e100e.p4ca91289$pe8a325cb$1> continuation) {
        super(2, continuation);
        this.this$0 = p4ca91289Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.pcb5e100e.p4ca91289$pe8a325cb$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.pcb5e100e.p4ca91289$pe8a325cb$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            pc69c522d.pf83c2a85.pac143fb7.pb88b530f pb88b530fVarMa630e3ac = p4670093c.p2486923a.pcb5e100e.p4ca91289.ma630e3ac(this.this$0);
            p4670093c.p2486923a.pcb5e100e.p4ca91289$pe8a325cb$1 p4ca91289_pe8a325cb_1 = this;
            this.fd304ba20 = 1;
            if (pb88b530fVarMa630e3ac.removeAllPaymentsFromReceipt(p4ca91289_pe8a325cb_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p4670093c.p2486923a.pcb5e100e.p4ca91289.m89a7f193(this.this$0).backToPaybackChoosePaymentSystem();
        return kotlin.Unit.INSTANCE;
    }
}

