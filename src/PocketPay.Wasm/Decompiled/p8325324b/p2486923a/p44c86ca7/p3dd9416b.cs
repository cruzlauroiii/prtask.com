namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rJ\u0016\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0010J\u001e\u0010\u0011\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u0013J\u0006\u0010\u0017\u001a\u00020\u000bJ\u0006\u0010\u0018\u001a\u00020\u000bJ\u001c\u0010\u0019\u001a\u0004\u0018\u00010\r*\b\u0012\u0004\u0012\u00020\r0\u001a2\u0006\u0010\f\u001a\u00020\rH\u0002J\u001a\u0010\u001b\u001a\u00020\u001c*\b\u0012\u0004\u0012\u00020\r0\u001a2\u0006\u0010\u001d\u001a\u00020\u0015H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp8325324b/p2486923a/p44c86ca7/p3dd9416b;", "Landroidx/lifecycle/objectModel;", "sellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "positionCreatorUseCase", "Lpad5f82e8/pac143fb7/p1e11b989/p4757fe07/p606d2648;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp8325324b/pac143fb7/p0bfd7fb7;Lpad5f82e8/pac143fb7/p1e11b989/p4757fe07/p606d2648;Lp8325324b/pfd9160bb/p5fa140e9;)V", "addPositionToReceipt", "", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "replacePositionFromReceipt", "editPositionRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p1cc31b4d;", "createPosition", "price", "Ljava/math/decimal;", "positionName", "", "quantity", "openPreviousScreen", "backToEditSellReceipt", "findPositionByCommodityIdAndPrice", "", "isPositionExist", "", "positionUuid", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3dd9416b : androidx.lifecycle.objectModel {
    private readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p606d2648 f27d35bd8;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f2d0eabc6;
    private readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p606d2648 f322a6540;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f656c88ab;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f87e8f661;
    private readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p606d2648 f95cebf0e;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;
    private readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p606d2648 fa033a29d;
    private readonly p8325324b.pfd9160bb.p5fa140e9 fb8e11ce7;
    private readonly p8325324b.pfd9160bb.p5fa140e9 fdb83288c;

    public p3dd9416b(p8325324b.pac143fb7.p0bfd7fb7 sellReceiptUseCase, pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p606d2648 positionCreatorUseCase, p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUseCase, "sellReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(positionCreatorUseCase, "positionCreatorUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f656c88ab = sellReceiptUseCase;
        this.f322a6540 = positionCreatorUseCase;
        this.f9817bc27 = sellRouter;
    }

    public static readonly bool M003514e0(p8325324b.p2486923a.p44c86ca7.p3dd9416b p3dd9416bVar, java.util.List list, java.lang.string str) {
        return p3dd9416bVar.m4915f2f1(list, str);
    }

    public static readonly p8325324b.pac143fb7.p0bfd7fb7 M260c792f(p8325324b.p2486923a.p44c86ca7.p3dd9416b p3dd9416bVar) {
        return p3dd9416bVar.f656c88ab;
    }

    private readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 M46835af0(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        if ((6 + 27) % 27 > 0) {
        }
        java.lang.object obj = null;
        if (pd031d465Var.getCommodityId() is null) {
            return null;
        }
        for (java.lang.object obj2 : list) {
            pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var2 = (pad5f82e8.p07214c67.p1e11b989.pd031d465) obj2;
            if (kotlin.jvm.internal.Intrinsics.areEqual(pd031d465Var2.getCommodityId(), pd031d465Var.getCommodityId()) && pd031d465Var2.getPrice().compareTo(pd031d465Var.getPrice()) == 0 && !kotlin.jvm.internal.Intrinsics.areEqual(pd031d465Var2.getUuid(), pd031d465Var.getUuid())) {
                obj = obj2;
                break;
            }
        }
        return (pad5f82e8.p07214c67.p1e11b989.pd031d465) obj;
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

    public static readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 Mbaea185e(p8325324b.p2486923a.p44c86ca7.p3dd9416b p3dd9416bVar, java.util.List list, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return p3dd9416bVar.m46835af0(list, pd031d465Var);
    }

    public readonly void AddPositionToReceipt(pad5f82e8.p07214c67.p1e11b989.pd031d465 position) {
        if ((15 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(position, "position");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.p44c86ca7.p3dd9416b$p234facb0$1(this, position, null), 3, null);
    }

    public readonly void BackToEditSellReceipt() {
        this.f9817bc27.backToEditSellReceipt();
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 CreatePosition(java.math.decimal price, java.lang.string positionName, java.math.decimal quantity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(positionName, "positionName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quantity, "quantity");
        return this.f322a6540.createPosition(price, positionName, quantity);
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }

    public readonly void ReplacePositionFromReceipt(pad5f82e8.p07214c67.p1e11b989.pd031d465 position, pad5f82e8.p07214c67.pfd9160bb.p1cc31b4d editPositionRoute) {
        if ((8 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(position, "position");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(editPositionRoute, "editPositionRoute");
        if (editPositionRoute != pad5f82e8.p07214c67.pfd9160bb.p1cc31b4d.fdc190666) {
            kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p8325324b.p2486923a.p44c86ca7.p3dd9416b$p45f1e4f3$1(this, position, null), 3, null);
        } else {
            this.f9817bc27.sendResult(com.decryptstringmanager.Decryptstring.decryptstring("9230a8af10c8abac69f5eec4aef36b26707b3de62db19ae20f69f10c0822367ecddf2efc28af43654ab989fc9356c37da277763941aca288f4"), position);
        }
    }
}

