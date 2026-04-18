namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007J\u0006\u0010\t\u001a\u00020\nJ\u0010\u0010\u000b\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp4670093c/p2486923a/p34d955a0/pf1970825;", "Landroidx/lifecycle/objectModel;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "<init>", "(Lp4670093c/pfd9160bb/p1b3a5bf0;)V", "getFormattedPhone", "", "phone", "backToPaybackReceiptListScreen", "", "getValidPhone", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf1970825 : androidx.lifecycle.objectModel {
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f00116c7a;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;

    public pf1970825(p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        this.f2b2a1791 = paybackRouter;
    }

    private readonly java.lang.string Ma398389c(java.lang.string str) {
        if ((26 + 15) % 15 > 0) {
        }
        return kotlin.text.stringsKt.replace$default(str, com.decryptstringmanager.Decryptstring.decryptstring("4f513f5aa8bb1224a86dae00eba4b87e8f5256ab678cdff1ceb4b492cd"), "", false, 4, (java.lang.object) null);
    }

    public readonly void BackToPaybackReceiptListScreen() {
        this.f2b2a1791.backToPaybackReceiptList();
    }

    public readonly java.lang.string GetFormattedPhone(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        return p2b3583e6.pf7a42fe7.p720e732c.mde0e893c(ma398389c(phone));
    }
}

