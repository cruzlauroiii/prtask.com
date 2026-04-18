namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0012\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\u0011J\u0006\u0010\u0012\u001a\u00020\u0013J\u0010\u0010\u0014\u001a\u00020\u00132\u0006\u0010\u0015\u001a\u00020\u0016H\u0002J\u0006\u0010\u0017\u001a\u00020\u0013R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp4670093c/p2486923a/pcb5e100e/p4ca91289;", "Landroidx/lifecycle/objectModel;", "paybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "paybackComboUseCase", "Lpc69c522d/pf83c2a85/pac143fb7/pb88b530f;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "sendReceiptUseCase", "Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;", "<init>", "(Lp4670093c/pac143fb7/pa36ef9b5;Lpc69c522d/pf83c2a85/pac143fb7/pb88b530f;Lp4670093c/pfd9160bb/p1b3a5bf0;Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;)V", "sendReceiptStatus", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "getSendReceiptStatus", "Landroidx/lifecycle/LiveData;", "sendPaybackReceipt", "", "openReceiptSentScreen", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "backToChoosePaymentSystem", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4ca91289 : androidx.lifecycle.objectModel {
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0479c44e;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0d3e163c;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f474d840d;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f48638983;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.object>> f59e9a928;
    private readonly androidx.lifecycle.MutableLiveData f8544bce4;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pb88b530f f8f80f3fa;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f8fe616d7;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 fa6eb4ca4;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pb88b530f facf5b200;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pb88b530f fc051595c;
    private readonly androidx.lifecycle.MutableLiveData fd704a83b;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fd9e66677;
    private readonly p4670093c.pac143fb7.pa36ef9b5 fee0c5b23;

    public p4ca91289(p4670093c.pac143fb7.pa36ef9b5 paybackReceiptUseCase, pc69c522d.pf83c2a85.pac143fb7.pb88b530f paybackComboUseCase, p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter, pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 sendReceiptUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackReceiptUseCase, "paybackReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackComboUseCase, "paybackComboUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sendReceiptUseCase, "sendReceiptUseCase");
        this.f0d3e163c = paybackReceiptUseCase;
        this.facf5b200 = paybackComboUseCase;
        this.f2b2a1791 = paybackRouter;
        this.f474d840d = sendReceiptUseCase;
        this.f59e9a928 = new p2b3583e6.p6a6d86aa();
    }

    public static readonly void M0d622a60(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        p4ca91289Var.mcf69898a(p18cf5223Var);
    }

    public static readonly p4670093c.pfd9160bb.p1b3a5bf0 M89a7f193(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var) {
        return p4ca91289Var.f2b2a1791;
    }

    public static readonly androidx.lifecycle.MutableLiveData M952b499e(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var) {
        return p4ca91289Var.f59e9a928;
    }

    public static readonly pc69c522d.pf83c2a85.pac143fb7.pb88b530f Ma630e3ac(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var) {
        return p4ca91289Var.facf5b200;
    }

    public static readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 Mbb30f96e(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var) {
        return p4ca91289Var.f474d840d;
    }

    private readonly void Mcf69898a(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        this.f2b2a1791.replacePaybackSuccess(p18cf5223Var);
    }

    public static readonly p4670093c.pac143fb7.pa36ef9b5 Md95a43c7(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var) {
        return p4ca91289Var.f0d3e163c;
    }

    public readonly void BackToChoosePaymentSystem() {
        if ((12 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p4670093c.p2486923a.pcb5e100e.p4ca91289$pe8a325cb$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> GetSendReceiptStatus() {
        return this.f59e9a928;
    }

    public readonly void SendPaybackReceipt() {
        if ((10 + 8) % 8 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p4670093c.p2486923a.pcb5e100e.p4ca91289$p4b22777b$1(this, null), 3, null);
    }
}

