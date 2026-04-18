namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0004\b\f\u0010\rJ\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00100\u0015J\u0012\u0010\u0016\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00130\u00120\u0015J\u0006\u0010\u0017\u001a\u00020\u0018J\u0006\u0010\u0019\u001a\u00020\u0018J\b\u0010\u001a\u001a\u00020\u0018H\u0002J\u0010\u0010\u001b\u001a\u00020\u00182\u0006\u0010\u001c\u001a\u00020\u0010H\u0002J\b\u0010\u001d\u001a\u00020\u0018H\u0002J\u0006\u0010\u001e\u001a\u00020\u0018R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0011\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00130\u00120\u000fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Lp1b856234/pf83c2a85/p2486923a/p4670093c/p2f0a867d;", "Landroidx/lifecycle/objectModel;", "sendReceiptUseCase", "Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;", "paybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "devicesUseCase", "Lpe0212e54/pac143fb7/p4b8940c0;", "router", "Lp1b856234/pf83c2a85/pfd9160bb/padac6c63;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "<init>", "(Lpad5f82e8/pac143fb7/p1e11b989/pf21d5ed1;Lp4670093c/pac143fb7/pa36ef9b5;Lpe0212e54/pac143fb7/p4b8940c0;Lp1b856234/pf83c2a85/pfd9160bb/padac6c63;Lp4670093c/pfd9160bb/p1b3a5bf0;)V", "paybackReceiptLiveData", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "sendReceiptLiveData", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "observePaybackReceipt", "Landroidx/lifecycle/LiveData;", "getSendReceiptEventLiveData", "sendReceipt", "", "openPreviousScreen", "getPaybackReceipt", "openReceiptSentScreen", "paybackReceipt", "openErrorScreen", "saveQueueReceiptToDb", "feature-electron-payment-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2f0a867d : androidx.lifecycle.objectModel {
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0d3e163c;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f292eec13;
    private readonly androidx.lifecycle.MutableLiveData f299d3f42;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2c910ec1;
    private readonly pe0212e54.pac143fb7.p4b8940c0 f34cd4691;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 f474d840d;
    private readonly androidx.lifecycle.MutableLiveData f50f1a6f7;
    private readonly p1b856234.pf83c2a85.pfd9160bb.padac6c63 f6e252018;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.object>> f73199d38;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f7a265158;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f879a2700;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f8a7afeb0;
    private readonly p1b856234.pf83c2a85.pfd9160bb.padac6c63 f979afb29;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f9941a57c;
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.p1e11b989.p18cf5223> fa382cc26;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fa57440df;
    private readonly p4670093c.pac143fb7.pa36ef9b5 fcb02f4a2;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 fd15040c1;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fd71545d5;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fda1713fa;
    private readonly p4670093c.pac143fb7.pa36ef9b5 fdf0bb755;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fe34846c3;
    private readonly androidx.lifecycle.MutableLiveData fe41c0b90;
    private readonly pe0212e54.pac143fb7.p4b8940c0 fe9b0a925;
    private readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 fed82234a;
    private readonly p1b856234.pf83c2a85.pfd9160bb.padac6c63 ff3395cd5;

    public p2f0a867d(pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 pf21d5ed1Var, p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5Var, pe0212e54.pac143fb7.p4b8940c0 p4b8940c0Var, p1b856234.pf83c2a85.pfd9160bb.padac6c63 padac6c63Var, p4670093c.pfd9160bb.p1b3a5bf0 p1b3a5bf0Var) {
        miaTQCffojQfVzyJ(pf21d5ed1Var, "sendReceiptUseCase");
        ibJwhtYQIJirWKad(pa36ef9b5Var, "paybackReceiptUseCase");
        kkRvMZfzxGaDkgaa(p4b8940c0Var, "devicesUseCase");
        MwrUDAvEvRpokQtH(padac6c63Var, "router");
        IcyGKEuhJuhlaAPj(p1b3a5bf0Var, "paybackRouter");
        this.f474d840d = pf21d5ed1Var;
        this.f0d3e163c = pa36ef9b5Var;
        this.fda1713fa = p4b8940c0Var;
        this.ff3395cd5 = padac6c63Var;
        this.f2b2a1791 = p1b3a5bf0Var;
        this.fa382cc26 = new androidx.lifecycle.MutableLiveData<>();
        this.f73199d38 = new p2b3583e6.p6a6d86aa();
        UauXcwGGcuEhZdRu(this);
    }

    public static void BNKlOqRXumaSpsJf(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        p2f0a867dVar.mcf69898a(p18cf5223Var);
    }

    public static void FGZAHLKAcObSvvmN(p4670093c.pfd9160bb.p1b3a5bf0 p1b3a5bf0Var) {
        p1b3a5bf0Var.openPaybackError();
    }

    public static void IcyGKEuhJuhlaAPj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job JCgXMEbXJpJoUQZw(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static kotlinx.coroutines.Job KDyTvEyOLvepVKbd(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void MwrUDAvEvRpokQtH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NKKXUjPIhCGzVtvi(p1b856234.pf83c2a85.pfd9160bb.padac6c63 padac6c63Var) {
        padac6c63Var.back();
    }

    public static kotlinx.coroutines.CoroutineScope QFLJiJPOBeQuQunh(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void QlgBQrKTvBQbAhvX(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        p2f0a867dVar.mc398eb5c();
    }

    public static void UauXcwGGcuEhZdRu(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        p2f0a867dVar.m9b63e6e8();
    }

    public static java.lang.object WYOUJgyFMKWoswda(androidx.lifecycle.MutableLiveData mutableLiveData) {
        return mutableLiveData.getValue();
    }

    public static kotlinx.coroutines.Job GJHTJMvNcuKTdSSN(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void GesnWzmNxeBJPyxd(p4670093c.pfd9160bb.p1b3a5bf0 p1b3a5bf0Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        p1b3a5bf0Var.replacePaybackSuccess(p9ded6185Var);
    }

    public static void IbJwhtYQIJirWKad(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KkRvMZfzxGaDkgaa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly void M0d622a60(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        BNKlOqRXumaSpsJf(p2f0a867dVar, p18cf5223Var);
    }

    public static readonly void M160cb365(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        QlgBQrKTvBQbAhvX(p2f0a867dVar);
    }

    public static readonly androidx.lifecycle.MutableLiveData M41e2481f(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.fa382cc26;
    }

    public static readonly androidx.lifecycle.MutableLiveData M57354353(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.f73199d38;
    }

    public static readonly pe0212e54.pac143fb7.p4b8940c0 M701d8e58(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.fda1713fa;
    }

    private readonly void M9b63e6e8() {
        if ((17 + 25) % 25 > 0) {
        }
        gJHTJMvNcuKTdSSN(QFLJiJPOBeQuQunh(this), null, null, new p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1(this, null), 3, null);
    }

    public static readonly pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 Mbb30f96e(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.f474d840d;
    }

    private readonly void Mc398eb5c() {
        FGZAHLKAcObSvvmN(this.f2b2a1791);
    }

    private readonly void Mcf69898a(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        gesnWzmNxeBJPyxd(this.f2b2a1791, p18cf5223Var);
    }

    public static readonly p4670093c.pac143fb7.pa36ef9b5 Md95a43c7(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.f0d3e163c;
    }

    public static void MiaTQCffojQfVzyJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope UqnjPqxjUwTmXKVE(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static kotlinx.coroutines.CoroutineScope WDKzFMjKNhbAjzkA(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> GetSendReceiptEventLiveData() {
        return this.f73199d38;
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.p1e11b989.p18cf5223> ObservePaybackReceipt() {
        return this.fa382cc26;
    }

    public readonly void OpenPreviousScreen() {
        NKKXUjPIhCGzVtvi(this.ff3395cd5);
    }

    public readonly void SaveQueueReceiptToDb() {
        if ((1 + 4) % 4 > 0) {
        }
        JCgXMEbXJpJoUQZw(wDKzFMjKNhbAjzkA(this), null, null, new p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p812699ae$1(this, null), 3, null);
    }

    public readonly void SendReceipt() {
        if ((15 + 10) % 10 > 0) {
        }
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) WYOUJgyFMKWoswda(this.fa382cc26);
        if (p18cf5223Var is not null) {
            KDyTvEyOLvepVKbd(uqnjPqxjUwTmXKVE(this), null, null, new p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1(this, p18cf5223Var, null), 3, null);
        }
    }
}

