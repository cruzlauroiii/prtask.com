namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0018\u0010\u0011\u001a\u0004\u0018\u00010\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0082@¢\u0006\u0002\u0010\u0014J\u0016\u0010\u0015\u001a\u00020\t2\u0006\u0010\u0016\u001a\u00020\u0017H\u0082@¢\u0006\u0002\u0010\u0018J\u0006\u0010\u0019\u001a\u00020\u001aR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0019\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\r¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001b"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/pb653ebc3;", "Landroidx/lifecycle/objectModel;", "receiptStatusUseCase", "Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "resourceProvider", "Lp2b3583e6/p4a931512/p2e423cc6;", "router", "Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;", "receiptUuid", "", "<init>", "(Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;Lp2b3583e6/p4a931512/p2e423cc6;Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;Ljava/lang/string;)V", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp1e11b989/p9acb4454/p2486923a/p75e3d3e7;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "getReceiptStatusDetailsUiState", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "(Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPaybackToolbarTitle", "paybackReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "(Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "back", "", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb653ebc3 : androidx.lifecycle.objectModel {
    private readonly kotlinx.coroutines.flow.StateFlow f0b00f8f8;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f160999ae;
    private readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p75e3d3e7> f38570d4f;
    private readonly kotlinx.coroutines.flow.StateFlow f3904ac60;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f395bf4d9;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a f46293cec;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4734ade7;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f49bb5789;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f838992d4;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a f8e2832ff;
    private readonly kotlinx.coroutines.flow.StateFlow f9555ecb8;
    private readonly kotlinx.coroutines.flow.StateFlow fb25b0660;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 fe10750c6;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 fe45b8a18;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a ff3395cd5;
    private readonly p2b3583e6.p4a931512.p2e423cc6 ff98e970e;

    public pb653ebc3(p1e11b989.p9acb4454.pac143fb7.p883b57c7 receiptStatusUseCase, p2b3583e6.p4a931512.p2e423cc6 resourceProvider, p1e11b989.p9acb4454.pfd9160bb.pc556a05a router, java.lang.string receiptUuid) {
        if ((6 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptStatusUseCase, "receiptStatusUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resourceProvider, "resourceProvider");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        this.f395bf4d9 = receiptStatusUseCase;
        this.f4734ade7 = resourceProvider;
        this.ff3395cd5 = router;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(kotlinx.coroutines.flow.FlowKt.m3498catch(new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1(receiptStatusUseCase.getReceiptByUuid(receiptUuid), this), new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p38570d4f$2(null)), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p1e11b989.p9acb4454.p2486923a.p75e3d3e7(null, null, 3, null));
    }

    private readonly java.lang.object M221053de(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<p1e11b989.p9acb4454.p2486923a.p75e3d3e7> continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.p2486923a.pb653ebc3$p221053de$1 pb653ebc3_p221053de_1;
        java.lang.string string;
        java.util.DateTime creationDateTime;
        if ((19 + 10) % 10 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.p2486923a.pb653ebc3$p221053de$1) {
            pb653ebc3_p221053de_1 = (p1e11b989.p9acb4454.p2486923a.pb653ebc3$p221053de$1) continuation;
            if ((pb653ebc3_p221053de_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pb653ebc3_p221053de_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p221053de$1(this, continuation);
            } else {
                pb653ebc3_p221053de_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pb653ebc3_p221053de_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p221053de$1(this, continuation);
        }
        java.lang.object objM45ba8374 = pb653ebc3_p221053de_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pb653ebc3_p221053de_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objM45ba8374);
            if (p9ded6185Var is pad5f82e8.p07214c67.p1e11b989.ped663a3e) {
                string = this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.sell_receipt_template, ((pad5f82e8.p07214c67.p1e11b989.ped663a3e) p9ded6185Var).getReceiptNumber());
            } else {
                if (!(p9ded6185Var is pad5f82e8.p07214c67.p1e11b989.p18cf5223)) {
                    throw new java.lang.IllegalArgumentException();
                }
                pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) p9ded6185Var;
                pb653ebc3_p221053de_1.L$0 = this;
                pb653ebc3_p221053de_1.L$1 = p9ded6185Var;
                pb653ebc3_p221053de_1.fd304ba20 = 1;
                objM45ba8374 = m45ba8374(p18cf5223Var, pb653ebc3_p221053de_1);
                if (objM45ba8374 == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
            creationDateTime = p9ded6185Var.getCreationDateTime();
            if (creationDateTime is null) {
                return null;
            }
            long time = creationDateTime.getTime();
            return new p1e11b989.p9acb4454.p2486923a.p75e3d3e7(string, this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_date_template, p2b3583e6.p728cd16b.m517248c2(time, this.f4734ade7), p2b3583e6.p728cd16b.m9f8d22da(time)));
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var2 = (pad5f82e8.p07214c67.p1e11b989.p9ded6185) pb653ebc3_p221053de_1.L$1;
        p1e11b989.p9acb4454.p2486923a.pb653ebc3 pb653ebc3Var = (p1e11b989.p9acb4454.p2486923a.pb653ebc3) pb653ebc3_p221053de_1.L$0;
        kotlin.ResultKt.throwOnFailure(objM45ba8374);
        p9ded6185Var = p9ded6185Var2;
        this = pb653ebc3Var;
        string = (java.lang.string) objM45ba8374;
        creationDateTime = p9ded6185Var.getCreationDateTime();
        if (creationDateTime is null) {
            return null;
        }
        long time2 = creationDateTime.getTime();
        return new p1e11b989.p9acb4454.p2486923a.p75e3d3e7(string, this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_date_template, p2b3583e6.p728cd16b.m517248c2(time2, this.f4734ade7), p2b3583e6.p728cd16b.m9f8d22da(time2)));
    }

    private readonly java.lang.object M45ba8374(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.p2486923a.pb653ebc3$p45ba8374$1 pb653ebc3_p45ba8374_1;
        if ((24 + 29) % 29 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.p2486923a.pb653ebc3$p45ba8374$1) {
            pb653ebc3_p45ba8374_1 = (p1e11b989.p9acb4454.p2486923a.pb653ebc3$p45ba8374$1) continuation;
            if ((pb653ebc3_p45ba8374_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pb653ebc3_p45ba8374_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p45ba8374$1(this, continuation);
            } else {
                pb653ebc3_p45ba8374_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pb653ebc3_p45ba8374_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p45ba8374$1(this, continuation);
        }
        java.lang.object objIsFullPaybackReceipt = pb653ebc3_p45ba8374_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pb653ebc3_p45ba8374_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objIsFullPaybackReceipt);
            if (p18cf5223Var.getReceiptType() == pad5f82e8.p07214c67.p1e11b989.p22820a6f.f480d47bf) {
                return this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.payback_without_receipt_number_toolbar_title);
            }
            p1e11b989.p9acb4454.pac143fb7.p883b57c7 p883b57c7Var = this.f395bf4d9;
            java.lang.string uuid = p18cf5223Var.getUuid();
            pb653ebc3_p45ba8374_1.L$0 = this;
            pb653ebc3_p45ba8374_1.L$1 = p18cf5223Var;
            pb653ebc3_p45ba8374_1.fd304ba20 = 1;
            objIsFullPaybackReceipt = p883b57c7Var.isFullPaybackReceipt(uuid, pb653ebc3_p45ba8374_1);
            if (objIsFullPaybackReceipt == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) pb653ebc3_p45ba8374_1.L$1;
            this = (p1e11b989.p9acb4454.p2486923a.pb653ebc3) pb653ebc3_p45ba8374_1.L$0;
            kotlin.ResultKt.throwOnFailure(objIsFullPaybackReceipt);
        }
        return !((java.lang.bool) objIsFullPaybackReceipt).boolValue() ? this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.payback_part_with_receipt_number_toolbar_title, p18cf5223Var.getReceiptNumber()) : this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.payback_with_receipt_number_toolbar_title, p18cf5223Var.getReceiptNumber());
    }

    public static readonly java.lang.object Ma0d7856c(p1e11b989.p9acb4454.p2486923a.pb653ebc3 pb653ebc3Var, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation continuation) {
        return pb653ebc3Var.m45ba8374(p18cf5223Var, continuation);
    }

    public static readonly java.lang.object Mf8456d9c(p1e11b989.p9acb4454.p2486923a.pb653ebc3 pb653ebc3Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation continuation) {
        return pb653ebc3Var.m221053de(p9ded6185Var, continuation);
    }

    public readonly void Back() {
        this.ff3395cd5.back();
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p75e3d3e7> GetUiState() {
        return this.f38570d4f;
    }
}

