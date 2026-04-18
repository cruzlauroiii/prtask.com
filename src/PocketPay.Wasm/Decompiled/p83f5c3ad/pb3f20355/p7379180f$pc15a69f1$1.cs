namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p2484c164;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.repository.NfcTapOnPhoneRepositoryImpl$observeNfcCardCommunicationStatus$1", m533f = "NfcTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {51}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p7379180f$pc15a69f1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 $paymentTerminal;
    private java.lang.object L$0;
    int f9f76cf96;
    int fd304ba20;
    int fda3ac053;
    int fe75470dd;
    int fec0111c0;

    p7379180f$pc15a69f1$1(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1> continuation) {
        super(2, continuation);
        this.$paymentTerminal = pd0910e67Var;
    }

    private static readonly kotlin.Unit M3abf8202(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mb119c8b8(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return m3abf8202(p7beea252Var);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1 p7379180f_pc15a69f1_1 = new p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1(this.$paymentTerminal, continuation);
        p7379180f_pc15a69f1_1.L$0 = obj;
        return p7379180f_pc15a69f1_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarSubscribe = this.$paymentTerminal.observeNfcCardCommunicationStatus().subscribe(new p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1$pdfea5ab7$1(producerScope), new p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1$pdfea5ab7$2(producerScope));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p7beea252VarSubscribe, "subscribe(...)");
            p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1$pd41d8cd9$p95263d50 p7379180f_pc15a69f1_1_pd41d8cd9_p95263d50 = new p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1$pd41d8cd9$p95263d50(p7beea252VarSubscribe);
            p83f5c3ad.pb3f20355.p7379180f$pc15a69f1$1 p7379180f_pc15a69f1_1 = this;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, p7379180f_pc15a69f1_1_pd41d8cd9_p95263d50, p7379180f_pc15a69f1_1) == coroutine_suspended) {
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

