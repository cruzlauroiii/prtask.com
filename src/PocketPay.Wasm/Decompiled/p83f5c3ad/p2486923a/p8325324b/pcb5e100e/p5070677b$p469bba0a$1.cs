namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.sell.error.TophPaymentSellErrorobjectModel$back$1", m533f = "TophPaymentSellErrorobjectModel.kt", m534i = {}, m535l = {38}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p5070677b$p469bba0a$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f177d03c3;
    int f517ddaf4;
    int fd304ba20;
    int fde25ad5d;
    readonly p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b this$0;

    p5070677b$p469bba0a$1(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b$p469bba0a$1> continuation) {
        super(2, continuation);
        this.this$0 = p5070677bVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b$p469bba0a$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b$p469bba0a$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((4 + 24) % 24 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.mc4f4919e(this.this$0).getStartTopRoute() != pad5f82e8.p07214c67.pfd9160bb.p15913342.f6718aa2c) {
                p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.mdc7bed18(this.this$0).back();
            } else {
                p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31VarMa82a18e4 = p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.ma82a18e4(this.this$0);
                p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b$p469bba0a$1 p5070677b_p469bba0a_1 = this;
                this.fd304ba20 = 1;
                obj = pfdb21b31VarMa82a18e4.isFastSellEnabled(p5070677b_p469bba0a_1);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (((java.lang.bool) obj).boolValue()) {
            p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.m399a97c0(this.this$0).getFastSellChoosePaySystemScreen());
        } else {
            p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b.mdc7bed18(this.this$0).back();
        }
        return kotlin.Unit.INSTANCE;
    }
}

