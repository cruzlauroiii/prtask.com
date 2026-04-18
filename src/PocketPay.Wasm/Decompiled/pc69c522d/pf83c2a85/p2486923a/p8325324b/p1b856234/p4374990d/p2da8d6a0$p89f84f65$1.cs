namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "combo.payment.presentation.sell.electron.processing.SellComboElectronProcessingobjectModel$addPaymentToReceipt$1", m533f = "SellComboElectronProcessingobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2da8d6a0$p89f84f65$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f8fee46e6;
    int fd304ba20;

    p2da8d6a0$p89f84f65$1(kotlin.coroutines.Continuation<? super pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1> continuation) {
        super(2, continuation);
    }

    public static java.lang.object BlJTHWsKxKHWXaiO(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1 p2da8d6a0_p89f84f65_1, java.lang.object obj) {
        return p2da8d6a0_p89f84f65_1.invokeSuspend(obj);
    }

    public static void QTsGJFkDKCARUmXS(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation SvCCOLtZzAKrdVLk(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1 p2da8d6a0_p89f84f65_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p2da8d6a0_p89f84f65_1.create(obj, continuation);
    }

    public static java.lang.object VqNMyrVuTrzFypve() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object ZyqtIlBDeihohxpj(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1 p2da8d6a0_p89f84f65_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p2da8d6a0_p89f84f65_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1(continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return zyqtIlBDeihohxpj(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return BlJTHWsKxKHWXaiO((pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p4374990d.p2da8d6a0$p89f84f65$1) SvCCOLtZzAKrdVLk(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        VqNMyrVuTrzFypve();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        QTsGJFkDKCARUmXS(obj);
        return kotlin.Unit.INSTANCE;
    }
}

