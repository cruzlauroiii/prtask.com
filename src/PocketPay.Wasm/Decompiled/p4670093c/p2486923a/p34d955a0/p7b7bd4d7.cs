namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\fJ\u000e\u0010\r\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\nJ\u0006\u0010\u000f\u001a\u00020\u0010J\b\u0010\u0011\u001a\u00020\u0010H\u0002J\u0010\u0010\u0012\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\nH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp4670093c/p2486923a/p34d955a0/p7b7bd4d7;", "Landroidx/lifecycle/objectModel;", "devicesUseCase", "Lpe0212e54/pac143fb7/p4b8940c0;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "<init>", "(Lpe0212e54/pac143fb7/p4b8940c0;Lp4670093c/pfd9160bb/p1b3a5bf0;)V", "deviceNameLiveData", "Landroidx/lifecycle/MutableLiveData;", "", "observeDeviceName", "Landroidx/lifecycle/LiveData;", "getFormattedPhone", "phone", "backToPaybackReceiptListScreen", "", "getDeviceName", "getValidPhone", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7b7bd4d7 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData f116edc0b;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f17d06ec3;
    private readonly androidx.lifecycle.MutableLiveData f20ba79ab;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly pe0212e54.pac143fb7.p4b8940c0 f2cc49002;
    private readonly androidx.lifecycle.MutableLiveData f5b3ac5ab;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f5f90ab84;
    private readonly pe0212e54.pac143fb7.p4b8940c0 f6242a21d;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> f702db766;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fd62773d2;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fda1713fa;
    private readonly pe0212e54.pac143fb7.p4b8940c0 ff20696dc;

    public p7b7bd4d7(pe0212e54.pac143fb7.p4b8940c0 devicesUseCase, p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(devicesUseCase, "devicesUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        this.fda1713fa = devicesUseCase;
        this.f2b2a1791 = paybackRouter;
        m552e069a();
        this.f702db766 = new androidx.lifecycle.MutableLiveData<>();
    }

    public static readonly androidx.lifecycle.MutableLiveData M396756bb(p4670093c.p2486923a.p34d955a0.p7b7bd4d7 p7b7bd4d7Var) {
        return p7b7bd4d7Var.f702db766;
    }

    private readonly void M552e069a() {
        if ((16 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p4670093c.p2486923a.p34d955a0.p7b7bd4d7$p552e069a$1(this, null), 3, null);
    }

    public static readonly pe0212e54.pac143fb7.p4b8940c0 M701d8e58(p4670093c.p2486923a.p34d955a0.p7b7bd4d7 p7b7bd4d7Var) {
        return p7b7bd4d7Var.fda1713fa;
    }

    private readonly java.lang.string Ma398389c(java.lang.string str) {
        if ((26 + 15) % 15 > 0) {
        }
        return kotlin.text.stringsKt.replace$default(str, com.decryptstringmanager.Decryptstring.decryptstring("b1c08e124c8147e5f4ff54e955ff14dbe70c72e90bc886797fad6482d8"), "", false, 4, (java.lang.object) null);
    }

    public readonly void BackToPaybackReceiptListScreen() {
        this.f2b2a1791.backToPaybackReceiptList();
    }

    public readonly java.lang.string GetFormattedPhone(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        return p2b3583e6.pf7a42fe7.p720e732c.mde0e893c(ma398389c(phone));
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> ObserveDeviceName() {
        return this.f702db766;
    }
}

