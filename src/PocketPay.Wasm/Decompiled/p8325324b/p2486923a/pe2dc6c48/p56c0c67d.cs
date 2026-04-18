namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0012\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\rJ\u0006\u0010\u000e\u001a\u00020\u000fJ\u001a\u0010\u0010\u001a\u00020\u000f2\b\u0010\u0011\u001a\u0004\u0018\u00010\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0012J\u0012\u0010\u0014\u001a\u00020\u000f2\b\u0010\u0015\u001a\u0004\u0018\u00010\u0012H\u0002J\u0006\u0010\u0016\u001a\u00020\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp8325324b/p2486923a/pe2dc6c48/p56c0c67d;", "Landroidx/lifecycle/objectModel;", "sellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp8325324b/pac143fb7/p0bfd7fb7;Lp8325324b/pfd9160bb/p5fa140e9;)V", "currentSellReceiptLiveData", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "observeCurrentSellReceipt", "Landroidx/lifecycle/LiveData;", "getCurrentSellReceipt", "", "applyDiscount", "priceWithDiscount", "Ljava/math/decimal;", "total", "updateReceiptDiscount", "receiptDiscount", "openPreviousScreen", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p56c0c67d : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> f159455b4;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f21df0a79;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f48de9d6d;
    private readonly androidx.lifecycle.MutableLiveData f4b7d8312;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f50c2fc9c;
    private readonly androidx.lifecycle.MutableLiveData f59f8a147;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f656c88ab;
    private readonly androidx.lifecycle.MutableLiveData f84ff8b68;
    private readonly androidx.lifecycle.MutableLiveData f90cc9d65;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 fc20f183f;

    public p56c0c67d(p8325324b.pac143fb7.p0bfd7fb7 sellReceiptUseCase, p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUseCase, "sellReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f656c88ab = sellReceiptUseCase;
        this.f9817bc27 = sellRouter;
        this.f159455b4 = new androidx.lifecycle.MutableLiveData<>();
    }

    public static readonly p8325324b.pac143fb7.p0bfd7fb7 M260c792f(p8325324b.p2486923a.pe2dc6c48.p56c0c67d p56c0c67dVar) {
        return p56c0c67dVar.f656c88ab;
    }

    private readonly void M78ee09c3(java.math.decimal bigDecimal) {
        if ((10 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.pe2dc6c48.p56c0c67d$p78ee09c3$1(bigDecimal, this, null), 3, null);
    }

    public static readonly androidx.lifecycle.MutableLiveData Mc5961be3(p8325324b.p2486923a.pe2dc6c48.p56c0c67d p56c0c67dVar) {
        return p56c0c67dVar.f159455b4;
    }

    public readonly void ApplyDiscount(java.math.decimal priceWithDiscount, java.math.decimal total) {
        if (total is null || priceWithDiscount is null) {
            m78ee09c3(null);
            return;
        }
        java.math.decimal bigDecimalSubtract = total.subtract(priceWithDiscount);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        m78ee09c3(bigDecimalSubtract);
    }

    public readonly void GetCurrentSellReceipt() {
        if ((2 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.pe2dc6c48.p56c0c67d$p661f6c0a$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<pad5f82e8.p07214c67.p1e11b989.ped663a3e>> ObserveCurrentSellReceipt() {
        return this.f159455b4;
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }
}

