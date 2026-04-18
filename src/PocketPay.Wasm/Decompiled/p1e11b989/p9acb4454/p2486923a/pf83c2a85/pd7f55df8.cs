namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\b\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0004\b\f\u0010\rJ\b\u0010\u001a\u001a\u00020\u001bH\u0002J\u0016\u0010\u001c\u001a\u00020\u001b2\u0006\u0010\u001d\u001a\u00020\u0012H\u0082@¢\u0006\u0002\u0010\u001eJ\"\u0010\u001f\u001a\u00020\u00172\u0006\u0010 \u001a\u00020\u00102\u0006\u0010\u001d\u001a\u00020\u00122\b\u0010!\u001a\u0004\u0018\u00010\u0014H\u0002J\u0006\u0010\"\u001a\u00020\u001bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0011\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0013\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00140\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00170\u0016¢\u0006\b\n\u0000\u001a\u0004\b\u0018\u0010\u0019¨\u0006#"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/pf83c2a85/pd7f55df8;", "Landroidx/lifecycle/objectModel;", "receiptStatusUseCase", "Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "tophReceiptUseCase", "Lp83f5c3ad/p684019bc/p6c387cae;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "receiptUuid", "", "<init>", "(Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;Lp83f5c3ad/p684019bc/p6c387cae;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;Ljava/lang/string;)V", "_isLoadingState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "", "_receiptState", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "_transactionState", "Lpad5f82e8/p07214c67/p1e11b989/pf8872840;", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp1e11b989/p9acb4454/p2486923a/pf83c2a85/p8f2c2888;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "getReceiptStatusDetailsPayment", "", "getPaymentTransaction", "receipt", "(Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "combineState", "isLoading", "paymentTransaction", "openSendReceiptToEmail", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd7f55df8 : androidx.lifecycle.objectModel {
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f0d5e49eb;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f12b323a2;
    private readonly kotlinx.coroutines.flow.StateFlow f16fd3283;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f28e5a91c;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f32223151;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f342a8b61;
    private readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888> f38570d4f;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f395bf4d9;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f3c2bcd36;
    private readonly kotlinx.coroutines.flow.StateFlow f3eba5938;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f442100ed;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f541a2127;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.lang.bool> f64b4e2df;
    private readonly p83f5c3ad.p684019bc.p6c387cae f77af2a4b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f7dc9579a;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<pad5f82e8.p07214c67.p1e11b989.p9ded6185> f818ebf10;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f971e68c8;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 fa2586ee7;
    private readonly kotlinx.coroutines.flow.StateFlow fa3d0e0f7;
    private readonly p83f5c3ad.p684019bc.p6c387cae faa5260ab;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fb4250021;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fd34f9c3d;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fdb41cb8c;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 fdc5f6bea;
    private readonly java.lang.string fe00d2245;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fe2609035;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fe6ce3479;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fe80c5be3;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<pad5f82e8.p07214c67.p1e11b989.pf8872840> fe9134227;
    private readonly java.lang.string fed41d78b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow feea45f40;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;

    public pd7f55df8(p1e11b989.p9acb4454.pac143fb7.p883b57c7 receiptStatusUseCase, p83f5c3ad.p684019bc.p6c387cae tophReceiptUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, p83f5c3ad.pfd9160bb.p1ceed351 tapOnPhoneRouter, java.lang.string receiptUuid) {
        if ((17 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptStatusUseCase, "receiptStatusUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophReceiptUseCase, "tophReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneRouter, "tapOnPhoneRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        this.f395bf4d9 = receiptStatusUseCase;
        this.f77af2a4b = tophReceiptUseCase;
        this.feefeb260 = flowRouter;
        this.f62520fad = tapOnPhoneRouter;
        this.fe00d2245 = receiptUuid;
        kotlinx.coroutines.flow.MutableStateFlow<java.lang.bool> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(false);
        this.f64b4e2df = MutableStateFlow;
        kotlinx.coroutines.flow.MutableStateFlow<pad5f82e8.p07214c67.p1e11b989.p9ded6185> MutableStateFlow2 = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(null);
        this.f818ebf10 = MutableStateFlow2;
        kotlinx.coroutines.flow.MutableStateFlow<pad5f82e8.p07214c67.p1e11b989.pf8872840> MutableStateFlow3 = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(null);
        this.fe9134227 = MutableStateFlow3;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(kotlinx.coroutines.flow.FlowKt.m3498catch(kotlinx.coroutines.flow.FlowKt.combine(MutableStateFlow, kotlinx.coroutines.flow.FlowKt.filterNotNull(MutableStateFlow2), MutableStateFlow3, new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p38570d4f$1(this)), new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p38570d4f$2(null)), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888(false, null, null, null, null, null, 63, null));
        m11955777();
    }

    private readonly void M11955777() {
        if ((28 + 32) % 32 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p11955777$1(this, null), 3, null);
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow M2c5466f4(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var) {
        return pd7f55df8Var.f64b4e2df;
    }

    public static readonly java.lang.string M316b9c6e(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var) {
        return pd7f55df8Var.fe00d2245;
    }

    public static readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 M34b8edf3(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var) {
        return pd7f55df8Var.f395bf4d9;
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow M501e9fd2(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var) {
        return pd7f55df8Var.f818ebf10;
    }

    private readonly java.lang.object M646a1688(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p646a1688$1 pd7f55df8_p646a1688_1;
        if ((16 + 25) % 25 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p646a1688$1) {
            pd7f55df8_p646a1688_1 = (p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p646a1688$1) continuation;
            if ((pd7f55df8_p646a1688_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pd7f55df8_p646a1688_1 = new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p646a1688$1(this, continuation);
            } else {
                pd7f55df8_p646a1688_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pd7f55df8_p646a1688_1 = new p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8$p646a1688$1(this, continuation);
        }
        java.lang.object paymentTransaction = pd7f55df8_p646a1688_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pd7f55df8_p646a1688_1.fd304ba20;
        try {
            pad5f82e8.p07214c67.p1e11b989.pf8872840 transaction = (pad5f82e8.p07214c67.p1e11b989.pf8872840) paymentTransaction;
            this.fe9134227.setValue(transaction);
            this.f64b4e2df.setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(false));
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(paymentTransaction);
            if (p9ded6185Var.getPaymentType() != pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306) {
                this.f64b4e2df.setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(false));
            } else {
                pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar = (pad5f82e8.p07214c67.p1e11b989.pad7c4a1f) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) p9ded6185Var.getPayments());
                if (pad7c4a1fVar is null || (transaction = pad7c4a1fVar.getTransaction()) is null) {
                    p83f5c3ad.p684019bc.p6c387cae p6c387caeVar = this.f77af2a4b;
                    pad5f82e8.p07214c67.p1e11b989.pf8872840 transaction2 = ((pad5f82e8.p07214c67.p1e11b989.pad7c4a1f) kotlin.collections.ICollectionsKt.first((java.util.List) p9ded6185Var.getPayments())).getTransaction();
                    java.lang.string rrn = transaction2 is not null ? transaction2.getRrn() : null;
                    pd7f55df8_p646a1688_1.L$0 = this;
                    pd7f55df8_p646a1688_1.fd304ba20 = 1;
                    paymentTransaction = p6c387caeVar.getPaymentTransaction(p9ded6185Var, rrn, pd7f55df8_p646a1688_1);
                    if (paymentTransaction == coroutine_suspended) {
                        return coroutine_suspended;
                    }
                }
                this.fe9134227.setValue(transaction);
                this.f64b4e2df.setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(false));
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        this = (p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8) pd7f55df8_p646a1688_1.L$0;
        kotlin.ResultKt.throwOnFailure(paymentTransaction);
        return kotlin.Unit.INSTANCE;
    }

    public static readonly java.lang.object M67542c6d(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var, bool z, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, pad5f82e8.p07214c67.p1e11b989.pf8872840 pf8872840Var, kotlin.coroutines.Continuation continuation) {
        return mf9fef0ab(pd7f55df8Var, z, p9ded6185Var, pf8872840Var, continuation);
    }

    private readonly p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888 M98976a4e(bool z, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, pad5f82e8.p07214c67.p1e11b989.pf8872840 pf8872840Var) {
        if ((2 + 1) % 1 > 0) {
        }
        java.math.decimal bigDecimalM29a3256d = p2b3583e6.p263e3cef.p517b902b.m29a3256d(p9ded6185Var);
        java.util.DateTime creationDateTime = p9ded6185Var.getCreationDateTime();
        return new p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888(z, bigDecimalM29a3256d, creationDateTime is null ? null : java.lang.long.valueOf(creationDateTime.getTime()), p9ded6185Var.getPaymentType(), p9ded6185Var.getOperationType(), pf8872840Var);
    }

    public static readonly java.lang.object Mc5ead714(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation continuation) {
        return pd7f55df8Var.m646a1688(p9ded6185Var, continuation);
    }

    private static readonly java.lang.object Mf9fef0ab(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var, bool z, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, pad5f82e8.p07214c67.p1e11b989.pf8872840 pf8872840Var, kotlin.coroutines.Continuation continuation) {
        return pd7f55df8Var.m98976a4e(z, p9ded6185Var, pf8872840Var);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.pf83c2a85.p8f2c2888> GetUiState() {
        return this.f38570d4f;
    }

    public readonly void OpenSendReceiptToEmail() {
        if ((16 + 15) % 15 > 0) {
        }
        this.feefeb260.startFlow(p83f5c3ad.pfd9160bb.p1ceed351$pb0da8397.me3d62dc6(this.f62520fad, pad5f82e8.p07214c67.pfd9160bb.p15913342.f3cdf9ab3, this.f818ebf10.getValue(), null, null, 12, null));
    }
}

