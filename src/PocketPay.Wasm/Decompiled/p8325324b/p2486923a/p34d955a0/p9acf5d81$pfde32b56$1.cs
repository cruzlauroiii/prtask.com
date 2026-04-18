namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.states.SellSuccessWithoutPrintobjectModel$backFromSellReceipt$1", m533f = "SellSuccessWithoutPrintobjectModel.kt", m534i = {}, m535l = {46}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p9acf5d81$pfde32b56$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p22820a6f $receiptType;
    int f75d24402;
    int fb2836bea;
    int fb757c560;
    int fd304ba20;
    int fd501337a;
    readonly p8325324b.p2486923a.p34d955a0.p9acf5d81 this$0;

    p9acf5d81$pfde32b56$1(pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar, p8325324b.p2486923a.p34d955a0.p9acf5d81 p9acf5d81Var, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p34d955a0.p9acf5d81$pfde32b56$1> continuation) {
        super(2, continuation);
        this.$receiptType = p22820a6fVar;
        this.this$0 = p9acf5d81Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p34d955a0.p9acf5d81$pfde32b56$1(this.$receiptType, this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p34d955a0.p9acf5d81$pfde32b56$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (this.$receiptType != pad5f82e8.p07214c67.p1e11b989.p22820a6f.fcc52554c) {
                p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31VarMa82a18e4 = p8325324b.p2486923a.p34d955a0.p9acf5d81.ma82a18e4(this.this$0);
                p8325324b.p2486923a.p34d955a0.p9acf5d81$pfde32b56$1 p9acf5d81_pfde32b56_1 = this;
                this.fd304ba20 = 1;
                obj = pfdb21b31VarMa82a18e4.isFastSellEnabled(p9acf5d81_pfde32b56_1);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                p8325324b.p2486923a.p34d955a0.p9acf5d81.mb54aec5a(this.this$0).backToAdvanceReceiptList();
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (((java.lang.bool) obj).boolValue()) {
            p8325324b.p2486923a.p34d955a0.p9acf5d81.m399a97c0(this.this$0).backToFastSellChoosePaySystem();
        } else {
            p8325324b.p2486923a.p34d955a0.p9acf5d81.mcd2fec56(this.this$0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

