namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0004\b\f\u0010\rJ\u0012\u0010\u0012\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u00100\u0013J\u0006\u0010\u0014\u001a\u00020\u0015J\u000e\u0010\u0016\u001a\u00020\u00152\u0006\u0010\u0017\u001a\u00020\u0011J\u0006\u0010\u0018\u001a\u00020\u0015R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u00100\u000fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp8325324b/p2486923a/p34d955a0/p65f1ae94;", "Landroidx/lifecycle/objectModel;", "sellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "sellComboUseCase", "Lpc69c522d/pf83c2a85/pac143fb7/pab691ef3;", "devicesUseCase", "Lpe0212e54/pac143fb7/p4b8940c0;", "sendReceiptUseCase", "Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp8325324b/pac143fb7/p0bfd7fb7;Lpc69c522d/pf83c2a85/pac143fb7/pab691ef3;Lpe0212e54/pac143fb7/p4b8940c0;Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;Lp8325324b/pfd9160bb/p5fa140e9;)V", "sendReceiptStatus", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "getSendReceiptStatus", "Landroidx/lifecycle/LiveData;", "sendReceipt", "", "openReceiptSentScreen", "receipt", "backToChoosePaymentSystem", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p65f1ae94 : androidx.lifecycle.objectModel {
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f05710632;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f29d1316b;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f39cfe0ff;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f474d840d;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f47ee9bfe;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 f592a8c7a;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> f59e9a928;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f656c88ab;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 f6dd9e4ee;
    private readonly androidx.lifecycle.MutableLiveData f75bbdaa8;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f88905fd2;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f889834e0;
    private readonly pe0212e54.pac143fb7.p4b8940c0 f89eacac2;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fa00640c1;
    private readonly p8325324b.pfd9160bb.p5fa140e9 fa06f121a;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fab3cafa7;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fda1713fa;
    private readonly pe0212e54.pac143fb7.p4b8940c0 ff0933a15;
    private readonly pe0212e54.pac143fb7.p4b8940c0 ffa8814ba;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 ffceec28b;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 ffe0c21b8;

    public p65f1ae94(p8325324b.pac143fb7.p0bfd7fb7 sellReceiptUseCase, pc69c522d.pf83c2a85.pac143fb7.pab691ef3 sellComboUseCase, pe0212e54.pac143fb7.p4b8940c0 devicesUseCase, pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 sendReceiptUseCase, p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUseCase, "sellReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellComboUseCase, "sellComboUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(devicesUseCase, "devicesUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sendReceiptUseCase, "sendReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f656c88ab = sellReceiptUseCase;
        this.ffceec28b = sellComboUseCase;
        this.fda1713fa = devicesUseCase;
        this.f474d840d = sendReceiptUseCase;
        this.f9817bc27 = sellRouter;
        this.f59e9a928 = new p2b3583e6.p6a6d86aa();
    }

    public static readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 M1d7af725(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var) {
        return p65f1ae94Var.ffceec28b;
    }

    public static readonly p8325324b.pac143fb7.p0bfd7fb7 M260c792f(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var) {
        return p65f1ae94Var.f656c88ab;
    }

    public static readonly p8325324b.pfd9160bb.p5fa140e9 M399a97c0(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var) {
        return p65f1ae94Var.f9817bc27;
    }

    public static readonly androidx.lifecycle.MutableLiveData M952b499e(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var) {
        return p65f1ae94Var.f59e9a928;
    }

    public static readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 Mbb30f96e(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var) {
        return p65f1ae94Var.f474d840d;
    }

    public readonly void BackToChoosePaymentSystem() {
        if ((5 + 3) % 3 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.p34d955a0.p65f1ae94$pe8a325cb$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> GetSendReceiptStatus() {
        return this.f59e9a928;
    }

    public readonly void OpenReceiptSentScreen(pad5f82e8.p07214c67.p1e11b989.ped663a3e receipt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        this.f9817bc27.openSellReceiptSuccessfullySent(receipt);
    }

    public readonly void SendReceipt() {
        if ((25 + 19) % 19 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.p34d955a0.p65f1ae94$p807ee7c0$1(this, null), 3, null);
    }
}

