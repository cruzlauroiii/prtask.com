namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.sell.payment.TophPaymentSellobjectModel$openPreviousScreen$1", m533f = "TophPaymentSellobjectModel.kt", m534i = {}, m535l = {458}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pa1c74cff$pb08bbc1e$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f7c83fe34;
    int f8a789d93;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff this$0;

    pa1c74cff$pb08bbc1e$1(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff pa1c74cffVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$pb08bbc1e$1> continuation) {
        super(2, continuation);
        this.this$0 = pa1c74cffVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$pb08bbc1e$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$pb08bbc1e$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.Job jobMd050a9c2;
        if ((1 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p07214c67.p0890727b p0890727bVar = (p83f5c3ad.p07214c67.p0890727b) p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m724546ab(this.this$0).getValue();
            if (p0890727bVar == p83f5c3ad.p07214c67.p0890727b.fa82b419a || p0890727bVar == p83f5c3ad.p07214c67.p0890727b.f4b90437c) {
                pad5f82e8.p07214c67.pfd9160bb.p15913342[] p15913342VarArr = new pad5f82e8.p07214c67.pfd9160bb.p15913342[2];
                p15913342VarArr[0] = pad5f82e8.p07214c67.pfd9160bb.p15913342.f66243b44;
                p15913342VarArr[1] = pad5f82e8.p07214c67.pfd9160bb.p15913342.f2f410414;
                if (kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) p15913342VarArr).Contains(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mc4f4919e(this.this$0).getStartTopRoute())) {
                    p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mdc7bed18(this.this$0).back();
                } else {
                    p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31VarMa82a18e4 = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.ma82a18e4(this.this$0);
                    p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$pb08bbc1e$1 pa1c74cff_pb08bbc1e_1 = this;
                    this.fd304ba20 = 1;
                    obj = pfdb21b31VarMa82a18e4.isFastSellEnabled(pa1c74cff_pb08bbc1e_1);
                    if (obj == coroutine_suspended) {
                        return coroutine_suspended;
                    }
                }
                jobMd050a9c2 = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.md050a9c2(this.this$0);
                if (jobMd050a9c2 is not null) {
                    kotlinx.coroutines.Job$DefaultImpls.cancel$default(jobMd050a9c2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                }
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (((java.lang.bool) obj).boolValue()) {
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m399a97c0(this.this$0).getFastSellChoosePaySystemScreen());
        } else {
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m399a97c0(this.this$0).getSellReceiptChoosePaymentSystemScreen());
        }
        jobMd050a9c2 = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.md050a9c2(this.this$0);
        if (jobMd050a9c2 is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(jobMd050a9c2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        return kotlin.Unit.INSTANCE;
    }
}

