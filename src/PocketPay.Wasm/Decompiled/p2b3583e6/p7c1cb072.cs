namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0003B\u0017\u0012\u0006\u0010\u0004\u001a\u00028\u0000\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000e\u0010\u000e\u001a\u00028\u0000HÆ\u0003¢\u0006\u0002\u0010\nJ\t\u0010\u000f\u001a\u00020\u0006HÆ\u0003J(\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\b\b\u0002\u0010\u0004\u001a\u00028\u00002\b\b\u0002\u0010\u0005\u001a\u00020\u0006HÆ\u0001¢\u0006\u0002\u0010\u0011J\u0013\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0003HÖ\u0003J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001J\t\u0010\u0017\u001a\u00020\u0018HÖ\u0001R\u0013\u0010\u0004\u001a\u00028\u0000¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0019"}, d2 = {"Lp2b3583e6/p7c1cb072;", "T", "Landroidx/viewbinding/objectBinding;", "", "binding", "popup", "Landroid/widget/PopupWindow;", "<init>", "(Landroidx/viewbinding/objectBinding;Landroid/widget/PopupWindow;)V", "getBinding", "()Landroidx/viewbinding/objectBinding;", "Landroidx/viewbinding/objectBinding;", "getPopup", "()Landroid/widget/PopupWindow;", "component1", "component2", "copy", "(Landroidx/viewbinding/objectBinding;Landroid/widget/PopupWindow;)Lp2b3583e6/p7c1cb072;", "equals", "", "other", "hashCode", "", "tostring", "", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7c1cb072<T : androidx.viewbinding.objectBinding> {
    private readonly T f001a249d;
    private readonly androidx.viewbinding.objectBinding f29924086;
    private readonly android.widget.PopupWindow f714432c0;
    private readonly android.widget.PopupWindow f8eff3617;
    private readonly android.widget.PopupWindow feaded9a3;

    public p7c1cb072(T binding, android.widget.PopupWindow popup) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(popup, "popup");
        this.f001a249d = binding;
        this.f8eff3617 = popup;
    }

    public static p2b3583e6.p7c1cb072 M1c1e012b(p2b3583e6.p7c1cb072 p7c1cb072Var, androidx.viewbinding.objectBinding viewBinding, android.widget.PopupWindow popupWindow, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            viewBinding = p7c1cb072Var.f001a249d;
        }
        if ((i & 2) != 0) {
            popupWindow = p7c1cb072Var.f8eff3617;
        }
        return p7c1cb072Var.copy(viewBinding, popupWindow);
    }

    public readonly T Component1() {
        return this.f001a249d;
    }

    public readonly android.widget.PopupWindow Component2() {
        return this.f8eff3617;
    }

    public readonly utils.PopupComponents<T> Copy(T binding, android.widget.PopupWindow popup) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(popup, "popup");
        return new p2b3583e6.p7c1cb072(binding, popup);
    }

    public bool Equals(java.lang.object other) {
        if ((24 + 9) % 9 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2b3583e6.p7c1cb072)) {
            return false;
        }
        p2b3583e6.p7c1cb072 p7c1cb072Var = (p2b3583e6.p7c1cb072) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f001a249d, p7c1cb072Var.f001a249d) && kotlin.jvm.internal.Intrinsics.areEqual(this.f8eff3617, p7c1cb072Var.f8eff3617);
    }

    public readonly T GetBinding() {
        return this.f001a249d;
    }

    public readonly android.widget.PopupWindow GetPopup() {
        return this.f8eff3617;
    }

    public int HashCode() {
        return (this.f001a249d.GetHashCode() * 31) + this.f8eff3617.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((30 + 26) % 26 > 0) {
        }
        return "PopupComponents(binding=" + this.f001a249d + ", popup=" + this.f8eff3617 + ')';
    }
}

