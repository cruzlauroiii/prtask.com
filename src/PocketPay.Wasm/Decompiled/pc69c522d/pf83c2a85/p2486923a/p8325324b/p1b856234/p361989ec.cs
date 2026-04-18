namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0010J\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00120\u0010J\u0012\u0010\u0014\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\u00150\u0010J\u0006\u0010\u0016\u001a\u00020\u0017J\u0016\u0010\u0018\u001a\u00020\u00172\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001cJ\u0010\u0010\u001d\u001a\u00020\u00172\u0006\u0010\u0019\u001a\u00020\u001aH\u0002J\u0006\u0010\u001e\u001a\u00020\u0017J\u0010\u0010\u001f\u001a\u00020\u00172\u0006\u0010\u0019\u001a\u00020\u001aH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00120\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0014\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\u00150\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lpc69c522d/pf83c2a85/p2486923a/p8325324b/p1b856234/p361989ec;", "Landroidx/lifecycle/objectModel;", "sellComboUseCase", "Lpc69c522d/pf83c2a85/pac143fb7/pab691ef3;", "router", "Lpc69c522d/pf83c2a85/pfd9160bb/pc32333e1;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lpc69c522d/pf83c2a85/pac143fb7/pab691ef3;Lpc69c522d/pf83c2a85/pfd9160bb/pc32333e1;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "currentSellReceiptLiveData", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "observeCurrentSellReceipt", "Landroidx/lifecycle/LiveData;", "snackbarStatus", "Lpad5f82e8/p07214c67/pe907423b/pb3f3bb37;", "getSnackbarStatus", "observeSendReceipt", "Lpad5f82e8/p07214c67/pa4ecfc70;", "getCurrentSellReceipt", "", "startPayment", "amount", "Ljava/math/decimal;", "type", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "replaceSellComboElectronProcessing", "openPreviousScreen", "openTapOnPhoneSellScreen", "feature-combo-payment-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p361989ec : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.p1e11b989.ped663a3e> f159455b4;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 f31b0762e;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f4fb1187f;
    private readonly androidx.lifecycle.MutableLiveData f53ab1803;
    private readonly pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 f5f5bd5b9;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 f64243efb;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 f686cfe69;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f6a113d7c;
    private readonly androidx.lifecycle.MutableLiveData f83ce473c;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f8fabb371;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> f95ceb8d2;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f97c89e95;
    private readonly androidx.lifecycle.MutableLiveData fa290359d;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fb4552634;
    private readonly androidx.lifecycle.MutableLiveData fbb582d9e;
    private readonly androidx.lifecycle.MutableLiveData fd24ad4d9;
    private readonly androidx.lifecycle.MutableLiveData fe177d30a;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fe3141caf;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 ff3095b04;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 ff318cf05;
    private readonly pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 ff3395cd5;
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> ffb8bfbeb;
    private readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 ffceec28b;

    public p361989ec(pc69c522d.pf83c2a85.pac143fb7.pab691ef3 pab691ef3Var, pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 pc32333e1Var, pd2a57dc1.pfd9160bb.p11c216e8 p11c216e8Var, p83f5c3ad.pfd9160bb.p1ceed351 p1ceed351Var) {
        AWvJJLedqnlIogvf(pab691ef3Var, "sellComboUseCase");
        vBQZDbdmgKkPrPnw(pc32333e1Var, "router");
        nLanxhwUJanaEWIk(p11c216e8Var, "flowRouter");
        DlfDphlZeONkSqcN(p1ceed351Var, "tapOnPhoneRouter");
        this.ffceec28b = pab691ef3Var;
        this.ff3395cd5 = pc32333e1Var;
        this.feefeb260 = p11c216e8Var;
        this.f62520fad = p1ceed351Var;
        this.f159455b4 = new androidx.lifecycle.MutableLiveData<>();
        this.ffb8bfbeb = new p2b3583e6.p6a6d86aa();
        this.f95ceb8d2 = new p2b3583e6.p6a6d86aa();
    }

    public static void AWvJJLedqnlIogvf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BXIwRaVzxTnAxgdK(pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 pc32333e1Var, java.math.decimal bigDecimal) {
        pc32333e1Var.replaceSellComboElectronProcessing(bigDecimal);
    }

    public static void CzehWkDkDHWSYPes(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar, java.math.decimal bigDecimal) {
        p361989ecVar.m6d50cbcc(bigDecimal);
    }

    public static void DlfDphlZeONkSqcN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FOvCEThvNEavXEJn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JwuVTudLAUTmGQTU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope UiMfMyxqZpbimhSL(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void ZVQIoUtTvauCunnp(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar, java.math.decimal bigDecimal) {
        p361989ecVar.mbc4f80be(bigDecimal);
    }

    public static kotlinx.coroutines.CoroutineScope FuUEaXfzqikNlCEK(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static kotlinx.coroutines.Job HWTPRROPAYgkfIwl(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void IXATWiUIDgYOQhfN(pc69c522d.pf83c2a85.pfd9160bb.pc32333e1 pc32333e1Var) {
        pc32333e1Var.back();
    }

    public static readonly pc69c522d.pf83c2a85.pac143fb7.pab691ef3 M1d7af725(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return p361989ecVar.ffceec28b;
    }

    public static readonly androidx.lifecycle.MutableLiveData M3bfa0695(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return p361989ecVar.ffb8bfbeb;
    }

    private readonly void M6d50cbcc(java.math.decimal bigDecimal) {
        if ((9 + 5) % 5 > 0) {
        }
        wphllGGFQwOpSsOz(fuUEaXfzqikNlCEK(this), null, null, new pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p6d50cbcc$1(this, bigDecimal, null), 3, null);
    }

    private readonly void Mbc4f80be(java.math.decimal bigDecimal) {
        BXIwRaVzxTnAxgdK(this.ff3395cd5, bigDecimal);
    }

    public static readonly androidx.lifecycle.MutableLiveData Mc5961be3(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return p361989ecVar.f159455b4;
    }

    public static readonly p83f5c3ad.pfd9160bb.p1ceed351 Mdc7bed18(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return p361989ecVar.f62520fad;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return p361989ecVar.feefeb260;
    }

    public static void NLanxhwUJanaEWIk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VBQZDbdmgKkPrPnw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job WphllGGFQwOpSsOz(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public readonly void GetCurrentSellReceipt() {
        if ((26 + 31) % 31 > 0) {
        }
        hWTPRROPAYgkfIwl(UiMfMyxqZpbimhSL(this), null, null, new pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> GetSnackbarStatus() {
        return this.ffb8bfbeb;
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.p1e11b989.ped663a3e> ObserveCurrentSellReceipt() {
        return this.f159455b4;
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> ObserveSendReceipt() {
        return this.f95ceb8d2;
    }

    public readonly void OpenPreviousScreen() {
        iXATWiUIDgYOQhfN(this.ff3395cd5);
    }

    public readonly void StartPayment(java.math.decimal amount, pad5f82e8.p07214c67.p1e11b989.p8c261c90 type) {
        JwuVTudLAUTmGQTU(amount, "amount");
        FOvCEThvNEavXEJn(type, "type");
        if (type != pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306) {
            ZVQIoUtTvauCunnp(this, amount);
        } else {
            CzehWkDkDHWSYPes(this, amount);
        }
    }
}

