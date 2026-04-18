namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.balance.TophBalanceobjectModel$observeNfcCardCommunicationStatus$1", m533f = "TophBalanceobjectModel.kt", m534i = {}, m535l = {100}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pcef97c41$pc15a69f1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 $paymentTerminal;
    int f54f2e54a;
    int f73f41a18;
    int f9ec0d6d6;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p2069ca79.pcef97c41 this$0;

    pcef97c41$pc15a69f1$1(p83f5c3ad.p2486923a.p2069ca79.pcef97c41 pcef97c41Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1> continuation) {
        super(2, continuation);
        this.this$0 = pcef97c41Var;
        this.$paymentTerminal = pd0910e67Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1(this.this$0, this.$paymentTerminal, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> flowObserveNfcCardCommunicationStatus = p83f5c3ad.p2486923a.p2069ca79.pcef97c41.mecf2730e(this.this$0).observeNfcCardCommunicationStatus(this.$paymentTerminal);
            p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1$1 pcef97c41_pc15a69f1_1_1 = new p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1$1(this.this$0);
            p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pc15a69f1$1 pcef97c41_pc15a69f1_1 = this;
            this.fd304ba20 = 1;
            if (flowObserveNfcCardCommunicationStatus.collect(pcef97c41_pc15a69f1_1_1, pcef97c41_pc15a69f1_1) == coroutine_suspended) {
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

