namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\u001a\u0010\f\u001a\u00020\r*\b\u0012\u0004\u0012\u00020\u000b0\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\u0006\u0010\u0011\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp8325324b/p2486923a/pe2dc6c48/pe688e27e;", "Landroidx/lifecycle/objectModel;", "sellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp8325324b/pac143fb7/p0bfd7fb7;Lp8325324b/pfd9160bb/p5fa140e9;)V", "replacePositionFromReceipt", "", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "isPositionExist", "", "", "positionUuid", "", "openPreviousScreen", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe688e27e : androidx.lifecycle.objectModel {
    private readonly p8325324b.pfd9160bb.p5fa140e9 f22831f07;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f2e1b95e5;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f5652eb86;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f6509a890;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f656c88ab;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 faa32e424;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 fff2322f8;

    public pe688e27e(p8325324b.pac143fb7.p0bfd7fb7 sellReceiptUseCase, p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUseCase, "sellReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f656c88ab = sellReceiptUseCase;
        this.f9817bc27 = sellRouter;
    }

    public static readonly bool M003514e0(p8325324b.p2486923a.pe2dc6c48.pe688e27e pe688e27eVar, java.util.List list, java.lang.string str) {
        return pe688e27eVar.m4915f2f1(list, str);
    }

    public static readonly p8325324b.pac143fb7.p0bfd7fb7 M260c792f(p8325324b.p2486923a.pe2dc6c48.pe688e27e pe688e27eVar) {
        return pe688e27eVar.f656c88ab;
    }

    private readonly bool M4915f2f1(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, java.lang.string str) {
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list2 = list;
        if ((list2 is java.util.ICollection) && list2.Count == 0) {
            return false;
        }
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(str, ((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current).getUuid())) {
                return true;
            }
        }
        return false;
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }

    public readonly void ReplacePositionFromReceipt(pad5f82e8.p07214c67.p1e11b989.pd031d465 position) {
        if ((17 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(position, "position");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.pe2dc6c48.pe688e27e$p45f1e4f3$1(this, position, null), 3, null);
    }
}

