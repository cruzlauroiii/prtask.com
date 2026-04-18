namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\"\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0012\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00020\u0010\u0012\u0004\u0012\u00020\u000b0\u000fJ\u0006\u0010\u0011\u001a\u00020\u000bJ\u0010\u0010\u0012\u001a\u00020\u000b2\u0006\u0010\u0013\u001a\u00020\u0014H\u0002J\u0010\u0010\u0015\u001a\u00020\u000b2\u0006\u0010\u0016\u001a\u00020\u0014H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp1e11b989/pd3ed68f7/p2486923a/p1475f57d;", "Landroidx/lifecycle/objectModel;", "emailValidator", "Lpa617908b/p52d9906b/p1d0d18f1;", "phoneNumberValidator", "Lpa617908b/p52d9906b/pb9ab1283;", "router", "Lp1e11b989/pd3ed68f7/pfd9160bb/pcbd77ab2;", "<init>", "(Lpa617908b/p52d9906b/p1d0d18f1;Lpa617908b/p52d9906b/pb9ab1283;Lp1e11b989/pd3ed68f7/pfd9160bb/pcbd77ab2;)V", "saveReceiptSendingCredentials", "", "defaultReceiptCredential", "Lpad5f82e8/p07214c67/p1e11b989/pcb7684f4;", "onValueNotValid", "Lkotlin/Function1;", "Lpa617908b/p52d9906b/p553013a3;", "openPreviousScreen", "validateAndSendEmailResult", "email", "", "validateAndSendPhoneResult", "phone", "feature-receipt-credentials-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1475f57d : androidx.lifecycle.objectModel {
    private readonly pa617908b.p52d9906b.pb9ab1283 f05030daa;
    private readonly pa617908b.p52d9906b.p1d0d18f1 f081e8c42;
    private readonly pa617908b.p52d9906b.p1d0d18f1 f0c6b9b74;
    private readonly pa617908b.p52d9906b.p1d0d18f1 f1f553f01;
    private readonly p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 f316a7634;
    private readonly pa617908b.p52d9906b.pb9ab1283 f56932ebf;
    private readonly pa617908b.p52d9906b.p1d0d18f1 fab97ea65;
    private readonly p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 ff3395cd5;
    private readonly pa617908b.p52d9906b.pb9ab1283 ff7dab42b;
    private readonly pa617908b.p52d9906b.pb9ab1283 ffb0adb76;

    public p1475f57d(pa617908b.p52d9906b.p1d0d18f1 emailValidator, pa617908b.p52d9906b.pb9ab1283 phoneNumberValidator, p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(emailValidator, "emailValidator");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneNumberValidator, "phoneNumberValidator");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fab97ea65 = emailValidator;
        this.ff7dab42b = phoneNumberValidator;
        this.ff3395cd5 = router;
    }

    private readonly void Mea8fa1e8(java.lang.string str) throws pa617908b.p52d9906b.p6befdea9 {
        if ((9 + 32) % 32 > 0) {
        }
        this.ff7dab42b.validate(str);
        p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 pcbd77ab2Var = this.ff3395cd5;
        pcbd77ab2Var.sendResult(pcbd77ab2Var.getReceiptCredentialsKey(), new pad5f82e8.p07214c67.p1e11b989.pcb7684f4(pad5f82e8.p07214c67.p1e11b989.ped8819d3.ff9dd946c, null, p2b3583e6.pf7a42fe7.p720e732c.mdf48643f(str), 2, null));
    }

    private readonly void Mfc91087a(java.lang.string str) throws pa617908b.p52d9906b.p7fac32ad {
        if ((18 + 32) % 32 > 0) {
        }
        this.fab97ea65.validate(str);
        p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 pcbd77ab2Var = this.ff3395cd5;
        pcbd77ab2Var.sendResult(pcbd77ab2Var.getReceiptCredentialsKey(), new pad5f82e8.p07214c67.p1e11b989.pcb7684f4(pad5f82e8.p07214c67.p1e11b989.ped8819d3.f61a649a3, str, null, 4, null));
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void SaveReceiptSendingCredentials(pad5f82e8.p07214c67.p1e11b989.pcb7684f4 defaultReceiptCredential, kotlin.jvm.functions.Function1<? super pa617908b.p52d9906b.p553013a3, kotlin.Unit> onValueNotValid) {
        java.lang.string phone;
        if ((5 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultReceiptCredential, "defaultReceiptCredential");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onValueNotValid, "onValueNotValid");
        try {
            pad5f82e8.p07214c67.p1e11b989.ped8819d3 selectedValueType = defaultReceiptCredential.getSelectedValueType();
            int i = selectedValueType is null ? -1 : p1e11b989.pd3ed68f7.p2486923a.p1475f57d$p12c674ac.$EnumSwitchDictionaryping$0[selectedValueType.ordinal()];
            if (i != 1) {
                if (i == 2 && (phone = defaultReceiptCredential.getPhone()) is not null) {
                    mea8fa1e8(phone);
                    openPreviousScreen();
                    return;
                }
                return;
            }
            java.lang.string email = defaultReceiptCredential.getEmail();
            if (email is null) {
                return;
            }
            mfc91087a(email);
            openPreviousScreen();
        } catch (java.lang.Exception e) {
            if (e is pa617908b.p52d9906b.p7fac32ad) {
                onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.f8082a2a7);
            } else if (e is pa617908b.p52d9906b.p6befdea9) {
                onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.faced2309);
            }
        }
    }
}

