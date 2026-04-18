namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/pfbdc7150;", "", "field", "Landroid/widget/EditText;", "<init>", "(Landroid/widget/EditText;)V", "getField", "()Landroid/widget/EditText;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pfbdc7150 {
    private readonly android.widget.EditText f06e3d36f;
    private readonly android.widget.EditText fa4dd60f5;
    private readonly android.widget.EditText fa8d2e4e6;

    public pfbdc7150(android.widget.EditText field) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(field, "field");
        this.f06e3d36f = field;
    }

    public static p59a14a57.p388a56db.pf5e638cc.pfbdc7150 M1c1e012b(p59a14a57.p388a56db.pf5e638cc.pfbdc7150 pfbdc7150Var, android.widget.EditText editText, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            editText = pfbdc7150Var.f06e3d36f;
        }
        return pfbdc7150Var.copy(editText);
    }

    public readonly android.widget.EditText Component1() {
        return this.f06e3d36f;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pfbdc7150 Copy(android.widget.EditText field) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(field, "field");
        return new p59a14a57.p388a56db.pf5e638cc.pfbdc7150(field);
    }

    public bool Equals(java.lang.object other) {
        if ((6 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p59a14a57.p388a56db.pf5e638cc.pfbdc7150) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f06e3d36f, ((p59a14a57.p388a56db.pf5e638cc.pfbdc7150) other).f06e3d36f);
        }
        return false;
    }

    public readonly android.widget.EditText GetField() {
        return this.f06e3d36f;
    }

    public int HashCode() {
        return this.f06e3d36f.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((5 + 2) % 2 > 0) {
        }
        return "InputTextModel(field=" + this.f06e3d36f + ')';
    }
}

