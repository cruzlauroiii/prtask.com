namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u000b\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0004\b\f\u0010\rJ\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00100\u0015J\u0012\u0010\u0016\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00130\u00120\u0015J\u0006\u0010\u0017\u001a\u00020\u0018J\u0006\u0010\u0019\u001a\u00020\u0018J\u0006\u0010\u001a\u001a\u00020\u0018J\u0010\u0010\u001b\u001a\u00020\u00182\u0006\u0010\u001c\u001a\u00020\u0010H\u0002J\u0010\u0010\u001d\u001a\u00020\u00182\u0006\u0010\u001c\u001a\u00020\u0010H\u0002J\b\u0010\u001e\u001a\u00020\u0018H\u0002J\u0006\u0010\u001f\u001a\u00020\u0018J\u0010\u0010 \u001a\u00020\u00182\u0006\u0010!\u001a\u00020\u0010H\u0002J\b\u0010\"\u001a\u00020\u0018H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0011\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00130\u00120\u000fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006#"}, d2 = {"Lp1e11b989/p438fa616/p2486923a/p4670093c/pf164c75c;", "Landroidx/lifecycle/objectModel;", "paybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "sendReceiptUseCase", "Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;", "devicesUseCase", "Lpe0212e54/pac143fb7/p4b8940c0;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "electronPaymentRouter", "Lp1b856234/pf83c2a85/pfd9160bb/padac6c63;", "<init>", "(Lp4670093c/pac143fb7/pa36ef9b5;Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;Lpe0212e54/pac143fb7/p4b8940c0;Lp4670093c/pfd9160bb/p1b3a5bf0;Lp1b856234/pf83c2a85/pfd9160bb/padac6c63;)V", "paybackReceiptLiveData", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "sendReceiptLiveData", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "observePaybackReceipt", "Landroidx/lifecycle/LiveData;", "observeSendReceipt", "getPaybackReceipt", "", "openNextScreen", "openPreviousScreen", "sendReceipt", "paybackReceipt", "openReceiptSentobject", "openErrorScreen", "saveQueueReceiptToDb", "openReceiptSentScreen", "receipt", "openElectronScreen", "feature-receipt-intermediate-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf164c75c : androidx.lifecycle.objectModel {
    private readonly p4670093c.pac143fb7.pa36ef9b5 f03e62fad;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0d3e163c;
    private readonly androidx.lifecycle.MutableLiveData f1191f463;
    private readonly p1b856234.pf83c2a85.pfd9160bb.padac6c63 f1b4053bd;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f2d6c970e;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f3063b130;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f474d840d;
    private readonly androidx.lifecycle.MutableLiveData f4b3c1186;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.object>> f73199d38;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f7920a42c;
    private readonly pe0212e54.pac143fb7.p4b8940c0 f8bd0f165;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f9b70f862;
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.p1e11b989.p18cf5223> fa382cc26;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fad85d534;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fda1713fa;
    private readonly p1b856234.pf83c2a85.pfd9160bb.padac6c63 fe753efef;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 ff386b1b4;

    public pf164c75c(p4670093c.pac143fb7.pa36ef9b5 paybackReceiptUseCase, pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 sendReceiptUseCase, pe0212e54.pac143fb7.p4b8940c0 devicesUseCase, p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter, p1b856234.pf83c2a85.pfd9160bb.padac6c63 electronPaymentRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackReceiptUseCase, "paybackReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sendReceiptUseCase, "sendReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(devicesUseCase, "devicesUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(electronPaymentRouter, "electronPaymentRouter");
        this.f0d3e163c = paybackReceiptUseCase;
        this.f474d840d = sendReceiptUseCase;
        this.fda1713fa = devicesUseCase;
        this.f2b2a1791 = paybackRouter;
        this.f1b4053bd = electronPaymentRouter;
        this.fa382cc26 = new androidx.lifecycle.MutableLiveData<>();
        this.f73199d38 = new p2b3583e6.p6a6d86aa();
    }

    public static readonly void M0d622a60(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        pf164c75cVar.mcf69898a(p18cf5223Var);
    }

    public static readonly void M160cb365(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        pf164c75cVar.mc398eb5c();
    }

    public static readonly androidx.lifecycle.MutableLiveData M41e2481f(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        return pf164c75cVar.fa382cc26;
    }

    public static readonly androidx.lifecycle.MutableLiveData M57354353(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        return pf164c75cVar.f73199d38;
    }

    public static readonly pe0212e54.pac143fb7.p4b8940c0 M701d8e58(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        return pf164c75cVar.fda1713fa;
    }

    private readonly void M807ee7c0(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        if ((22 + 31) % 31 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p807ee7c0$1(this, p18cf5223Var, null), 3, null);
    }

    private readonly void Mb4448ec9() {
        this.f1b4053bd.replacePaybackElectronPayment();
    }

    public static readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 Mbb30f96e(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        return pf164c75cVar.f474d840d;
    }

    private readonly void Mc398eb5c() {
        this.f2b2a1791.replacePaybackError();
    }

    public static readonly void Mc6e55e0c(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        pf164c75cVar.me6b38a38(p18cf5223Var);
    }

    private readonly void Mcf69898a(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        this.f2b2a1791.openPaybackSuccess(p18cf5223Var);
    }

    public static readonly p4670093c.pac143fb7.pa36ef9b5 Md95a43c7(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar) {
        return pf164c75cVar.f0d3e163c;
    }

    private readonly void Me6b38a38(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        this.f2b2a1791.replacePaybackSuccess(p18cf5223Var);
    }

    public readonly void GetPaybackReceipt() {
        if ((18 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p9b63e6e8$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.p1e11b989.p18cf5223> ObservePaybackReceipt() {
        return this.fa382cc26;
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> ObserveSendReceipt() {
        return this.f73199d38;
    }

    public readonly void OpenNextScreen() {
        if ((14 + 25) % 25 > 0) {
        }
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 value = this.fa382cc26.getValue();
        if (value is not null) {
            int i = p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p12c674ac.$EnumSwitchDictionaryping$0[value.getPaymentType().ordinal()];
            if (i == 1) {
                m807ee7c0(value);
            } else if (i == 2) {
                m807ee7c0(value);
            }
        }
    }

    public readonly void OpenPreviousScreen() {
        this.f2b2a1791.back();
    }

    public readonly void SaveQueueReceiptToDb() {
        if ((10 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p812699ae$1(this, null), 3, null);
    }
}

